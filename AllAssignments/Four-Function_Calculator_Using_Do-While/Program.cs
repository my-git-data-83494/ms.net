using System.Xml.Serialization;

namespace Four_Function_Calculator_Using_Do_While
{
    internal class Program
    {
        public class Function
        {
            public int add(int x, int y)
            {
                return x + y;
            }

            public int sub(int x, int y)
            {
                return x - y;
            }

            public int mul(int x, int y)
            {
                return x * y;
            }

            public int div(int x, int y)
            {
                return x / y;
            }
        }

        static void Main(string[] args)
        {
            do
            {
                Function f = new Function();
                Console.WriteLine("Enter number 1 value");
                int num1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter number 2 value");
                int num2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("1:Addition 2:Substraction 3:Multiplication 4:Division");
                int choice = Convert.ToInt32(Console.ReadLine());
                int result = 0;

                switch (choice)
                {
                    case 1:
                        result = f.add(num1, num2);
                        break;
                    case 2:
                        result = f.sub(num1, num2); break;
                    case 3:
                        result = f.mul(num1, num2); break;
                    case 4:
                        result = f.div(num1, num2); break;
                    default:
                        Console.WriteLine("Wrong Input"); break;
                }
                Console.WriteLine(result);
                Console.WriteLine("Do you want to continue y/n");
                string value = Console.ReadLine();
                if (value == "n")
                {
                    break;
                }
            } while (true);
            Console.WriteLine("Hit any key to close");
            Console.ReadLine();
        }
    }
}

