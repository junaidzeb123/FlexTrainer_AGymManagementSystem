using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace WindowsFormsApp2
{
    public class Owner_class
    {
        private string firstName;
        private string lastName;
        private string gmail;
        private string fatherName;
        private string cnic;
        private string gender;
        private string address;
        private string password;
        private string userName;

        private string gymname;
        private string licencseNO;
        private string location;
        private string timing;
        private int  varificatiostatus;



        public int Getvarificatiostatus()
        {
            return varificatiostatus;
        }

        public void Setvarificatiostatus(int value)
        {
            varificatiostatus = value;
        }
        // Getter and setter methods for firstName
        public string GetFirstName()
        {
            return firstName;
        }

        public void SetFirstName(string value)
        {
            firstName = value;
        }

        // Repeat the above pattern for other properties...
        public string GetLastName()
        {
            return lastName;
        }

        public void SetLastName(string value)
        {
            lastName = value;
        }

        public string GetGmail()
        {
            return gmail;
        }

        public void SetGmail(string value)
        {
            gmail = value;
        }

        public string GetFatherName()
        {
            return fatherName;
        }

        public void SetFatherName(string value)
        {
            fatherName = value;
        }

        public string GetCNIC()
        {
            return cnic;
        }

        public void SetCNIC(string value)
        {
            cnic = value;
        }

        public string GetGender()
        {
            return gender;
        }

        public void SetGender(string value)
        {
            gender = value;
        }


        public string Getgymname()
        {
            return gymname;
        }

        public void SetGymName(string value)
        {
            gymname = value;
        }

        public string GetUserName()
        {
            return userName;
        }

        public void SetUserName(string value)
        {
            userName = value;
        }
        public string GetAddress()
        {
            return address;
        }

        public void SetAddress(string value)
        {
            address = value;
        }
        public string GetPassword()
        {
            return password;
        }

        public void SetPassword(string value)
        {
            password = value;
        }


        public string GetLicenseNO()
        {
            return licencseNO;
        }

        public void SetLicenseNO(string value)
        {
            licencseNO = value;
        }

        public string GetLocation()
        {
            return location;
        }

        public void SetLocation(string value)
        {
            location = value;
        }

      

        public string GetTiming()
        {
            return timing;
        }

        public void SetTiming(string value)
        {
            timing = value;
        }

      
    }
}
