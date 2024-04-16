namespace SplitTheBill;

using Microsoft.VisualBasic;
using SplitTheBill;

[TestClass]
public class TipPersonTest{
    TipPersonMethod tipPersonMethod = new TipPersonMethod();
    public void return_Exact_Value_WhenAll_Parameters_ArePassed(){
        decimal price = 1000.0M; 
        int patrons = 15;
        float tipercentage = 25.0f; 

        var ret = tipPersonMethod.tipPerPerson(price, patrons, tipercentage);
        Assert.AreEqual(250, (double)ret);
    }
}