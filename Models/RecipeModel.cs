using System;
using MongoDB.Bson.Serialization.Attributes;


namespace NotesCook.Models
{
    class RecipeModel
    {

        [BsonId]    // id
        public Guid Id { get; set; }   // MongoDB private id
        public string Name {get; set;}
        public int NumberOfPeople { get; set; }

    }
}
