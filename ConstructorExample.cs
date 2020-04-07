using System; 

namespace Learning 
{  	
  public class ConstructorExample
  {
	public string color;  
	  
	public ConstructorExample()
	{
      color = "Red";
	}
	  
	public ConstructorExample(string value1) // Constructor Overloading
	{
      color = value1;
	}	  
	  
    public static void Main(string[] args)
    { 
	  ConstructorExample demoObj1 = new ConstructorExample(); // Constructor call at this time means object creation
      Console.WriteLine(demoObj1.color);  
		
	  ConstructorExample demoObj2 = new ConstructorExample("Blue");
      Console.WriteLine(demoObj2.color);		
    }
  }
}