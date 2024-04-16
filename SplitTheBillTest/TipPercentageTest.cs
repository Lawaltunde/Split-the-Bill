namespace SplitTheBill;

using Microsoft.VisualBasic;
using SplitTheBill;

[TestClass]
public class TipPercentageTest
{
    TipPercentage tipPercentage = new TipPercentage();
    Dictionary<string, decimal> mealDetails = new Dictionary<string, decimal>{
        {"Lawal", 78.0M},
        {"Tunde", 87.0M},
        {"Prof Brent", 98.0M}
    };

    float tipPercent = 15.0f; 

    [TestMethod]
    public void returningActualValueWhenAllParameterArePassed(){

        var ret = tipPercentage.getTipPercentageCalculated(mealDetails, tipPercent);

        Assert.AreEqual((double)11.7M, (double)ret["Lawal"]); //total tip is 39.45

    }

    [TestMethod]
    public void retuning_Zero_Amount_Paid_ForTheTip_WhenZeroTipPercentageIsPassed(){
        float tipPercent = 0.0f;
        var ret = tipPercentage.getTipPercentageCalculated(mealDetails, tipPercent);
        Assert.AreEqual(0, ret["Lawal"]);
        Assert.AreEqual(0, ret["Tunde"]);
        Assert.AreEqual(0, ret["Prof Brent"]);
    }
}