﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace WindowsFormsApp2
{
    public class Member_class
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

        private string gym;
        private int VarificationStatus;


        public int GetVarificationStatus()
        {
            return VarificationStatus;
        }

        public void SetVarificationStatus(int value)
        {
            VarificationStatus = value;
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

      
        public string GetMemberGym()
        {
            return gym;
        }

        public void SetGymName(string value)
        {
            gym = value;
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
    }
}
