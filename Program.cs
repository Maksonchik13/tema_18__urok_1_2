////Тема 18. Урок 1

//string[] words = { "СОЛНЦЕ", "ЛУНА", "ЗЕМЛЯ", "МАРС", "ЮПИТЕР", "САТУРН" };
//string sentence = "";
//string word = "";
//do
//{
//    Console.WriteLine("Введите слово");
//     word = Console.ReadLine()!;
//    string up=word.ToUpper();
//    if (words.Contains(up))
//    {
//        sentence += "(скрыто) ";
//    }
//    else if (word!="конец")
//    {
//    sentence += word+" ";
//    }
//}
//while (word!="конец");

//Console.WriteLine(sentence);


//Тема 18. Урок 2

////задание 1
//Console.WriteLine("Введите строку из цифр, разделенных запятыми");
//string n=Console.ReadLine()!;
//string[] mas=n.Split(',');
//int sum = 0;
//for (int i = 0; i < mas.Length; i++)
//{
//    int a=int.Parse(mas[i]);
//    sum += a;
//}
//Console.WriteLine("Сумма = "+sum);

// задание 2
Console.WriteLine("Введите предложение");
string predlozh=Console.ReadLine()!;
string []mas1=predlozh.Split(" ");
Console.WriteLine("Количество слов в предложении = "+mas1.Length);