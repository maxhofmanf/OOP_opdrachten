using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;


public enum Type
{
    Fire,
    Water,
    Leaf
}
abstract class Pokemon
{
    
    private Type strength;
    private Type weakness;
    
    public Type getStrength() { return strength; }
    public Type getWeakness() { return weakness; }
    public string name;
    public bool status;

    public Pokemon(string name,bool status, Type strength, Type weakness)
    {
        this.name = name;
        this.status = status;
        this.strength = strength;
        this.weakness = weakness;
    }

    public abstract void BattleCry();
}
class Charmander : Pokemon
{
    public Charmander(string name ) : base(name,true, Type.Fire, Type.Water) { }

    public override void BattleCry()
    {
        Console.WriteLine(name + " used battle cry: Charmander!");
    }
}

class Bulbasaur : Pokemon
{
    public Bulbasaur(string name) : base(name,true, Type.Leaf, Type.Fire) { }

    public override void BattleCry()
    {
        Console.WriteLine(name + " used battle cry: Bulba!");
    }
}

class Squirtle : Pokemon
{
    public Squirtle(string name) : base(name,true, Type.Water, Type.Leaf) { }

    public override void BattleCry()
    {
        Console.WriteLine(name + " used battle cry: Squirtle!");
    }
}