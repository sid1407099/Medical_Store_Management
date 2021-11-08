using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using DTO;
using System.Data;

namespace DAL
{
    class MedicalDAL
    {
        SqlConnection sqlConObj;
        SqlCommand sqlCmdObj;

        public MedicalDAL()
        {
            sqlConObj = new SqlConnection();
            sqlCmdObj = new SqlCommand();
        }
        public int checkLogin(MedicalDTO newObj)
        {
            try
            {
                sqlConObj.ConnectionString = ConfigurationManager.ConnectionStrings["Medical"].ConnectionString;

                sqlCmdObj.CommandText = @"UserMst_Select_for_login";

                sqlCmdObj.CommandType = CommandType.StoredProcedure;
                sqlCmdObj.Connection = sqlConObj;

                
                sqlCmdObj.Parameters.AddWithValue("@name", newObj.UserName);
                sqlCmdObj.Parameters.AddWithValue("@pass", newObj.UserPassword);

                //Return
                SqlParameter prmReturn = new SqlParameter();
                prmReturn.Direction = ParameterDirection.ReturnValue;
                prmReturn.SqlDbType = SqlDbType.Int;
                sqlCmdObj.Parameters.Add(prmReturn);

                sqlConObj.Open();

                //non execute query
                sqlCmdObj.ExecuteNonQuery();
                return Convert.ToInt32(prmReturn.Value);
            }
            catch(Exception e)
            {
                throw e;
            }
        }
    }
}
