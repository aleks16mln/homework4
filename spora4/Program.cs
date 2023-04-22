// Массивы - коллекция однотипных данных
// т.е. несколько значений одного типа данных
// массивы могут быть любого типа данных
// чтобы получить массив надо написать: тип_данных[]

// Определение массива:
// со значением
// int[] array = new int[] { 1, 2, 3 }; // в массиве сразу будут значения [1, 2, 3]
// int[] array = { 1, 2, 3 }; // или так (без new тип_данных[])
// int[] array = { "один", "два", "три" }; // так не получится, нужен правильный тип данных
// string[] stringArray = new string[] { "один", "два", "три" }; // ["один", "два", "три"]

// с указанием размера
// int[] array = new int[3]; // размер 3, заполняется значением по умолчанию: [0, 0, 0]

// Индексы массива: 
// индекс - номер элемента в массиве. индексы начинаются с 0
// int[] array = { 1, 2, 3 };
// int x = array[0]; // первый по счёту элемент массива, индекс 0
// Console.WriteLine(x); // 1
// array[0] = 5; // изменение первого элемента (с индексом 0) с 1 на 5
// Console.WriteLine(array[0]); // 5

// Длина массива:
// длина массива - количество его элементов
// int[] array = { 1, 2, 3 };
// int x = array.Length; // получение количества элементов (длины)
// Console.WriteLine(x); // 3

// Перебор массива:
// int[] array = { 1, 2, 3 };
// // Console.WriteLine(array); // C# скажет только то, что это массив, но не выведет элементов массива
// // индексы начинаются с 0, поэтому и цикл с 0
// // условие строго меньше длины, потому что последний индекс на 1 меньше длины
// for (int i = 0; i < array.Length; i++) 
// {
//     Console.WriteLine(array[i]); // Выведет 1, потом 2, потом 3
// }
// если условие <= то мы попытаемся обратиться к элементу массива с индексом, которого не существует
// и получим ошибку
// for (int i = 0; i <= array.Length; i++) 
// {
//     Console.WriteLine(array[i]); // Выведет 1, потом 2, потом 3
// }

// Строки - массивы букв
// string str = "Hello world";
// Console.WriteLine("Первый символ: " + str[0]); // выводим первый символ строки: буква H
// Console.WriteLine("Все символы строки в стоблик: ");
// for (int i = 0; i < str.Length; i++) 
// {
//     Console.WriteLine(str[i]); // Выведет все символы в столбик
// }
// Отличие строки от массива:
// string str = "Hello world";
// str[0] = 'T'; // ошибка: элементы строки нельзя изменять

// Функции (или методы - это одно и то же): 
// Объявление функций:
// тип_данных название_функции(входные_параметры)

// !!! ВАЖНО !!! 
// функция должна возвращать переменную (или значение) того же типа данных, что у неё перед названием

// Функция возвращающая результат:
// return - специальное ключевое слово. Оно возвращает результат, который записан после неё
// и останавливает выполнение функции
// int - тип_данных, GetSquare - название_функции, number - входной_параметр
// перед GetSquare тип данных int -> значит можем вернуть только целое число
// int GetSquare(int number)
// {
//     int square = number * number; // получаем квадрат числа
//     // return "hello";
//     return square; // возвращение результата и завершение функции
// }

// // Пример функции с несколькими параметрами
// int GetSum(int first, int second)
// {
//     return first + second;
// }

// // Пример функции с типом string
// string MakeString(string first, string second)
// {
//     string newString = $"{first} {second}";
//     return newString;
// }

// int x = GetSquare(6); // вызов функции
// Console.WriteLine(x); // 25
// int y = GetSum(5, 6); // вызов функции с несколькими параметрами (параметры указываются через запятую)
// Console.WriteLine(y); // 11
// string z = MakeString("Hello", "world"); // вызов функции с типом string
// Console.WriteLine(z); // Hello world

// !Пример нескольких return в функции + альтернативное решение задачи про число с консоли и день недели
// string GetWeekDay(int dayNumber) 
// {
//     if (dayNumber < 1 || dayNumber > 7)
//     {
//         return $"Не существует дня с номером {dayNumber}";
//     }

//     string[] weekDays = { "понедельник", "вторник", "среда", "четверг", "пятница", "суббота", "воскресенье" };
//     return weekDays[dayNumber - 1];
// }

// Console.WriteLine ("Введи номер дня: ");
// string textFromConsole = Console.ReadLine();
// int weekDayNumber = Convert.ToInt32(textFromConsole);
// Console.WriteLine();
// string weekDay = GetWeekDay(weekDayNumber);
// Console.WriteLine(weekDay);

// !Окончание примера

// Функция НЕ возвращающая результат:
// void - тип данных специально для функций, которые ничего не возвращают
// void PrintMessage(string message, int number) // void для функции, которая ничего не возвращает
// {
//     Console.WriteLine(message + " " + number);
// }

// PrintMessage("Моё сообщение номер: ", 5); // вызов функции
// PrintMessage("Моё сообщение номер: ", 6);
// PrintMessage("Моё сообщение номер: ", 7);


// Использование return для остановки функции
// void PrintMessage(string message, int number)
// {
//     if (number > 3)
//     {
//         Console.WriteLine("Слишком большой номер");
//         return; // если number > 3, то выводим сообщение и заканчиваем выполнение функции
//         // т.е. дальше выполнение кода не пойдёт
//     }
//     Console.WriteLine(message + " " + number);
// }

// PrintMessage("Моё сообщение номер: ", 4); // вызов функции

// какая-то программа: считывает число с консоли и возвращает его квадрат
// Все функции лучше описывать в начале программы (сверху)
// int GetSquare(int number)
// {
//     return number * number;
// }

// string str = Console.ReadLine();
// int x = int.Parse(str);
// x = GetSquare(x);
// Console.WriteLine(x);


// Распространённая ошибка:
// Лишние действия 2 и 3: 
// 1. Читаем строку (string) с консоли - Console.ReadLine()
// 2. Переводим строку в число - int.Parse
// 3. Переводим число в строку - Convert.ToString
// Ошибка: если нам нужна только строка, то результат Console.ReadLine() не надо переводить в число
// int num = int.Parse(Console.ReadLine());
// string str = Convert.ToString(num); // число в строку

// Правильное решение:
// string str = Console.ReadLine();
