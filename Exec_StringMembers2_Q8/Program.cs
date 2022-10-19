using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exec_StringMembers2_Q8
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//隱藏手機號碼
			string mobileNumber = "0935000046";
			string keepItSecret = $"{mobileNumber.Substring(0, 4)}{new string('*', 4)}{mobileNumber.Substring(8, 2)}";

			Console.WriteLine(keepItSecret);
		}
	}
}
