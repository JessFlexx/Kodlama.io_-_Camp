using System;

namespace OOP3._2
{
    class Program
    {
        static void Main(string[] args)
        {
            //IPersonManager personManager = new IPersonManager();
            //personManager.Add(); //iNTERFACE NEWLENEMEZ
            //Inheritance newlenir
            IPersonManager customerManager = new CustomerManager();
            customerManager.Add();

            IPersonManager employeeManager = new EmplpyeeManager();
            employeeManager.Add();

            IPersonManager internManager = new InternManager();

            ProjectManager projectManager = new ProjectManager();
            projectManager.ekle(customerManager);
            projectManager.ekle(employeeManager);
            projectManager.ekle(internManager);
            projectManager.Update(customerManager);
            projectManager.Update(employeeManager);
            projectManager.Update(internManager);

        }
    }
}
