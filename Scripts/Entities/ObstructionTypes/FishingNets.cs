using Godot;
using System;

// Subclass for twig implementing the IObstruction interface
public partial class FishingNets : Node, Obstruction
{
    public int Health { get; set; } = 20;
    public int Damage { get; set; } = 20;
    public int Speed { get; set; } = 20;
    public int Level { get; set; } = 20;

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
