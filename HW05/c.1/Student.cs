using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c._1
{
    public class Student
    {
        public int _studentNumber;
        public string _firstname;
        public string _lastname;
        public float _gpa;
        public string _classification;
        public string _major;

        public string Name
        {
            get
            {
                if (string.IsNullOrEmpty(this._firstname) || (string.IsNullOrEmpty(this._lastname)))
                {
                    throw new Exception("invalid");
                }
                else
                {
                    return this._firstname + " " + this._lastname;
                }
            }
        }

        public float overall_GPA
        {
            get
            {
                if (this._gpa < 0)
                {
                    throw new Exception("invalid");
                }
                else
                {


                    return this._gpa;
                }
            }
        }

        public string major
        {
            set
            {
                _major = value;
            }
            get
            {
                return _major;
            }
        }

        public int studentnumber
        {
            set
            {
                _studentNumber = value;
            }
            get
            {
                return _studentNumber;
            }
        }

        public string Classification
        {
            set
            {
                _classification = value;
            }

            get
            {
                return _classification;
            }
        }

        public Student( String Firstname,string Lastname)
        {
            
            this._firstname = Firstname;
            this._lastname = Lastname;
        }
        public Student(float GPA, string Major)
        {
            this._gpa = GPA;
            this._major = Major;
        }
        
    }
}
