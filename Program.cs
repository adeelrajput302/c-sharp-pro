using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Linq;
using static emploess_cured.Program;
namespace emploess_cured
{
    internal class Program
    {
        public class Visitor
        {
            // properties defined
            public int Id { get; set; }
            public string Name { get; set; }
            public int PhoneNumber { get; set; }
            public int FlatNumber { get; set; }

        }

        static void Main(string[] args)
        {
            Console.WriteLine(" ------------- WELCOME TO SECURITY MANAGEMENT SYSTEM ------------- ");
            Console.WriteLine("");

            // create a list for hold a custam ( Data type )
            List<Visitor> Visit = new List<Visitor>();

            // Get the input

            int Choice;

            do
            {
                Console.WriteLine("1. Add Delvery");
                Console.WriteLine("2. Show All Rider List");
                Console.WriteLine("3. Remove Complet Rider List");
                Console.WriteLine("4. Find The Rider By Id ");
                Console.WriteLine("5. Update Rider By Id / Data");
                Console.WriteLine("6. Exit");

                Console.WriteLine("");

                Console.Write("Enter your choice: ");
                Choice = Convert.ToInt32(Console.ReadLine());

                switch (Choice)
                {
                    case 1:

                        for (int i = 0; i < Choice; i++)
                        {
                            Console.WriteLine("Enter Your ID: ");
                           int id = Convert.ToInt32(Console.ReadLine());
                            {
                                Console.WriteLine("Ok YOUR ID IS SAVE: ");
                            }

                            Console.WriteLine("Enter Your Name: ");
                            string Name = Console.ReadLine();
                            {
                                Console.WriteLine("Ok YOUR NAME IS SAVE: ");
                            }

                            Console.WriteLine("Enter The Flat Number For Delivery: ");
                            int FlatNumber = Convert.ToInt32(Console.ReadLine());
                            {
                                Console.WriteLine("Ok YOUR FLAT NUMBER IS SAVE: ");
                            }

                            Console.WriteLine("Enter Your  PhoneNumber: ");
                            int PhoneNumber = Convert.ToInt32(Console.ReadLine());
                            {
                                Console.WriteLine("Ok YOUR PHONE NUMBER IS SAVE: ");
                            }

                            Console.WriteLine("");

                            Console.WriteLine(" Thanks For Your Time ");

                            Console.WriteLine("");


                            // create a object 
                            Visitor obj = new Visitor
                            {
                                Id = id,
                                Name = Name,
                                PhoneNumber = PhoneNumber,
                                FlatNumber = FlatNumber
                            };

                            Visit.Add(obj);
                        }
                        break;

                    case 2:

                        foreach (var visitor in Visit)
                        {
                            Console.WriteLine(" Wait For Loding...... ");
                            Thread.Sleep(500);
                            Console.WriteLine($"Id: {visitor.Id}, Name: {visitor.Name}, Phone: {visitor.PhoneNumber}, Flat: {visitor.FlatNumber}");
                        }
                        break;

                    case 3:

                        if (Visit.Count == 0)
                        {
                            Console.WriteLine(" Wait For Loding...... ");
                            Thread.Sleep(600);
                            Console.WriteLine($"The List Of Rider Are Already Empty");
                        }
                        else
                        {
                            Visit.Clear();
                            Console.WriteLine(" Wait For Loding...... ");
                            Thread.Sleep(500);
                            Console.WriteLine("your lIST IS Empty SuccessFuly: ");
                        }

                        break;

                        case 4:

                        Console.WriteLine("Enter The Id Number For Check The Data: ");
                        int FindId = Convert.ToInt32(Console.ReadLine());
                        
                           Visitor FindById = Visit.Find(Visitor => Visitor.Id == FindId);
                        

                        // visitor is a data type of list
                        // findbyid is a name for calling this methed
                        // Visit.Find   Visit is a list name and .find is a methed
                        
                        if(FindById != null)
                        {

                            Console.WriteLine(" Wait For Loding...... ");
                            Thread.Sleep(500);
                            Console.WriteLine($"Found The Rider Data:- Id: {FindById.Id}, Name: {FindById.Name}, Phone: {FindById.PhoneNumber}, Flat: {FindById.FlatNumber}");
                       

                        }

                        else
                        {
                            Console.WriteLine(" Wait For Loding...... ");
                            Thread.Sleep(400);
                            Console.WriteLine("Not Match The Id / NO Have Data!");
                        }
                        break ;

                        case 5:

                        Console.WriteLine("Enter The Id For Updata The Data: ");
                        int Updata = Convert.ToInt32(Console.ReadLine());

                        Visitor UpdataById = Visit.Find(Visitor => Visitor.Id == Updata);

                        if(UpdataById != null)
                        {
                            Console.WriteLine("Yes Id Found: ");
 
                            // up data the name 
                            Console.WriteLine("Enter The New Name: ");
                            string NewName = Console.ReadLine();
                            UpdataById.Name = NewName;
                            Console.WriteLine($"{NewName} Is UpData Empty SuccessFuly");

                            // updata the phonenumber
                            Console.WriteLine("Enter The New PhoneNumber: ");
                            int NewPhoneNumber = Convert.ToInt32(Console.ReadLine());
                            UpdataById.PhoneNumber = NewPhoneNumber;
                            Console.WriteLine($"{NewPhoneNumber} Is UpData Empty SuccessFuly");

                            // updata the flatnumber
                            Console.WriteLine("Enter The New FlatNumber: ");
                            int NewFlatNumber = Convert.ToInt32(Console.ReadLine());
                            UpdataById.FlatNumber = NewFlatNumber;
                            Console.WriteLine($"{NewFlatNumber} Is UpData Empty SuccessFuly");

                            Thread.Sleep(500);
                            Console.WriteLine("Complet Data Is Updata  SuccessFuly: ");

                        }
                        break ;

                        case 6:

                        Console.WriteLine("Eixt The Program:");
                        break ;

                }

            }

            while (Choice != 6);

        }
    }
}  