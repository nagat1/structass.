using static System.Runtime.InteropServices.JavaScript.JSType;
using System.ComponentModel;
using System.Drawing;
using System.Diagnostics.Metrics;
using System.Xml.Linq;
using System;
using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.X509Certificates;

namespace structass_
{
    internal class Program
    {
        static void Main(string[] args)
        {


            #region 1
            ////1.Define a struct "Person" with properties "Name" and "Age".
            ////Create an array of three "Person" objects and populate it with data.
            ////Then, write a C# program to display the details of all the persons in the array.

            //Person[] people = new Person[3];
            //people[0] = new Person
            //{
            //Name = "ahmed",
            //Age = 30

            //};
            //people[1] = new Person
            //{
            //Name = "ali",
            //Age = 21
            //};
            //people[2]= new Person()
            //{
            //    Name = "alyaa",
            //    Age = 28
            //};
       
       
            //for (int i = 0; i < 3; i++)
            //{
            //    Console.WriteLine($"person{i} name is {people[i].Name}, age {people[i].Age}");
            //}

            #endregion

            #region 2

            //2.Create a struct called "Point" to represent a 2D point with properties "X" and "Y".
            //Write a C# program that takes two points as input from the user
            //and calculates the distance between them.


            //Point point1 = new Point();
            //Point point2 = new Point();
            //Console.WriteLine("please enter int point (x1,y1)");
            //point1.X = int.Parse(Console.ReadLine());
            //point1.Y = int.Parse(Console.ReadLine());
            //Console.WriteLine("please enter int point (x2,y2)");

            //point2.X = int.Parse(Console.ReadLine());
            //point2.Y = int.Parse(Console.ReadLine());
            //Point d = new Point();
            //double result = d.distance(point1.X, point1.Y, point2.X, point2.Y);
            //Console.WriteLine($"the distance between them is =>{result}");
            #endregion

            #region 3

            //3.Create a struct called "Person" with properties "Name" and "Age".
            //Write a C# program that takes details of 3 persons as input from the user and
            //displays the name and age of the oldest person.
            //   Console.WriteLine("enter names and ages of three person");
            //   Person[] people = new Person[3];

            //   for (int i = 0; i < people.Length; i++) {
            //       Console.WriteLine($"enter name of  {i + 1} person");
            //       people[i].Name = Console.ReadLine();
            //       Console.WriteLine($"enter age of {i+1} person");
            //       people[i].Age = int.Parse(Console.ReadLine());

            //   }
            //   Person oldestPerson = people[0];
            //   oldest();

            //       void oldest()
            //   {

            //   for (int i = 1; i < people.Length; i++)  
            //       if (people[i].Age > oldestPerson.Age)
            //           oldestPerson = people[i];
            //Console.WriteLine($"The oldest person is {oldestPerson.Name}," + $" and his/her age is {oldestPerson.Age}.");
            //   }

            #endregion

        }
        }
    }

