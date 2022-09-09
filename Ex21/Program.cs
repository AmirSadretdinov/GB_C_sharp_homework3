// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53
double Distance(int[] A, int[] B)
{
    double result = Math.Sqrt
    (
         (Math.Pow((B[0]-A[0]),2)) + 
         (Math.Pow((B[1]-A[1]),2)) + 
         (Math.Pow((B[2]-A[2]),2)) 
    );
    return result;
}
//Точка А
System.Console.WriteLine("Введите координату Х для точки А");
int inputA1 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите координату Y для точки А");
int inputA2 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите координату Z для точки А");
int inputA3 = Convert.ToInt32(Console.ReadLine());
int[] A = {inputA1, inputA2, inputA3};

//Точка В
System.Console.WriteLine("Введите координату Х для точки B");
int inputB1 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите координату Y для точки B");
int inputB2 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите координату Z для точки B");
int inputB3 = Convert.ToInt32(Console.ReadLine());
int[] B = {inputB1, inputB2, inputB3};
//Результат
double result = Distance(A, B);
System.Console.WriteLine(result);