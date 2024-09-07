using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Israeli_Academic_Calculator
{
    public class Course
    {
        string name;
        int score;
        int nakaz; //nakaz = Credit points per course
        bool is_binary_active; // checks if binary assigned to course


        public Course(string name, int score, int nakaz, bool is_binary_active)
        {
            Name = name;
            Score = score;
            Nakaz = nakaz;
            Is_Binary_Active = is_binary_active;
            
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Score
        {
            get { return score; }
            set { score = value; }
        }
        public int Nakaz
        {
            get { return nakaz; }
            set { nakaz = value; }
        }
        public bool Is_Binary_Active
        {
            get { return is_binary_active; }
            set { is_binary_active = value;}
        }

    }

  
}
