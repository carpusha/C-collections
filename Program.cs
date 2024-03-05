//List<int> listint = new List<int>();
//int[] Arr = {1, 2, 3};
//listint.Add(1);
//listint.Add(-2);
//listint.AddRange(Arr);
//listint.Insert(1, 3);
//listint.Sort();
//Console.WriteLine(listint.Count);
//for (int i = 0; i < listint.Count; i++)
//{
//    Console.Write(listint[i] + " ");
//}

//Dictionary<int,string> dic = new Dictionary<int,string>();
//dic.Add(1, "asd");
//dic.Add(2, "fdgd");

//foreach(KeyValuePair<int,string> item in dic)
//{
//    Console.WriteLine(item.Key + " " + item.Value);
//}

Console.Write("Введіть кількість людей в колі:");
int n = int.Parse(Console.ReadLine());

// Створення списку людей
List<int> people = new List<int>();
for (int i = 1; i <= n; i++)
{
    people.Add(i);
}

int position = 0;
while (people.Count > 1)
{
    // Видалення кожної другої людини
    position = (position + 1) % people.Count;
    people.RemoveAt(position);
}

// Виведення останньої залишеної людини
Console.WriteLine("Остання залишена людина: " + people[0]);






Console.ReadKey();
