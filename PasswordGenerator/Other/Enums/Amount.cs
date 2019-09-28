using System.ComponentModel;

namespace PasswordGenerator.Other.Enums
{
    public enum Amount
    {
        [Description("None")]
        None,
        [Description("One")]
        One,
        //[Description("Random amount")]
        //RandomAmount,
        [Description("Exact Amount:")]
        ExactAmount
    }
}
