using System;

class Program
{
   static void Main(string[] args)
   {
      //following steps 
      // Step 1: Declaration and instantiation of the first two arrays
      int[] firstArray = { 1, 2, 3 }; // Directly initializing the array with values
      int[] secondArray = { 4, 5, 6 }; // Same here for the second array

      // Step 2: Declaration of the third array with double the size
      int[] mergedArray = new int[firstArray.Length + secondArray.Length];

      // Step 3: Filling the third array with the values of the first and second arrays
      // Adding values from the first array
      for (int i = 0; i < firstArray.Length; i++)
      {
         mergedArray[i] = firstArray[i];
      }

      // Adding values from the second array
      // Notice how we start at the end of the first array's length
      for (int i = 0; i < secondArray.Length; i++)
      {
         mergedArray[firstArray.Length + i] = secondArray[i];
      }

      // Optional: Displaying the merged array to verify
      Console.WriteLine("Merged Array:");
      foreach (int value in mergedArray)
      {
         Console.WriteLine(value);
      }
   }
}

