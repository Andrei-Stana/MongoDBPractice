using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace MongoDBPractice
{
    class Personenbeschreibung
    {
        //Getters and setters

        [BsonId]
        public Guid Id { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public int Age { get; set; }
        public int Code { get; set; }
    }
}
