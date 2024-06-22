using CSharp.Activity.Delegates;
using System;

namespace LoanProcessing
{
    class Program
    {
        static void Main()
        {
            LoanSystem loanSystem = new LoanSystem();
            loanSystem.ProcessLoanApplication(Show);
        }

        // Callback method to display the credit score of the applicant on the console
        static void Show(LoanApplicant applicant)
        {
            Console.WriteLine($"Applicant's Credit Score: {applicant.CreditScore}");
        }
    }
}