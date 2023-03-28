
using System.Text.RegularExpressions;




////ЗАДАНИЕ 2(E)
//string[] text = new string[5];
//Console.WriteLine("Введите строки: ");
//for (int i = 0; i < text.Length; i++)
//{
//    text[i] = Console.ReadLine();
//}

//Regex regex = new Regex("^[A-Fa-f0-9]{8}-[A-Fa-f0-9]{4}-[A-Fa-f0-9]{4}-[A-Fa-f0-9]{4}-[A-Fa-f0-9]{12}$");

//for (int i = 0; i < text.Length; i++)
//{
//    if (regex.IsMatch(text[i]))
//    {
//        Console.WriteLine(text[i]+"\tСтрока является корректным GUID.");
//    }
//    else
//    {
//        Console.WriteLine(text[i]+"\tСтрока не является корректным GUID.");
//    }
//}





////ЗАДАНИЕ 2(D)
//string[] text = new string[5];
//Console.WriteLine("Введите строки: ");
//for (int i = 0; i < text.Length; i++)
//{
//    text[i] = Console.ReadLine();
//}

//Regex regex = new Regex(@"^#([A-Fa-f0-9]{6})$");

//for (int i = 0; i < text.Length; i++)
//{
//    if (regex.IsMatch(text[i]))
//    {
//        Console.WriteLine(text[i] + "\tСтрока является шестнадцатиричным идентификатором цвета в HTML.");
//    }
//    else
//    {
//        Console.WriteLine(text[i] + "\tСтрока не является шестнадцатиричным идентификатором цвета в HTML.");
//    }
//}






////ЗАДАНИЕ 2(C)
//string[] text = new string[5];
//Console.WriteLine("Введите строки: ");
//for (int i = 0; i < text.Length; i++)
//{
//    text[i] = Console.ReadLine();
//}

//Regex regex = new Regex(@"ик\b");

//for (int i = 0; i < text.Length; i++)
//{
//    if (regex.IsMatch(text[i]))
//    {
//        Console.WriteLine(regex.Replace(text[i], ""));
//    }
//}





////ЗАДАНИЕ 2(B)
//string[] text = new string[5];
//Console.WriteLine("Введите строки: ");
//for (int i = 0; i < text.Length; i++)
//{
//    text[i] = Console.ReadLine();
//}

//Regex regex = new Regex(@"(\w+){10,}");

//Console.WriteLine("\n Замена на *: ");
//for (int i = 0; i < text.Length; i++)
//{
//    if (regex.IsMatch(text[i]))
//    {
//        Console.WriteLine(regex.Replace(text[i], "*"));
//    }
//}
//Console.WriteLine("\nЗамена на первую букву:");
//for (int i = 0; i < text.Length; i++)
//{
//    if (regex.IsMatch(text[i]))
//    {
//        Console.WriteLine(regex.Replace(text[i], match => match.Value.Substring(0, 1)));
//    }
//}
//Console.WriteLine("\nЗамена всего слова на первую букву:");
//for (int i = 0; i < text.Length; i++)
//{
//    if (regex.IsMatch(text[i]))
//    {
//        Console.WriteLine(regex.Replace(text[i], (match => new string(Convert.ToChar(match.Value.Substring(0, 1)), match.Value.ToString().Length))));
//    }
//}




////ЗАДАНИЕ 2(A)
//string[] text= new string[5];
//Console.WriteLine("Введите строки: ");
//for(int i=0; i<text.Length; i++)
//{
//    text[i]=Console.ReadLine();
//}

//Regex regex = new Regex(@"((cat).*){2,}");

//Console.WriteLine("\nСтроки, где 2 раза встречается \"cat\": ");
//bool signal = true;
//for(int i=0; i<text.Length; i++)
//{
//    if (regex.IsMatch(text[i])){
//        Console.WriteLine(text[i]);
//        signal=false;
//    }
//}
//if (signal)
//{
//    Console.WriteLine("\nПодходящих строк нет");
//}




////ЗАДАНИЕ 1(D)
//Console.WriteLine("Введите адрес: ");
//string str = Console.ReadLine();
////C:\Users\namename\Documents\fileeeee.txt

//Regex regex = new Regex(@"^[A-Za-z]:\\(?:[\w]+\\)*\w+\.\w+$");

//if (!regex.IsMatch(str))
//{
//    Console.WriteLine("Ошибка");
//    return;
//}

//Regex regex2 = new Regex(@"\\([\w ]+)");

//MatchCollection matches = regex2.Matches(str);

//Console.WriteLine("\nКаталоги:");
//foreach (Match match in matches)
//{
//    Console.WriteLine(match);
//}





////ЗАДАНИЕ 1(C)
//Console.WriteLine("Введите строку: ");
//string str = Console.ReadLine();

//Regex regex = new Regex(@"[+-]?\d+([,.]\d+)");

//if (!regex.IsMatch(str))
//{
//    Console.WriteLine("Ошибка");
//    return;
//}

//MatchCollection matchs = regex.Matches(str);

//Console.WriteLine("\nЧисла:");
//for (int i = 0; i < matchs.Count; i++)
//{
//    Console.Write(matchs[i] + " ");
//}

//string new_str = "number";
//Console.WriteLine("\n\nНовая строка:");
//Console.WriteLine(regex.Replace(str, new_str));





////ЗАДАНИЕ 1(B)
//Console.WriteLine("Введите строку: ");
//string str = Console.ReadLine();

//Regex regex = new Regex(@"\d+");

//MatchCollection matchs = regex.Matches(str);

//List<int> value = new List<int>();

//if (matchs.Count > 0)
//{
//    foreach (Match m in matchs)
//    {
//        value.Add(int.Parse(m.Value));
//    }

//    Console.WriteLine("\nЧисла: ");
//    for (int i = 0; i < value.Count; i++)
//    {
//        Console.Write(value[i].ToString() + " ");
//    }

//    int sum = 0;
//    for (int i = 0; i < value.Count; i++)
//    {
//        sum += value[i];
//    }
//    Console.WriteLine("\n\nСумма чисел = " + sum);

//    int max_index = 0;
//    for (int i = 0; i < value.Count; i++)
//    {
//        if (value[i] > value[max_index])
//        {
//            max_index = i;
//        }
//    }
//    Console.WriteLine($"\nМаксимальное число = {value[max_index]}\t Индекс = {max_index}");
//}
//else
//{
//    Console.WriteLine("\nОшибка");
//}





////ЗАДАНИЕ 1(А)
//Console.WriteLine("Введите строку: ");
//string str = Console.ReadLine();

//Regex regex = new Regex(@"abcd(2023)1{7}0\1");

//if (regex.IsMatch(str))
//{
//    Regex regex2 = new Regex(@"2023");
//    string new_s = "happynewyear";
//    Console.WriteLine(regex2.Replace(str, new_s));
//}
//else
//{
//    Console.WriteLine("Ошибка");
//}




