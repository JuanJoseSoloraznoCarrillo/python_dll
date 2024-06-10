using System;
using libApp; //libApp namespace using as a library.

//Main. Program used as a Main file executable.
public class Program{
  // static void Main is the executable default program in a csharp program.
  public static void Main(string[] args){
    // args: the argument given through command line.
    MainJClass application = new MainJClass(); // TestApp instantiation.
    // Checking if an argument has been given.
    var input = 0;
    var mult = 0.0f;
    if(args.Length == 1){
      System.Console.WriteLine("Getting value through command line... ");
      string theString = string.Join(" ",args);
      // managing the data type given.
      try
      {
        input = Int32.Parse(theString);
      }
      catch (System.Exception)
      {
        System.Console.WriteLine("[!] >> Wrong type as argument");
      }
      application.SetValue(input); // using SetValue mehtod.
    }
    else if (args.Length == 2)
    {
      try
      {   
          string theString = string.Join(" ",args[0]);
          input = Int32.Parse(theString);
          mult = float.Parse(args[1]);
          application.SetValue(input); // using SetValue mehtod.
      }
      catch (System.Exception)
      {
        System.Console.WriteLine("[!] >> Wrong type as argument 2 {0} | {1}",mult,input);
      }
    }
    else{ // default value.

      application.SetValue(717); // using SetValue mehtod.
    }
    var myValue = application.GetValue(); // using GetValue method.
    var output = application.Multiply(mult);
    System.Console.WriteLine("The value set: {0}",myValue);
    System.Console.WriteLine($"The property: {application.TheValue}");
    System.Console.WriteLine("The multiplication result is: {0}",output);
  }
}
