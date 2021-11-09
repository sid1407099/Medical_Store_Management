using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using DTO;
using Medical_Store_Management;
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

        public int ClientInsert(MedicalDTO newObj1)
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


        //
        public int ClientUpdate(MedicalDTO newObj2)
        {
            try
            {

                sqlConObj.ConnectionString = ConfigurationManager.ConnectionStrings["Medical"].ConnectionString;

                sqlCmdObj.CommandText = @"UpdateClient";

                sqlCmdObj.CommandType = CommandType.StoredProcedure;
                sqlCmdObj.Connection = sqlConObj;


                sqlCmdObj.Parameters.AddWithValue("@CU_Id", newObj2.id);
                sqlCmdObj.Parameters.AddWithValue("@CU_Name", newObj2.firstName);
                sqlCmdObj.Parameters.AddWithValue("@CU_Surname", newObj2.last_Name);
                sqlCmdObj.Parameters.AddWithValue("@CU_Mobile_No", newObj2.mobile);
                sqlCmdObj.Parameters.AddWithValue("@CU_Address", newObj2.address);
                sqlCmdObj.Parameters.AddWithValue("@CU_City", newObj2.city);


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

        public int ClientDelete(MedicalDTO newObj3)
        {
            try
            {

                sqlConObj.ConnectionString = ConfigurationManager.ConnectionStrings["Medical"].ConnectionString;

                sqlCmdObj.CommandText = @"DeleteClient";

                sqlCmdObj.CommandType = CommandType.StoredProcedure;
                sqlCmdObj.Connection = sqlConObj;


                sqlCmdObj.Parameters.AddWithValue("@CU_Id", newObj3.id);



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

        public List<MedicalDTO> Fetch()
        {
            try
            {
                MedicalContext contextObj = new MedicalContext();

                //LINQ
                List<ClientMst> midResult = (from prod in contextObj.ClientMsts
                                             select prod).ToList();
                List<MedicalDTO> finalResult = new List<MedicalDTO>();

                foreach (var client in midResult)
                {
                    finalResult.Add(new MedicalDTO()
                    {
                        id=client.CU_Id,
                        firstName = client.CU_Name,
                        last_Name=client.CU_Surname,
                        mobile= (float)client.CU_Mobile_No,
                        address=client.CU_Address,
                        city=client.CU_City
                        
                    });
                }
                return finalResult;


            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public List<MedicalDTO> Fetch1()
        {
            try
            {
                MedicalContext contextObj = new MedicalContext();
                var midResult = contextObj.ClientMsts.ToList();

                //LINQ
                Console.WriteLine("Enter name to find");
                String a = Console.ReadLine();

                var teenAgerStudent = (from prod in contextObj.ClientMsts
                                       where prod.CU_Name.Contains(a)
                                       select prod).ToList();

                List<MedicalDTO> finalResult = new List<MedicalDTO>();

                foreach (var client in teenAgerStudent)
                {
                    finalResult.Add(new MedicalDTO()
                    {
                        id = client.CU_Id,
                        firstName = client.CU_Name,
                        last_Name = client.CU_Surname,
                        mobile = (float)client.CU_Mobile_No,
                        address = client.CU_Address,
                        city = client.CU_City
                    });
                }
                return finalResult;


            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
