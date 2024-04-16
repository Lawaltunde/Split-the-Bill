namespace SplitTheBill;

public class TipPersonMethod{
    public decimal tipPerPerson(decimal price, int patron, float tipPercentage){

        var totalPrice = price * patron;
        
        var totalTip = (totalPrice * (decimal)tipPercentage) / 100;

        return totalTip/patron;
    }
}