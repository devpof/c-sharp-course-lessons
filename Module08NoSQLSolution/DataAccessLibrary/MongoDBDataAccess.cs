using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary
{
    public class MongoDBDataAccess
    {
        private IMongoDatabase db;
        public MongoDBDataAccess(string dbName, string connectionString)
        {
            var client = new MongoClient(connectionString);
            db = client.GetDatabase(dbName);
        }

        public void InsertRecord<T>(string table, T record)
        {
            var collection = db.GetCollection<T>(table);
            collection.InsertOne(record);
        }

        public List<T> LoadRecords<T>(string table)
        {
            var collection = db.GetCollection<T>(table);
            return collection.Find(new BsonDocument()).ToList(); // new BsonDocument() like empty parameters in relational
        }

        // Guid is the unique string for NoSQL
        public T LoadRecordById<T>(string table, Guid id)
        {
            var collection = db.GetCollection<T>(table);
            var filter = Builders<T>.Filter.Eq("Id", id); // filter where property name if Id must match the id.

            return collection.Find(filter).First();
        }

        // tim uses this a lot for update and inserts.
        // Combination of Insert and Update. It finds if the record already exists first
        // and insert or update depending on if it is found or not.
        [Obsolete]
        public void UpsertRecord<T>(string table, Guid id, T record)
        {
            var collection = db.GetCollection<T>(table);
            
            var result = collection.ReplaceOne(
                new BsonDocument("_id", id), //_id is the private standard value that all MongoDB uses as a unique identifier.
                record,
                new UpdateOptions { IsUpsert = true });
        }

        public void DeleteRecord<T>(string table, Guid id)
        {
            var collection = db.GetCollection<T>(table);
            var filter = Builders<T>.Filter.Eq("Id", id);

            collection.DeleteOne(filter);
        }
    }
}
