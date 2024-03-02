using System;
using System.Collections.Generic;

public interface Obstruction
{
	int Health { get; set; }
	int Damage { get; set; }
	int Speed { get; set; }
	int Level { get; set; }
	void DamageNest();
	void ReceiveDamage(int damagePoints);
	void DestroySelf();
	void Initialize(int level);

}
