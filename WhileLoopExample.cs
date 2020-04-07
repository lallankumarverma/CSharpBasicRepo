using System; 

namespace Learning 
{ 
  public class WhileLoopExample
  {
    public static void Main(string[] args)
    {  	
      int i = 0;
	  while (i < 5) 
      {
	    Console.WriteLine(i);
		i++;
	  } 
	 	
	  Console.WriteLine("\n");
		
	  i = 10;
	  do 
	  {
		Console.WriteLine(i);
		i--;
	  }
	  while (i != 0);		
    }
  }
}