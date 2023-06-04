Console.Clear();


int[] RandomMass()
{
// //[1,0,1,1,0,1,0,0]
    int k = new Random().Next(2, 20);
    int[] n = new int[k];
    for (int i=0;i<k;i++)
    n[i] = new Random().Next(100, 1000);
   
       
    return n;
}
int Even(int[] n)
{
    int count=0;
    for (int i=0;i<n.Length;i++)
    {
        if (n[i]%2==0 && n[i]!=0){
            count++;
        }
    }
    return count;
}
int[] mass=RandomMass();
Console.WriteLine($" Случайный массив: [{String.Join(" ",mass)}]");
Console.WriteLine($" Колличество четных элементов: {Even(mass)}");
