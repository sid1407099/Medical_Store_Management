using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BL
{
    class MedicalBL
    {
        public int check(MedicalDTO newObj)
        {
            try
            {
                MedicalDAL dalObj = new MedicalDAL();
                int result = dalObj.checkLogin(newObj);

                return result;
            }
            catch (Exception e)
            {
                throw e;

            }
        }

        public int insertClient(MedicalDTO newObj1)
        {
            try
            {
                MedicalDAL dalObj1 = new MedicalDAL();
                int result1 = dalObj1.ClientInsert(newObj1);
                return result1;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public int updateClient(MedicalDTO newObj2)
        {
            try
            {
                MedicalDAL dalObj2 = new MedicalDAL();
                int result2 = dalObj2.ClientUpdate(newObj2);
                return result2;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public int deleteClient(MedicalDTO newObj3)
        {
            try
            {
                MedicalDAL dalObj3 = new MedicalDAL();
                int result3 = dalObj3.ClientDelete(newObj3);
                return result3;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        //clientRetrieve

        public List<MedicalDTO> GetDetails()
        {
            try
            {
                MedicalDAL dalObj = new MedicalDAL();

                List<MedicalDTO> result = dalObj.Fetch();
                return result;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        //clientSearch
        public List<MedicalDTO> GetDetails1()
        {
            try
            {
                MedicalDAL dalObj = new MedicalDAL();

                List<MedicalDTO> result = dalObj.Fetch1();
                return result;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
