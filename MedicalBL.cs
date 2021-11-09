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

        public string insertClient(MedicalDTO newObj1)
        {
            try
            {
                MedicalDAL dalObj1 = new MedicalDAL();
                String result1 = dalObj1.Client(newObj1);
                return result1;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
