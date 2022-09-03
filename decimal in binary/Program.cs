int n = int.Parse(Console.ReadLine());
string str = String.Empty;
while (n > 0)

{
   
    str=Convert.ToString(n%2)+str;
    n=n/2;  
    
}
Console.Write($"{str}  ");
