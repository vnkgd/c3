﻿// // Рекурсия 2 Собираем строку с числами от a до b, a≤b
// string NumbersFor(int a, int b)
// {
//  string result = String.Empty;
//  for (int i = a; i <= b; i++) //Запускаем цикл, который будет менять счётчик от значения а, меньшим или равным б.   Соответственно,

//  {
//  result += $"{i} "; // Врезультирующую строку будем собирать конкретное значение счётчика. 
//  }
//  return result;
// }
// string NumbersRec(int a, int b)
// {
//  if (a <= b) return $"{a} " + NumbersRec(a + 1, b); //В то же время, используя рекурсию, надо прописать условие окончания. если а меньше или равно b, собираем строку с текущим значением а и вызываем новую копию метода со значениями аргументов. Первый увеличится на 1
//  else return String.Empty; // — в нашем случае оно указано в ветке else, когда возвращаем пустую строку, если условие не выполнилось.
// }
// Console.WriteLine(NumbersFor(1, 10)); // 1 2 3 4 5 6 7 8 9 10
// Console.WriteLine(NumbersRec(1, 10)); // 1 2 3 4 5 6 7 8 9 10


// //Собираем строку с числами от a до b, a≤b

// string NumbersFor(int a, int b)
// {
//  string result = String.Empty;
//  for (int i = a; i >= b; i--)
//  {
//  result += $"{i} ";
//  }
//  return result;
// }
// string NumbersRec(int a, int b)
// {
//  if (a <= b) return NumbersRec(a + 1, b) + $"{a} ";
//  else return String.Empty;
// }
// Console.WriteLine(NumbersFor(1, 10)); // 10 9 8 7 6 5 4 3 2 1
// Console.WriteLine(NumbersRec(1, 10)); // 10 9 8 7 6 5 4 3 2 1

// //Сумма чисел от 1 до n
// int SumFor(int n)
// {
//  int result = 0;
//  for (int i = 1; i <= n; i++) result += i;
//  return result;
// }
// int SumRec(int n)
// {
//  if (n == 0) return 0; //Если использовать рекурсию, потребуется прописать условия выхода, а условие выхода здесь — n, равное нулю. В этом случае будем возвращать нейтральный по значению элемент.
//  else return n + SumRec(n - 1); //Если число отлично от 0, возвращаем текущее значение n и рекурсивный вызов функции с аргументом на 1 меньше.
// }
// Console.WriteLine(SumFor(10)); // 55
// Console.WriteLine(SumRec(10)); // 55

// //Факториал числа - В нашем случае факториалом числа называется произведение чисел от 1 до n.

// int FactorialFor(int n) // используя итеративный подход, мы описываем функцию, принимающую значение того самого n, факториал которого требуется найти.
// {
//  int result = 1; //заводим некоторую результирующую переменную, по умолчанию будет нейтральный по умножению элемент — 1

//  for (int i = 1; i <= n; i++) result *= i; //Далее идёт цикл от 1 до момента, пока i меньше или равно n. Соответственно, будем домножать результат на текущее значение i, 
//  return result; //а после этого — возвращать результат.
// }
// int FactorialRec(int n) // Если у нас рекурсивный подход
// {
//  if (n == 1) return 1; // обязательное условие выхода — то, что n, аргумент нашей функции, стал равен 1. В этом случае будем возвращать 1. Кстати, по-хорошему надо описать ещё и 0, потому что 0! тоже считается 1.
//  else return n * FactorialRec(n - 1); //И остальные условия, когда мы будем возвращать текущее значение n, умноженное на вызов рекурсивной функции с аргументом на 1 меньше. 
// }
// Console.WriteLine(FactorialFor(10)); // 3628800 // А результат будет одинаковым.
// Console.WriteLine(FactorialRec(10)); // 3628800

// //Вычислить а в степени n
// int PowerFor(int a, int n) //n — это показатель степени 
// { int result = 1;
//  for (int i = 1; i <= n; i++) result *= a; //если мы будем использовать такой подход, то простой итеративный метод будет выглядеть как перебор счётчика от 1 до n и домножения результата на текущее значение так называемогооснования степени
//  return result;
// }
// int PowerRec(int a, int n) // 
// { //return n == 0 ? 1 : PowerRec(a, n - 1) * a; // если хотите уменьшить число строк, то язык C# позволяет использовать так называемый тернарный оператор. И та конструкция, которая написана на двух строчках, записывается и одной строкой — return n = 0?1: и так далее
//  if (n == 0) return 1; //В случае же рекурсивного подхода сразу опишем условия выхода — начнём читать код от «если n равно 0, то возвращаем единицу» Не рассматриваем 0, как некую неопределённость. И договоримся, что 0 0 для нашего случая будет 1
//                        //если показатель степени равен 0, будем возвращать 1
//  else return PowerRec(a, n - 1) * a; //иначе — запустим рекурсивный подсчёт, там текущее значение а будет домножаться на вызов рекурсивной функции, где в качестве аргумента передаём основания нашей степени и показатель на 1 меньше
// }
// int PowerRecMath(int a, int n) //используем формулу из математики.
// {
//  if (n == 0) return 1;
//  else if (n % 2 == 0) return PowerRecMath(a * a, n / 2);
//  else return PowerRecMath(a, n - 1) * a;
// }
// Console.WriteLine(PowerFor(2, 10)); // 1024
// Console.WriteLine(PowerRec(2, 10)); // 1024
// Console.WriteLine(PowerRecMath(2, 10)); // 1024

// //Перебор слов
// char[] s = { 'а', 'и', 'с','в'}; //   пусть у нас будет алфавит, который будет храниться в массиве символов
// int count = s.Length;
// int n = 1;
// for (int i = 0; i < count; i++) // Далее возьмём один цикл и переберём все эти буквы. У нас получатся однобуквенные слова
// {
//     for (int j = 0; j < count; j++) // Если потребуются двухбуквенные слова, мы уже должны будем использовать цикл в цикле.
//     {
//         for (int k = 0; k < count; k++) //Соответственно, если нам потребуется использовать трёхбуквенные слова, придётся делать цикл в цикле, заключив всё в ещё один цикл. И так далее.
//         {
//             for (int l = 0; l < count; l++)
//             {
//                 for (int m = 0; m < count; m++)
//                     {
//                         Console.WriteLine($"{n++,-5}{s[i]}{s[j]}{s[k]}{s[l]}{s[m]}");
//                     }
//             }
//         }
//     }
// }

// //Общее решение
// int n = 0;
// void FindWords(string alphabet, char[] word, int length = 0) //у нас будет метод, который примет тот самый алфавит (alphabet) — передадим его просто строкой. далее будет массив из букв (word), которые составят новое слово; затем на текущей итерации вызова рекурсии будет собираться длина (length) самого этого слова.
// {
//     if (length == word.Length) // Описываем условия выхода из рекурсии. То есть если длина нашего массива как раз таки совпала с текущей длиной, которую получили на текущем вызове рекурсии,
//     {
//         Console.WriteLine($"{n++} {new String(word)}"); return; // тогда будем просто показывать получившееся слово и на этом заканчивать.
//     }
//         for (int i = 0; i < alphabet.Length; i++) //В противном случае потребуется запустить цикл по всем элементам нашего алфавита, чтобы собрать очередное слово.
//     {
//         word[length] = alphabet[i];
//         FindWords(alphabet, word, length + 1);
//     }
// }

// FindWords("аисв", new char[2]); //2 это двух буквенные значения, 3 это трёх буквенные и т.д.

//Как посмотреть содержимое папки?/

// string path = "E:/Git";
// DirectoryInfo di = new DirectoryInfo(path);
// System.Console.WriteLine(di.CreationTime);

void CatalogInfo(string path, string indent = "")
{
 DirectoryInfo catalogs = new DirectoryInfo(path);
 foreach (var currentCatalog in catalogs.GetDirectories())
 {
 Console.WriteLine($"{indent}{currentCatalog.Name}");
 CatalogInfo(currentCatalog.FullName, indent + " ");
 }
 foreach (var item in catalogs.GetFiles())
 {
 Console.WriteLine($"{indent}{item.Name}");
 }
}
string path = @"/Users/Val/Desktop/";
CatalogInfo(path);