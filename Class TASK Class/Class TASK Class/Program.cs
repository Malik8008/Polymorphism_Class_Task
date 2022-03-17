using System;

namespace Class_TASK_Class
{
    class Program
    {
        static void Main(string[] args)
        {
            //string word = Console.ReadLine();
            //Console.WriteLine(Reverse(word));

            //Names();
            Car car = new Car("BMW","F30","Orange",360);
            car.GetInfo();



            Bus bus = new Bus(25,"Ford","Transit","Yellow",180);
            bus.GetInfo();
        }

        //public static int CATCH(string word)
        //{
        //    int count = 0;
        //    foreach (char letters in word)
        //    {
        //        if (letters == 'a')
        //        {
        //            count++;
        //        }

        //    }
        //    return count;
        //}


        //public static string Reverse(string word)
        //{
        //    string newword = "";

        //    for (int i = word.Length - 1; i >= 0; i--)
        //    {
        //        newword += word[i];
        //    }
        //    return newword;
        //}

        //public static void Names()
        //{
        //    string[] names = { "maclaren", "mustang", "malik" };
        //    for (int i = 0; i < names.Length; i++)
        //    {
        //        if (names[i].Length > 5)
        //        {
        //            Console.WriteLine(names[i]);
        //        }
        //    }
        //}
    }
}
