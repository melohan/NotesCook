using System;
using System.Collections.Generic;
using MongoDB.Bson.Serialization.Attributes;

/**
 * This object is an embedded document in recipe. 
 * Because the MongoDB driver does not auto-generate id for this kind of elements, 
 * the constructor does so before insertion into the database.
 **/
namespace NotesCook.Models
{
    public class Tag : Model
    {

        /************************************************
         *            Constructors
         ***********************************************/

        /**
         * Default constructor
         **/
        public Tag() 
        {
           this.Id = Guid.NewGuid();
        }

        /**
         * Constructor with params
         * @param string name
         **/
        public Tag(string name) : this()
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


        /************************************************
       *             Operations on records
         ***********************************************/

        public override void Create()
        {
            Insert<Tag>(this);
        }

        public override void Edit()
        {
            Update<Tag>(this.Id, this);
        }

        public override void Remove()
        {
            Delete<Tag>(this.Id);
        }
    }
}
