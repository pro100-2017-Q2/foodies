using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using VirtualPantry.Enums;

namespace VirtualPantry.Converters
{
	public class ConversionChartConverter : IMultiValueConverter
	{
		public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
		{
			string output = "###";
			double orginalAmount = 0;
			double convertedAmount = 0;
			Units originalUnit = Units.item;
			Units convertedUnit = Units.item;

			double.TryParse(values[0].ToString(), out orginalAmount);
			if (values[1] != null && values[2] != null)
			{
				originalUnit = (Units)values[1];
				convertedUnit = (Units)values[2];
			}

			try
			{
				switch (originalUnit)
				{
					case Units.cup:
						switch (convertedUnit)
						{
							case Units.cup:
								convertedAmount = orginalAmount;
								output = convertedAmount.ToString();
								break;
							case Units.fl_oz:
								convertedAmount = orginalAmount * 8;
								output = convertedAmount.ToString();
								break;
							case Units.g:
								convertedAmount = orginalAmount * 340;
								output = convertedAmount.ToString();
								break;
							case Units.gal:
								convertedAmount = orginalAmount / 16;
								output = convertedAmount.ToString();
								break;
							case Units.kg:
								convertedAmount = orginalAmount / 4.2;
								output = convertedAmount.ToString();
								break;
							case Units.l:
								convertedAmount = orginalAmount / 4.2;
								output = convertedAmount.ToString();
								break;
							case Units.lb:
								convertedAmount = orginalAmount / 1.9;
								output = convertedAmount.ToString();
								break;
							case Units.mg:
								convertedAmount = orginalAmount * 200;
								output = convertedAmount.ToString();
								break;
							case Units.ml:
								convertedAmount = orginalAmount * 230;
								output = convertedAmount.ToString();
								break;
							case Units.oz:
								convertedAmount = orginalAmount * 8.3;
								output = convertedAmount.ToString();
								break;
							case Units.pint:
								convertedAmount = orginalAmount / 2;
								output = convertedAmount.ToString();
								break;
							case Units.quart:
								convertedAmount = orginalAmount / 4;
								output = convertedAmount.ToString();
								break;
							case Units.tbsp:
								convertedAmount = orginalAmount * 16;
								output = convertedAmount.ToString();
								break;
							case Units.tsp:
								convertedAmount = orginalAmount * 48;
								output = convertedAmount.ToString();
								break;
							default:
								break;
						}
						break;
					case Units.fl_oz:
						switch (convertedUnit)
						{
							case Units.cup:
								convertedAmount = orginalAmount / 8;
								output = convertedAmount.ToString();
								break;
							case Units.fl_oz:
								convertedAmount = orginalAmount;
								output = convertedAmount.ToString();
								break;
							case Units.g:
								convertedAmount = orginalAmount * 29.5;
								output = convertedAmount.ToString();
								break;
							case Units.gal:
								convertedAmount = orginalAmount / 128;
								output = convertedAmount.ToString();
								break;
							case Units.kg:
								convertedAmount = orginalAmount / 33.8;
								output = convertedAmount.ToString();
								break;
							case Units.l:
								convertedAmount = orginalAmount / 4.2;
								output = convertedAmount.ToString();
								break;
							case Units.lb:
								convertedAmount = orginalAmount / 15.3;
								output = convertedAmount.ToString();
								break;
							case Units.mg:
								convertedAmount = orginalAmount * 29573.5;
								output = convertedAmount.ToString();
								break;
							case Units.ml:
								convertedAmount = orginalAmount * 29.57;
								output = convertedAmount.ToString();
								break;
							case Units.oz:
								convertedAmount = orginalAmount;
								output = convertedAmount.ToString();
								break;
							case Units.pint:
								convertedAmount = orginalAmount / 16;
								output = convertedAmount.ToString();
								break;
							case Units.quart:
								convertedAmount = orginalAmount / 32;
								output = convertedAmount.ToString();
								break;
							case Units.tbsp:
								convertedAmount = orginalAmount * 2;
								output = convertedAmount.ToString();
								break;
							case Units.tsp:
								convertedAmount = orginalAmount * 6;
								output = convertedAmount.ToString();
								break;
							default:
								break;
						}
						break;
					case Units.g:
						switch (convertedUnit)
						{
							case Units.cup:
								convertedAmount = orginalAmount / 236.6;
								output = convertedAmount.ToString();
								break;
							case Units.fl_oz:
								convertedAmount = orginalAmount / 29.57;
								output = convertedAmount.ToString();
								break;
							case Units.g:
								convertedAmount = orginalAmount;
								output = convertedAmount.ToString();
								break;
							case Units.gal:
								convertedAmount = orginalAmount / 3785.4;
								output = convertedAmount.ToString();
								break;
							case Units.kg:
								convertedAmount = orginalAmount / 1000;
								output = convertedAmount.ToString();
								break;
							case Units.l:
								convertedAmount = orginalAmount / 1000;
								output = convertedAmount.ToString();
								break;
							case Units.lb:
								convertedAmount = orginalAmount / 453.5;
								output = convertedAmount.ToString();
								break;
							case Units.mg:
								convertedAmount = orginalAmount * 1000;
								output = convertedAmount.ToString();
								break;
							case Units.ml:
								convertedAmount = orginalAmount;
								output = convertedAmount.ToString();
								break;
							case Units.oz:
								convertedAmount = orginalAmount / 28.3;
								output = convertedAmount.ToString();
								break;
							case Units.pint:
								convertedAmount = orginalAmount / 473.1;
								output = convertedAmount.ToString();
								break;
							case Units.quart:
								convertedAmount = orginalAmount / 946.3;
								output = convertedAmount.ToString();
								break;
							case Units.tbsp:
								convertedAmount = orginalAmount / 14.78;
								output = convertedAmount.ToString();
								break;
							case Units.tsp:
								convertedAmount = orginalAmount / 4.9;
								output = convertedAmount.ToString();
								break;
							default:
								break;
						}
						break;
					case Units.gal:
						switch (convertedUnit)
						{
							case Units.cup:
								convertedAmount = orginalAmount * 16;
								output = convertedAmount.ToString();
								break;
							case Units.fl_oz:
								convertedAmount = orginalAmount * 128;
								output = convertedAmount.ToString();
								break;
							case Units.g:
								convertedAmount = orginalAmount * 3785.4;
								output = convertedAmount.ToString();
								break;
							case Units.gal:
								convertedAmount = orginalAmount;
								output = convertedAmount.ToString();
								break;
							case Units.kg:
								convertedAmount = orginalAmount * 3.79;
								output = convertedAmount.ToString();
								break;
							case Units.l:
								convertedAmount = orginalAmount * 3.78;
								output = convertedAmount.ToString();
								break;
							case Units.lb:
								convertedAmount = orginalAmount * 8.3;
								output = convertedAmount.ToString();
								break;
							case Units.mg:
								convertedAmount = orginalAmount * 119826.4;
								output = convertedAmount.ToString();
								break;
							case Units.ml:
								convertedAmount = orginalAmount * 3785.4;
								output = convertedAmount.ToString();
								break;
							case Units.oz:
								convertedAmount = orginalAmount * 148.9;
								output = convertedAmount.ToString();
								break;
							case Units.pint:
								convertedAmount = orginalAmount * 8;
								output = convertedAmount.ToString();
								break;
							case Units.quart:
								convertedAmount = orginalAmount * 4.8;
								output = convertedAmount.ToString();
								break;
							case Units.tbsp:
								convertedAmount = orginalAmount * 256;
								output = convertedAmount.ToString();
								break;
							case Units.tsp:
								convertedAmount = orginalAmount * 768;
								output = convertedAmount.ToString();
								break;
							default:
								break;
						}
						break;
					case Units.kg:
						switch (convertedUnit)
						{
							case Units.cup:
								convertedAmount = orginalAmount * 4.2;
								output = convertedAmount.ToString();
								break;
							case Units.fl_oz:
								convertedAmount = orginalAmount * 33.8;
								output = convertedAmount.ToString();
								break;
							case Units.g:
								convertedAmount = orginalAmount * 1000;
								output = convertedAmount.ToString();
								break;
							case Units.gal:
								convertedAmount = orginalAmount / 3.7;
								output = convertedAmount.ToString();
								break;
							case Units.kg:
								convertedAmount = orginalAmount;
								output = convertedAmount.ToString();
								break;
							case Units.l:
								convertedAmount = orginalAmount;
								output = convertedAmount.ToString();
								break;
							case Units.lb:
								convertedAmount = orginalAmount * 2.2;
								output = convertedAmount.ToString();
								break;
							case Units.mg:
								convertedAmount = orginalAmount * 1000;
								output = convertedAmount.ToString();
								break;
							case Units.ml:
								convertedAmount = orginalAmount * 1000;
								output = convertedAmount.ToString();
								break;
							case Units.oz:
								convertedAmount = orginalAmount * 35.2;
								output = convertedAmount.ToString();
								break;
							case Units.pint:
								convertedAmount = orginalAmount * 2.1;
								output = convertedAmount.ToString();
								break;
							case Units.quart:
								convertedAmount = orginalAmount * 1.1;
								output = convertedAmount.ToString();
								break;
							case Units.tbsp:
								convertedAmount = orginalAmount * 67.6;
								output = convertedAmount.ToString();
								break;
							case Units.tsp:
								convertedAmount = orginalAmount * 202.9;
								output = convertedAmount.ToString();
								break;
							default:
								break;
						}
						break;
					case Units.l:
						switch (convertedUnit)
						{
							case Units.cup:
								convertedAmount = orginalAmount * 4.2;
								output = convertedAmount.ToString();
								break;
							case Units.fl_oz:
								convertedAmount = orginalAmount * 33.8;
								output = convertedAmount.ToString();
								break;
							case Units.g:
								convertedAmount = orginalAmount * 1000;
								output = convertedAmount.ToString();
								break;
							case Units.gal:
								convertedAmount = orginalAmount / 3.7;
								output = convertedAmount.ToString();
								break;
							case Units.kg:
								convertedAmount = orginalAmount;
								output = convertedAmount.ToString();
								break;
							case Units.l:
								convertedAmount = orginalAmount;
								output = convertedAmount.ToString();
								break;
							case Units.lb:
								convertedAmount = orginalAmount * 2.2;
								output = convertedAmount.ToString();
								break;
							case Units.mg:
								convertedAmount = orginalAmount * 100000;
								output = convertedAmount.ToString();
								break;
							case Units.ml:
								convertedAmount = orginalAmount * 1000;
								output = convertedAmount.ToString();
								break;
							case Units.oz:
								convertedAmount = orginalAmount * 33.8;
								output = convertedAmount.ToString();
								break;
							case Units.pint:
								convertedAmount = orginalAmount * 2.1;
								output = convertedAmount.ToString();
								break;
							case Units.quart:
								convertedAmount = orginalAmount;
								output = convertedAmount.ToString();
								break;
							case Units.tbsp:
								convertedAmount = orginalAmount * 67.6;
								output = convertedAmount.ToString();
								break;
							case Units.tsp:
								convertedAmount = orginalAmount * 202.8;
								output = convertedAmount.ToString();
								break;
							default:
								break;
						}
						break;
					case Units.lb:
						switch (convertedUnit)
						{
							case Units.cup:
								convertedAmount = orginalAmount * 2;
								output = convertedAmount.ToString();
								break;
							case Units.fl_oz:
								convertedAmount = orginalAmount * 15.3;
								output = convertedAmount.ToString();
								break;
							case Units.g:
								convertedAmount = orginalAmount * 453.5;
								output = convertedAmount.ToString();
								break;
							case Units.gal:
								convertedAmount = orginalAmount / 8.3;
								output = convertedAmount.ToString();
								break;
							case Units.kg:
								convertedAmount = orginalAmount / 2.2;
								output = convertedAmount.ToString();
								break;
							case Units.l:
								convertedAmount = orginalAmount / 2.2;
								output = convertedAmount.ToString();
								break;
							case Units.lb:
								convertedAmount = orginalAmount;
								output = convertedAmount.ToString();
								break;
							case Units.mg:
								convertedAmount = orginalAmount * 453592;
								output = convertedAmount.ToString();
								break;
							case Units.ml:
								convertedAmount = orginalAmount * 453.5;
								output = convertedAmount.ToString();
								break;
							case Units.oz:
								convertedAmount = orginalAmount * 16;
								output = convertedAmount.ToString();
								break;
							case Units.pint:
								convertedAmount = orginalAmount;
								output = convertedAmount.ToString();
								break;
							case Units.quart:
								convertedAmount = orginalAmount / 2;
								output = convertedAmount.ToString();
								break;
							case Units.tbsp:
								convertedAmount = orginalAmount * 32;
								output = convertedAmount.ToString();
								break;
							case Units.tsp:
								convertedAmount = orginalAmount * 96;
								output = convertedAmount.ToString();
								break;
							default:
								break;
						}
						break;
					case Units.mg:
						switch (convertedUnit)
						{
							case Units.cup:
								convertedAmount = orginalAmount / 236588.2;
								output = convertedAmount.ToString();
								break;
							case Units.fl_oz:
								convertedAmount = orginalAmount / 29573.5;
								output = convertedAmount.ToString();
								break;
							case Units.g:
								convertedAmount = orginalAmount / 1000;
								output = convertedAmount.ToString();
								break;
							case Units.gal:
								convertedAmount = orginalAmount / 119826.4;
								output = convertedAmount.ToString();
								break;
							case Units.kg:
								convertedAmount = orginalAmount / 1000000;
								output = convertedAmount.ToString();
								break;
							case Units.l:
								convertedAmount = orginalAmount / 1000000;
								output = convertedAmount.ToString();
								break;
							case Units.lb:
								convertedAmount = orginalAmount * 453592.3;
								output = convertedAmount.ToString();
								break;
							case Units.mg:
								convertedAmount = orginalAmount;
								output = convertedAmount.ToString();
								break;
							case Units.ml:
								convertedAmount = orginalAmount / 1000;
								output = convertedAmount.ToString();
								break;
							case Units.oz:
								convertedAmount = orginalAmount / 28349.5;
								output = convertedAmount.ToString();
								break;
							case Units.pint:
								convertedAmount = orginalAmount / 473176.4;
								output = convertedAmount.ToString();
								break;
							case Units.quart:
								convertedAmount = orginalAmount / 946352.9;
								output = convertedAmount.ToString();
								break;
							case Units.tbsp:
								convertedAmount = orginalAmount / 17062.5;
								output = convertedAmount.ToString();
								break;
							case Units.tsp:
								convertedAmount = orginalAmount / 5000;
								output = convertedAmount.ToString();
								break;
							default:
								break;
						}
						break;
					case Units.ml:
						switch (convertedUnit)
						{
							case Units.cup:
								convertedAmount = orginalAmount / 236.5;
								output = convertedAmount.ToString();
								break;
							case Units.fl_oz:
								convertedAmount = orginalAmount / 29.5;
								output = convertedAmount.ToString();
								break;
							case Units.g:
								convertedAmount = orginalAmount;
								output = convertedAmount.ToString();
								break;
							case Units.gal:
								convertedAmount = orginalAmount / 3785.4;
								output = convertedAmount.ToString();
								break;
							case Units.kg:
								convertedAmount = orginalAmount / 1000;
								output = convertedAmount.ToString();
								break;
							case Units.l:
								convertedAmount = orginalAmount / 1000;
								output = convertedAmount.ToString();
								break;
							case Units.lb:
								convertedAmount = orginalAmount / 1000;
								output = convertedAmount.ToString();
								break;
							case Units.mg:
								convertedAmount = orginalAmount * 1000;
								output = convertedAmount.ToString();
								break;
							case Units.ml:
								convertedAmount = orginalAmount;
								output = convertedAmount.ToString();
								break;
							case Units.oz:
								convertedAmount = orginalAmount / 29.5;
								output = convertedAmount.ToString();
								break;
							case Units.pint:
								convertedAmount = orginalAmount / 473.1;
								output = convertedAmount.ToString();
								break;
							case Units.quart:
								convertedAmount = orginalAmount / 946.3;
								output = convertedAmount.ToString();
								break;
							case Units.tbsp:
								convertedAmount = orginalAmount / 14.7;
								output = convertedAmount.ToString();
								break;
							case Units.tsp:
								convertedAmount = orginalAmount / 4.9;
								output = convertedAmount.ToString();
								break;
							default:
								break;
						}
						break;
					case Units.oz:
						switch (convertedUnit)
						{
							case Units.cup:
								convertedAmount = orginalAmount / 8;
								output = convertedAmount.ToString();
								break;
							case Units.fl_oz:
								convertedAmount = orginalAmount;
								output = convertedAmount.ToString();
								break;
							case Units.g:
								convertedAmount = orginalAmount * 29.5;
								output = convertedAmount.ToString();
								break;
							case Units.gal:
								convertedAmount = orginalAmount / 128;
								output = convertedAmount.ToString();
								break;
							case Units.kg:
								convertedAmount = orginalAmount / 35.2;
								output = convertedAmount.ToString();
								break;
							case Units.l:
								convertedAmount = orginalAmount / 33.8;
								output = convertedAmount.ToString();
								break;
							case Units.lb:
								convertedAmount = orginalAmount / 16;
								output = convertedAmount.ToString();
								break;
							case Units.mg:
								convertedAmount = orginalAmount * 28349.5;
								output = convertedAmount.ToString();
								break;
							case Units.ml:
								convertedAmount = orginalAmount * 29.5;
								output = convertedAmount.ToString();
								break;
							case Units.oz:
								convertedAmount = orginalAmount;
								output = convertedAmount.ToString();
								break;
							case Units.pint:
								convertedAmount = orginalAmount * 16;
								output = convertedAmount.ToString();
								break;
							case Units.quart:
								convertedAmount = orginalAmount * 32;
								output = convertedAmount.ToString();
								break;
							case Units.tbsp:
								convertedAmount = orginalAmount * 2;
								output = convertedAmount.ToString();
								break;
							case Units.tsp:
								convertedAmount = orginalAmount * 6;
								output = convertedAmount.ToString();
								break;
							default:
								break;
						}
						break;
					case Units.pint:
						switch (convertedUnit)
						{
							case Units.cup:
								convertedAmount = orginalAmount * 2;
								output = convertedAmount.ToString();
								break;
							case Units.fl_oz:
								convertedAmount = orginalAmount * 16;
								output = convertedAmount.ToString();
								break;
							case Units.g:
								convertedAmount = orginalAmount * 473.1;
								output = convertedAmount.ToString();
								break;
							case Units.gal:
								convertedAmount = orginalAmount / 9.3;
								output = convertedAmount.ToString();
								break;
							case Units.kg:
								convertedAmount = orginalAmount / 1.8;
								output = convertedAmount.ToString();
								break;
							case Units.l:
								convertedAmount = orginalAmount / 2.1;
								output = convertedAmount.ToString();
								break;
							case Units.lb:
								convertedAmount = orginalAmount;
								output = convertedAmount.ToString();
								break;
							case Units.mg:
								convertedAmount = orginalAmount * 473176.4;
								output = convertedAmount.ToString();
								break;
							case Units.ml:
								convertedAmount = orginalAmount * 473.1;
								output = convertedAmount.ToString();
								break;
							case Units.oz:
								convertedAmount = orginalAmount * 16.6;
								output = convertedAmount.ToString();
								break;
							case Units.pint:
								convertedAmount = orginalAmount;
								output = convertedAmount.ToString();
								break;
							case Units.quart:
								convertedAmount = orginalAmount / 2;
								output = convertedAmount.ToString();
								break;
							case Units.tbsp:
								convertedAmount = orginalAmount * 31.5;
								output = convertedAmount.ToString();
								break;
							case Units.tsp:
								convertedAmount = orginalAmount * 94.6;
								output = convertedAmount.ToString();
								break;
							default:
								break;
						}
						break;
					case Units.quart:
						switch (convertedUnit)
						{
							case Units.cup:
								convertedAmount = orginalAmount * 4;
								output = convertedAmount.ToString();
								break;
							case Units.fl_oz:
								convertedAmount = orginalAmount * 32;
								output = convertedAmount.ToString();
								break;
							case Units.g:
								convertedAmount = orginalAmount * 946.3;
								output = convertedAmount.ToString();
								break;
							case Units.gal:
								convertedAmount = orginalAmount / 4;
								output = convertedAmount.ToString();
								break;
							case Units.kg:
								convertedAmount = orginalAmount;
								output = convertedAmount.ToString();
								break;
							case Units.l:
								convertedAmount = orginalAmount;
								output = convertedAmount.ToString();
								break;
							case Units.lb:
								convertedAmount = orginalAmount * 2;
								output = convertedAmount.ToString();
								break;
							case Units.mg:
								convertedAmount = orginalAmount * 1092000;
								output = convertedAmount.ToString();
								break;
							case Units.ml:
								convertedAmount = orginalAmount * 946.3;
								output = convertedAmount.ToString();
								break;
							case Units.oz:
								convertedAmount = orginalAmount * 32;
								output = convertedAmount.ToString();
								break;
							case Units.pint:
								convertedAmount = orginalAmount * 2;
								output = convertedAmount.ToString();
								break;
							case Units.quart:
								convertedAmount = orginalAmount;
								output = convertedAmount.ToString();
								break;
							case Units.tbsp:
								convertedAmount = orginalAmount * 64;
								output = convertedAmount.ToString();
								break;
							case Units.tsp:
								convertedAmount = orginalAmount * 192;
								output = convertedAmount.ToString();
								break;
							default:
								break;
						}
						break;
					case Units.tbsp:
						switch (convertedUnit)
						{
							case Units.cup:
								convertedAmount = orginalAmount / 16;
								output = convertedAmount.ToString();
								break;
							case Units.fl_oz:
								convertedAmount = orginalAmount / 1.9;
								output = convertedAmount.ToString();
								break;
							case Units.g:
								convertedAmount = orginalAmount * 15;
								output = convertedAmount.ToString();
								break;
							case Units.gal:
								convertedAmount = orginalAmount / 256;
								output = convertedAmount.ToString();
								break;
							case Units.kg:
								convertedAmount = orginalAmount / 66.6;
								output = convertedAmount.ToString();
								break;
							case Units.l:
								convertedAmount = orginalAmount / 66.6;
								output = convertedAmount.ToString();
								break;
							case Units.lb:
								convertedAmount = orginalAmount / 30.6;
								output = convertedAmount.ToString();
								break;
							case Units.mg:
								convertedAmount = orginalAmount * 17062.5;
								output = convertedAmount.ToString();
								break;
							case Units.ml:
								convertedAmount = orginalAmount * 14.7;
								output = convertedAmount.ToString();
								break;
							case Units.oz:
								convertedAmount = orginalAmount / 2;
								output = convertedAmount.ToString();
								break;
							case Units.pint:
								convertedAmount = orginalAmount / 32;
								output = convertedAmount.ToString();
								break;
							case Units.quart:
								convertedAmount = orginalAmount / 64;
								output = convertedAmount.ToString();
								break;
							case Units.tbsp:
								convertedAmount = orginalAmount;
								output = convertedAmount.ToString();
								break;
							case Units.tsp:
								convertedAmount = orginalAmount * 3;
								output = convertedAmount.ToString();
								break;
							default:
								break;
						}
						break;
					case Units.tsp:
						switch (convertedUnit)
						{
							case Units.cup:
								convertedAmount = orginalAmount / 48;
								output = convertedAmount.ToString();
								break;
							case Units.fl_oz:
								convertedAmount = orginalAmount / 6;
								output = convertedAmount.ToString();
								break;
							case Units.g:
								convertedAmount = orginalAmount * 4.9;
								output = convertedAmount.ToString();
								break;
							case Units.gal:
								convertedAmount = orginalAmount / 768;
								output = convertedAmount.ToString();
								break;
							case Units.kg:
								convertedAmount = orginalAmount / 200;
								output = convertedAmount.ToString();
								break;
							case Units.l:
								convertedAmount = orginalAmount / 200;
								output = convertedAmount.ToString();
								break;
							case Units.lb:
								convertedAmount = orginalAmount / 92;
								output = convertedAmount.ToString();
								break;
							case Units.mg:
								convertedAmount = orginalAmount * 5000;
								output = convertedAmount.ToString();
								break;
							case Units.ml:
								convertedAmount = orginalAmount * 5;
								output = convertedAmount.ToString();
								break;
							case Units.oz:
								convertedAmount = orginalAmount / 5.6;
								output = convertedAmount.ToString();
								break;
							case Units.pint:
								convertedAmount = orginalAmount / 96;
								output = convertedAmount.ToString();
								break;
							case Units.quart:
								convertedAmount = orginalAmount / 192;
								output = convertedAmount.ToString();
								break;
							case Units.tbsp:
								convertedAmount = orginalAmount / 3;
								output = convertedAmount.ToString();
								break;
							case Units.tsp:
								convertedAmount = orginalAmount;
								output = convertedAmount.ToString();
								break;
							default:
								break;
						}
						break;
					default:
						break;
				}
			}
			catch
			{
				output = "Cannot Convert";
			}

			return output;
		}

		public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
		{
			throw new NotImplementedException();
		}
	}
}
