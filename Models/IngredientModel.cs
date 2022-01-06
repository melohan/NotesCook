using System;
using MongoDB.Bson.Serialization.Attributes;


namespace NotesCook.Models
{

    class IngredientModel
    {

        /************************************************
         *            Constructors
         ***********************************************/

        /**
         * Default constructor
         **/
        public IngredientModel(){}

        /**
         * Constructor with params
         * @param string name
         * @param int quantity
         * @param string unit
         **/
        public IngredientModel(string name, int quantity, string unit)
        {
            this.Name     = name;
            this.Quantity = quantity;
            this.Unit     = unit;
        }

        /**
         * Copy constructor
         * @param IngredientModel
         **/
        public IngredientModel(IngredientModel Other)
        {
            this.Id       = Other.Id;
            this.Name     = Other.Name;
            this.Quantity = Other.Quantity;
            this.Unit     = Other.Unit;
        }

        /************************************************
         *             Setters & Getters
         ***********************************************/

        [BsonId]    // id
        public Guid Id { get; set; }   
        public string Name { get; set; }
        public int Quantity { get; set; }
        public string Unit { get; set; }

    }
}
