using System;
/// <summary> Base </summary>
public abstract class Base
{
	/// <summary> Name of object </summary>
	public string name;
	/// <summary> String </summary>
	public override string ToString() => $"{this.name} is a {this.GetType()}";
}
interface IInteractive
{
	void Interact();
}
interface IBreakable
{
	int durability{get; set;}
	void Break();
}
interface ICollectable
{
	bool isCollected{get; set;}
	void Collect();
}
/// <summary> Door </summary>
public class Door: Base, IInteractive{
	/// <summary> Door constructor </summary>
	public Door(string dName = "Door") => name = dName;
	/// <summary> Interact with door </summary>
	public void Interact() => Console.WriteLine($"You try to open the {name}. It's locked.");
}
/// <summary> Various decorations </summary>
public class Decoration: Base, IInteractive, IBreakable
{
	/// <summary> Is quest item? </summary>
	public bool isQuestItem {get; set;}
	/// <summary> Item duribility </summary>
	public int durability{get; set;}
	/// <summary> Decoration constructor </summary>
	public Decoration(string name="Decoration", int durability=1, bool isQuestItem=false){
		this.name = name;
		if (durability < 0)
			throw new Exception("Durability must be greater than 0");
		this.durability = durability;
		this.isQuestItem = isQuestItem;
    }
    	/// <summary> Interact with decoration </summary>
	public void Interact()
    {
		if (durability <= 0)
			Console.WriteLine($"The {name} has been broken.");
        else if (isQuestItem)
			Console.WriteLine($"You look at the {name}. There's a key inside.");
        else
			Console.WriteLine($"You look at the {name}. Not much to see here.");
	}
    /// <summary> Now kill it. </summary>
	public void Break()
    {
		durability--;
		if (durability > 0)
        	Console.WriteLine($"You hit the {name}. It cracks.");
		else if (durability == 0)
        	Console.WriteLine($"You smash the {name}. What a mess.");
		else
			Console.WriteLine($"The {name} is already broken.");
    }
}