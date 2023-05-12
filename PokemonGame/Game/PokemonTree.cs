namespace PokemonGame;

public class PokemonTree
{
    public class Node
    {
        public Node? Left;//<
        public Node? Right;//>
        public Pokemon pokemon;
        public Node? Parent;
        public int size;
        public Node(Node left, Node right, Pokemon pokemon)
        {
            this.Left = left;
            this.Right = right;
            this.pokemon = pokemon;
            this.size = 1;
        }

    }
    Node? root;
    public int Size{
        get => root.size;
    }

    public void Add(Pokemon pokemon)
    {
        Node testednode = new Node(null, null, pokemon);
        if (root is null)
        {
            root = testednode;
            return;
        }
        int compval = root.pokemon.Name.CompareTo(testednode.pokemon.Name);
        if (compval > 0)
        {
            ++root.size;
            if (root.Right is null)
            {
                root.Right = testednode;
                
            }
            else
            {
                Node subjectnode = root.Right;
                NodeAdd(subjectnode, testednode);
            }
        }
        else
        {
            ++root.size;
            if (root.Left is null)
            {
                root.Left = testednode;
                testednode.Parent = root;
            }
            else
            {
                Node subjectnode = root.Left;
                NodeAdd(subjectnode, testednode);
            }
        }
    }
    public void NodeAdd(Node main, Node addednode)
    {
        ++main.size;
        int compval = main.pokemon.Name.CompareTo(addednode.pokemon.Name);
        if (compval > 0)
        {
            if (main.Right is null)
            {
                main.Right = addednode;
                addednode.Parent = main;
                return;
            }
            NodeAdd(main.Right, addednode);
        }
        else
        {
            if (main.Left is null)
            {
                main.Left = addednode;
                addednode.Parent = main;
                return;
            }
            NodeAdd(main.Left, addednode);
        }
    }
    public Pokemon Search(string Name)
    {
        return(SearchNode(root, Name));
    }
    public Pokemon SearchNode(Node main, string Name)
    {
        if (main is null)
        {
            throw new ArgumentException("No Pokemon with such name");
        }
        int compval = main.pokemon.Name.CompareTo(Name);
        if (compval == 0)
        {
            return (main.pokemon);
        }
        else if (compval > 0)
        {
            return SearchNode(main.Right, Name);
        }
        else
        {
            return SearchNode(main.Left, Name);
        }
    }
    public Pokemon Delete(string Name)
    {
        Node _deletable = SearchDelete(root, Name);
        if(_deletable.Parent is null){
            if(_deletable.Right.size < _deletable.Left.size){
                Node searchable = _deletable.Left;
                
                return(_deletable.pokemon);
            }
        }
        int compval = _deletable.pokemon.Name.CompareTo(_deletable.Parent.pokemon.Name);
        if(compval == 0){

        }
    }
    public Node SearchDelete(Node main, string Name)
    {
        --main.size;
        if (main is null)
        {
            throw new ArgumentException("No Pokemon with such name");
        }
        int compval = main.pokemon.Name.CompareTo(Name);
        if (compval == 0)
        {
            return (main);
        }
        else if (compval > 0)
        {
           return SearchDelete(main.Right, Name);
        }
        else
        {
            return SearchDelete(main.Left, Name);
        }
    }
}


