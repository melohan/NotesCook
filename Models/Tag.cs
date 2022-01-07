using System;
using MongoDB.Bson.Serialization.Attributes;

namespace NotesCook.Models
{
    class Tag
    {

        /************************************************
         *            Constructors
         ***********************************************/

        /**
         * Default constructor
         **/
        public Tag() { }

        /**
         * Constructor with params
         * @param string name
         **/
        public Tag(string name)
        {
            this.name = name;
        }

        /**
         * Copy constructor
         * @param TagModel
         **/
        public Tag(Tag Other)
        {
            this.id   = Other.id;
            this.name = Other.name;
        }

        /************************************************
         *             Setters & Getters
         ***********************************************/

        [BsonId]    // id
        public Guid id { get; set; }   // MongoDB private id
        public string name { get; set; }

    }
}
