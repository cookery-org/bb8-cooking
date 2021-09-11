using Cookery.Core.Interfaces.Domain;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;

namespace Cookery.Domain.DTO
{
    public abstract class Document : IDocument
    {
        [BsonId]
        [BsonRepresentation(BsonType.String)]
        public ObjectId Id { get; set; }
        [BsonDateTimeOptions(Representation = BsonType.DateTime)]
        [BsonElement("createDate")]
        public DateTime CreateDate { get; }
        [BsonDateTimeOptions(Representation = BsonType.DateTime)]
        [BsonElement("updateDate")]
        public DateTime UpdateDate { get; set; }
    }
}