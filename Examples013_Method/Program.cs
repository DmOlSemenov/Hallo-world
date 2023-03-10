Console.WriteLine("Введите номер задачи  ");
int i = int.Parse(Console.ReadLine ());
switch (i)
{
    case 1:
    {
        // Вид 1
        void Method1()
        {
            Console.WriteLine("Автор Семенов Д.О.");
        }
        Method1();
        break;
    }
    case 2:
    {
        //Вид 2
        void Method2 (string msg)
        {
            Console.WriteLine(msg);
        }
        //Method2("Текст сообщения");
        void Method21 (string msg, int count)
        {
            int i = 0;
            while(i < count)
            {
                Console.WriteLine(msg);
                i++;
            }   
        }
        Method21(msg: "Текст сообшения", count: 4);
        break;
    }
    case 3:
    {
        //Вид 3
        int Method3()
        {
            return DateTime.Now.Year;
        }
        int Year = Method3();
        Console.WriteLine(Year);
        break;
    }
    case 4:
    {
        //Вид 4
        string Method4 (int count, string text)
        {
            int i = 0;
            string result = string.Empty;
            while(i < count)
            {
                result = result + text;
                i++;
            }
            return result;
        }
        string res = Method4(5, "Привет");
        Console.WriteLine(res);
        break;
    }
    case 5:
    {
        string Method4 (int count, string text)
        {
            string result = string.Empty;
            for (int i = 0; i < count; i++)
            {
                result = result + text;        
            }
            return result;
        }
        string res = Method4 (5, "Привет");
        Console.WriteLine(res);
        break;
    }
    case 6:
    {
        for (int b = 2; b < 10; b++)
        {
            for (int j = 2; j < 10; j++)
            {
                Console.WriteLine($"{b} x {j} = {b * j}");      
            } 
            Console.WriteLine();       
        }
        break;
    }   
    case 7:
    {
        //=====Работа с текстом
        // Дан текст. В тексте нужно все пробелы заменить чёрточками,
        // маленькие буквы “к” заменить большими “К”,
        // а большие “С” маленькими “с”.
        // Ясна ли задача?
        string text = "— Я думаю, — сказал князь, улыбаясь, — что, "
                    + "ежели бы вас послали вместо нашего милого Винценгероде, "
                    + "вы бы взяли приступом согласие прусского короля. "
                    + "Вы так красноречивы. Вы дадите мне чаю?";
        string Replase (string text, char oldValue, char newValue)
        {
            string result = string.Empty;
            int length = text.Length;
            for (int i = 0; i < length; i++)
            {
                if (text[i] == oldValue) result = result + $"{newValue}";
                else result = result + $"{text[i]}";
            }
            return result;
        }
        string newText = Replase (text, ' ', '_');
        Console.WriteLine(newText);
        newText = Replase (text, 'к', 'К');
        Console.WriteLine(newText);
        break;
    }
    case 8:
    {
        int[] arr = { 1, 5, 2, 7, 5, 9, 5, 8, 6, 7};
        void PrintArray (int[] array)
        {
            int count = array.Length;
            for(int a = 0; a < count; a++)
            {
                Console.Write($"{array[a]}");
                
            }
            Console.WriteLine();
        }
        void SelectionSort(int[] array)
        {
            for (int a = 0; a < array.Length -1; a++)
            {
                int maxPosition = a;
                for (int c = a + 1; c < array.Length; c++)
                {
                    if (array[c] > array[maxPosition]) maxPosition = c;
                    int temporari = array[a];
                    array[a] = array[maxPosition];
                    array[maxPosition] = temporari;
                }
            }
        }
        PrintArray(arr);
        SelectionSort(arr);
        PrintArray(arr);
        break;
    }
}
