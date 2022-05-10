using System;
using Midterm_3;

namespace CS162NMidterm3
{
    class Program
    {
        static void Main(string[] args)
        {
            TestingDefaultConstructor();
            TestingConstructor();
            TestingGetters();
            TestingSetters();
        }
        static void TestingDefaultConstructor()
        {
            Professor p1 = new Professor();

            Console.WriteLine("Testing default constructor");

            Console.WriteLine("Expecting Jane Doe CS L00000000");
            Console.WriteLine(p1.ToString());

            Console.WriteLine();
        }

        static void TestingConstructor()
        {
            Professor p1 = new Professor("Mari", "Good", "CS", "L00000001");
            Professor p2 = new Professor("Susie", "Coursar", "HEALTH", "L00000002");

            Console.WriteLine("Testing Constructors");

            Console.WriteLine("Expecting Mari Good CS L00000001");
            Console.WriteLine(p1.ToString());
            Console.WriteLine();

            Console.WriteLine("Expecting Susie Coursar HEALTH L00000002");
            Console.WriteLine(p2.ToString());

            Console.WriteLine();

        }

        static void TestingGetters()
        {
            Professor p1 = new Professor("Mari", "Good", "CS", "L00000001");

            Console.WriteLine("Testing Getters");

            Console.WriteLine("Expecting Mari");
            Console.WriteLine(p1.FirstName);

            Console.WriteLine("Expecting Good");
            Console.WriteLine(p1.LastName);

            Console.WriteLine("Expecting CS");
            Console.WriteLine(p1.Department);

            Console.WriteLine("Expecting L00000001");
            Console.WriteLine(p1.LNumber);

            Console.WriteLine();
        }

        static void TestingSetters()
        {
            Professor p1 = new Professor("Mari", "Good", "CS", "L00000001");

            Console.WriteLine("Testing Setters");
            p1.FirstName = "Susie";
            p1.LastName = "Coursar";
            p1.Department = "HEALTH";
            p1.LNumber = "L00000002";

            Console.WriteLine("Expecting Susie Coursar HEALTH L00000002");
            Console.WriteLine(p1.ToString());
            Console.WriteLine();

            Console.WriteLine("Checking exceptions");
            Console.WriteLine("Expecting Argument Exception for Department");
            try
            {
                p1.Department = "Test";
                Console.WriteLine("Failure");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine("Expecting Argument Exception for LNumber");
            try
            {
                p1.LNumber = "Test";
                Console.WriteLine("Failure");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine("Expecting Argument Exception for LNumber");
            try
            {
                p1.LNumber = "L0000001";
                Console.WriteLine("Failure");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}