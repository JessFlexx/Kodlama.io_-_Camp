using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class ApplicationManager
    {
        public void ApplyLoan(ILoanBaseManager loanBaseManager , List<ILoggerService> loggerServices)
        {
            //Başvuran kişinin bilgilerini değerlendirme
            //Kodları
            loanBaseManager.Calculate();
            foreach ( var services in loggerServices)
            {
                services.Log();

            }
        }

        public  void DoPreInfo(List<ILoanBaseManager> loans) 
        {
            foreach (var loan in loans)
            {
                loan.Calculate();
            }

        }
    }
}
