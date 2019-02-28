using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wpf_tmp.Model
{
    public class Person
    {
        private string fName;
        public string Fname
        {
            get { return fName; }
            set
            {
                fName = value;
            }
        }

        private string lName;
        public string LName
        {
            get { return lName; }
            set
            {
                lName = value;
            }
        }

        private string fullName;
        public string FullName
        {
            get
            {
                return fullName = Fname + " " + LName;
            }
            set
            {
                if (fullName != value)
                {
                    fullName = value;
                }
            }
        }
    }
}