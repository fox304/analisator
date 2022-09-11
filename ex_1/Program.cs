// Составить частотный словарь элементов (целые числа)
Console.OutputEncoding = System.Text.Encoding.UTF8;

int [] digits = {2,4,2,5,6,2,5,2,2,2,2,2,4,5,6,4,3};

for (int i = 0; i < digits.Length; i++)
{
    int count = 0;
    if (digits[i]==-1) continue;
    for (int j = i+1; j < digits.Length; j++)
    {
        if (digits[j]==-1 || digits[j]!=digits[i]) continue;
        count++;digits[j] = -1; 
    }
    Console.WriteLine($"число {digits[i]} повторяется {count+1}");
}
/*
                    двумерный в одномерный
*/
// int [,] twoarray = {{1,2,3},{4,5,6},{1,1,6}};
// int [] onearray = new int [twoarray.Length];
// int x = 0;
// for (int i = 0; i < twoarray.GetLength(0); i++)
// {
    
//     for (int j = 0; j < twoarray.GetLength(1); j++)
//     {
//         onearray[x+j] = twoarray[i,j];   
//     }
//     x+=twoarray.GetLength(1);
// }
// for (int i = 0; i < onearray.Length; i++)
// {
//     Console.WriteLine(onearray[i]);
// }
/*
                    для строк
*/

// string ourstring = "12  3435 65 4tr rt h t67";

// for (int i = 0; i < ourstring.Length; i++)
// {
//     int count  = 0;
//     for (int j = i+1; j < ourstring.Length; j++)
//     {
//         if (ourstring[i] == ourstring[j])
//         { 
//             ourstring = ourstring.Remove(j,1);
//             count++;          
//         }
//     }
//     Console.WriteLine($" символ {ourstring[i]}  повторяется {count+1} раз");   
// }

