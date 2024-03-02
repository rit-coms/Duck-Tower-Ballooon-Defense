using System;
using System.Collections;

namespace QuackAttack.Scripts.Entities
{
    public interface IDuck
    {
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

        /* The amount that the duck can be sold for */
        int price
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
        /// 	This destroys the duck. Normally, this will be used when the duck is sold.
        /// </summary>
        /// 
        /// <returns>
        /// 	The currency received from selling the duck
        /// </returns>
        int DestroyDuck();

        /// <summary>
        /// 	Deals damage to a specified obstruction
        /// </summary>
        /// <param name="obstruction"></param>
        /// <param name="damagePoints">Amount of damage to be dealt to the obstruction</param>
        /// <returns></returns>
        void dealDamage(Obstruction obstruction);
    }
}