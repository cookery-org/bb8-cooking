using Cookery.Domain.Enums;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Cookery.Domain.DTO
{

    //[BsonCollection("products")]
    public class ProductsEntity : Document
    {
        [BsonElement("name")]
        public string Name { get; set; }

        [BsonElement("category")]
        public ECategory Category { get; set; }        
    }
}
