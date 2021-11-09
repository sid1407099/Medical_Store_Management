using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    class MedicalDTO
    {
        public String UserName { get; set; }
        public String UserPassword { get; set; }



        //client property
        public int id { get; set; }
        public String firstName { get; set; }
        public String last_Name { get; set; }
         public float mobile { get; set; }
        
        public String address { get; set; }
        public String city { get; set; }
    }
}
