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
                    if (selectOption == 3)
                    {
                        Console.WriteLine("1. Insert");
                        Console.WriteLine("2. UPDATE");
                        Console.WriteLine("3. DELETE");
                        Console.WriteLine("4. Retrieve");
                        Console.WriteLine("5. Search by name");
                        int selectClientOption = Convert.ToInt32(Console.ReadLine());

                        switch (selectClientOption)
                        {

                            case 1:

                                Console.WriteLine("Enter Client Id");
                                int inputID = Convert.ToInt32(Console.ReadLine());
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

                                newMedicalObj1.id = inputID;
                                newMedicalObj1.firstName = inputFirstName;
                                newMedicalObj1.last_Name = inputLastName;
                                newMedicalObj1.mobile = inputMobile;
                                newMedicalObj1.address = inputAddress;
                                newMedicalObj1.city = inputCity;

                                MedicalBL blObj1 = new MedicalBL();
                                int result1 = blObj.insertClient(newMedicalObj1);

                                if (result1 == 0)
                                {
                                    Console.WriteLine("success");
                                }
                                else
                                {
                                    Console.WriteLine("error");
                                }
                                Console.ReadKey();
                                break;

                            case 2:
                                Console.WriteLine("Enter Client Id");
                                int updateID = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("Enter First Name");
                                String updateFirstName = Console.ReadLine();
                                Console.WriteLine("Enter Last Name");
                                String updateLastName = Console.ReadLine();
                                Console.WriteLine("Enter Mobile Number");
                                float updateMobile = float.Parse(Console.ReadLine());
                                Console.WriteLine("Enter Address");
                                String updateAddress = Console.ReadLine();
                                Console.WriteLine("Enter City");
                                String updateCity = Console.ReadLine();

                                MedicalDTO newMedicalObj2 = new MedicalDTO();

                                newMedicalObj2.id = updateID;
                                newMedicalObj2.firstName = updateFirstName;
                                newMedicalObj2.last_Name = updateLastName;
                                newMedicalObj2.mobile = updateMobile;
                                newMedicalObj2.address = updateAddress;
                                newMedicalObj2.city = updateCity;

                                MedicalBL blObj2 = new MedicalBL();
                                int result2 = blObj.updateClient(newMedicalObj2);

                                if (result2 == 0)
                                {
                                    Console.WriteLine("success");
                                }
                                else
                                {
                                    Console.WriteLine("error");
                                }
                                Console.ReadKey();
                                break;
                            case 3:
                                Console.WriteLine("Enter Client Id");
                                int deleteID = Convert.ToInt32(Console.ReadLine());

                                MedicalDTO newMedicalObj3 = new MedicalDTO();

                                newMedicalObj3.id = deleteID;



                                MedicalBL blObj3 = new MedicalBL();
                                int result3 = blObj.deleteClient(newMedicalObj3);

                                if (result3 == 0)
                                {
                                    Console.WriteLine("success");
                                }
                                else
                                {
                                    Console.WriteLine("error");
                                }
                                Console.ReadKey();
                                break;
                            case 4:
                                MedicalBL blObj4 = new MedicalBL();
                                List<MedicalDTO> lstFinalResult = blObj.GetDetails();

                               foreach (var client in lstFinalResult)
                                {
                                    
                                    Console.WriteLine(client.id + " " + client.firstName+" "+ client.last_Name + " " + client.mobile + " " + client.address + " " + client.city);
                                    //Console.WriteLine(prod.last_Name);
                                }
                                Console.ReadLine();
                                break;
                            case 5:
                                MedicalBL blObj5 = new MedicalBL();
                                List<MedicalDTO> lstFinalResult1 = blObj.GetDetails1();

                                foreach (var  client in lstFinalResult1)
                                {
                                    Console.WriteLine(client.firstName+" "+client.last_Name + " " + client.mobile + " " + client.address + " " + client.city);
                                }
                                Console.ReadLine();
                                break;

                        }


                    }


                }
                else
                {
                    Console.WriteLine("Login not successfull");
                    Console.ReadKey();
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
