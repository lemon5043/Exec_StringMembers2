using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exec_StringMembers2_Q7
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.Write("請輸入第一個數");
			string input1 = Console.ReadLine();
			Console.Write("請輸入第二個數");
			string input2 = Console.ReadLine();
			double sum = Convert.ToDouble(input1) + Convert.ToDouble(input2);
			double result = Math.Round(sum, 2, MidpointRounding.AwayFromZero);
			Console.WriteLine(result);
		}
	}
}
