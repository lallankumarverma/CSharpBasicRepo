using System; 

namespace Learning 
{  	
  public class PropertyExample
  {
	public string color;  
	  
	public string getSetPropertyExample1
	{
      get; set;
	}	
	  
	public string getSetPropertyExample2
	{
      get {return color;}
	  set {color = value;}
	}	  
	  
    public static void Main(string[] args)
    { 
	  PropertyExample propertyObj = new PropertyExample();
	  propertyObj.getSetPropertyExample1 = "Red";	
	  propertyObj.getSetPropertyExample2 = "Blue";	  
	  	 
      Console.WriteLine(propertyObj.getSetPropertyExample1); 
	  Console.WriteLine(propertyObj.getSetPropertyExample2);  
		
    }
  }
}