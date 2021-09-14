using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using TakamineProduction;



namespace Sample
{
	class Program
	{
		static void Main(string[] args)
		{
			var angle = new FlexibleAngle();


			Write("★初期状態");

			angle.Degree = 180;
			Write("★Degree = 180");

			angle.Radian = 1;
			Write("★Radian = 1");

			angle.Radian = double.NaN;
			Write("★Radian = double.NaN");

			angle.Radian = Math.PI * 2;
			Write("★Radian = Math.PI * 2");

			angle.Degree += 45;
			Write("★Degree += 45");

			angle.IsMinimumContorlled = true;
			angle.Degree = 360;
			Write("★Degree = 360");

			angle.Degree = -90;
			Write("★Degree = -90");

			Console.ReadKey();


			//************************************************************************************

			void Write(string title)
			{
				Console.WriteLine(title);
				Console.WriteLine("Degree:" + angle.Degree.ToString());
				Console.WriteLine("Radian:" + angle.Radian.ToString());
				Console.WriteLine("");
			}
		}
	}
}
