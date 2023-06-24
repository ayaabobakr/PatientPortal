using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Web.UI.WebControls;
using System.Runtime.Remoting.Messaging;


namespace Patient.Models
{
    public class DAL
    {
        static public string name;
        static public void setname(string n)
        {
            name = n;
        }

        static public string getname()
        {
            return name;
        }

        static public string nid;
        static public void setnid(string n)
        {
            nid = n;
        }

        static public string getnid()
        {
            return nid;
        }


        static public string email;
        static public void setemail(string n)
        {
            email = n;
        }

        static public string getemail()
        {
            return email;
        }


        static public string phone;
        static public void setphone(string n)
        {
            phone = n;
        }

        static public string getphone()
        {
            return phone;
        }




        static public string age;
        static public void setage(string n)
        {
            age = n;
        }

        static public string getage()
        {
            return age;
        }



        static public string gen;
        static public void setgen(string n)
        {
            gen = n;
        }

        static public string getgen()
        {
            return gen;

        }


        static public string addre;
        static public void setaddre(string n)
        {
            addre = n;
        }

        static public string getaddre()
        {
            return addre;
        }


        static public string sym;
        static public void setsym(string n)
        {
            sym = n;
        }

        static public string getsym()
        {
            return sym;
        }


        static public string aller;
        static public void setaller(string n)
        {
            aller = n;
        }

        static public string getaller()
        {
            return aller;
        }



        public string GetLogin(Class1 login)
        {
            string connstring = "server=mssql-132712-0.cloudclusters.net,10130; uid=admin; pwd=#Sahar2023; database=Gimpses";
            SqlConnection con = new SqlConnection();
            con.ConnectionString = connstring;
            con.Open();  
            String sql = "SELECT Patient.*, MR.Allergies,MR.Pat_Symptoms FROM Patient JOIN MR ON Patient.NationalID = MR.NationalID WHERE Patient.username = '" + login.UserName + "' AND Patient.password ='" + login.Password + "'";
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            if (dt.Rows.Count > 0)
            {
                setnid(dt.Rows[0]["nationalid"].ToString());
                setname(dt.Rows[0]["name"].ToString());
                setaddre(dt.Rows[0]["Address"].ToString());
                setphone(dt.Rows[0]["phone"].ToString());
                setemail(dt.Rows[0]["email"].ToString());
                DateTime dateOfBirth = (DateTime)dt.Rows[0]["dateofbirth"];
                setage(dateOfBirth.ToString("dd/MM/yyyy"));
                setgen(dt.Rows[0]["gender"].ToString());
                setaller(dt.Rows[0]["allergies"].ToString());
                setsym(dt.Rows[0]["pat_symptoms"].ToString());
                return "Logged In Successfully"; }
            else
            { return "Log In Failed"; }

        }

        public string GetName()
        {
            return getname();
        }

        public string GetNid()
        {
            return getnid();
        }

        public string GetDOB()
        {
            return getage();
        }

        public string GetGender()
        {
            return getgen();
        }

        public string GetAddress()
        {
            return getaddre();
        }

        public string GetPhone()
        {
            return getphone();
        }

        public string GetEmail()
        {
            return getemail();
        }

        public string GetAllerg()
        {
            return getaller();
        }

        public string GetSympt()
        {
            return getsym();
        }


    }
}