using System.Collections.Generic;
using LoanApproval.Models;
using LoanApproval.Services;
using LoanApproval.Specifications;
using LoanApproval.Specifications.LoanApplications;


namespace LoanApprovalTests.Test
{

    public class LoanApprovalTest
    {
        private readonly Dictionary<string, ISpecification<LoanApplication>> _specifications = new Dictionary<string, ISpecification<LoanApplication>>
        {
            { "CreditScore", new CreditScoreSpecification() },
            { "Age", new AgeSpecification() },
            { "Income", new IncomeSpecification() }
        };

        [Fact]
        public void Should_Approve_Loan_When_Criteria_Are_Met()
        {
            // Arrange
            var loanApplication = new LoanApplication(750, 35, 60000m);
            var loanService = new LoanService(_specifications);

            // Act
            var isApproved = loanService.ApproveLoan(loanApplication);

            // Assert
            Assert.True(isApproved);
        }

        [Fact]
        public void Should_Reject_Loan_When_Criteria_Are_Not_Met()
        {
            // Arrange
            var loanApplication = new LoanApplication(500, 22, 15000m);
            var loanService = new LoanService(_specifications);

            // Act
            var isApproved = loanService.ApproveLoan(loanApplication);

            // Assert
            Assert.False(isApproved);
        }

    }
}