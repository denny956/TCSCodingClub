// 輸出星期
Console.WriteLine($"日\t一\t二\t三\t四\t五\t六");

// 填充空白
for (int space = 1; space <= 5; space = space + 1)
{
    Console.Write("\t");
}

// 輸出月曆內容
for (int i = 1; i <= 31; i = i + 1)
{
    Console.Write(i);
}