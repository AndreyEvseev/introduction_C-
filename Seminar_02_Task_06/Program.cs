// 6. Создать массив на 3 элемента и присвоить 
// рандомные значения элементам массива

int N = 3, i = 0;
int [] array = new int[N];
while (i < N)
{
    array[i] = new Random().Next();
    Console.Write(i + ": ");
    Console.Write(array[i] + "; ");
    i++;
}
