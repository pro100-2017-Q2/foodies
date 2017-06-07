using Microsoft.VisualStudio.TestTools.UnitTesting;
using VirtualPantry.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VirtualPantryTests.Converters;
using VirtualPantry.Enums;

namespace VirtualPantry.Converters.Tests
{
	[TestClass()]
	public class ConversionChartConverterTests
	{
		[TestMethod()]
		public void ConvertTest()
		{
			string output = "";
			double amount = 1;
			Units originalUnit = Units.cup;
			Units convertedUnit = Units.g;
			output = Class1.Convert(amount, originalUnit, convertedUnit).ToString();
			Console.WriteLine(output);

			output = Class1.Convert("w", "w", "w").ToString();
			Console.WriteLine(output);
		}
	}
}