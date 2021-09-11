using System.ComponentModel;
using System.Text.Json.Serialization;

namespace Cookery.Domain.Enums
{
    [Newtonsoft.Json.JsonConverter(typeof(JsonStringEnumConverter))]
    public enum EPaymentMethod
    {
        [Description("Money")]
        Money = 1,

        [Description("CreditCard")]
        CreditCard = 2,

        [Description("DebitCard")]
        DebitCard = 3,

        [Description("Voucher")]
        Voucher = 4
    }
}