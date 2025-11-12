using Microsoft.VisualBasic;

public class Deck<T>
{
    private List<T> cards = new List<T>();
    public void Add(T card)
    {
        cards.Add(card);
    }
    public void Remove(T card)
    {
        cards.Remove(card);
    }
    public T GetCard(int index)
    {
        if (index < 0 || index >= cards.Count)
            throw new IndexOutOfRangeException("Index error");
        return cards[index];
    }
    public void Printall()
    {
        foreach (var card in cards)
        {
            Console.WriteLine(card);
        }
    }
    public int Count => cards.Count;
    public void Clear()
    {
        cards.Clear();
    }

}