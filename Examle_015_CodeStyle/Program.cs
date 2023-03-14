// Красивый код

using System.Linq; // используем системные библиотеки.

//int a = 12; //даже если написать var вместо int, всё равно покажет Int32. заранее записывать не надо.
//Console.WriteLine(a.GetType()); //узнаём тип данных. в ответ пришло System.Int32 c .Name возвращает только Int32

var data = new int[] {1,2,3,4}
            .Where(e=> e>0)
            .Select(e=> new{q = e, w = e + 1});
Console.WriteLine(data.GetType().Name);    

//a = 123; // так делать не надо