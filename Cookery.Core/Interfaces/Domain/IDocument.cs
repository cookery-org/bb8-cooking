using MongoDB.Bson;
using System;

namespace Cookery.Core.Interfaces.Domain
{
    public interface IDocument
    {
        ObjectId Id { get; set; }
        DateTime CreateDate { get; }
        DateTime UpdateDate { get; set; }
    }
}
