using System;
using MongoDB.Bson.Serialization.Attributes;

namespace NotesCook.Models
{
    class TagModel
    {

        /************************************************
         *            Constructors
         ***********************************************/

        /**
         * Default constructor
         **/
        public TagModel() { }

        /**
         * Constructor with params
         * @param string name
         **/
        public TagModel(string name)
        {
            this.name = name;
        }

        /**
         * Copy constructor
         * @param TagModel
         **/
        public TagModel(TagModel Other)
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
