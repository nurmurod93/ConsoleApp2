

//using System;
//namespace function3
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            int a = 8, b = 5;

//            swapp(ref a, ref b);

//            Console.WriteLine(a + "  " + b);
//            Console.ReadKey();
//        }
//        static void swapp(ref int a, ref int b)
//        {
//            int k = a;
//            a = b;
//            b = k;
//        }
//    }
//}

//using System;
//namespace function4
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            float a = 5;
//            kvadrad(a, out float yuza1, out float peremetr1, out float radius1);

//            Console.WriteLine(yuza1 + "  " + peremetr1 + " " + radius1);
//            Console.ReadKey();
//        }
//        static void kvadrad(float a, out float yuza, out float peremetr, out float radius)
//        {
//            yuza = a * a;
//            peremetr = 4 * a;
//            radius = a / 2;
//        }
//    }
//}

using ConsoleApp2;

namespace Readonly1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            User u = new User("lyushan", "china", 23);
            Console.WriteLine(u.name);

            Company company = new Company("Kimchin", 2000);
            company.Name = "Junsang";
            Console.WriteLine(company.Salary);
            //company.Name = "Abduvali";
            //company.Salary = 21161.5166135m;

        }
    }
}