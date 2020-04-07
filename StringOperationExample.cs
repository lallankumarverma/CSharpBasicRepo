using System; 

namespace Learning 
{ 
  public class StringOperationExample
  {
    public static void Main(string[] args)
    {  	
      string greeting = "Hello World!";
	  Console.WriteLine(greeting);	
	  Console.WriteLine(greeting.Length);
	  Console.WriteLine(greeting.ToLower());	
	  Console.WriteLine(greeting.ToUpper());
	  Console.WriteLine(greeting.IndexOf("o"));
	  Console.WriteLine(greeting[6]);	
	  Console.WriteLine(greeting.Substring(6));	
		
	  string text = "Hello 'India' ";
	  Console.WriteLine(text);
	 
	  text = "Hello \"India\" ";
	  Console.WriteLine(text);	
		
	  text = "Hello India\\Hindustan ";
	  Console.WriteLine(text);	
	
    }
  }
}