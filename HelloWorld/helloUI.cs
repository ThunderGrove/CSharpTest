using System;
using System.Windows.Forms;

public class HelloWorld:Form{
  public static void Main(string[] args)
  {
    Application.Run(new HelloWorld());
  }
  public HelloWorld(){
    Text="Hello MONO World";
  }
}
