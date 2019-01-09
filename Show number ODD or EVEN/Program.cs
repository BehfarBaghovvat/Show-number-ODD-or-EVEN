
namespace Show_number_ODD_or_EVEN
{
    class Program
    {
        static void Main(string[] args)
        {

            int Number;

            System.Console.WriteLine("          ======================SHOW NUMBER OOD OR EVEN======================");

            System.Console.WriteLine();

            System.Console.Write
                ("Please enter number: ");

            Number = System.Convert.ToInt32
                (System.Console.ReadLine());

            System.Console.WriteLine();

            int Result = Number % 2;

            if (Result==0)
            {
                System.Console.Write
                    ("The number {0} is EVEN",Number);

                System.Console.WriteLine();
                System.Console.WriteLine();
            }

            else
            {
                System.Console.Write
                    ("The number {0} is ODD", Number);

                System.Console.WriteLine();
                System.Console.WriteLine();
            }  
            
            
            

            System.Console.Write("Press [ENTER] To Exit...");
            System.Console.ReadLine();


        }
    }
}
