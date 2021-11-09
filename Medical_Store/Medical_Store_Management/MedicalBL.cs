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
                int result1 = dalObj1.Client(newObj1);
                return result1;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
            public int insertSales(MedicalDTO newObj1)
            {
                try
                {
                    MedicalDAL dalObj1 = new MedicalDAL();
                    int result1 = dalObj1.Sales(newObj1);
                    return result1;
                }
                catch (Exception e)
                {
                    throw e;
                }
            }
        public int insertCompany(MedicalDTO newObj1)
        {
            try
            {
                MedicalDAL dalObj1 = new MedicalDAL();
                int result1 = dalObj1.Company(newObj1);
                return result1;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
