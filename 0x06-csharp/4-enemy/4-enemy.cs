using System;

namespace Enemies
{
	/// <summary>Enemies</summary>
	public class Zombie
    {
		private int health;
		private string name = "(No name)";
		/// <summary>name</summary>
		public string Name
        {
			get { return name; }
			set { name = value; }
		}
		/// <summary>Zombie Health</summary>
		public Zombie()
        {
			health = 0;
		}
		/// <summary>Zombie Health More Than 0</summary>
		public Zombie(int value)
        {
			if (value < 0)
				throw new ArgumentException("Health must be greater than or equal to 0");
			health = value;
		}
		/// <summary>Unholy Resurrection</summary>
		public int GetHealth()
        {
			return health;
		}
	}
}