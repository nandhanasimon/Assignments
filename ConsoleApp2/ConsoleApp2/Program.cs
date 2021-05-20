using System;

namespace ConsoleApp2
{
    public class adult

    {
        string firstname;
        string lastname;

     public virtual void FullName()
        {
            Console.WriteLine("Firstname,LastName" + firstname + lastname);
        }
    }


    public class child :adult 

    {

        string firstname;
        string lastname;

        public override void FullName()
        {
            Console.WriteLine("Firstname,LastName" + firstname + lastname);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            child[] mychild = new adult[2];

        }
    }

   
 
}
