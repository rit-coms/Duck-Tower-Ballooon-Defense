using Godot;
using QuackAttack.DuckProperties;
using QuackAttack.Scripts.Entities;
using System;
using System.Collections;

public partial class MommaDuck : Node2D, IDuck
{
    public MommaDuck(int level)
    {
        // Get the available duck levels for a standard duck 
        DuckLevels MommaDuckLevels = new DuckLevels(DuckType.MOMMA_DUCK);

        // Get the level based on what level the duck is
        LevelData levelData = MommaDuckLevels.Levels[level];

        // Assing the damage, speed, and price attributes based on the level the duck is
        damage = levelData.damage;
        speed = levelData.speed;
        price = levelData.price;
    }

    public int damage { get; set; }
    public int speed { get; set; }
    public int price { get; set; }

    public ArrayList upgradePaths { get; set; }

	// Obstructions should probably be global class
    public void dealDamage(Obstruction obstruction)
    {
		//obstruction.ReceiveDamage(damage);
        throw new NotImplementedException();
    }

    /*
    *    This will be called when the duck is being sold. The returned int is the currency obtained from the destruction.
    */
    public int DestroyDuck()
    {
        QueueFree();
        return price;
    }
}