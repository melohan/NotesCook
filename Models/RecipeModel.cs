using System;
using System.Collections.Generic;               // List<>
using MongoDB.Bson.Serialization.Attributes;
using NotesCook.Database;


namespace NotesCook.Models
{
    class RecipeModel
    {
        /************************************************
         *            Constructors
         ***********************************************/
        private const string COLLECTION = "Recipe";
        private const string DATABASE = "Database";
        /**
         * Default constructor
         **/
        public RecipeModel()
        {
            this.Tags        = new List<TagModel>();
            this.Ingredients = new List<IngredientModel>();
            this.Steps       = new List<StepModel>();
        }


        /************************************************
         *             Setters & Getters
         ***********************************************/

        [BsonId]    // id
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int NumberOfPeople { get; set; }
        public List<TagModel> Tags { get; set;  }
        public List<IngredientModel> Ingredients { get; set; }
        public List<StepModel> Steps { get; set; }


        /************************************************
         *            Add element to recipe
         ***********************************************/

        /**
         * Add tag
         * @param TagModel
         **/
        public void Add(TagModel tag)
        {
            this.Tags.Add(tag);
        }

        /**
         * Add ingredient
         * @param IngredientModel
         **/
        public void Add(IngredientModel ingredient)
        {
            this.Ingredients.Add(ingredient);
        }

        /**
         * Add step
         * @param StepModel
         **/
        public void Add(StepModel step)
        {
            this.Steps.Add(step);
        }

        /************************************************
         *            Remove element to recipe
         ***********************************************/

        /**
         * Remove tag
         * @param TagModel
         **/
        public void Remove(TagModel tag)
        {
            if (tag != null)
                this.Tags.Remove(tag);
        }

        /**
         * Add ingredient
         * @param IngredientModel
         **/
        public void Remove(IngredientModel ingredient)
        {
            if (ingredient != null)
                this.Ingredients.Remove(ingredient);
        }

        /**
         * Add step
         * @param StepModel
         **/
        public void Remove(StepModel step)
        {
            if (step != null)
                this.Steps.Remove(step);
        }

    }
}
