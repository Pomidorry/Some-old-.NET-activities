using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharp.Activity.Delegates;

namespace Activity9Delegates.Tests
{
    [TestClass]
    public class LoanSystemTests
    {
        [TestMethod]
        public void TestLoanApplicationProcessing()
        {
            // Arrange
            LoanSystem loanSystem = new LoanSystem();

            // Act
            LoanApplicant applicantResult = null;
            Action<LoanApplicant> callbackMethod = (applicant) => applicantResult = applicant;
            loanSystem.ProcessLoanApplication(callbackMethod);

            // Assert
            Assert.IsNotNull(applicantResult);
            Assert.IsTrue(applicantResult.CreditScore >= 1 && applicantResult.CreditScore <= 100);
        }
    }
}
