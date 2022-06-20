//Объявляем массивы In и Out. Размер массива Out задаем используя функцию, 
//которая подсчитывает количество элементов в массиве In длиннной <= 3

string [] arrayIn = {"hello world", "2", ":-)", "1234", "Hi!"};
string [] arrayOut = new string [ArraySize(arrayIn)];

Console.WriteLine(PrintArray(arrayIn));
FormNewArray(arrayIn, arrayOut);
Console.WriteLine(PrintArray(arrayOut));


//Вычисление размера массива Out
int ArraySize (string [] array)
    {
        int count = 0;
            for(int i = 0; i < array.Length; i++)
                {
                    if (array[i].Length <=3 )
                    count++;
                }
            return count;
    }

//Формирование массива отвечающего условиям задачи
void FormNewArray(string [] array1, string [] array2)
    {
        int count = 0;
        for(int i = 0; i < array1.Length; i++)
            {
                if (array1[i].Length <=3 )
                    {
                        array2[count] = array1[i];
                        count++;
                    }
            }
    }

//Вывод массива
string PrintArray(string [] array)
    {
        int size = array.Length;
        string res = string.Empty;
        res = "[ ";
            for(int i = 0; i < size; i++)
                {
                    res += $"{array[i], 1} ";
                }
        res += "]";
        return res;
    }

