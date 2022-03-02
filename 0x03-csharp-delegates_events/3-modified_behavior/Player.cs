using System;
/// <summary>enum for modifiers</summary>
public enum Modifier
{
	/// <summary> Baby </summary>
	Weak,
	/// <summary> normal </summary>
	Base,
	/// <summary> Mucho Macho Muchacho </summary>
	Strong
}

/// <summary> modifier </summary>
public delegate float CalculateModifier(float baseValue, Modifier modifier);
/// <summary> health changes </summary>
public delegate void CalculateHealth(float hpInfo);
/// <summary> The Player Itself </summary>
public class Player
{
	private string name;
	private float maxHp;
	private float hp;
	/// <summary> Name and Max Health </summary>
	public Player(string name="Player", float maxHp=100f)
    {
		this.name = name;
		if (maxHp <= 0)
        {
			maxHp = 100f;
			Console.WriteLine("maxHp must be greater than 0. maxHp set to 100f by default.");
		}
		this.maxHp = maxHp;
		this.hp = maxHp;
	}
	/// <summary> Health </summary>
	public void PrintHealth()
    {
		Console.WriteLine($"{name} has {hp} / {maxHp} health");
	}
    /// <summary> Changes current Health </summary>
	public void ValidateHP(float newHp)
    {
		if (newHp < 0)
			newHp = 0f;
		if (newHp > this.maxHp)
			newHp = this.maxHp;
		this.hp = newHp;
	}
    /// <summary> Regen Health </summary>
	public void HealDamage(float heal)
    {
		if (heal < 0)
			heal = 0f;
        ValidateHP(this.hp + heal);
		Console.WriteLine($"{name} heals {heal} HP!");
	}
    /// <summary> Ouchie Acquired </summary>
	public void TakeDamage(float damage)
    {
		if (damage < 0)
			damage = 0f;
			ValidateHP(this.hp -damage);
		Console.WriteLine($"{name} takes {damage} damage!");
	}
    /// <summary> hp </summary>
	public void ValidateHP(float newHp)
    {
		if (newHp < 0)
			newHp = 0f;
		if (newHp > this.maxHp)
			newHp = this.maxHp;
		this.hp = newHp;
	}
	/// <summary> modifiers </summary>
	public float ApplyModifier(float baseValue, Modifier modifier)
    {
		if (modifier == Modifier.Weak)	{ return baseValue / 2; }
		if (modifier == Modifier.Strong)	{ return baseValue * 1.5f; }
		return baseValue;
	}
}
