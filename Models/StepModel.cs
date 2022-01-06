using System;
using MongoDB.Bson.Serialization.Attributes;


namespace NotesCook.Models
{
    class StepModel
    {
        [BsonId]    // id
        public Guid Mid { get; set; }   // MongoDB private id
        public int Position { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

    }
}
