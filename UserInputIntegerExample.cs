using System; 

namespace Learning 
{ 
  public class UserInputIntegerExample 
  {
    public static void Main(string[] args)
    {  	
	 // The Console.ReadLine() method returns a string. Therefore, you cannot get information from another data type, such as int.	
	 // So we need to typecast it
	 Console.WriteLine("Enter your age:");
	 int age = Convert.ToInt32(Console.ReadLine());
	 Console.WriteLine("Your age is: " + age); 
    }
  }
}