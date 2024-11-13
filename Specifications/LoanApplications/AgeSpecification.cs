using LoanApproval.Models;

namespace LoanApproval.Specifications.LoanApplications;

public class AgeSpecification : Specification<LoanApplication>
{
    public override bool IsSatisfiedBy(LoanApplication entity) => entity.Age >= 21 && entity.Age <=65;
}