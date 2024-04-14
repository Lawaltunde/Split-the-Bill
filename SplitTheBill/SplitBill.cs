namespace SplitTheBill;

public class SplitBill
{
    public decimal AcceptTheAmountAndNumberOfPeopleReturnSplitAmount(int people, decimal amount){
        if(amount== 0)
            return 0;

        else 
            if(people == 0)
                throw new  DivideByZeroException("Number of People can't be zero");
        
        else
            return amount/people;  

    }
}
