﻿namespace Property
{
    class Program
    {
        static void Main(string[] args)
        {

            Person person = new Person
            {
                Age = 39,
                FullName = "James T Cerk",
                Salary = 10000,
            };

            person.ShowInfo();

            Person p1 = new Person
            {

                Age = 40,

                FullName ="Jenifer Daison",

                Salary=7800,
            };            

            p1.ShowInfo();







            System.Console.WriteLine();

            System.Console.ReadLine();

        }   
        
    }
}
