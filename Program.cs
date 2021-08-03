using System;
using System.Collections.Generic;

namespace HomeWork5._5
{
    
    class Program
    {
        #region
        /// <summary>
        /// Умножение матрицы на число
        /// </summary>
        /// <param name="_array">Матрица исходная</param>
        /// <param name="mult">Множитель</param>
        /// <returns>Вернет матрицу</returns>
        static int[] multi1 (int[] _array, int mult)
        {
            ConsoleInfo($"Перемножение одномерной матрицы на {mult}");
            int[] ret = new int[_array.Length];
            for (int i = 0; i < _array.Length; i++)
            {
                ret[i] = _array[i] * mult;
            }

            return ret;
        }

        /// <summary>
        /// Умножение двумерной матрицы на число
        /// </summary>
        /// <param name="_array">Двумерная матрица</param>
        /// <param name="mult">Множитель</param>
        /// <returns>Вернет двумерную матрицу</returns>
        static int[,] multi1(int[,] _array, int mult)
        {
            ConsoleInfo($"Перемножение двумерной матрицы на {mult}");

            int[,] ret = new int[_array.GetLength(0),_array.GetLength(1)];
            for (int i = 0; i < _array.GetLength(0); i++)
            {
                for (int j = 0; j < _array.GetLength(1); j++)
                {
                    ret[i, j] = _array[i, j] * mult;
                }
                
            }

            return ret;
        }

        /// <summary>
        /// Умножение матрицы на матрицу (одномерную)
        /// </summary>
        /// <param name="_array1">Матрица исходная</param>
        /// <param name="_array2">Множитель</param>
        /// <returns>Вернет матрицу</returns>
        static int[,] multi1(int[,] _array1, int[,] _array2)
        {
            ConsoleInfo($"Перемножение двумерных матриц");

            int rows = _array1.GetLength(0);
            int cols = _array2.GetLength(1);

            if (rows != cols)
            {
                ConsoleInfo("Матрицы не равны! Возврат максимальной, но пустой матрицы");
                return new int[rows, cols];
            }
            int[,] ret = new int[rows, cols];


            for (int i = 0; i < rows; i++)
            {
                for (int k = 0; k < cols; k++)
                {
                    for (int j = 0; j < _array1.GetLength(1); j++)
                    {
                        ret[i, k] += _array1[i, j] * _array2[j, k];
                    }
                }
            }

            return ret;
        }


        
        /// <summary>
        /// Сложение одномерной матрицы
        /// </summary>
        /// <param name="_array1">одномерная матрица</param>
        /// <param name="_array2">одномерная матрица</param>
        /// <returns>Вернет одномерную матрицу</returns>
        static int[] addition1(int[] _array1, int[] _array2)
        {
            
            if (! isArrayEqual(_array1, _array2))
            {
                ConsoleInfo("Матрицы не равны! Возврат максимальной, но пустой матрицы");
                return new int[Math.Max(_array1.GetLength(0), _array2.GetLength(0))];
            }

            int[] ret = new int[_array1.Length];

            for (int i = 0; i < _array1.Length; i++)
            {
                ret[i] = _array1[i] + _array2[i];

            }
            return ret;
        }

        /// <summary>
        /// Сложение двумерной матрицы
        /// </summary>
        /// <param name="_array1">двумерная матрица</param>
        /// <param name="_array2">двумерная матрица</param>
        /// <returns>Вернет двумерную матрицу</returns>
        static int[,] addition1(int[,] _array1, int[,] _array2)
        {
             if (! isArrayEqual(_array1, _array2))
            {
                ConsoleInfo("Двумерные матрицы не равны! Возврат максимальной, но пустой двумерной матрицы");
                // вернем максимальный массив
                return new int[Math.Max(_array1.GetLength(0), _array2.GetLength(0)), Math.Max(_array1.GetLength(1),_array2.GetLength(1))];
            }
            int[,] ret = new int[_array1.GetLength(0),_array1.GetLength(1)];

            for (int row = 0; row < _array1.GetLength(0); row ++)
            {
                for (int col = 0; col < _array1.GetLength(1); col ++)
                {
                    ret[row,col] = _array1[row,col] + _array2[row,col];
                }
                

            }
            return ret;
        }


        /// <summary>
        /// Вычитание одномерных матриц
        /// </summary>
        /// <param name="_array1">одномерная матрица</param>
        /// <param name="_array2">одномерная матрица</param>
        /// <returns>Вернет одномерную матрицу</returns>
        static int[] subtraction1(int[] _array1, int[] _array2)
        {

            if (!isArrayEqual(_array1, _array2))
            {
                ConsoleInfo("Матрицы не равны! Возврат максимальной, но пустой матрицы");
                return new int[Math.Max(_array1.GetLength(0), _array2.GetLength(0))];
            }

            int[] ret = new int[_array1.Length];

            for (int i = 0; i < _array1.Length; i++)
            {
                ret[i] = _array1[i] - _array2[i];

            }
            return ret;
        }

        /// <summary>
        /// Вычитание двухмерных матриц
        /// </summary>
        /// <param name="_array1">двумерная матрица</param>
        /// <param name="_array2">двумерная матрица</param>
        /// <returns>Вернет двумерную матрицу</returns>
        static int[,] subtraction1(int[,] _array1, int[,] _array2)
        {
            if (!isArrayEqual(_array1, _array2))
            {
                ConsoleInfo("Двумерные матрицы не равны! Возврат максимальной, но пустой двумерной матрицы");
                // вернем максимальный массив
                return new int[Math.Max(_array1.GetLength(0), _array2.GetLength(0)), Math.Max(_array1.GetLength(1), _array2.GetLength(1))];
            }
            int[,] ret = new int[_array1.GetLength(0), _array1.GetLength(1)];

            for (int row = 0; row < _array1.GetLength(0); row++)
            {
                for (int col = 0; col < _array1.GetLength(1); col++)
                { 
                    ret[row, col] = _array1[row, col] - _array2[row, col];
                }


            }
            return ret;
        }

        /// <summary>
        /// проверка равенства одномерного массивов
        /// </summary>
        /// <param name="_array1">массив 1</param>
        /// <param name="_array2">массив 2</param>
        /// <returns></returns>
        static bool isArrayEqual(int[] _array1, int[] _array2)
        {
            return _array1.Length == _array2.Length;
        }
        
        /// <summary>
        /// проверка равенства двумерных массивов
        /// </summary>
        /// <param name="_array1">массив 1</param>
        /// <param name="_array2">массив 2</param>
        /// <returns></returns>
        static bool isArrayEqual(int[,] _array1, int[,] _array2)
        {
            return _array1.GetLength(0) == _array2.GetLength(1) && _array1.GetLength(1) == _array2.GetLength(0);
        }

        

        /// <summary>
        /// Получить матрицу, заполненню случайными числами
        /// </summary>
        /// <param name="_length">Длина матрицы</param>
        /// <returns></returns>
        static int[] getRandomMatrix(int _length)
        {
            int[] ret = new int[_length];
            Random rand = new Random();
            for (int i = 0; i < _length; i++)
            {
                ret[i] = rand.Next(10);
            }
            return ret;
        }


        /// <summary>
        /// Получить двумерную матрицу
        /// </summary>
        /// <param name="_rows">Количество строк</param>
        /// <param name="_cols">Количество колонок</param>
        /// <returns></returns>
        static int[,] getRandomMatrix(int _rows, int _cols)
        {
            int[,] ret = new int[_cols, _rows];
            Random rand = new Random();
            for (int i = 0; i < _cols; i++)
            {
                for (int j = 0; j < _rows; j++)
                {
                    ret[i, j] = rand.Next(10);
                }
                
            }
            return ret;
        }

        /// <summary>
        /// Показать одномерную матрицу
        /// </summary>
        /// <param name="_matrix">Матрица</param>
        static void showMatrix(int[] _matrix)
        {
            string outString = "";
            foreach (int i in _matrix)
            {
                outString += i.ToString() + "\t";
            }
            ConsoleInfo(outString);
            ConsoleInfo("\n");
        }

        /// <summary>
        /// Показать двумерную матрицу
        /// </summary>
        /// <param name="_matrix">Матрица</param>
        static void showMatrix(int[,] _matrix)
        {
            string outString = "";
            int _rows = _matrix.GetLength(0);
            int _cols = _matrix.GetLength(1);

            for(int i= 0; i < _rows; i ++)
            {
                for (int j = 0; j < _cols; j++)
                {
                    outString += _matrix[i, j].ToString() + "\t";

                }
                ConsoleInfo(outString);
                outString = "";
            }
            ConsoleInfo("\n");
        }
        #endregion

        /// <summary>
        /// перевод введеной строки в число
        /// </summary>
        /// <param name="text">текст, который надо преобразовать</param>
        /// <returns>число (0- если не получилось преобразовать)</returns>
        static int KeyInputInt(string text)
        {
            string s = KeyInputString(text);

            int ret = 0;

            Int32.TryParse(s, out ret);

            return ret;
        }

        /// <summary>
        /// Метод ввода текста
        /// </summary>
        /// <param name="text">Сообщение для вывода пользователю</param>
        /// <returns>строка ввода</returns>
        static string KeyInputString(string text)
        {
            ConsoleInfo($"Input string ({text})");

            return Console.ReadLine();
        }
        static void ConsoleInfo(string text)
        {
            Console.WriteLine($"> {text}");
        }

        static void showH1(string _text)
        {
            ConsoleInfo($"***************{_text}***************\n");
        }


        static void showH2(string _text)
        {
            ConsoleInfo($"-------------{_text}-------------\n");
        }

        static void showH3(string _text)
        {
            ConsoleInfo($"---{_text}---\n");
        }


        static void MainMatrix()
        {
            showH1("Задание №1 (МАТРИЦА)");

            // Матрица №1
            int[] matrix1_1 = getRandomMatrix(5);
            showH3("Матрица 1 заполненная случайными числами\n");
            showMatrix(matrix1_1);
            // Матрица №2
            int[] matrix1_2 = getRandomMatrix(5);
            showH3("Матрица 2 заполненная случайными числами\n");
            showMatrix(matrix1_2);

            // Матрица №1 двумерная
            int[,] matrix2_1 = getRandomMatrix(4, 2);
            showH3("Матрица 2 заполненная случайными числами\n");
            showMatrix(matrix2_1);
            // Матрица №2 двумерная
            int[,] matrix2_2 = getRandomMatrix(4, 2);
            showH3("Матрица 2 заполненная случайными числами\n");
            showMatrix(matrix2_2);

            
            showH2("Умножение");
            // Умножение

            var a = multi1(matrix1_1, 5); // умножаем к примеру на 5
            showMatrix(a);

            var aa = multi1(matrix2_1, 7); // умножаем к примеру на 7
            showMatrix(aa);

            showH2("Сложение");

            showH3("Одномерная матрица №2");

            int[] b = addition1(matrix1_1, matrix1_2);
            showMatrix(b);

            showH3("Двумерная матрица №2");
            int[,] bb = addition1(matrix2_1, matrix2_2);
            showMatrix(bb);


            // Выводим сразу в консоль ответ от действий, без лишних переменных
            showH2("Вычитание");
            showH3("Одномерная матрица №2");
            showMatrix(subtraction1(matrix1_1, matrix1_2));

            showH3("Двумерная матрица №2");
            showMatrix(subtraction1(matrix2_1, matrix2_2));

            showH2("Умножение");
            showH3("Перемножение только двумерной матрицы");
            showH3("Создание третьей матрицы");
            int[,] matrix2_3 = getRandomMatrix(matrix2_1.GetLength(0), matrix2_1.GetLength(1));
            showMatrix(matrix2_3);
            showMatrix(multi1(matrix2_1, matrix2_3));
            Console.ReadKey();
        }

        #region 

        static List<string> getMaxLengthString(string _inputString)
        {
            string[] outString = _inputString.Split(' ');
            List<string> ret = new List<string>();
            int maxString = 0;
            for(int i = 0; i < outString.Length; i++)
            {
                outString[i] = outString[i].Trim();
                maxString = Math.Max(outString[i].Length, maxString);
            }
            ConsoleInfo($"Найдена максимальная строка длинной {maxString} символов. Подходящие слова под эту длину:");
            for (int i = 0; i < outString.Length; i++)
            {
                
                if (maxString == outString[i].Length )
                {
                    ConsoleInfo($"{outString[i]}");
                    ret.Add(outString[i]);
                }
            }
            return ret;
        }

        static List<string> getMinLengthString(string _inputString)
        {
            string[] outString = _inputString.Split(' ');
            List<string> ret = new List<string>();
            int minString = int.MaxValue;
            for (int i = 0; i < outString.Length; i++)
            {
                outString[i] = outString[i].Trim();
                minString = Math.Min(outString[i].Length, minString);
            }
            ConsoleInfo($"Найдена минимальная строка длинной {minString} символов. Подходящие слова под эту длину:");
            for (int i = 0; i < outString.Length; i++)
            {

                if (minString == outString[i].Length)
                {
                    ConsoleInfo($"{outString[i]}");
                    ret.Add(outString[i]);
                }
            }
            return ret;
        }

        static void MainText()
        {
            showH1("Задание 2. Тексты");


            string inputString = "";
            inputString = KeyInputString("Введите предложение ");
            getMaxLengthString(inputString);

            getMinLengthString(inputString);

            Console.ReadKey();
        }
        #endregion

        #region
        static string TrimText(string _string)
        {
            if (_string.Trim().Length == 0) return "";

            string ret = "";

            string _last = "";
            foreach (char _char in _string)
            {
                if (_last == _char.ToString().ToLower())
                {
                    continue;
                }
                else
                {
                    ret += _char;
                }
                _last = _char.ToString().ToLower();
            }

            return ret;
        }
        static void MainTrimText()
        {
            showH1("Задание 3. Удаление дублей символов в строке");
            string inputString = KeyInputString("Введите строку ");
            showH2("Строка без дублей");
            ConsoleInfo($"{TrimText(inputString)}");

            Console.ReadKey();
        }
        #endregion

        #region
        private static void MainProgressiveCheck()
        {
            showH1("Задание 4. Проверка на прогрессию");
            string inputString = KeyInputString("Введи последовательность");
            if (inputString.Trim() == "")
            {
                return;
            }

            string[] listString = inputString.Split();


            List<int> listInt = new List<int>();
            foreach (string line in listString)
            {
                if (line.Trim() == "") continue;
                int tmp = 0;
                int.TryParse(line, out tmp);
                if (listInt.IndexOf(tmp) > -1) { continue; }
                listInt.Add(tmp);


            }
            if (listInt.Count < 2)
            {
                ConsoleInfo("В массиве меньше 2 чисел.");
                return;
            }
            listInt.Sort(); // сортируем
            bool isProgressive = true;
            int delta = listInt[1] - listInt[0];
            for (int i = 2; i < listInt.Count; i++)
            {
                int _delta = listInt[i] - listInt[i - 1];
                if (_delta != delta && _delta % delta != 0)
                {
                    isProgressive = false;
                    break;
                }
            }

            ConsoleInfo($"Это прогрессия - {isProgressive}");

            Console.ReadKey();
        }
        #endregion

        static void Main(string[] args)
        {

            MainMatrix(); // Задание 1

            MainText(); // Задание 2

            MainTrimText(); // Задание 3

            MainProgressiveCheck(); // Задание 4
        }

       
    }
}
