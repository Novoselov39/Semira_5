Console.Clear();


double[] RandomMass()
{
// //[1,0,1,1,0,1,0,0]
    int k = new Random().Next(2, 10);
    double[] n = new double[k];
    for (int i=0;i<k;i++)
    n[i] = Math.Round(new Random().NextDouble()*100,2);
   
       
    return n;
}


double MaxElement(double[] n)
{
    double Max = n[0];
    for (int i=1;i<n.Length;i++)
    {
        if (Max<n[i])
        {
            Max=n[i];
        }
    }
    return Max;
}
double MinElement(double[] n)
{
    double Min = n[0];
    for (int i=1;i<n.Length;i++)
    {
        if (Min>n[i])
        {
            Min=n[i];
        }
    }
    return Min;
}
double[] mass=RandomMass();
Console.WriteLine($" Случайный массив: [{String.Join("; ",mass)}]");
Console.WriteLine($" Max: {MaxElement(mass)}");
Console.WriteLine($" Min: {MinElement(mass)}");
Console.WriteLine($" Разница между максимальным и минимальным: {MaxElement(mass)-MinElement(mass)}");

