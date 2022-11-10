{
//Задание-1
string input = Console.ReadLine(); 
if (int.TryParse(input, out int n)) 
{
    List<char> dighits = new(); 
    dighits = n.ToString().ToCharArray().ToList(); 

    var ordered_dighits = dighits.OrderByDescending(x => x).ToList(); 
    double bigest = double.Parse(string.Join("", ordered_dighits));
    Console.WriteLine($"Bigest number is {bigest}"); 
    double qur = Math.Pow(bigest, 2);
    Console.WriteLine($"Sqr of number is {qur}");
}
else
{
    Console.WriteLine("Set a correct number");
}


// Задание - 2
string input = Console.ReadLine(); 
if (int.TryParse(input, out int n)) 
{
    List<char> dighits = new(); 
    dighits = n.ToString().ToCharArray().ToList();
    dighits.RemoveAt(0);
    dighits.RemoveAt(dighits.Count - 1);
    string res = string.Join("", dighits);
    Console.WriteLine($"Result is is {res}"); 

}
else
{
    Console.WriteLine("Set a correct number"); 
}
//Задание - 3
string input1 = Console.ReadLine(); 
string input2 = Console.ReadLine(); 
string input3 = Console.ReadLine(); 


if (int.TryParse(input1, out int _in1) && int.TryParse(input2, out int _in2) && int.TryParse(input3, out int _in3)) 
{

    int total = _in1 + _in2 + _in3; 
    double res = total / 3.0; 
    string _res = res.ToString("N8"); 
    Console.WriteLine($"Result is {_res}"); 
}
else 
{
    Console.WriteLine("Set a correct numbers!"); 
//Задание - 4
string input = Console.ReadLine(); 

if (int.TryParse(input, out int _input_int)) 
{
    var dighit = input.ToCharArray().ToList(); 
    List<char> good_dighit = new(); 
    foreach (char c in dighit) 
    {
        int check = int.Parse(c.ToString()); 
        if (check % 2 == 0) good_dighit.Add(c); 

    }

    if (good_dighit.Count > 0) 
        Console.WriteLine($"Result is {string.Join("", good_dighit)}"); 
    else Console.WriteLine($"Число не содержит четных цифр");

}
else
{
    Console.WriteLine("Set a correct number");
}
//Задание - 5
string input = Console.ReadLine();

if (int.TryParse(input, out int temp))
{
    var dighit = input.ToArray().ToList();
    if (dighit.Count == 5)
    {
        dighit.RemoveAt(3);
    }
    Console.WriteLine($"Result is {string.Join("", dighit)}");
}
else
{
    Console.WriteLine("Set a correct number!");
}
//Задание - 6
int[] a = { 1,2,10,3,4,18,5,6,1 };
int best_count = 0;

for (int i = 0; i < a.Length; i++)
{
    if (i == 0) continue;
    if (i == a.Length - 1) continue;

    int _this_int = a[i];
    int _before_int = a[i - 1];
    int _after_int = a[i + 1];

    if (_this_int > _before_int && _this_int > _after_int) best_count++;
}
Console.WriteLine($"Таких чисел: {best_count}");
}
