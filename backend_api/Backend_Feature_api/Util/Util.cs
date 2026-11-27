using System.Globalization;
using System.Text;

namespace Backend_Feature_api.Util
{
	public enum Movement_T
	{
		IN,
		OUT,
		NULL,
	}
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

		public static (string move_quantity,Movement_T move_T) Set_Movement_Type(int old_quantity,int current_quantity)
		{
			if (current_quantity >= old_quantity)
				return ((current_quantity - old_quantity).ToString(), Movement_T.IN);
			else if (current_quantity < old_quantity)
				return ((current_quantity - old_quantity).ToString(), Movement_T.OUT);

			return (null, Movement_T.NULL)!;
		}

		public static string Convert_Movement_string(Movement_T type)
		{
			return type switch
			{
				Movement_T.IN => "+In",
				Movement_T.OUT => "-Out",
			};
		}
	}
}
