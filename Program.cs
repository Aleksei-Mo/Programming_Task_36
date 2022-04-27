// Задача 36. Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечетных позициях.
Console.Clear();
Console.WriteLine("This program finds sum of all elements of the array that locates on odd position.");
Console.Write("Enter array dimension:");
int arrayDim = Convert.ToInt32(Console.ReadLine());//enter dimension of an array
int [] newArray = FillArray(arrayDim);// get the filled array
int sum=0;
Console.Write("The array elements with odd positions: ");
  for(int index=0; index<newArray.Length; index++)
     {
       if (index%2!=0)//check current element of the array for even
          {
           Console.Write($"{newArray[index]} ");
           sum=sum+newArray[index];
          }
     }
Console.WriteLine();
Console.WriteLine($"Sum of all elements of the array that locates on odd position is {sum}.");

//***********************************************//
int [] FillArray(int dim)
{
 int [] arrayWarning ={0};
    if(dim>0)// if dimension>0 then continue with filling
      { 
        int [] array = new int[dim];
        Console.Write("Your array is: ");
          for(int index=0; index<dim; index++)
             {
              Console.Write($"{array[index]=new Random().Next(-100,101)} ");
             }
        Console.WriteLine();
        return array;
      }
      else
      {
        Console.WriteLine("Warning! The entered dimesion is wrong. Please check and try again!"); 
        return arrayWarning;
      }
 
}
//***********************************************//