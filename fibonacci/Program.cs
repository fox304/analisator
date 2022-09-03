//  фибоначи
int n = Convert.ToInt32(Console.ReadLine());
int n1=0,n2=1,n3=1;
for (int i = 0; i < n; i++)
{
    n3 = n1 + n2;
    n1 = n2;
    n2 = n3;
    Console.Write($"{n3} ");
}
