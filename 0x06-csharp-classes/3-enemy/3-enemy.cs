using System;

namespace Enemies
{
	/// <summary>Zombie</summary>
	public class Zombie
    {
		private int health;
		/// <summary>Zombie health</summary>
		public Zombie()
        {
			health = 0;
		}
		/// <summary>Zombie</summary>
		public Zombie(int value)
        {
			if (value < 0)
				throw new ArgumentException("Health must be greater than or equal to 0");
			health = value;
		}
		/// <summary>Undead Regeneration</summary>
		public int GetHealth()
        {
			return health;
		}
	}
}