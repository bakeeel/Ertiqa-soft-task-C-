using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SqlClient;

using System.Text;
using System.Threading.Tasks;

namespace Ertiqa_soft.DAL
{
    class LoginClass
    {
        public DataTable LOGIN(string user,string pass)
        {
            DataAccessLayer DAL = new DataAccessLayer();
            SqlParameter []parm = new SqlParameter[2];
            parm[0] = new SqlParameter("@USER", SqlDbType.VarChar, 50);
            parm[0].Value = user;

            parm[1] = new SqlParameter("@PASS", SqlDbType.VarChar, 50);
            parm[1].Value = pass;

            DAL.open();
            DataTable dt = new DataTable();

           dt= DAL.SelectData("SP_LOGIN", parm);
            return dt;


        }

    }
}
