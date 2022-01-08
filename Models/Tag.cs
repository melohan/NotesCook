using System;
using System.Collections.Generic;
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
            this.Name = name;
        }

        /**
         * Copy constructor
         * @param TagModel
         **/
        public Tag(Tag Other)
        {
            this.Id   = Other.Id;
            this.Name = Other.Name;
        }

        /************************************************
         *             Setters & Getters
         ***********************************************/

        [BsonId]    // id
        public Guid Id { get; set; }   // MongoDB private id
        public string Name { get; set; }

        /************************************************
        *                  Methods 
        ***********************************************/

        /**
         * Get Step by a name in a list.
         * @param List<Step> list
         * @string name
         **/
        public static Tag FindByName(List<Tag> list, string name)
        {
            foreach (Tag step in list)
            {
                if (step.Name == name)
                    return step;
            }
            return new Tag();
        }
    }
}
