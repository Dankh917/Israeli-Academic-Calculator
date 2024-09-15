using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Israeli_Academic_Calculator
{
    public record Course
    {
        string name;
        double score;
        double nakaz; //nakaz = Credit points per course
        bool isBinaryActive; // checks if binary assigned to course


        public Course(string name, double score, double nakaz, bool isBinaryActive)
        {
            Name = name;
            Score = score;
            Nakaz = nakaz;
            IsBinaryActive = isBinaryActive;
            
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
        public bool IsBinaryActive
        {
            get { return isBinaryActive; }
            set { isBinaryActive = value;}
        }


        public override string ToString()
        {
            return "Name: "+Name+" | Score: "+score+" | Nakaz: "+nakaz+" | Binary active: "+isBinaryActive;
        }

        
    }


  
}
