using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Reflection;

namespace AssemblyTwo
{

    public class getTypes
    {


        public void getTypy()
        { 
        //Type T = Type.GetType("AssemblyTwo.Hello");
            //Type TT = typeof(Hello);
            
            Hello H = new Hello();
            Type TTT= H.GetType();
            PropertyInfo[] properties = TTT.GetProperties();
            ConstructorInfo[] co = TTT.GetConstructors();
            foreach (ConstructorInfo property in co)
            {
               Console.WriteLine(property.Name);
                Console.ReadLine(); 
            }
        }

    }
    public  class Hello
    {
        protected internal  int x = 999;
        public Hello() { }
        public Hello(int x) { }
    }


    public  class Hi<T>
    {
         internal static int x = 999;

        public static bool Calculator(T value1, T value2) { return value1.Equals(value2); }

    }
    
    class Program
    {
        static void Main(string[] args)
        {

            //bool Equal = Hi<string>.Calculator("ba", "ba");
            //Console.WriteLine(Equal);
            
            Custmer x = new Custmer();
            x.Firstname = "mohammed";
            x.Lastname = "asaad";
            Console.WriteLine(x.ToString());
            Console.ReadLine();
        }
    }

    public class Custmer
    {
        public string Firstname { get; set; }
        public string Lastname  { get; set; }

        public override string ToString()
        {
            return Firstname + Lastname;
        }

    }
}
