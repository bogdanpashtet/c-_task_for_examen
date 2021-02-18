using System;
using System.Runtime.InteropServices;

namespace var_1
{
    public class human
    {
        #region aaaa

        private  string name;
        public string Name
        {
            set { name = value; }
            get { return name; }
        }

        private int age;
        public int Age
        {
            set { age = value; }
            get { return age; }
        }

        private int height;
        public int Height
        {
            set { height = value; }
            get { return height; }
        }
        private int weight;
        public int Weight
        {
            set { weight = value; }
            get { return weight; }
        }

        #endregion

        #region constructors and destructors
        public human()
        {
            Name = "Bob";
            Age = 19;
            Height = 175;
            Weight = 70;
        }

        public human(int a, int h, int w, string n)
        {
            Name = n;
            Age = a;
            Height = h;
            Weight = w;
        }
        ~human()
        {
            Age = 0;
            Height = 0;
            Weight = 0;
        }

        #endregion

        public void print()
        {
            Console.WriteLine("\n------------------------\n");
            Console.WriteLine("\nAge: ");
            Console.WriteLine(Age);
            Console.WriteLine("\nHeight: ");
            Console.WriteLine(Height);
            Console.WriteLine("\nWeight");
            Console.WriteLine(Weight);
            Console.WriteLine("\n------------------------\n");
        }
       
    }

    public class adult : human
    {

        public adult()
        {
            Name = "John";
            Age = 20;
            Height = 192;
            Weight = 87;
            Passport = "22 33 445566";
        }


        private string passport;
        public string Passport
        {
            set { passport = value; }
            get { return passport; }
        }

        public  void print() 
        {
            Console.WriteLine("\n------------------------\n");
            Console.WriteLine("\nAge: ");
            Console.WriteLine(Age);
            Console.WriteLine("\nHeight: ");
            Console.WriteLine(Height);
            Console.WriteLine("\nWeight");
            Console.WriteLine(Weight);
            Console.WriteLine("\nPassport: ");
            Console.WriteLine(Passport);
            Console.WriteLine("\n------------------------\n");
        }         

    }


}