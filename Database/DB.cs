using System;
using System.Collections.Generic;
using MongoDB.Bson;
using MongoDB.Driver;


namespace NotesCook.Database
{
    class DB
    {
        private IMongoDatabase mdb;


        /************************************************
         *            Constructors
         ***********************************************/
        /**
         *  This constructor is for simple cases with a single collection.
         **/
        public DB(string database)
        {
            var client = new MongoClient();
            this.mdb = client.GetDatabase(database);
        }

        /**
         *  This constructor is for simple cases with a single collection. 
         *  @param string database
         *  @param string collection
         *  @throw ArgumentException if collection is not set
         **/
        public DB(string database, string collection ):this(database)
        {
            this.Collection = collection;
        }

        /************************************************
         *               Insert methods
        ***********************************************/

        /**
         * Insert record in defined collection
         * Object id is automatically sets if id is declared as the BSON ID.
         * @throw Argument exception if collection is not set.
         **/
        public void Insert<T>(T record)
        {
            if(this.Collection == null)
            {
                throw new ArgumentException("Collection is not set.");
            }
            mdb.GetCollection<T>(this.Collection).InsertOne(record);
        }

        /************************************************
         *               Select methods
         ***********************************************/

        /**
         * Get all records in a collection
         * @throw Argument exception if collection is not set.
         **/
        public List<T> All<T>()
        {
            if (this.Collection == null)
            {
                throw new ArgumentException("Collection is not set.");
            }
            return mdb.GetCollection<T>(this.Collection).Find(new BsonDocument()).ToList();
        }


        /**
         * Find record by id
         **/ 
        public T FindOne<T>(Guid id)
        {
            var filter = Builders<T>.Filter.Eq("Id", id);
            return mdb.GetCollection<T>(this.Collection).Find(filter).First();
        }

        /**
         * Find record by key - value
         * @string key
         * @U value
         **/ 
        public T FindOne<T, U>(string key, U value)
        {
            var filter = Builders<T>.Filter.Eq(key, value);
            return mdb.GetCollection<T>(this.Collection).Find(filter).First();
        }

        /**
         * Find multiple record by one value
         * @string key
         * @U value
         **/
        public List<T> FindMultiple<T, U>(string key, U value)
        {
            var filter = Builders<T>.Filter.Eq(key, value);
            return mdb.GetCollection<T>(this.Collection).Find(filter).ToList<T>();
        }


        /************************************************
         *               Update methods
         ***********************************************/

        /**
         * Update record by id
         * @param Guid id
         * @param T record
         **/ 
        public void Update<T>(Guid id, T record)
        {
            var result = mdb.GetCollection<T>(this.Collection).ReplaceOne(
                new BsonDocument("_id", id),
                record,
                new ReplaceOptions { IsUpsert = true }
                );
        }

        /************************************************
         *               Delete methods
         ***********************************************/
        
        /**
         * Delete record by Id
         * @param Guid id
         **/
        public void Delete<T>(Guid id)
        {
            var filter = Builders<T>.Filter.Eq("Id", id);
            mdb.GetCollection<T>(this.Collection).DeleteOne(filter);
        }

        public string Collection { get; set; }      // db collection

    }
}
