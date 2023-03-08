using System.Collections;

internal class SessionEight
{
    ArrayList itemsA = new ArrayList();
    ArrayList itemsB = new ArrayList();

    public void AddItems()
    {
        itemsA.Add(10);
        itemsA.Add("Anh da on hon");
        itemsA.Add(7.89);
        itemsB.Add(true);
        itemsB.Add("Neu luc do");
        itemsB.Add(-10);
        itemsA.Insert(1, "Oke");
        itemsB.Insert(1, "Umum");
        foreach (var item in itemsA)
        {
            Console.Write(item + "\n");
        }

        foreach (var item in itemsB)
        {
            Console.Write(item + "\n");
        }

        itemsA.Remove(10);
        itemsB.Remove("Umum");
        itemsA.Remove(2);
        itemsB.Remove(2);
    }

}