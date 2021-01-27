using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class PersonalLoanManager : ILoanBaseManager
    {
        public void Calculate()
        {
            Console.WriteLine("Bireysel kredi ödeme planı hesaplandı.");
        }

        public void DoSmthg()
        {
            throw new NotImplementedException();
        }
    }
}
