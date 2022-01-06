using System;
using MongoDB.Bson.Serialization.Attributes;


namespace NotesCook.Models
{
    class StepModel
    {

        /************************************************
         *            Constructors
         ***********************************************/

        /**
         * Default constructor
         **/
        public StepModel() { }

        /**
         * Constructor with params
         * @param int    position
         * @param string name
         * @param string description
         **/
        public StepModel(int position, string name,  string description)
        {
            this.Position    = position;
            this.Name        = name;
            this.Description = description;
        }

        /**
         * Copy constructor
         * @param StepModel
         **/
        public StepModel(StepModel Other)
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

    }
}
