﻿using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class BusinessLoanService : ILoanBaseManager
    {
        public void Calculate()
        {
            Console.WriteLine("Esnaf kredisi hesaplandı.");
        }

        public void DoSmthg()
        {
            throw new NotImplementedException();
        }
    }
}
