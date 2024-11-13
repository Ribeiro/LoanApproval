using LoanApproval.Specifications;
using LoanApproval.Models;

namespace LoanApproval.Services
{
    public class LoanService
    {
        private readonly ISpecification<LoanApplication> _loanApprovalSpec;

        public LoanService(Dictionary<string, ISpecification<LoanApplication>> specifications)
        {
            if (specifications == null || specifications.Count == 0)
            {
                throw new ArgumentException("Specifications dictionary cannot be null or empty.");
            }

            _loanApprovalSpec = CombineSpecifications(specifications);
        }

        private static ISpecification<LoanApplication> CombineSpecifications(Dictionary<string, ISpecification<LoanApplication>> specs)
        {
            ISpecification<LoanApplication>? combinedSpec = null;

            foreach (var spec in specs.Values)
            {
                combinedSpec = combinedSpec == null ? spec : combinedSpec.And(spec);
            }

            return combinedSpec!;
        }

        public bool ApproveLoan(LoanApplication application)
        {
            return _loanApprovalSpec.IsSatisfiedBy(application);
        }
    }
}