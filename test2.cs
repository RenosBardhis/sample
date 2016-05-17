/*
 * Created by SharpDevelop.
 * User: Renos
 * Date: 10/1/2016
 * Time: 10:34 μμ
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace DefaultNamespace
{
	
	public class Class1
	{
		public Class1()
		{
			Console.Write("Δώσε κάποιον αριτθμό: ");
			String s= Console.In.ReadLine();
			int noumero= Int32.Parse(s);
			Console.WriteLine(noumero);
			
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}
