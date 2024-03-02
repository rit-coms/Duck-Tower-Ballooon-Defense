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
	Node f;
	private static Dictionary<int, (int health, int damage, int speed)> FishingNetLevelStats = new Dictionary<int, (int health, int damage, int speed)>
	{
		// Level, (Health, Damage, Speed)
		{ 1, (20, 20, 20) },
		{ 2, (30, 30, 30) },
		{ 3, (40, 40, 40) }
	};
	public FishingNets()
	{
	}

	public void Initialize(int level)
	{
		(Health, Damage, Speed) = FishingNetLevelStats[level];
		Level = level;
	}

	public override void _Ready()
	{
		f = GetNode("follow");
	}
	public void DamageNest()
	{
		// Call nest fucntion that makes it take damage
		// Then destory self
		GlobalVars.Nest.TakeDamage(this.Damage);
	}

	public void DestroySelf()
	{
		if (this.Health < 0)
		{
			QueueFree();
		}
	}

	public override void _Process(double delta)
	{
		// Progress /moves the obstruction by 2.2
		PathFollow2D fo = (PathFollow2D)f;
		fo.Progress += (float)2.2;
	}

	public void ReceiveDamage(int damagePoints)
	{
		Health = this.Health - damagePoints;
		this.DestroySelf();
	}

}
