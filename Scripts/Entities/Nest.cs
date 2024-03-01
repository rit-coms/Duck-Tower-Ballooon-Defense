using Godot;
using System;
[GlobalClass]
public partial class Nest : Node
{
	public override void _Ready()
	{
	}
	public int Health { get; set; }
	internal void TakeDamage(int damagePoints)
	{
		Health -= damagePoints;
		this.DestroySelf();
	}
	public void DestroySelf()
	{
		if (this.Health < 0)
		{
			QueueFree();
		}
	}
}