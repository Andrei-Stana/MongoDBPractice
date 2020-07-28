using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Text;

namespace MongoDBPractice
{
    class CRUD
    {
        //Creates CRUD actions

        private IMongoDatabase db;

        public CRUD(string database)
        {
            var client = new MongoClient();
            db = client.GetDatabase(database);
        }

        public void insertRecord<T>(string table, T record)
        {
            var collection = db.GetCollection<T>(table);
            collection.InsertOne(record);
        }
    }
}
