using System;
using System.Collections.Generic;               // List<>
using MongoDB.Bson.Serialization.Attributes;
using NotesCook.Database;


namespace NotesCook.Models
{
    public class Recipe : Model
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
         *            Remove element to recipe object
         ***********************************************/

        /**
         * Destroy Recipe
         **/
        public void Destroy()
        {
            DB dB = new DB("NotesCook", "Recipe");
            dB.Delete<Recipe>(this.Id);
        }

        /**
         * Remove step
         * @param position
         **/
        public void RemoveStepByPosition(int position)
        {
            foreach(Step step in this.Steps)
            {
                if(step.Position == position)
                {
                    this.Steps.Remove(step);
                    return;
                }
            }
        }

        /**
         * Remove ingredient
         * @param name
         **/
        public void RemoveIngredientByName(string name)
        {
            foreach (Ingredient ingredient in this.Ingredients)
            {
                if (ingredient.Name == name)
                {
                    this.Ingredients.Remove(ingredient);
                    return;
                }
            }
        }

        /**
         * Remove tag
         * @param name
         **/
        public void RemoveTagByName(string name)
        {
            foreach (Tag tag in this.Tags)
            {
                if (tag.Name == name)
                {
                    this.Tags.Remove(tag);
                    return;
                }
            }
        }

    /************************************************
     *             Operations on records
     ***********************************************/


        public override void Create()
        {
            Insert<Recipe>(this);
        }

        public override void Edit()
        {
            Update<Recipe>(this.Id, this);
        }

        public override void Remove()
        {
            Delete<Recipe>(this.Id);
        }

    }
}
