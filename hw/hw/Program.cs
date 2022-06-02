using System;
using ClassLibrary;

namespace hw
{
    class Program
    {
        static void Main(string[] args)
        {
            Department goods = new Department();
            goods.AddEmployee(new Employee() { Name = "Xeyal" });
            foreach(var item in goods.employees)
            {
                Console.WriteLine(item.Name);
            }

        }
    }
}
