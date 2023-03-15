// Как посмотреть содержимое папки?/

// string path = "C:/Users/Val/Desktop"; //путь к папке
// DirectoryInfo di = new DirectoryInfo(path); //информация о папке или файле.
// System.Console.WriteLine(di.CreationTime); //дата создания папки (CreationTime)
// FileInfo[] fi = di.GetFiles(); //какие файлы есть в папке. Класс FileInfo , который содержит информацию о конкретном файле

// for (int i=0; i <fi.Length; i++) // циклом пробегаемся по всем элементам
// {
//     System.Console.WriteLine(fi[i].Name); //вызываем свойство, в нашем случае Name
// }

//а теперь опишем рекурси, которая будет ходить по папкам и смотреть, что же там внутри.

// void CatalogInfo(string path, string indent = "") // Метод называется CatalogInfo. В качестве аргумента принимаем путь к текущей папке (string path), а в качестве второго аргумента используем искусственный приём, позволяющий делать отступы, чтобы примерно видеть структуру папки (string indent = "")
// {
// DirectoryInfo catalogs = new DirectoryInfo(path); //Далее получаем информацию о той директории, в которую зашли, по указанному пути
// foreach (var currentCatalog in catalogs.GetDirectories())  //Далее получаем информацию о той директории, в которую зашли, по указанному пути
//     {
//         Console.WriteLine($"{indent}{currentCatalog.Name}"); //выводя информацию о текущем каталоге мы будем рекурсивно заныривать и, соответственно, смотреть все папки, которые получим на этапе (DirectoryInfo catalogs)
//         CatalogInfo(currentCatalog.FullName, indent + " ");
//     }
// foreach (var item in catalogs.GetFiles()) //После того как закончим вывод папок, получим весь список файлов в текущей директории текущего каталога 
//     {
//         Console.WriteLine($"{indent}{item.Name}"); //и покажем их.
//     }
// }
// string path = @"C:/Users/Val/Desktop";
// CatalogInfo(path);

// //http://rebus1.com/index.php?item=tower
// //Игра в пирамидки
// void Towers(string with = "1", string on = "3", string some = "2", int count = 3) //Сделаем шпиль (with = "1") рабочим и возьмём из него текущий блинчик. Вторым аргументом передадим шпиль, на котором должна оказаться пирамидка (on = "3") Далее дадим название нашему промежуточному шпилю, потому что всего их по умолчанию три (some = "2")  и укажем, какое количество блинов есть всего (count = 3)
// {
//     if (count > 1) Towers(with, some, on, count - 1);
//     Console.WriteLine($"{with} >> {on}");
//     if (count > 1) Towers(some, on, with, count - 1);
// }

// Towers();
// //Затем запустим метод и посмотрим, что конкретно потребуется выполнить для трёх пирамидок
// // Итак, мы должны с 1 шпиля переместить блины на 3, а с 1 — на 2. Соответственно, с 1 — на 3, с 1 — на 2. Дальше с 3 — на 2, с 1 — на 3. С 3 — на 2, с 1 — на 3, далее со 2 — на 1, со 2 — на 3. Со 2  — на 1, со 2 — на 3. И далее с 1 — на 3. Как видите, наш алгоритм отработал 

// //Обход разных структур
// //((4 - 2) * (1 + 3)) / 10
// string emp = String.Empty;
// string[] tree = { emp, "/", "*", "10", "-", "+", emp, emp, "4", "2", "1", "3" }; // у нас есть одномерный массив, представляющий собой дерево. emp мы используем, чтобы вся строчка помещалась без горизонтального скролла
// // 0 1 2 3 4 5 6 7 8 9 10 11
// void InOrderTraversal(int pos = 1) //Дальше описываем метод, позволяющий делать обход. в качестве аргумента указываем ту позицию, с которой будем начинать этот обход (pos = 1)
// {
//     if (pos < tree.Length) // и делаем проверку. То есть если наша позиция вылетела за количество элементов, хранящихся в нашем дереве, на этом наша рекурсия закончится
//     // Это условие продолжения, когда позиция превзошла количество узлов в нашем дереве
//     {
//         int left = 2 * pos; //Далее считаем позицию левого поддерева. Левая часть находится на позиции 2i, или 2 pos в моём случае. 
//         int right = 2 * pos + 1; //а правая — на 2i+1
//         if (left < tree.Length && !String.IsNullOrEmpty(tree[left])) InOrderTraversal(left); //Затем делаем проверку. Если есть левое поддерево, мы не вылетаем за границы нашего дерева (left < tree.Length), и элемент, который там хранится, не считается пустым (&& !String.IsNullOrEmpty(tree[left])), например, ситуация 6 и 7 здесь обозначена специально,  надо рекурсивно запустить обход дерева с текущей позиции (InOrderTraversal(left))
//         Console.WriteLine(tree[pos]); //Далее выводим узел, в нашем случае будет значение конкретной операции или числа
//         if (right < tree.Length && !String.IsNullOrEmpty(tree[right])) InOrderTraversal(right); // и аналогичным образом делаем для правого поддерева. Если правое поддерево существует, и элемент, в который мы попали, непустой, надо рекурсивно запустить обход 
//     }
// }

// InOrderTraversal();


// //Проблема рекусрии - долгое время подсчётов
// //сравнение подходов при вычислении чисел фибоначчи
// decimal fRec = 0; // есть две переменные, одна из которых будет использоваться для подсчёта вызова рекурсии, рекурсивного метода
// decimal fIte = 0; // а вторая — считать количество итераций цикла для итеративного подхода

// decimal FibonacciRecursion(int n)
// {
//     fRec++;
//     return n == 0 || n == 1 ? 1 : FibonacciRecursion(n - 1) + FibonacciRecursion(n - 2);
// }

// decimal FibonacciIteration(int n)
// {
//     fIte++;
//     decimal result = 1;
//     decimal f0 = 1;
//     decimal f1 = 1;
//     for (int i=2; i <= n; i++)
//     {
//         result = f0 + f1;
//         f1 = result;
//         fIte++;
//     }
//     return result;
// }


// //# 1 2 3 4 5 6
// //V 1 1 2 3 5 8 
// Console.ReadLine(); // Console.ReadLine используется, чтобы после запуска можно было сделать консоль больше.
// DateTime dt = DateTime.Now; //выведем время
// for (int n = 30; n < 40; n++) // В цикле для начала я запускаю итеративный подсчёт чисел Фибоначчи.
// {
//     Console.WriteLine($"FibonacciIteration({n}) = {FibonacciIteration(n)} fIte = {fIte}"); 
//     //Console.WriteLine($"FibonacciIteration({n}) = {FibonacciIteration(n)} fIte = {fIte.ToString("### ### ###"), -15}"); 
//     //Сделаем более красивую маску — мы сильно вылетим за пределы, и будет горизонтальная прокрутка, зато наглядно
//     // текстом показываю значение {n}, для какого числа мы считаем, само значение (n) и то, сколько итераций цикла произошло (fIte.ToString)
//     fIte = 0; //После того как посчитали очередное число, обнуляем fIte. и на новой итерации этого цикла, то есть для следующего числа Фибоначчи, будем иметь новое представление этого значения
// }
// System.Console.WriteLine((DateTime.Now - dt).TotalMilliseconds);


// Console.WriteLine();
// Console.ReadLine();

// dt = DateTime.Now; //выведем время и для рекурсивного подхода

// for (int n = 30; n < 40; n++)
// {
//     Console.WriteLine($"FibonacciRecursion({n}) = {FibonacciRecursion(n)} fRec = {fRec}");
//     //Console.WriteLine($"FibonacciRecursion({n}) = {FibonacciRecursion(n)} fRec = {fRec.ToString("### ### ###"), -15}");
//     //Аналогичным образом делаем всё для рекурсивного подхода, только здесь станет выводиться своя переменная и составляться будет она же
//     fRec = 0;
// }
// System.Console.WriteLine((DateTime.Now - dt).TotalMilliseconds);

// //код зациклился или долго отрабатывает. похоже снизу ещё есть строки, но их не показали.

// //переполнение стека
// int i =0;
// void Rec()
// {
//     System.Console.WriteLine(i++);
//     Rec();
// }

// // Rec();

// int[,] pic = new int[1000, 1000];
// for (int i = 0; i < 1000; i++)
// {
//  pic[0, i] = 1;
//  pic[i, 0] = 1;
//  pic[i, 999] = 1;
//  pic[999, i] = 1;
// }