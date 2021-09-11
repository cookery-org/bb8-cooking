using Cookery.Domain.Enums;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;

namespace Cookery.Domain.DTO
{
    //[BsonCollection("shopList")]
    public class ShopListEntity : Document
    {
        [BsonElement("name")]
        public string Name { get; set; }

        public List<ProductsListEntity> ProductsLists { get; set; }

        [BsonElement("shopDate")]
        public DateTime ShopDate { get; set; }

        [BsonElement("status")]
        public EStatus Status { get; set; }

        [BsonElement("paymentMethod")]
        public EPaymentMethod PaymentMethod { get; set; }

        [BsonElement("local")]
        public string Local { get; set; }

        [BsonElement("amount")]
        public decimal Amount { get; set; }
    }
}
