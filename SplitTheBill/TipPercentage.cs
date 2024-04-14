namespace SplitTheBill;

public class TipPercentage{
    public Dictionary<string, decimal> getTipPercentageCalculated(Dictionary<string, decimal> detail, float tipPercentage){
        Dictionary<string, decimal> nameAndTip = new Dictionary<string, decimal>();

        decimal totalMealCost = 0;

        foreach(var nameTip in detail){
            totalMealCost += nameTip.Value;
        }

        decimal totalTipAmount = totalMealCost * (decimal)(tipPercentage/100);

        foreach(var single in detail){
            decimal tipForPerson = (single.Value / totalMealCost) * totalTipAmount;
            nameAndTip.Add(single.Key, tipForPerson);
        }

        return nameAndTip;
    }

}