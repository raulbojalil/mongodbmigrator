using MongoDB.Bson;
using MongoDB.Bson.Serialization;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Authentication;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MongoDBMigrator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private MongoClient GetMongoConnection(string connString, bool sslSource)
        {
            var settings = MongoClientSettings.FromUrl(new MongoUrl(connString));

            if (sslSource)
                settings.SslSettings = new SslSettings() { EnabledSslProtocols = SslProtocols.Tls12 };

            return new MongoClient(settings);
        }

        private int MigrateData(string sourceConnString, bool sslSource, string destConnString, bool sslDest, string dbName, string collectionName, int batchSize = 50, string query = "")
        {
            int total = 0;
            var sourceMongoClient = GetMongoConnection(sourceConnString, sslSource);
            var destMongoClient = GetMongoConnection(destConnString, sslDest);

            List<BsonDocument> sourceDocs = null;
            var skip = 0;

            while (sourceDocs == null || sourceDocs.Count > 0)
            {
                sourceDocs = sourceMongoClient.GetDatabase(dbName).GetCollection<BsonDocument>(collectionName).Find(string.IsNullOrEmpty(query) ? (FilterDefinition<BsonDocument>.Empty) : (BsonSerializer.Deserialize<BsonDocument>(query))).Skip(skip).Limit(batchSize).ToList();
                if (sourceDocs.Count > 0)
                {
                    total += sourceDocs.Count;
                    destMongoClient.GetDatabase(dbName).GetCollection<BsonDocument>(collectionName).InsertMany(sourceDocs);
                }
                skip += batchSize;
            }

            return total;
            
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            var srcConnString = txtSrcConnString.Text;
            var destConnString = txtDestConnString.Text;
            var srcUseSSL = chkSrcSSL.Checked;
            var destUseSSL = chkDestSSL.Checked;

            var dbName = lsbDatabases.SelectedItem == null ? string.Empty : lsbDatabases.SelectedItem.ToString();
            var collectionName = lsbCollections.SelectedItem == null ? string.Empty : lsbCollections.SelectedItem.ToString();
            var batchSize = (int)nudBatchSize.Value;
            var jsonQuery = txtQuery.Text;

            if (string.IsNullOrEmpty(srcConnString) || string.IsNullOrEmpty(destConnString))
            {
                MessageBox.Show("Connection Strings are required", "Data required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(dbName) || string.IsNullOrEmpty(collectionName))
            {
                MessageBox.Show("Database and/or collection names required", "Data required", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return;
            }

            EnableUI(false, "Copying data, please wait...");
            

            new Task(() =>
            {

                var total = 0;

                try
                {
                    total = MigrateData(srcConnString, srcUseSSL, destConnString, destUseSSL, dbName.ToString(), collectionName.ToString(), batchSize, jsonQuery);
                }
                catch (Exception ex)
                {
                    Invoke(new Action(() =>
                    {
                        MessageBox.Show(ex.Message, "Error copying data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }));
                }

                Invoke(new Action(() => {

                    MessageBox.Show(string.Format("The process is complete. Total items: {0}", total), "Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    EnableUI(true, "Ready");

                }));

            }).Start();

        }

        private void EnableUI(bool enabled, string message)
        {
            gpbConnStrings.Enabled = enabled;
            gpbDatabases.Enabled = enabled;
            gpbCollections.Enabled = enabled;
            gpbQuery.Enabled = enabled;
            gpbBatchSize.Enabled = enabled;
            btnLoadDBs.Enabled = enabled;
            btnStart.Enabled = enabled;
            lblStatus.Text = message;

        }

        private MongoClient currentMongoConnection;

        private void btnLoadDBs_Click(object sender, EventArgs e)
        {

            var connString = txtSrcConnString.Text;
            var useSSL = chkSrcSSL.Checked;

            if (string.IsNullOrEmpty(connString))
            {
                MessageBox.Show("The source connection string is required ", "Source Connection String Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            EnableUI(false, "Loading databases...");
            lsbDatabases.Items.Clear();

            new Task(() =>
            {
                try
                {
                    currentMongoConnection = GetMongoConnection(connString, useSSL);

                    Invoke(new Action(() =>
                    {
                        foreach (var db in currentMongoConnection.ListDatabases().ToList())
                        {
                            lsbDatabases.Items.Add(db["name"]);
                        }
                    }));
                }
                catch(Exception ex)
                {
                    Invoke(new Action(() =>
                    {
                        MessageBox.Show(ex.Message, "Error loading databases", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }));
                }

                Invoke(new Action(() => { EnableUI(true, "Ready"); }));

            }).Start();
        }

        private void lsbDatabases_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedDbName = lsbDatabases.SelectedItem.ToString();
            EnableUI(false, string.Format("Loading collections from {0}...", selectedDbName));
            lsbCollections.Items.Clear();

            new Task(() =>
            {
                try
                {

                    Invoke(new Action(() =>
                    {
                        foreach (var coll in currentMongoConnection.GetDatabase(selectedDbName).ListCollections().ToList())
                        {
                            lsbCollections.Items.Add(coll["name"]);
                        }
                    }));
                }
                catch (Exception ex)
                {
                    Invoke(new Action(() =>
                    {
                        MessageBox.Show(ex.Message, "Error loading collections", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }));
                }

                Invoke(new Action(() => { EnableUI(true, "Ready"); }));

            }).Start();
        }
    }
}
