using System;
using System.Collections.Generic;
using MongoDB.Bson.Serialization.Attributes;


namespace NotesCook.Models
{
    /**
     * This object is an embedded document in recipe. 
     * Because the MongoDB driver does not auto-generate id for this kind of elements, 
     * the constructor does so before insertion into the database.
     **/
    public class Step : Model
    {

        /************************************************
         *            Constructors
         ***********************************************/

        /**
         * Default constructor
         **/
        public Step() 
        {
            this.Id = Guid.NewGuid();
        }

        /**
         * Constructor with params
         * @param int    position
         * @param string name
         * @param string description
         **/
        public Step(int position, string name,  string description) : this()
        {
            this.Position    = position;
            this.Name        = name;
            this.Description = description;
        }

        /**
         * Copy constructor
         * @param StepModel
         **/
        public Step(Step Other)
        {
            this.Id          = Other.Id;
            this.Position    = Other.Position;
            this.Name        = Other.Name;
            this.Description = Other.Description;
        }

        /************************************************
         *             Setters & Getters
         ***********************************************/

        [BsonId]    // id
        public Guid Id { get; set; }   
        public int Position { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        /************************************************
         *                  Methods 
         ***********************************************/

        /**
         * Get Step by a name in a list.
         * @param List<Step> list
         * @string name
         **/
        public static Step FindByName(List<Step> list, string name)
        {
            foreach (Step step in list)
            {
                if (step.Name == name)
                    return step;
            }
            return new Step();
        }

      /************************************************
       *             Operations on records
       ***********************************************/

        public override void Create()
        {
            Insert<Step>(this);
        }

        public override void Edit()
        {
            Update<Step>(this.Id, this);
        }

        public override void Remove()
        {
            Delete<Step>(this.Id);
        }

    }
}
