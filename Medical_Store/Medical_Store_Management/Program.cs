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

                if (result == 0)
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
                                Console.WriteLine("we are updating..........");
                                break;


                        }


                    }

                    if (selectOption == 2)
                    {
                        Console.WriteLine("1. Insert");
                        Console.WriteLine("2. UPDATE");
                        int selectClientOption = Convert.ToInt32(Console.ReadLine());

                        switch (selectClientOption)
                        {

                            case 1:

                                Console.WriteLine("Enter Company Id");
                                int inputID = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("Enter Company Name");
                                String inputcname = Console.ReadLine();
                                Console.WriteLine("Enter Name of the person");
                                String inputLastName = Console.ReadLine();
                                Console.WriteLine("Enter Address");
                                String inputAddress = Console.ReadLine();
                                Console.WriteLine("Enter Mobile Number");
                                float inputMobile = float.Parse(Console.ReadLine());

                                MedicalDTO newMedicalObj1 = new MedicalDTO();

                                newMedicalObj1.id = inputID;
                                newMedicalObj1.cname = inputcname;
                                newMedicalObj1.last_Name = inputLastName;
                                newMedicalObj1.mobile = inputMobile;
                                newMedicalObj1.address = inputAddress;

                                MedicalBL blObj1 = new MedicalBL();
                                int result1 = blObj.insertCompany(newMedicalObj1);

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
                                Console.WriteLine("we are updating this module.....");
                                Console.ReadKey();
                                break;


                        }


                    }

                    if (selectOption == 4)
                    {

                        Console.WriteLine("....updating....");

                        Console.WriteLine("Enter Client Id");
                        int inputID = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter customer Name");
                        String inputFirstName = Console.ReadLine();
                        Console.WriteLine("Enter stock Name");
                        String inputsName = Console.ReadLine();
                        Console.WriteLine("Enter price");
                        float inputprice = float.Parse(Console.ReadLine());
                        Console.WriteLine("Enter Quantity");
                        int inputquantity = int.Parse(Console.ReadLine());
                        float inputtotal = inputprice * inputquantity;
                        Console.WriteLine("Total Price\n" + inputtotal);




                        MedicalDTO newMedicalObj1 = new MedicalDTO();

                        newMedicalObj1.id = inputID;
                        newMedicalObj1.firstName = inputFirstName;
                        newMedicalObj1.sname = inputsName;
                        newMedicalObj1.price = inputprice;
                        newMedicalObj1.quantity = inputquantity;
                        newMedicalObj1.total_price = inputtotal;

                        MedicalBL blObj1 = new MedicalBL();
                        int result1 = blObj.insertSales(newMedicalObj1);

                        if (result1 == 0)
                        {
                            Console.WriteLine("success");
                        }
                        else
                        {
                            Console.WriteLine("error");
                        }
                        Console.ReadKey();


                    }
                    if (selectOption == 1)
                    {
                        Console.WriteLine("We are updating this module.......");
                        Console.ReadKey();
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
