using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using VirtualPantry.Recipes;

namespace VirtualPantry.Converters
{
	public class RatingImageConverter : IValueConverter
	{
		public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
		{
			Recipe r = value as Recipe;
			if (r == null)
			{
				return "";
			}
            //StarRating rating = r.Rating;
            //string imguri = "../Images/Ratings/";
            //switch (rating)
            //{
            //	case StarRating.zero:
            //		imguri += "zero.png";
            //		break;
            //	case StarRating.one:
            //		imguri += "one.png";
            //		break;
            //	case StarRating.two:
            //		imguri += "two.png";
            //		break;
            //	case StarRating.three:
            //		imguri += "three.png";
            //		break;
            //	case StarRating.four:
            //		imguri += "four.PNG";
            //		break;
            //	case StarRating.five:
            //		imguri += "five.png";
            //		break;
            //	default:
            //		imguri += "zero.png";
            //		break;
            //}
            //return imguri;
            return null; 
		}

		public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
		{
			throw new NotImplementedException();
		}
	}
}
