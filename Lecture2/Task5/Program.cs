// Теперь попробуем адаптировать решение предыдущей задачи, в которой 
// находили нужные элементы и позицию нужного элемента в массиве.
// Для этого потребуется описать метод, отличный от void. Он будет возвращать позицию, то 
// есть index. Назовём этот метод IndexOf, а в качестве аргумента будет приходить массив 
// collection и какой-то элемент find.

void FillArray(int[] collection) // Void - метод который ничего не возвращает
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index++] = new Random().Next(1,10);
        index++;
    }
     
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;


    }
}
int[] array = new int[10]; // создали новый массив с 10-Ю элементами

int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1;
    while (index < count)
    {
        if(collection[index] == find)
        {
            position = index;
        }
        index++;
    }
    return position;
}
FillArray(array);
PrintArray(array);
Console.WriteLine();

int pos = IndexOf(array, 444);
Console.WriteLine(pos);