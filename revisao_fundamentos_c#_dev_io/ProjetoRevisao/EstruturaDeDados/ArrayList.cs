using System.Collections;
internal class ArrayList
{
    private static void Main(string[] args)
    {
        var arrayList = new ArrayList();

        arrayList.Add(1);
        arrayList.Add("Leandro");
        arrayList.Add(true);

        Console.WriteLine(arrayList);
    }
}