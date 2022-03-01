using System;
/// <summary> Base </summary>
public abstract class Base
{
	/// <summary> Name of object </summary>
	public string name;
	/// <summary> String </summary>
	public override string ToString() => $"{this.name} is a {this.GetType()}";
}