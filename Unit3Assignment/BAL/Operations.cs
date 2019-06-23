using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using BEL;
using System.Data;
using System.Data.SqlClient;

namespace BAL
{
    public class Operations
    {
        public Dbconnection db = new Dbconnection();
        public Informations info = new Informations();

        public int insertReg(Informations info)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into Register Values ('"+info.name+"','"+info.gender+"','"+info.dob+"','"+info.address+"','"+info.education+"','"+info.username+"','"+info.password+"' )";
            return db.ExenonQuery(cmd);
        }

        public DataTable login(Informations info)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from register where Username = '" + info.username + "' and Password = '" + info.password + "'";
            return db.ExeReader(cmd);
        }
        //here we declare the queries and db operations needed for the application

    }
}
