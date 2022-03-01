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