/*using LoanApproval.Services;
using LoanApproval.Specifications;
using LoanApproval.Specifications.LoanApplications;
using LoanApproval.Models;

namespace LoanApproval.Main;

public class Program
{
    protected Program()
    {}

    static void Main(string[] args)
    {
        var specifications = new Dictionary<string, ISpecification<LoanApplication>>
        {
            { "CreditScore", new CreditScoreSpecification() },
            { "Age", new AgeSpecification() },
            { "Income", new IncomeSpecification() }
        };

        var loanService = new LoanService(specifications);
        var application = new LoanApplication(720, 30, 55000);

        bool isApproved = loanService.ApproveLoan(application);
        Console.WriteLine($"Loan Approved: {isApproved}");
    }
}
*/
