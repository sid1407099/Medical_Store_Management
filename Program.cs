using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using BL;

namespace Medical_Store_Management
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter Username");
                String input1 = Console.ReadLine();

                Console.WriteLine("Enter Password");
                String input2 = Console.ReadLine();

                MedicalDTO newMedicalObj = new MedicalDTO();

                newMedicalObj.UserName = input1;
                newMedicalObj.UserPassword = input2;

                MedicalBL blObj = new MedicalBL();
                int result = blObj.check(newMedicalObj);

                if (result == 1)
                {
                    Console.WriteLine("Login successfull");
                }
                else
                {
                    Console.WriteLine("Login not successfull");
                }
                Console.ReadKey();
            }
            catch (Exception e)
            {
                Console.WriteLine("Something went wrong");
                Console.WriteLine(e.Message);
            }

        }
    }
}
