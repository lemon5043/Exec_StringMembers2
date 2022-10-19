using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exec_StringMembers2_Q5
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//比對Allen 不分大小寫
			Console.Write("請輸入您的名字");
			string input = Console.ReadLine();

			if (string.IsNullOrEmpty(input))
			{
				Console.WriteLine("請再試一次");
				return;
			}

			if (input.ToLower() == "allen")
			{
				Console.WriteLine("您是Allen");
			}
			else
			{
				Console.WriteLine("您不是Allen");
			}
		}
	}
}
