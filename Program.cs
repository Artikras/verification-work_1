﻿            string[] M;
            Console.WriteLine("Введите массив строк через пробел");
            //Выводим первую строку
            string stroka = Console.ReadLine();
            //Получаем информацию от пользователя
            M = stroka.Split(' ');
            var result = new string[M .Length];
            var realSize = 0;
            foreach (var value in M )
            {
                if (value.Length <= 3)
                {
                    result[realSize] = value;
                    realSize++;
                }
            }
            //Задаем условие и диапазон работы
            Console.WriteLine(string.Join(Environment.NewLine, result, 0, realSize));
            Console.ReadKey(true);