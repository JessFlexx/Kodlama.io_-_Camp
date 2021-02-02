using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3._2
{
    class PersonManager
    {
        public void Add() 
        {
            Console.WriteLine("Eklendi");
        } 

    }
    class CustomerManager2 : PersonManager
    {
        public CustomerManager2()
        {
        }
    }
}
