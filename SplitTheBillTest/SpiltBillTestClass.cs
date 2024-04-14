namespace SplitTheBillTest;
using SplitTheBill;

[TestClass]
public class SplitBillTestClass
{
    SplitBill splitBill = new SplitBill();

    [TestMethod]
    public void return_zero_when_noCurrency_orZeroAmount_passed()
    {
        
        var ret = splitBill.AcceptTheAmountAndNumberOfPeopleReturnSplitAmount(7, 0);
        Assert.AreEqual(0, ret);
    }

    [TestMethod]
    public void return_exeption_when_numberOfPepleIsZero()
    {
        //var ret = splitBill.AcceptTheAmountAndNumberOfPeopleReturnSplitAmount(0, 5);
        Assert.ThrowsException<DivideByZeroException>(()=> splitBill.AcceptTheAmountAndNumberOfPeopleReturnSplitAmount(0, 5));
    }

    [TestMethod]
    public void return_actualAmountToBeSplilted()
    {
        var ret = splitBill.AcceptTheAmountAndNumberOfPeopleReturnSplitAmount(10, 500);
        Assert.AreEqual(50, ret);
    }
}