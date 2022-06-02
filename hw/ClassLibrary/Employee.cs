using System;
namespace ClassLibrary
{
    public class Employee:Department
    {
       
        public string Surname;
        protected double _salary;

        public int SalaryLimit
        {
            get => _salarylimit;
                set
            {
                if (_salarylimit > 250)
                    _salarylimit = value;
            }
        }

        public Employee()
        {
            Name = Name.ToUpper();
            Surname = Surname.ToUpper();
        }

    }
}
