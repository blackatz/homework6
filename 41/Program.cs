//пользователь ввел с клавиатуры Н чисел.
//посчитайте, сколько цифр больше 0 ввел пользователь

{
Console.Clear();
Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine("Подсчет положительных чисел");
Console.WriteLine("");
Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("числа перечисляются через запятую");
Console.ResetColor();

int[] arrayNumbers = InputArrayNumbers(); // ввод массива чисел с разбором на части

Console.WriteLine(PozitiveNumbers(arrayNumbers));


Console.WriteLine("");
Console.ForegroundColor = ConsoleColor.Cyan;
Console.Write("для завершения задачи нажмите любую клавишу...");
Console.ResetColor();
Console.ReadKey(true);
}

static int[] InputArrayNumbers()
    {
        Console.WriteLine("");

        NewInput:

        Console.Write("Введите числа: ");
        string str  = Console.ReadLine()!;
        string[] str_ = str.Split(','); // разбить на элементы
        int[] rezult = new int[str_.Length];
        for (int i = 0; i < str_.Length; i++)
        {
            string tempStr = str_[i].Trim(); //удаление боковых пробелов

            if(int.TryParse(tempStr, out int tempInt)) // если элемент число
            {
                rezult[i] = tempInt; //запись элемента
            }
            else //если элемент не число
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"err: некорректный ввод {i + 1}-го элемента!");
                Console.ResetColor();

                goto NewInput; //сначала
            }
            }
            return rezult;
        }

        int PozitiveNumbers(int[] arrayNumbers)
        {   
            int pozitive = 0;
            int i = 0;
            int[] rezult = new int[arrayNumbers.Length];
            
            while (i < arrayNumbers.Length)
            {
                if (arrayNumbers[i] > 0)
                {
                    pozitive++;
                    i++; }

                else
                {
                    i++;
                }
            }

            return pozitive;
        }