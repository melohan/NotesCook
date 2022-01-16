using System;
using System.Collections.Generic;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using MongoDB.Driver;

/**
 * This object is an embedded document in recipe. 
 * Because the MongoDB driver does not auto-generate id for this kind of elements, 
 * the constructor does so before insertion into the database.
 **/
namespace NotesCook.Models
{

    public class Ingredient:Model
    {

        /************************************************
         *            Constructors
         ***********************************************/

        /**
         * Default constructor
         **/
        public Ingredient(){
            this.Id = Guid.NewGuid();
        }

        /**
         * Constructor with params
         * @param string name
         * @param double quantity
         * @param string unit
         **/
        public Ingredient(string name, double quantity, string unit):this()
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
        public double Quantity { get; set; }
        public string Unit { get; set; }

        /************************************************
         *             Methods on lists 
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


      /************************************************
       *             Operations on records
       ***********************************************/

        public override void Edit()
        {
            Update<Ingredient>(this.Id, this);
        }
        
        public override void Create()
        {
            Insert<Ingredient>(this);
        }
              
        public override void Remove()
        {
            Delete<Ingredient>(this.Id);
        }

    }
}
