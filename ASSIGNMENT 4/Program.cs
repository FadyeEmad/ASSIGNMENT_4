#region Q1
// VALUE TYPE PARAMETERS
// PASSING BY VALUE -> ببعت نسخه من المتغير استخدمها في الفانكشن و اي تعديلات بتحصل عليها مش بتاثر علي المتغيرات الاساسيه لانها مجرد نسخه من القيم
static void swap(int x, int y)
{
    int temp = x;
    x = y;
    y = temp;
}
//MAIN
int x = 5, y = 10;
swap(x, y); // x و y هيفضلوا بنفس القيم بتاعتهم مش هتتغير ولا تتبدل علشان انا بعت نسخه من المتغير للفانكشن مش المتغير نفسه

//PASSING BY REF -> ببعت المتغير نفسه للفانكشن و اي تغيير بيحصل في قيمته بياثر علي المتغير الاساسي علشان انا باعت المتغير نفسه مش نسخه منه

static void swap(ref int x, ref int y)
{
    int temp = x;
    x = y;
    y = temp;
}
//MAIN
int x = 5, y = 10;
swap(ref x, ref y); // x و y قيمهم هتتبدل علشان هنا انا بعت المتغير نفسه للفانكشن ف لما بدلت القيم المتغير الاساسي قيمته اتبدلت 

#endregion


#region Q2
// REFRENCE TYPE PARAMETERS

// PASSING BY VALUE 
static int sumarray(int[] arr)
{
    int[] arr2 = [5, 6, 7];
    arr = arr2;
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        sum += arr[i];
    }
    return sum;
}
//MAIN
int[] arr1 = [1, 2, 3];
Console.WriteLine(arr1[0]); // output = 1
sumarray(arr1);
Console.WriteLine(arr1[0]); // output = 1 

//PASSING BY REF

static int sumarray(ref int[] arr)
{
    int[] arr2 = [5, 6, 7];
    arr = arr2;
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        sum += arr[i];
    }
    return sum;
}
//MAIN
int[] arr1 = [1, 2, 3];
Console.WriteLine(arr1[0]); // output = 1
sumarray(ref arr1);
Console.WriteLine(arr1[0]); // output = 5


#endregion


#region Q3

static void sum(int x, int y, out int sum, out int subt)
{
    sum = x + y;
    subt = x - y;
}


int sumres, subtres;
int x = int.Parse(Console.ReadLine());
int y = int.Parse(Console.ReadLine());
sum(x, y, out sumres, out subtres);
Console.WriteLine($" sum = {sumres} _____________ subtract = {subtres} ");


#endregion


#region Q4

static int digit_of_num(int x)
{
    int num_digit = 0, sum = 0;
    for (int i = 1; sum < x; i++)
    {
        sum += i;
        num_digit++;
    }
    return num_digit;
}

Console.WriteLine(digit_of_num(25));


#endregion


#region Q5

static bool is_prime(int x)
{
    bool res = false;
    int check = 0;
    for (int i = 2; i < x; i++)
    {
        if (x % i == 0 && x != i)
        {
            check++;
        }

    }
    if (check == 0)
    {
        res = true;
    }
    return res;
}
int x = int.Parse(Console.ReadLine());
Console.WriteLine(is_prime(x));

#endregion


#region Q6
static void max_min(int[] arr, ref int max, ref int min)
{
    max = 0;
    min = 9 ^ 10;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > max)
        {
            max = arr[i];
        }
        if (arr[i] < min)
        {
            min = arr[i];
        }
    }
}

int[] arr1 = [15, 20, 60, 10, 13, 9];
int max = 0, min = 0;
max_min(arr1, ref max, ref min);
Console.WriteLine($" max = {max} ____________ min = {min}");

#endregion


#region Q7

static int factorial(int x)
{
    int fac = 1;
    for (int i = 1; i <= x; i++)
    {
        fac *= i;
    }
    return fac;

}
int m = int.Parse(Console.ReadLine());
Console.WriteLine(factorial(m));


#endregion


#region Q8

static string change_char(string text, int num_of_index, char x)
{
    char[] arr = text.ToCharArray();
    arr[num_of_index] = x;

    return new string(arr);
}
Console.WriteLine("write string");
string x = Console.ReadLine();
Console.WriteLine("write num of index you will change");
int m = int.Parse(Console.ReadLine());
Console.WriteLine($"enter char you want put it ");
char c = Console.ReadKey().KeyChar;
Console.WriteLine();
Console.WriteLine(change_char(x, m, c));

#endregion