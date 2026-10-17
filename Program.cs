using System;
class Program
{
    static void Main(string[] args)
    {
        int a, b;   // declare the data type
        
        try
        {
            Console.Write("Enter number1 : "); a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter number2 : "); b = Convert.ToInt32(Console.ReadLine());
            int result = a / b;

            Console.WriteLine("Resulte : " + result);
        }
        catch(FormatException e)
        {
            Console.WriteLine("Error : Invalid input, Please enter intager numbers " );
        }
        catch(DivideByZeroException e)
        {
            Console.WriteLine("Error : "+e.Message);
        }catch(Exception e)
        {
             Console.WriteLine("Error Unexspected : " + e.Message);
        }
        finally
        {

             Console.WriteLine("Program executed successfully");   
        }
    }
}
