
Console.OutputEncoding = System.Text.Encoding.UTF8;
int [] array = new int [5];
int [] array2 = new int [4];
void InputPrintArray()
{

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1,11);
        Console.Write(array[i]+" ");
    }

}
// //-------------------------------------------------------------
int [] ReMoveArraysElement(int [] arr)

{
    
    for (int i = 0; i < arr.Length; i++)
    {
        array2[i] = arr[i];
        Console.Write(array2[i]+" ");
        
    }
    return array2;
}
// //--------------------------------------------------------------

// InputPrintArray();
// Console.WriteLine();
// ReMoveArraysElement(array);
//-------------------------------------------------------------
int Rec(int [] arr)
{
    if (arr[1] == 0) return arr[0];
    else 
    {
        int k = arr[^1];
    }
    return arr[^1]*Rec(ReMoveArraysElement(arr));
}
InputPrintArray();
Rec(array);
