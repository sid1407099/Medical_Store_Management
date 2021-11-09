using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    class MedicalDTO
    {
        public String UserName{get;set;}
        public String UserPassword { get; set; }



        //client property
public int CU_Id { get; set; }
public String CU_Name { get; set; }
public String CU_Surname { get; set; }
public float CU_Mobile_No { get; set; }
public String CU_Address { get; set; }
public String CU_City { get; set; }
    }
}
