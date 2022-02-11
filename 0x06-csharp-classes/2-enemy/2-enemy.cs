using System;

namespace Enemies
{
	/// <summary>Enemies.</summary>
	public class Zombie
    {
		/// <summary>Zombie.</summary>
		public int health;
		/// <summary>Zombie health</summary>
		public Zombie()
        {
			health = 0;
		}
		/// <summary>Zombies</summary>
		public Zombie(int value)
        {
			if (value < 0)
				throw new ArgumentException("Health must be greater than or equal to 0");
			health = value;
		}
	}
}