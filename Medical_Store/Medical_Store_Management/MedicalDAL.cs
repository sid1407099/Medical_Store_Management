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
            catch (Exception e)
            {
                throw e;
            }

        }

        public int Client(MedicalDTO newObj1)
        {
            try
            {

                sqlConObj.ConnectionString = ConfigurationManager.ConnectionStrings["Medical"].ConnectionString;

                sqlCmdObj.CommandText = @"insertIntoClient";

                sqlCmdObj.CommandType = CommandType.StoredProcedure;
                sqlCmdObj.Connection = sqlConObj;


                sqlCmdObj.Parameters.AddWithValue("@CU_Id", newObj1.id);
                sqlCmdObj.Parameters.AddWithValue("@CU_Name", newObj1.firstName);
                sqlCmdObj.Parameters.AddWithValue("@CU_Surname", newObj1.last_Name);
                sqlCmdObj.Parameters.AddWithValue("@CU_Mobile_No", newObj1.mobile);
                sqlCmdObj.Parameters.AddWithValue("@CU_Address", newObj1.address);
                sqlCmdObj.Parameters.AddWithValue("@CU_City", newObj1.city);
                //sqlCmdObj.Parameters.AddWithValue("@Query", 1);

                SqlParameter prmReturn = new SqlParameter();
                prmReturn.Direction = ParameterDirection.ReturnValue;
                prmReturn.SqlDbType = SqlDbType.Int;
                sqlCmdObj.Parameters.Add(prmReturn);

                sqlConObj.Open();

                //non execute query
                sqlCmdObj.ExecuteNonQuery();
                return Convert.ToInt32(prmReturn.Value);

            }
            catch (Exception e)
            {

                throw e;

            }
        }
        public int Sales(MedicalDTO newObj1)
        {
            try
            {

                sqlConObj.ConnectionString = ConfigurationManager.ConnectionStrings["Medical"].ConnectionString;

                sqlCmdObj.CommandText = @"SALES_INSERT_STOCK";

                sqlCmdObj.CommandType = CommandType.StoredProcedure;
                sqlCmdObj.Connection = sqlConObj;


                sqlCmdObj.Parameters.AddWithValue("@PID", newObj1.id);
                sqlCmdObj.Parameters.AddWithValue("@PNAME", newObj1.firstName);
                sqlCmdObj.Parameters.AddWithValue("@NAME", newObj1.sname);
                sqlCmdObj.Parameters.AddWithValue("@PRICE", newObj1.price);
                sqlCmdObj.Parameters.AddWithValue("@QNT", newObj1.quantity);
                sqlCmdObj.Parameters.AddWithValue("@TPRICE", newObj1.total_price);
                //sqlCmdObj.Parameters.AddWithValue("@Query", 1);

                SqlParameter prmReturn = new SqlParameter();
                prmReturn.Direction = ParameterDirection.ReturnValue;
                prmReturn.SqlDbType = SqlDbType.Int;
                sqlCmdObj.Parameters.Add(prmReturn);

                sqlConObj.Open();

                //non execute query
                sqlCmdObj.ExecuteNonQuery();
                return Convert.ToInt32(prmReturn.Value);

            }
            catch (Exception e)
            {

                throw e;

            }
        }
        public int Company(MedicalDTO newObj1)
        {
            try
            {

                sqlConObj.ConnectionString = ConfigurationManager.ConnectionStrings["Medical"].ConnectionString;

                sqlCmdObj.CommandText = @"CompanyMst_ADD";

                sqlCmdObj.CommandType = CommandType.StoredProcedure;
                sqlCmdObj.Connection = sqlConObj;

                sqlCmdObj.Parameters.AddWithValue("@cid", newObj1.id);
                sqlCmdObj.Parameters.AddWithValue("@cname", newObj1.cname);
                sqlCmdObj.Parameters.AddWithValue("@person", newObj1.last_Name);
                sqlCmdObj.Parameters.AddWithValue("@address", newObj1.address);
                sqlCmdObj.Parameters.AddWithValue("@contact", newObj1.mobile);
                //sqlCmdObj.Parameters.AddWithValue("@Query", 1);

                SqlParameter prmReturn = new SqlParameter();
                prmReturn.Direction = ParameterDirection.ReturnValue;
                prmReturn.SqlDbType = SqlDbType.Int;
                sqlCmdObj.Parameters.Add(prmReturn);

                sqlConObj.Open();

                //non execute query
                sqlCmdObj.ExecuteNonQuery();
                return Convert.ToInt32(prmReturn.Value);

            }
            catch (Exception e)
            {

                throw e;

            }
        }
    }
}
