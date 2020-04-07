using System; 

namespace Learning 
{ 
  public class VaribalesExample 
  {
    public static void Main(string[] args)
    {  	
	  int myNum1 = 5, myNum2 = 6, myNum3 = 7;
      double myDoubleNum = 5.99D;
	  char myLetter = 'D';
	  bool myBool = true;
	  string myText = "Hello";		
		
      Console.WriteLine("Integer Values " + myNum1 + " , " + myNum2 + " , " + myNum3); 
	  Console.WriteLine("Concatenation " + myNum1+myNum2+myNum3);	
	  Console.Write("Addition ");
	  Console.WriteLine(myNum1+myNum2+myNum3);	
	  Console.WriteLine("Double Value " + myDoubleNum);
	  Console.WriteLine("Char Value " + myLetter);
	  Console.WriteLine("Boolean Value " + myBool);
	  Console.WriteLine("String Value " + myText);		
    }
  }
}