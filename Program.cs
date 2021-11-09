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
                    Console.WriteLine("Welcome " + input1);
                    //
                    Console.WriteLine("Please select operation to perform");
                    Console.WriteLine("1. Stock");
                    Console.WriteLine("2. Company");
                    Console.WriteLine("3. Client");
                    Console.WriteLine("4. Sell Item");

                    int selectOption = Convert.ToInt32(Console.ReadLine());


                    switch (selectOption) {
                        case 3:
                            Console.WriteLine("Enter Client Id");
                            int inputID = Convert.ToInt32( Console.ReadLine());
                            Console.WriteLine("Enter First Name");
                            String inputFirstName = Console.ReadLine();
                            Console.WriteLine("Enter Last Name");
                            String inputLastName = Console.ReadLine();
                            Console.WriteLine("Enter Mobile Number");
                            float inputMobile = float.Parse(Console.ReadLine());
                            Console.WriteLine("Enter Address");
                            String inputAddress = Console.ReadLine();
                            Console.WriteLine("Enter City");
                            String inputCity = Console.ReadLine();

                            MedicalDTO newMedicalObj1 = new MedicalDTO();

                            newMedicalObj1.CU_Id = inputID;
                            newMedicalObj1.CU_Name = inputFirstName;
                            newMedicalObj1.CU_Surname = inputLastName;
                            newMedicalObj1.CU_Mobile_No = inputMobile;
                            newMedicalObj1.CU_Address = inputAddress;
                            newMedicalObj1.CU_City = inputCity;

                            MedicalBL blObj1 = new MedicalBL();
                            String result1 = blObj.insertClient(newMedicalObj);
                            Console.ReadKey();
                            break;

                            
                    }
                    
                
                }
                else
                {
                    Console.WriteLine("Login not successfull");
                }
                
            }
            catch (Exception e)
            {
                
                Console.WriteLine("Something went wrong");
                Console.WriteLine(e.Message);
                
                Console.ReadKey();
            }

        }
    }
}
