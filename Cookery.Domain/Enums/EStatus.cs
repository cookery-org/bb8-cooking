using System.ComponentModel;
using System.Text.Json.Serialization;

namespace Cookery.Domain.Enums
{
    [Newtonsoft.Json.JsonConverter(typeof(JsonStringEnumConverter))]
    public enum EStatus
    {
        [Description("Openned")]
        Openned = 1,

        [Description("Finish")]
        Finish = 2,

        [Description("In Progress")]
        InProgress = 3
    }
}