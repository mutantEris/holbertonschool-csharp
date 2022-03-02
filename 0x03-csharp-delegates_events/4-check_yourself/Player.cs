using System;
/// <summary>Delegate for health changes.</summary>
public delegate void CalculateHealth(float hpInfo);
/// <summary> The Player Itself </summary>
public class Player
{
	private string name;
	private float maxHp;
	private float hp;
    private string status;
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
        this.status = $"{name} is ready to go!";
		this.HPCheck = this.CheckStatus;
	}
	/// <summary> Health </summary>
	public void PrintHealth()
    {
		Console.WriteLine($"{name} has {hp} / {maxHp} health");
	}
    /// <summary> Checks HP </summary>
	public EventHandler<CurrentHPArgs> HPCheck;
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
    /// <summary> Modifiers </summary>
	public float ApplyModifier(float baseValue, Modifier modifier)
    {
		if (modifier == Modifier.Weak)
            return baseValue / 2;
		if (modifier == Modifier.Strong)
            return baseValue * 1.5f;
		return baseValue;
	}
    /// <summary> Checks yon status </summary>
    private void CheckStatus(object sender, CurrentHPArgs e)
    {
		if (this.hp == this.maxHp)
			this.status = $"{name} is in perfect health!";
		else if (this.hp >= maxHp / 2)
			this.status = $"{name} is doing well!";
		else if (this.hp >= maxHp / 4)
			this.status = $"{name} isn't doing too great...";
		else if (this.hp > 0)
			this.status = $"{name} needs help!";
		else
			this.status = $"{name} is knocked out!";
		Console.WriteLine(status);
	}
}
public delegate float CalculateModifier(float baseValue, Modifier modifier);
/// <summary> Modifiers </summary>
public enum Modifier
{
	/// <summary> Baby </summary>
	Weak,
	/// <summary> Normal </summary>
	Base,
	/// <summary> Mucho Macho Muchacho </summary>
	Strong
}
/// <summary> current hp </summary>
public class CurrentHPArgs: EventArgs
{
	/// <summary> CURRENT HP </summary>
	public readonly float currentHp;
	/// <summary> The Current HPs </summary>
	public CurrentHPArgs(float newHp)
    {
		this.currentHp = newHp;
	}
}