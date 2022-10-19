using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exec_StringMembers2_Q3
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//aLLeN kUO轉成allen kuo
			string strangeAllen = "aLLeN kUO";
			string smallAllen = strangeAllen.ToLower();

			// 方案1 只適用在Allen Kuo 的方法
			string bigAllen = strangeAllen.ToUpper();
			string normalAllen1 =
				$"{bigAllen[0]}{smallAllen.Substring(1, 5)}{bigAllen[6]}{smallAllen.Substring(7, 2)}";
			Console.WriteLine(normalAllen1);
			
			//方案2 適用在任何人的方法-使用split
			string[] split = smallAllen.Split(' ');
			string normalAllen2 = "";
			foreach (var item in split)
			{
				normalAllen2 += char.ToUpper(item[0])+item.Substring(1) + ' ';
			}

			normalAllen2 = normalAllen2.TrimEnd();
			Console.WriteLine(normalAllen2);

			//方案3 適用任何人的方法-使用ToTitleCase
			string normalAllen3 = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(smallAllen);
			Console.WriteLine(normalAllen3);
		}
	}
}
