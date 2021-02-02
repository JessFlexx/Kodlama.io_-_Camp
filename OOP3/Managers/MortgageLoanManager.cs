using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class MortgageLoanManager : ILoanBaseManager
    {
        public void Calculate()
        {
            //
            //Yapılacak hesaplama işlemlerinin kodları.
            //
            Console.WriteLine("Ev kredisi ödeme planı hesaplandı.");
        }

        public void DoSmthg()
        {
            throw new NotImplementedException();
        }
    }
}
