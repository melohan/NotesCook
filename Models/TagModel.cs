using System;
using MongoDB.Bson.Serialization.Attributes;

namespace NotesCook.Models
{
    class TagModel
    {
        [BsonId]    // id
        public Guid Mid { get; set; }   // MongoDB private id
        public string Name { get; set; }
    }
}
