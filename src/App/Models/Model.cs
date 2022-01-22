using NotesCook.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotesCook.Models
{
    public abstract class Model
    {
        /**
         * Returns the affected db object with the requirements of the child models.
         **/
        private static DB GetDb()
        {
            DB db = new DB("NotesCook", "recipes");
            return db;
        }

        /**
         * Create the object in the database.
         **/
        abstract public void Create();

        /**
         * Modify the record in the database with the passed object.
         **/
        abstract public void Edit();

        /**
         * Delete record according.
         **/
        abstract public void Remove();


        /**
         * Insert the object in the database.
         * @param T obj
         **/
        public static void Insert<T>(T obj)
        {
            DB db = GetDb();
            db.Insert(obj);
        }

        /**
         * Modify the record by id in the database with the passed object.
         * @param Guid id
         * @param T obj
         **/
        public static void Update<T>(Guid id, T obj)
        {
            DB db = GetDb();
            db.Update<T>(id, obj);
        }
        /**
         * Delete record by Guid
         * @param Guid
         **/ 
        public static void Delete<T>(Guid id)
        {
            DB db = GetDb();
            db.Delete<T>(id);
        }

        /**
         * Get the record as an object.
         * @param Guid id
         **/
        public static T Get<T>(Guid id)
        {
            DB db = GetDb();
            return db.FindOne<T>(id);
        }

        /**
         * Get all records as list of objets.
         **/
        public static List<T> All<T>()
        {
            DB db = GetDb();
            return db.All<T>();
        }

        /**
         * Returns object list that matches the given key value.
         * @param string key
         * @param U value
         **/
        public static List<T> Find<T, U>(string key, U value)
        {
            DB db = GetDb();
            return db.FindMultiple<T, U>(key, value);
        }


        /**
         * Returns the object that matches the given key value.
         * @param string key
         * @param U value
         **/
        public static T FindOne<T, U>(string key, U value)
        {
            DB db = GetDb();
            return db.FindOne<T, U>(key, value);
        }

    }
}
