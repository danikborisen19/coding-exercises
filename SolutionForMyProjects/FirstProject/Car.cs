using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject
{
    class MyClass
    {

        string color = "red";
        int maxSpeed = 200;

        public void fullThrottle()
        {
            Console.WriteLine("The car is going as fast as it can!");
        }
        class Program
        {
            static void Main(string[] args)
            {
                MyClass myCar = new MyClass();
                myCar.fullThrottle();
            }
        }
    }
}
        







