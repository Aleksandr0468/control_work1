/*Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо 
задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше 
обойтись исключительно массивами*/


// функция подсчета элементов массива
int CountSpecialElements(string[] array)
{
    int count = 0;
    foreach (string elem in array)
    {
        if (elem.Length <= 3) 
        {
            count++;
        }
    }
    return count;
}

string[] CreateNewArray(string[] array, int len)
{
    string[] new_array = new string[len];
    int i = 0;
    foreach (string elem in array)
    {
        if (elem.Length <= 3) 
        {
            new_array[i] = elem;
            i++;
        }
    }
    return new_array;
}


string[] array = {"Russia", "Denmark", "Kazan"};

int count = CountSpecialElements(array);
string[] new_array = CreateNewArray(array, count);


Console.WriteLine("['" + string.Join("', '", new_array) + "']");