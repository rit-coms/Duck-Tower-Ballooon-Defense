using Godot;
using System;
using System.Collections.Generic;

// Subclass for twig implementing the IObstruction interface
public partial class FishingNets : Node, Obstruction
{
	public int Health { get; set; }
	public int Damage { get; set; }
	public int Speed { get; set; }
	public int Level { get; set; }
	Nest n;
	private static Dictionary<int, (int health, int damage, int speed)> TwigLevelStats = new Dictionary<int, (int health, int damage, int speed)>
	{
		// Level, (Health, Damage, Speed)
		{ 1, (20, 20, 20) },
		{ 2, (30, 30, 30) },
		{ 3, (40, 40, 40) }
	};
	public FishingNets(int level)
	{
		(Health, Damage, Speed) = TwigLevelStats[level];
		Level = level;
	}
	public void DamageNest()
	{
		// Call nest fucntion that makes it take damage
		// Then destory self
		GlobalVars.Nest.TakeDamage(this.Damage);
		throw new NotImplementedException();
	}

	public void DestroySelf()
	{
		if (this.Health < 0)
		{
			QueueFree();
		}
	}

	public void ReceiveDamage(int damagePoints)
	{
		Health = this.Health - damagePoints;
		this.DestroySelf();
	}

}
