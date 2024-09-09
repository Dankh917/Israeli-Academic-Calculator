using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Israeli_Academic_Calculator
{
    public class Calculator
    {
        List<Course> List_Courses;

        public Calculator()
        {
            List_Courses = new List<Course>();
        }

        public void Add_Course(Course course)
        {
            List_Courses.Add(course);
        }
        public void Del_Course(Course course) 
        { 
            List_Courses.Remove(course);
        }

        public double Calculate_Average_Score()
        {
            double total_score=0;
            double total_nakaz=0;
            double result;

            foreach (Course course in List_Courses)
            {
                if (course.Is_Binary_Active == false)
                {
                    total_score += course.Score * course.Nakaz;
                    total_nakaz += course.Nakaz;
                }
            }
            result = total_score / total_nakaz;
            
            return Math.Round(result, 2); //rounds the average score result to XX.XX format  

        }

        public void Print_Courses_names()
        {
            foreach(Course course in List_Courses)
            {
                Console.WriteLine(course.Name+" ");
            }
        }




    }
}
