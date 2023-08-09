// int [] array = new int [4]; //create array with 4 elements

// for (int i=0; i<array.Length; i++)
// {
//     array [i] = new Random().Next(-9,10);
//     Console.Write (array [i]+" ");
//     }

// Console.WriteLine();

// for (int k=0; k<array.Length; k++)
// {
//     array[k]=array[k]*-1;
//     Console.Write (array [k]+" ");
// }




// Task #2


// Console.WriteLine ("give me a number");
// int num = Convert.ToInt32(Console.ReadLine());

// bool ifFind = false;

// int [] array = new int [5]; 

// for (int i=0; i<array.Length; i++)
// {
//     array [i] = new Random().Next(-9,10);
//     Console.Write (array [i]+"; ");
//     if (array[i]==num)
//      {
//         ifFind = true;
//         }
        
//     }
    
//     if (ifFind == true)
    // {
    //     Console.WriteLine ("Yes");
    // }
    // else
    // {
    //     Console.WriteLine ("No");
    // }

   // Task #3

//     int [] array = new int [123]; 

// int count = 0;

// for (int i=0; i<array.Length; i++)
// {
//     array [i] = new Random().Next(-9,100);
//     Console.Write (array [i]+"; ");
//     if (array[i]<99 && array[i]>10)
//      {
//         count++;
//         }
        
//     }
//     Console.WriteLine();
    
//            Console.WriteLine ("the number of numbers in giving interval  "+ count);

// Task #4

Console.WriteLine ("give me a number");
int num = Convert.ToInt32(Console.ReadLine());

int [] array1 = new int [num]; 
int [] array2 = new int [array1.Length/2+array1.Length%2];

for (int i=0; i<array1.Length; i++)
{
    array1 [i] = new Random().Next(0,10);
    Console.Write (array1 [i]+"; ");
    
 }
 
 Console.WriteLine();
 
 for (int i=0; i<array2.Length; i++)
 {
    array2[i] = array1 [i]*array1[array1.Length-i-1];
    
        if (i==array1.Length-i-1)
    {
    array2[i]=array1[i];
    }
    Console.Write (array2 [i]+"; ");
 }