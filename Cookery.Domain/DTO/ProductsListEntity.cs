using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System.Collections.Generic;

namespace Cookery.Domain.DTO
{
    //[BsonCollection("products")]
    public class ProductsListEntity 
    {
        [BsonElement("product")]
        public List<ProductsEntity> Products { get; set; }

        [BsonElement("check")]
        public bool Check { get; set; }

        [BsonElement("quantity")]
        public int Quantity { get; set; }
    }
}
