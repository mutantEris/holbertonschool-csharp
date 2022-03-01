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
/// <summary> Tests </summary>
public class TestObject: Base, IInteractive, IBreakable, ICollectable
{
	/// <summary> Durability </summary>
	public int durability{get; set;}
	/// <summary> isCollected </summary>
	public bool isCollected{get; set;}
	/// <summary> Interact() </summary>
	public void Interact(){}
	/// <summary> Break() </summary>
	public void Break(){}
	/// <summary> Collect() </summary>
	public void Collect(){}
}