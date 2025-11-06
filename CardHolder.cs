namespace modul2Oppgave1;

public class CardHolder<T>
{
    private T[] cards = new T[5];
    public void AddCard(T card, int index)
    {
        if (index < 0 || index >= 5)
            throw new IndexOutOfRangeException("index must be between 0 and 4");
        cards[index] = card;

    }

    public T GetCard (int index)
    {
        return cards[index];
    }












}