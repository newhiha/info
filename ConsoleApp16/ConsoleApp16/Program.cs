// See https://aka.ms/new-console-template for more information
//Задача
//int[] mas = new int[5] { 1, 8, 7, 4, 9 };
//for (int i = 0; i < mas.Length-1; i++)
//{
//    for(int j=i+1;j<mas.Length;j++)
//    {
//        if (mas[i]> mas[j])
//        {
//            int d = mas[i];
//            mas[i] = mas[j];
//            mas[j]=d ;
//        }
//    }
//}

//foreach(int d in mas)
//{
//    Console.WriteLine(d);
//}
//Console.ReadKey();
//Задача 1
//int n;
//n= int.Parse(Console.ReadLine());
//int[] mas = new int[n];
//Random random = new Random();
//for (int i = 0; i < mas.Length; i++)
//{
//     random.Next(1, 80);
//    Console.WriteLine($"mas[{i}]");
//    Console.WriteLine(random.Next(1, 80));

//}   
//Задача 2
//int[] mas = new int[12] { 5, 6, 1, -5, 64, 23, -4, -6, -13, 14, -1, 12 };

//for (int i = 0; i < mas.Length - 1; i++)
//{
//    for (int j = i+1; j < mas.Length; j++)
//    {
//        if (mas[i] < mas[j])
//        {
//            int d=mas[i];
//            mas[i]=mas[j];
//            mas[j]=d;
//        }
//    }
//}

//foreach (int d in mas)
//{
//    Console.WriteLine(d);
//}

//int max =mas[0];
//foreach(int i in mas)
//    if ( i> max) max = i;
//Console.WriteLine("max="+max);

//int min =mas[0];
//foreach(int i in mas)
//    if ( i< min) min = i;
//Console.WriteLine($"Cумма={min += max}") ;
//Console.ReadKey();
//Задача 3
