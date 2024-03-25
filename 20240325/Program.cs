// 輸出星期
Console.WriteLine($"日 一 二 三 四 五 六");

// 填充空白
for (int space = 1; space <= 5; space = space + 1)
{
    Console.Write(" ");
}

// 輸出月曆內容
for (int i = 1; i <= 31; i = i + 1)
{
    Console.Write(i);
}