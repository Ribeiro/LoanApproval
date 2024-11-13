namespace LoanApproval.Models;

public class LoanApplication
{
    public int CreditScore {get;} 
    public int Age {get;}
    public decimal Income {get;}

    public LoanApplication(int creditScore, int age, decimal income)
    {
        CreditScore = creditScore;
        Age = age;
        Income = income;
    }
}