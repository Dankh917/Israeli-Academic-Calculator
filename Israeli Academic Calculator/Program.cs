using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Israeli_Academic_Calculator
{
    //Test and debugging file
    internal class Program
    {
        [STAThread]  // This is required for WPF applications
        public static void Main(string[] args)
        {
            Calculator calculator = new Calculator();


            Course c1 = new Course("english", 64, 3, true);
            Course c2 = new Course("Deutsch", 78, 4, false);
            Course c3 = new Course("Deutsch", 92, 2, false);

            calculator.Add_Course(c1);
            calculator.Add_Course(c2);
            calculator.Add_Course(c3);

            Console.WriteLine(calculator.Calculate_Average_Score());    


        }
    }
}
