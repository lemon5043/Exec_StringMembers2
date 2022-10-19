using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exec_StringMembers2_Q4
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//字串1100225轉成20210225
			//將字串轉日期 使用課本教的方法TryParseExact
			string dt = "1100225";
			DateTime.TryParseExact(dt, "yyyMMdd", null, DateTimeStyles.NoCurrentDateDefault, out DateTime republicEra);
			string commonEra = republicEra.AddYears(1911).ToString("yyyyMMdd");
			Console.WriteLine(commonEra);
		}
	}
}
