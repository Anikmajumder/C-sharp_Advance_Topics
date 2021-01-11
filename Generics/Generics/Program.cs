using System;  
namespace CSharpProgram
{
    class GenericClass<T>
    {
        public GenericClass(T msg)
        {
            Console.WriteLine(msg);
        }


       



    }



    class AnotherGenericClass
    {
        public void Show<T>(T sms)
        {
            Console.WriteLine(sms);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            GenericClass<string> gen = new GenericClass<string>("This is generic class");
            GenericClass<int> genI = new GenericClass<int>(101);
            GenericClass<char> getCh = new GenericClass<char>('I');


            AnotherGenericClass genC = new AnotherGenericClass();
            genC.Show("This is generic method");
            genC.Show(101);
            genC.Show('I');
        }
    }
}
