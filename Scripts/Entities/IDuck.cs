using System;
using System.Collections;

namespace QuackAttack.Scripts.Entities
{
    public interface IDuck
    {
        // Required Duck Properties
		/* The damage the duck can deal to obstructions */
        int damage
        {
            get;
            set;
        }

		/* The speed that the duck can attack */
        int speed
        {
            get;
            set;
        }

		/* The upgrage paths with the associated levels */
        ArrayList upgradePaths
        {
            get;
            set;
        }

        /// <summary>
        /// 	Sells a duck and sets the currency 
        /// </summary>
        /// 
        /// <returns>
        /// 	The currency received from selling the duck
        /// </returns>
        int SellDuck();

        /// <summary>
        /// 	Deals damage to a specified obstruction
        /// </summary>
        /// <param name="obstruction"></param>
        /// <param name="damagePoints">Amount of damage to be dealt to the obstruction</param>
        /// <returns></returns>
        int dealDamage(Obstruction obstruction, int damagePoints);
    }
}