using System; /* using System means that we can use classes from the System namespace. */

namespace Learning /* namespace is a used to organize your code, and it is a container for classes and other namespaces. */
{ 
  public class Program /*  class is a container for data and methods, which brings functionality to your program. Every line of code that runs in C# must be inside a class. In our example, we named the class Program. */
  {
    public static void Main(string[] args)
    {
      // Console is a class of the System namespace, which has a WriteLine() method that is used to output/print text. In our example it will output "Hello World!".  
      // WriteLine() method print text in new line 
	  // Write() method print text in same line	 
	  	
	  Console.WriteLine("Hello World!");  
	  Console.WriteLine("I will print on a new line.");
      
	  Console.Write("Hello World! ");
	  Console.Write("I will print on the same line."); 		
    }
  }
}