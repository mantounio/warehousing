using System.Globalization;
using System.Text;

namespace Backend_Feature_api.Util
{
	public static class Util
	{
		public static (string comma_format, string underscore_format) ConvertTo_Formal_Price(string value)
		{
			StringBuilder builder = new();
			string value_str = value;
			int count = 0;

			for (int i = value_str.Length - 1; i >= 0; i--)
			{
				if (count == 3)
				{
					builder.Append(",");
					count = 0;
				}

				builder.Append(value_str[i]);
				count++;
			}

			char [] arr = builder.ToString().ToCharArray();
			Array.Reverse(arr);

			string final = string.Join(null, arr);

			return (final, final.Replace(",", "_"));
		}

		public static string Bind_To_WareHouse(string category)
		{
			return category switch
			{
				"Electronics" => "Main Warehouse",
				"Accessories" => "East Warehouse",
				"Office Supplies" => "West Warehouse"
			};
		}

		public static string Get_Date_Time()
		{
			DateTime now = DateTime.Now;
			PersianCalendar persian_cal = new();

			int year = persian_cal.GetYear(now);
			int month = persian_cal.GetMonth(now);
			int day = persian_cal.GetDayOfMonth(now);

			return $"{year}-{month}-{day} {now.ToString("H:m")}";
		}
	}
}
