//Задача 25: Напишите цикл, который принимает на вход 
//два числа (A и B) и возводит число A в натуральную степень B.

int MetPow(int a, int n)
{
    int res = a;
    for(int i = 1;i<n;i++)
    {
        res*=a;
    }
    return res;
}

Console.WriteLine("Введите число ");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите степень ");
int N = Convert.ToInt32(Console.ReadLine());
int result = MetPow(A,N);
Console.WriteLine($"{result}");

//Задача 27: Напишите программу, которая принимает на вход число 
//и выдаёт сумму цифр в числе.

int SummaChisel(int num)
{
    int sum=0;
    //int proizv=1;
    while(num>0)
    {
        int chislo= num%10;
        sum+=chislo;
        //proizv*=chislo;// так же можно сделать и произведение чисел
        num=num/10;
    }
    return sum;//proizv;
}
Console.WriteLine("Введите число ");
int n = Convert.ToInt32(Console.ReadLine());
int result = SummaChisel(n);
Console.WriteLine($"Сумма чисел числа {n} = {result}");

//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и 
//выводит их на экран.

void ShowArray(int[] array)// метод выводит массив
{
    for(int i =0;i<array.Length; i++)
    {
        Console.Write(array[i] + " ");
       
    }
     Console.WriteLine();
}

int [] CreateArray(int size)
{
 int[] array = new int[size]; //выделили память
    for(int i = 0;i<size;i++)
    {
        Console.Write($"Введите элемент массива под индексом {i}:\t");
        array[i]= Convert.ToInt32(Console.ReadLine());//заполнение массива с консоли
    }
    return array;
}
Console.Write("Введите кол-во элементов массива ");
int length = Convert.ToInt32(Console.ReadLine());
int [] myArray = CreateArray(length);
Console.Write("Вывод массива:\t ");
ShowArray(myArray);