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
        double score;
        double nakaz; //nakaz = Credit points per course
        bool is_binary_active; // checks if binary assigned to course


        public Course(string name, double score, double nakaz, bool is_binary_active)
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
        public double Score
        {
            get { return score; }
            set 
            {
                
               
                if (value < 0 || value > 100)
                {
                    throw new Exception("Score must be a positve number between 0-100");
                }
                score = value; 
            }
        }
        public double Nakaz
        {
            get { return nakaz; }
            set 
            {
                if (value <= 0 )
                {
                    throw new Exception("Nakaz must be a positve number (>0)");
                }
                
                nakaz = value; 
            }
        }
        public bool Is_Binary_Active
        {
            get { return is_binary_active; }
            set { is_binary_active = value;}
        }


        public override string ToString()
        {
            return "Name: "+Name+" | Score: "+score+" | Nakaz: "+nakaz+" | Binary active: "+Is_Binary_Active;
        }

        public override bool Equals(object obj) //overwritten this as to make the Del_Course(Course course) func in the Calculator class work , without it wouldnt work
        {
            if (obj == null || GetType() != obj.GetType())
                return false;

            Course other = (Course)obj;
            return Name == other.Name && Score == other.Score && Nakaz == other.Nakaz && Is_Binary_Active == other.Is_Binary_Active; 
        }
    }


  
}
