using System.ComponentModel;
using System.Text.Json.Serialization;

namespace Cookery.Domain.Enums
{
    [Newtonsoft.Json.JsonConverter(typeof(JsonStringEnumConverter))]
    public enum ECategory
    {
        [Description("Drinks")]
        Drinks = 1,

        [Description("Utilities")]
        Utilities = 2,

        [Description("Cleaning")]
        Cleaning = 3,

        [Description("Personal Hygiene")]
        PersonalHygiene = 4,

        [Description("Grocery")]
        Grocery = 5,

        [Description("Cold and Dairy Products")]
        ColdAndDairyProducts = 6,

        [Description("Fruits and Vegetables")]
        FruitsAndVegetables = 7,

        [Description("Butcher and Fish")]
        ButcherAndFish = 8,

        [Description("Frozen")]
        Frozen = 11,

        [Description("Canned")]
        Canned = 12
    }
}