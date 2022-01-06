using System;
using MongoDB.Bson.Serialization.Attributes;


namespace NotesCook.Models
{
    class IngredientModel
    {

        [BsonId]    // id
        public Guid Mid { get; set; }   // MongoDB private id
        public string Name { get; set; }
        public int Quantity { get; set; }
        public string Unit { get; set; }

    }
}
