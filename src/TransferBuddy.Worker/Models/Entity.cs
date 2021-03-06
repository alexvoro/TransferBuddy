using System;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace TransferBuddy.Worker.Models
{
    public abstract class Entity
    {
        [BsonId]
        public ObjectId Id { get; set; }

        public DateTime Created { get; set; }
    }
}