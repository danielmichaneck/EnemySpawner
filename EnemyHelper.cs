using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnemyHandler
{
    internal static class EnemyHelper
    {
        /// <summary>
        /// A static class that contains various helpful functions.
        /// </summary>

        // A constant that holds the total amount of enemy types.
        internal const int NumberOfEnemyTypes = 5;

        internal static void SetHealth(EnemyType type, ref float health)
        {
            // Sets the health of an enemy depending on type.
            // The "ref" in the parameter means that it accepts
            // a variable as an argument, and then the change to
            // here in this code is reflected in the variable
            // where it was called.
            // I.E, changing health here changes it there.
            switch(type)
            {
                case EnemyType.Hogger:
                    health = 10;
                    break;

                case EnemyType.Onyxia:
                    health = 500;
                    break;

                case EnemyType.Arthas:
                    health = 100000;
                    break;
            }
            // Default value.
            // The health does not do anything in this program,
            // this is only for demo purposes.
            health = 1;
        }

        internal static EnemyType GetRandomEnemyType()
        {
            // Creates a "Random" class which helps with generating random numbers.
            // It would have been better to create a "Singleton" which can be instanced
            // unlike a static class, but can only have ONE instance. Then we don't
            // have to create a new Random every time we run this method.
            Random _random = new Random();
            // Random.Next() gets the next random number.
            // It now generates a number between 0 and 100000000 and then
            // uses modulo to divide by the number of enemy types,
            // leaving a residue of 0, 1, 2, 3, or 4 since it is 5.
            // It then converts this int to an EnemyType and returns the value.
            return (EnemyType)(_random.Next(0, 100000000) % NumberOfEnemyTypes);
        }
    }
}
