namespace QuackAttack.DuckProperties {
	public enum DuckType 
	{
			STANDARD = 0,
			CANNON_DUCK = 1,
			MOMMA_DUCK = 2
	}


	/// <summary>
	/// Object that specifies level specific characteristics
	/// </summary>
	public class LevelData 
	{
		public int damage { get; set; }
		public int speed { get; set; }
		public int price { get; set; }
	}

	/// <summary>
	/// Holds all the Standard duck levels
	/// </summary>
	public class DuckLevels 
	{
		public LevelData[] Levels { get; set; }

		public DuckLevels (DuckType type) {
			if (type == DuckType.STANDARD) {
				Levels[0] = new LevelData { 
					damage = 10, 
					speed = 10, 
					price = 10 
				};
				Levels[1] = new LevelData { 
					damage = 20, 
					speed = 20, 
					price = 20 
				};
				Levels[2] = new LevelData { 
					damage = 40, 
					speed = 40, 
					price = 40 
				};
			} else if (type == DuckType.CANNON_DUCK) {
				Levels[0] = new LevelData { 
					damage = 100, 
					speed = 1, 
					price = 50 
				};
				Levels[1] = new LevelData { 
					damage = 100, 
					speed = 5, 
					price = 100 
				};
				Levels[2] = new LevelData { 
					damage = 100, 
					speed = 10, 
					price = 150
				};
			} else if (type == DuckType.MOMMA_DUCK) {
				Levels[0] = new LevelData { 
					damage = 40, 
					speed = 50, 
					price = 100 
				};
				Levels[1] = new LevelData { 
					damage = 80, 
					speed = 70, 
					price = 200 
				};
				Levels[2] = new LevelData { 
					damage = 100, 
					speed = 100, 
					price = 400
				};
			}
			
		}
	}

}