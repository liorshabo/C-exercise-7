using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace Proj7
{
    class Worker
    {

        string first_name;
        string last_name;
        int num_of_shifts;
        double salary;

        public string First_name { get => first_name; set => first_name = value; }
        public string Last_name { get => last_name; set => last_name = value; }
        public int Num_of_shifts { get => num_of_shifts; set => num_of_shifts = value; }
        public double Salary { get => salary; set => salary = value; }

        public Worker (string first, string last, int shift, double sal)
        {
            First_name = first;
            Last_name = last;
            Num_of_shifts = shift;
            Salary = sal;
        }
        public override string ToString()
        {
            return Last_name + " " + First_name;
        }

    }
}
