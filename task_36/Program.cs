Console.Clear();


int[] RandomMass()
{
// //[1,0,1,1,0,1,0,0]
    int k = new Random().Next(2, 20);
    int[] n = new int[k];
    for (int i=0;i<k;i++)
    n[i] = new Random().Next(-100, 100);
   
       
    return n;
}
int SumNotEvenPoss(int[] n)
{
    int sum=0;
    for (int i=1;i<n.Length;i=i+2)
    {
        sum=sum+n[i];
    }
    return sum;
}
int[] mass=RandomMass();
Console.WriteLine($" Случайный массив: [{String.Join(" ",mass)}]");
Console.WriteLine($" сумма нечетных элементов {SumNotEvenPoss(mass)}");
