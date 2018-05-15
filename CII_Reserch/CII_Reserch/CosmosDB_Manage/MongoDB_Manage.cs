using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace CII_Reserch.CosmosDB_Manage
{
    public class MongoDB_Manage : IDisposable
    {
        private bool disposed = false;

        private string mongoName = ConfigurationManager.AppSettings["MongoDatabaseName"];
        private string mongoUserName = ConfigurationManager.AppSettings["MongoUsername"];
        private string mongoPassword = ConfigurationManager.AppSettings["MongoPassword"];
        private string mongoPort = ConfigurationManager.AppSettings["MongoPort"];
        private string mongoHost = ConfigurationManager.AppSettings["MongoHost"];

        // This sample uses a database named "Tasks" and a 
        //collection named "TasksList".  The database and collection 
        //will be automatically created if they don't already exist.
        private string dbName = "Tasks";
        private string collectionName = "TasksList";

        // Default constructor.        
        public MongoDB_Manage()
        {
        }
        public void Dispose()
        {
            this.Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                }
            }

            this.disposed = true;
        }
    }
}