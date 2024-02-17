using Godot;
using System;
using System.Collections.Generic;

// Subclass for twig implementing the IObstruction interface
public partial class Twig : Node, Obstruction
{
	public int Health { get; set; }
	public int Damage { get; set; }
	public int Speed { get; set; }
	public int Level { get; set; }
	private static Dictionary<int, (int health, int damage, int speed)> TwigLevelStats = new Dictionary<int, (int health, int damage, int speed)>
	{
		//Level, (Health, Damage, Speed)
        { 1, (20, 20, 20) },
		{ 2, (30, 30, 30) },
		{ 3, (40, 40, 40) }
	};
	public Twig(int level)
	{
		(Health, Damage, Speed) = TwigLevelStats[level];
		Level = level;
	}
	public void DamageNest()
	{
		throw new NotImplementedException();
	}

	public void DestrotySelf()
	{
		throw new NotImplementedException();
	}

	public void ReceiveDamage(int damagePoints)
	{
		throw new NotImplementedException();
	}


}
