using LoanApproval.Models;

namespace LoanApproval.Specifications.LoanApplications;

public class IncomeSpecification : Specification<LoanApplication>
{
    public override bool IsSatisfiedBy(LoanApplication entity) => entity.Income >= 50000;
}