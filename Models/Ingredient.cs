using System;
using System.Collections.Generic;
using MongoDB.Bson.Serialization.Attributes;


namespace NotesCook.Models
{

    public class Ingredient
    {

        /************************************************
         *            Constructors
         ***********************************************/

        /**
         * Default constructor
         **/
        public Ingredient(){}

        /**
         * Constructor with params
         * @param string name
         * @param int quantity
         * @param string unit
         **/
        public Ingredient(string name, int quantity, string unit)
        {
            this.Name     = name;
            this.Quantity = quantity;
            this.Unit     = unit;
        }

        /**
         * Copy constructor
         * @param IngredientModel
         **/
        public Ingredient(Ingredient Other)
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

        /************************************************
         *                  Methods 
         ***********************************************/

        /**
         * Get ingredient by a name in a list.
         * @param List<Ingredient> list
         * @string name
         **/ 
        public static Ingredient FindByName(List<Ingredient> list, string name)
        {
            foreach(Ingredient ingredient in list)
            {
                if (ingredient.Name == name)
                    return ingredient;
            }
            return new Ingredient();
        }

    }
}
