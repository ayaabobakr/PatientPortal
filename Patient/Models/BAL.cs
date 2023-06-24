using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Patient.Models
{
    public class BAL
    {

        public string GetLogin(Class1 login)
        {
            DAL dal = new DAL();
            string response = dal.GetLogin(login);
            return response;
        }

        public string GetName()
        {
            DAL dal = new DAL();
            string response = dal.GetName();
            return response;
        }

        public string GetNid()
        {
            DAL dal = new DAL();
            string response = dal.GetNid();
            return response;
        }

        public string GetDOB()
        {
            DAL dal = new DAL();
            string response = dal.GetDOB();
            return response;
        }

        public string GetGender()
        {
            DAL dal = new DAL();
            string response = dal.GetGender();
            return response;
        }

        public string GetAddress()
        {
            DAL dal = new DAL();
            string response = dal.GetAddress();
            return response;
        }

        public string GetPhone()
        {
            DAL dal = new DAL();
            string response = dal.GetPhone();
            return response;
        }

        public string GetEmail()
        {
            DAL dal = new DAL();
            string response = dal.GetEmail();
            return response;
        }

        public string GetAllerg()
        {
            DAL dal = new DAL();
            string response = dal.GetAllerg();
            return response;
        }

        public string GetSympt()
        {
            DAL dal = new DAL();
            string response = dal.GetSympt();
            return response;
        }
    }
}