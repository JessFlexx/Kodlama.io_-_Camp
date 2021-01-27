using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            
            ILoanBaseManager mortgageLoanManager = new MortgageLoanManager();
            ILoanBaseManager vehicleLoanManager = new VehicleLoanManager();
            ILoanBaseManager personalLoanManager = new PersonalLoanManager();

            ILoggerService dataBaseLoggerService = new DataBaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();

            
            ApplicationManager applicationManager = new ApplicationManager();
            applicationManager.ApplyLoan(new BusinessLoanService(),
            new List<ILoggerService> { new DataBaseLoggerService(), new SmsLoggerService() } );


            List<ILoanBaseManager> loans = new List<ILoanBaseManager> {personalLoanManager , vehicleLoanManager};
            applicationManager.DoPreInfo(loans);


        }
    }
}
