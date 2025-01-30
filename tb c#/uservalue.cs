using System;

class forwhile
{
	public static void Main()
	{
		int a;
		int b;
		Console.WriteLine("enter value:");
		string number =Console.ReadLine(); 
		Int32.TryParse(number, out a);
		
		Console.WriteLine("::output::");
		for(b=0;b<=a;b++)
		{
			Console.WriteLine(+b);
		}
		b=a;
		Console.WriteLine("::reverse output::");
		while(b>=0)
		{
			
			Console.WriteLine(b);
			b--;
		}
	}
}