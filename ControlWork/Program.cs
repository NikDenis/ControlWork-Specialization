/*Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

## Примеры:
[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
[“Russia”, “Denmark”, “Kazan”] → []
*/

Console.WriteLine("Сколько элементов масива вы хотите ввести?");
int size = Convert.ToInt32(Console.ReadLine());

string[] arrayElement = new string[size];
int len = 3;
int pos = 0;
for (int i = 0; i < size; i++)
{
    Console.Write($"Введите {i+1}-й элемент: ");
    string element = Convert.ToString(Console.ReadLine());
    if (element.Length <= len)
        {
            arrayElement[pos] = element;
            pos++;
        }

}
void ShowArray(string[] array)        //Метод для вывода массива
{
    for(int i =0; i < size; i++)
    {
        Console.Write(array[i] + " ");
    }
    
}

Console.WriteLine();
Console.Write("Элементы состоящие из 3 символов: ");
ShowArray(arrayElement); 
