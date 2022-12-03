string[] StringArray(int n) 
{
    int i = 0;
    int j = 0;
    string[] array = new string[n];
    string[] finAr;
    Console.WriteLine("Please input the string and we count its character less then 3: ");
    while(i < n) 
    {
        Console.Write(i + 1 + ": ");
        string s = Console.ReadLine();
        if(s.Length <= 3)
           array[j++] = s; 
        i++;      
    }
    return array;
}

Console.Write("Please input array length: ");
int n = Convert.ToInt32(Console.ReadLine());
string[] a = StringArray(n);
// Console.Write("[");
foreach (string item in a)
    Console.Write(item + " ");
// Console.Write("]");