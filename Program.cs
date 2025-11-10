using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data.SqlTypes;
using System.Security.Cryptography.X509Certificates;

namespace modul2Oppgave1;

class Program
{
    static void Main(string[] args)
    {
        CardHolder<MagicCard> holder = new CardHolder<MagicCard>();

        holder.AddCard(new MagicCard("Lightning Bolt", "Instant", 1 ), 0);
        holder.AddCard(new MagicCard("Llanowar Elves", "Creature", 1 ), 1);
        holder.AddCard(new MagicCard("Island", "Land", 0 ), 2);
        holder.AddCard(new MagicCard("Counterspell", "Instant", 2 ), 3);
        holder.AddCard(new MagicCard("Serra Angel", "Creature", 5 ), 4);

        holder.PrintAll();
    }
    public static T Max<T>(T a, T b) where T : IComparable<T>
    {  
        Console.WriteLine("Hello, World!");

        Console.WriteLine(Max(32, 10));
        Console.WriteLine(Max("beta", "alpha"));
        return a.CompareTo(b) > 0 ? a : b;
    }
}
