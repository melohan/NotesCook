using System;
using System.Collections.Generic;               // List<>
using MongoDB.Bson.Serialization.Attributes;
using NotesCook.Database;


namespace NotesCook.Models
{
    public class Recipe
    {
        /************************************************
         *            Constructors
         ***********************************************/

        /**
         * Default constructor
         **/
        public Recipe()
        {
            this.Tags        = new List<Tag>();
            this.Ingredients = new List<Ingredient>();
            this.Steps       = new List<Step>();
        }
      

        /************************************************
         *             Setters & Getters
         ***********************************************/

        [BsonId]    // id
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int NumberOfPersons { get; set; }
        public List<Tag> Tags { get; set;  }
        public List<Ingredient> Ingredients { get; set; }
        public List<Step> Steps { get; set; }


        /************************************************
         *            Add element to recipe
         ***********************************************/

        /**
         * Add tag
         * @param TagModel
         **/
        public void Add(Tag tag)
        {
            this.Tags.Add(tag);
        }

        /**
         * Add ingredient
         * @param IngredientModel
         **/
        public void Add(Ingredient ingredient)
        {
            this.Ingredients.Add(ingredient);
        }

        /**
         * Add step
         * @param StepModel
         **/
        public void Add(Step step)
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
        public void Remove(Tag tag)
        {
            if (tag != null)
                this.Tags.Remove(tag);
        }

        /**
         * Add ingredient
         * @param IngredientModel
         **/
        public void Remove(Ingredient ingredient)
        {
            if (ingredient != null)
                this.Ingredients.Remove(ingredient);
        }

        /**
         * Add step
         * @param StepModel
         **/
        public void Remove(Step step)
        {
            if (step != null)
                this.Steps.Remove(step);
        }

    }
}
