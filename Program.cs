using System;

namespace HomeWork5._5
{
    
    class Program
    {
        /// <summary>
        /// Умножение матрицы на число
        /// </summary>
        /// <param name="_array">Матрица исходная</param>
        /// <param name="mult">Множитель</param>
        /// <returns>Вернет матрицу</returns>
        static int[] multi1 (int[] _array, int mult)
        {
            Console.WriteLine($"Перемножение одномерной матрицы на {mult}");
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
            Console.WriteLine($"Перемножение двумерной матрицы на {mult}");

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
            Console.WriteLine($"Перемножение двумерных матриц");

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


        static void ConsoleInfo(string text)
        {
            Console.WriteLine($"> {text}");
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
            Console.WriteLine($"Input string ({text})");

            return Console.ReadLine();
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
            Console.WriteLine(outString);
            Console.WriteLine("\n");
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
                Console.WriteLine(outString);
                outString = "";
            }
            Console.WriteLine("\n");
        }


        static void showH1(string _text)
        {
            Console.WriteLine($"***************{_text}***************\n");
        }


        static void showH2(string _text)
        {
            Console.WriteLine($"-------------{_text}-------------\n");
        }

        static void showH3(string _text)
        {
            Console.WriteLine($"---{_text}---\n");
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

        static void Main(string[] args)
        {

            // Вызов задания по матрицам
            MainMatrix(); // Задание 1

        }

    }
}
