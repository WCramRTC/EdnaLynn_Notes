using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdnaLynn_Notes
{
    internal class Patient
    {

        // Class Members
        // 4 Types of members
        // Fields
        string _firstName;
        string _lastName;
        string _mailingAddress;
        string _socialSecurityNumber;
        string _pronoun;
        string _genderIdentity;

        // Constructor
        // Access Modifer - No Return - No static - Class Name
        public Patient(string firstName, string lastName, string mailing, string social, string pronoun, string gender)
        {
            _firstName = firstName;
            _lastName = lastName;
            _mailingAddress = mailing;
            _socialSecurityNumber = social;
            _pronoun = pronoun;
            _genderIdentity = gender;
        }

        // overloading 
        public Patient(string firstName, string lastName)
        {
            _firstName = firstName;
            _lastName = lastName;
        }



        // Properties
        // _firstName - No Parenthesis
        public string FirstName
        {
            // 3 keywords, get, set, value
            // Get allows the user to SEE the value
            get
            {
                return _firstName;
            }
            // --------------------
            set
            {
                if(value != "Jonathan")
                {
                    _firstName = value;
                }
                else
                {
                    _firstName = "Get Bent Jonathan";
                }
                
            }
        }

        public string SocialSecurityNumber { get => _socialSecurityNumber; 
           }


        // Methods
        public void ChangeSocial()
        {
            //_socialSecurityNumber
        }
    }
}
