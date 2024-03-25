// 輸出星期
using System.Globalization;

Console.WriteLine($"週數\t日\t一\t二\t三\t四\t五\t六");

// 計算當月第一天的星期
DateTime firstDayOfMonth = new DateTime(2024, 3, 1);
int firstDayOfWeek = (int)firstDayOfMonth.DayOfWeek;

// 計算當月的天數
int daysInMonth = DateTime.DaysInMonth(2024, 3);

//创建公历日历对象
GregorianCalendar gregorianCalendar = new GregorianCalendar();

// 填充空白
for (int space = 1; space <= firstDayOfWeek + 1; space = space + 1)
{
    if (space == 1)
    {
        //获取指定日期是周数 CalendarWeekRule指定 第一周开始于该年的第一天，DayOfWeek指定每周第一天是星期几
        int weekOfYear = gregorianCalendar.GetWeekOfYear(new DateTime(2024, 3, 1), CalendarWeekRule.FirstDay, DayOfWeek.Sunday);
        string time = weekOfYear.ToString();
        Console.Write(time + "\t");
    }
    else 
    {
        Console.Write("\t");
    }
}

// 輸出月曆內容
for (int i = 1; i <= daysInMonth; i = i + 1)
{
    if ((5 + i) % 7 == 0)
    {
        Console.Write(i);
        Console.WriteLine(); // 每週最後一天要換一行

        if (i != 1)
        {
            //获取指定日期是周数 CalendarWeekRule指定 第一周开始于该年的第一天，DayOfWeek指定每周第一天是星期几
            int weekOfYear = gregorianCalendar.GetWeekOfYear(new DateTime(2024, 3, i + 1), CalendarWeekRule.FirstDay, DayOfWeek.Sunday);
            string time = weekOfYear.ToString();
            Console.Write(time + "\t");
        }
    }
    else
    {
        Console.Write(i);
        Console.Write("\t"); // 不用換行的填充空白
    }
}