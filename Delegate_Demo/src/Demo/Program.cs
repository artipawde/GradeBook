using System;

namespace Demo
{
    class Program
    {

        public delegate void addNum(int a, int b);
        public delegate void subNum(int a , int b);
        public delegate void mulNum(int a, int b);
        public delegate void divNum(int a, int b);
        static void Main(string[] args)
        {
            Console.WriteLine("Which Operation Would you like to Perform : 1. Addtion 2. Subtraction 3.multiplication 4.division");
            int val = Int32.Parse(Console.ReadLine());
           // Console.WriteLine($"sel : {sel}");
            addNum delegateObj1 = new addNum(sum);
            subNum delegateObj2 = new subNum(sub);
            mulNum delegateObj3 = new mulNum(mul);
            divNum delegateObj4 = new divNum(div);

            Console.WriteLine("Enter 1st Number :");
            int num1 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Enter 2st Number :");
            int num2 = Int32.Parse(Console.ReadLine());
        

            CalculatorWithDelegate(val, num1, num2);

           // delegateObj1(100,50);
           // delegateObj2(100,50);
        }
        public static void CalculatorWithDelegate(int val, int n1, int n2)
        {
            switch(val)
            {
                case 1:     
                sum(n1,n2);
                break;
                
                case 2:
                sub(n1,n2);
                break;
 
                case 3:
                mul(n1,n2);
                break;

                case 4:
                div(n1,n2);
                break;
            }
        }
        
        public static void sum(int a, int b)
        {
            Console.WriteLine($"Addition of {a} + {b} = {a + b} ");
        }
        public static void sub(int a, int b)
        {
            Console.WriteLine($"Substraction of {a} - {b} = {a - b} ");
        }
        public static void mul(int a, int b)
        {
            Console.WriteLine($"Multiplication of {a} * {b} = {a * b} ");
        }
        public static void div(int a, int b)
        {
            try{                                    
                Console.WriteLine($"Division of {a} / {b} = {a / b} ");
               }
            catch(DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
