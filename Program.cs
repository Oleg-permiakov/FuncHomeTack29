// Задаём массив из 8 элементов и выводим его на экран


int[] CreateArray () {
int[] array = new int[8];
for (int i = 0; i < array.Length; i++)
{
     array[i] = new Random().Next(1, 11);
}
return array;
   
}

void Printarray (int[] array) {              
for (int i = 0; i < array.Length; i++)    
 {
    Console.Write(array[i] + " ");
 }
}

int[] array1 = CreateArray();
Printarray(array1);
