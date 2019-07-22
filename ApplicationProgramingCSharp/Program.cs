using System;

namespace ApplicationProgramingCSharp
{
//    class Program
//    {
//        private static string _name = "Marry";
//        private static bool _gender = Convert.ToBoolean("Male");
//        private int _age = Convert.ToInt32("25");
//        private int _ageMarriage = Convert.ToInt32("35");
//
//        public static string Name
//        {
//            get { return _name; }
//            set { _name = value; }
//        }
//
//        public static bool Gender
//        {
//            get { return _gender; }
//            set { _gender = value; }
//        }
//
//        public static int Age
//        {
//            get { return Age; }
//            set { Age = value; }
//        }
//
//        public override string ToString()
//        {
//            Console.WriteLine("Simple Properties Demo");
//            return "Person details: Name =  + @Name , Gender =  + @Gender + , Age = + @Age";
//
//        }
//
//        static void Main(string[] args)
//        {
//            People people = new People();
//            
//            Console.WriteLine("Simple Properties Demo");
//            Console.WriteLine($"Person details: Name = {@Name}" + " , Gender = " + @Gender + " , Age = " + @Age);
//
//            Console.WriteLine("Person details (apter incrementing age) :  Name = " + @Name + " , Gender = " + @Gender);
//        }
//    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Simple Properties Demo");
            var people = new People("Marry", true, 25);
            if (people.Gender.Equals(true))
            {
                Console.WriteLine("Persion details: " + "Name = {0}, Gender = Male, Age = {2}", people.Name,
                    people.Gender, people.Age);
            }

            people.Age += 10;
            Console.WriteLine("Person details (apter incrementing age): " + "Name = {0}, Gender = Male, Age = {2}",
                people.Name, people.Gender, people.Age);
        }
    }
}