using System.Reflection.Metadata.Ecma335;

namespace modul2Oppgave1;
public class MagicCards
{
    public string Name { get; set; }
    public string Type { get; set; }

    public MagicCard(string name, string type)
    {
        Name = name;
        Type = type;
    }
    public override string ToString()=> $"{Name} ({Type})";
}