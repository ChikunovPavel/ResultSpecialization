// Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа.
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритм

Console.WriteLine("Input the size of the array:");
int size = Convert.ToInt32(Console.ReadLine());

string[] CreateArray(int size)
{
    string [] array = new string [size];  
    for(int i = 0; i < size; i++)
    {
        Console.WriteLine("Input value line:");
        array[i] = Convert.ToString(Console.ReadLine());
    }
    Console.WriteLine();

    
    return array;
}

void ShowArray(string[]array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

   
String [] CreateNewArray(string[] array)
{
    string [] newarray = new string [array.Length];  
    for(int i = 0; i < array.Length; i++)
    {
        String s = array[i];
        if(s.Length <= 3)
        {
        newarray[i] = s;
        Console.Write(newarray[i] + " ");
        }
    }
    return newarray;
}






string [] myArray = CreateArray(size);
ShowArray(myArray);
string [] newArray = CreateNewArray(myArray);



