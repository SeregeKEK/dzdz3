void Zadacha1(){
    // Задайте двумерный массив. Напишите программу, 
    // которая упорядочит по убыванию элементы каждой строки двумерного массива.
    int rows = 4;
    int columns = 4;
    int[,] array = new int[rows, columns];
    FillArray(array);
    PrintArray(array);
    Console.WriteLine();
    for(int i = 0; i < columns; i++){
        for(int j = 0; j < rows - 1; j++){
            for(int k = j + 1; k < columns; k++){
                if(array[i,k] > array[i,j]){
                    int temp = array[i,j];
                    array[i,j] = array[i,k];
                    array[i,k] = temp;     
                }
            }
        }
    }
    PrintArray(array);
}

void Zadacha2(){
    // Задайте прямоугольный двумерный массив. 
    // Напишите программу, которая будет находить строку с наименьшей суммой элементов.
    int minRow = 0;
    int minSum = 0;
    int sum = 0;
    int rows = 4;
    int columns = 4;
    int[,] array = new int[rows, columns];
    FillArray(array);
    PrintArray(array);
    for(int i = 0; i < columns; i++){
        minSum += array[0,i];
    }
    for(int i = 0; i < columns; i++){
        for(int j = 0; j < rows; j++){
            sum += array[i,j];
        }
        if(sum < minSum){
            minSum = sum;
            minRow = i;
        }
        sum = 0;
    }
    Console.WriteLine($"Строкa с наименьшей суммой эл-тов: {minRow +1}");
}


void Zadacha3(){
    // Заполните спирально массив 4 на 4.
    int rows = 4;
    int columns = 4;
    int[,] array = new int[rows, columns];
    int count = 1;
    for(int i = 0; i < columns; i++){
        array[0, i] = count++;
        if(i == columns - 1){
            for(int j = 1; j < rows; j++){
                array[j, i] = count++;
                if(j == rows - 1){
                    for(int k = columns - 2; k != -1; k--){
                        array[j, k] = count++;
                        if(k == 0){
                            for(int l = rows - 2; l != 0; l--){
                                array[l, k] = count++;
                            }
                        }
                    }
                }
            }
        }
    }
    for(int m = 1; m < columns - 1; m++){
        array[1, m] = count++;
        if(m == columns - 2){
            for(int n = 2; n < rows - 1; n++){
                array[n, m] = count++;
                if(n == rows - 2){
                    for(int p = columns - 3; p != 0; p--){
                        array[n, p] = count++;
                    }
                }
            }
        }
    }
    PrintArray(array);
}

void FillArray(int [,] array, int startNumber = 0, int finishNumber = 10){
    finishNumber++;
    Random random = new Random();
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);
    for(int i = 0; i < rows; i++){
        for(int j = 0; j < columns; j++){
            array[i, j] = random.Next(startNumber, finishNumber);
        }
        Console.WriteLine();
    }
}

void PrintArray(int [,] array){
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);
    for(int i = 0; i < rows; i++){
        for(int j = 0; j < columns; j++){
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
}
// Zadacha1();
// Zadacha2();
Zadacha3();