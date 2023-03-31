namespace StackTask;

public enum CardElement
{
    Water,
    Fire,
    Earth,
    Air,
    Light,
    Darkness
}

public enum CardType
{
    Creature,
    Spell,
    InstantSpell,
    Territory
}

public class Card
{

    private CardElement elem;
    private CardType type;
    private string text = text;
    private int prior = prior;
    public CardElement Element

    public Card(CardElement elem, CardType type, string text, int

    {
        get { return element;}
    }
    public CardType Type
    {
        get { return type;}
    }
    public string Text
    {
        get { return text;}
    }
    public int Prior
    {
        get { return prior;}
    }
    public Card(CardElement elem, CardType type, string text, int prior)
    {
        this.text = text;
        this.prior = prior;
        this.elem = elem;
        this.type = type;
    }
    public override string ToString()
    {
        string result = $"\t\n{elem}\n\t{type}\n{text}\n";
        return result;
    }

    public CardElement Element
    {
        get
        {
            throw new NotImplementedException();
        }
    }

    public CardType Type
    {
        get
        {
            throw new NotImplementedException();
        }
    }

    public string Text
    {
        get
        {
            throw new NotImplementedException();
        }
    }

    public int Prior
    {
        get
        {
            throw new NotImplementedException();
        }
    }
}