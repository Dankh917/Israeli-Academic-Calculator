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
        List<Course> listCourses;

        public Calculator()
        {
            listCourses = new List<Course>();
        }

        public void AddCourse(Course course)
        {
            listCourses.Add(course);
        }
        public void DeleteCourse(Course course) 
        { 
            listCourses.Remove(course);
        }

        public double CalculateAverageScore()
        {
            double total_score=0;
            double total_nakaz=0;
            double result;

            foreach (Course course in listCourses)
            {
                if (course.IsBinaryActive == false)
                {
                    total_score += course.Score * course.Nakaz;
                    total_nakaz += course.Nakaz;
                }
            }
            result = total_score / total_nakaz;
            
            return Math.Round(result, 2); //rounds the average score result to XX.XX format  

        }

        public void PrintCoursesNames()
        {
            foreach(Course course in listCourses)
            {
                Console.WriteLine(course.Name+" ");
            }
        }




    }
}
