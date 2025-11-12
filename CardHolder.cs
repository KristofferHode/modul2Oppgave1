namespace modul2Oppgave1;
//gammel kode for å lage en deck holder som holder ett spesifikt antall kort
public class CardHolder<T>
{
    private T[] cards = new T[6];
    public void AddCard(T card, int index)
    {
        if (index < 0 || index >= 6)
            throw new IndexOutOfRangeException("index must be between 0 and 4");
        
        cards[index] = card;
        }

    public T GetCard(int index)
    {
        return cards[index];
    }

    public void PrintAll()
    {
        foreach (var card in cards)
        {
            Console.WriteLine(card);
        }
    }
}