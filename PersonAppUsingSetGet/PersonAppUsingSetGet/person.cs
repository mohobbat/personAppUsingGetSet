using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonAppUsingSetGet
{
    class person
    {
        private string firstName ;
        private string lastName;
        private string middleName;


        public string FirstName
        {
            set
            {

                firstName = value;
            }

            get
            {
                return firstName;
            }
        }

        public string LastName
        {
            set
            {
                
               
                
                
                    lastName = value;    
                
                
            }
            get
            {
                return lastName;
            }

        }

        public string MiddleName
        {
            set
            {
                middleName = value;
            }
            get
            {
                return middleName;
            }
        }



        public string GetFulName()
        {
            return firstName + "  " + middleName + "   " + lastName;
        }


        public string GetReversName()
        {
            string Revers = " ";
            string fulname = GetFulName();

            for (int i = fulname.Length - 1; i >= 0; i--)
            {
                Revers += fulname[i];

            }
            return Revers;
        }
    }


}
