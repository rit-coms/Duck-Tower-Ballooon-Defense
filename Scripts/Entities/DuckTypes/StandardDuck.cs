using Godot;
using QuackAttack.Scripts.Entities;
using System;
using System.Collections;

public partial class StandardDuck : Node2D, IDuck
{
	public enum Levels {
		ONE = 1,
		TWO = 2,
		THREE = 3
	}

    public StandardDuck()
    {
            
    }

    public int type { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public int damage { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public int speed { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public ArrayList upgradePaths { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

	// Obstructions should probably be global class
    public void dealDamage(Obstruction obstruction, int damagePoints)
    {
		// obstruction.ReceiveDamage(damagePoints);
        throw new NotImplementedException();
    }

    public int DestroyDuck()
    {
        throw new NotImplementedException();
    }
}