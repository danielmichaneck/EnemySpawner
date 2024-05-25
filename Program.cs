namespace EnemyHandler
{
    internal class Program
    {
        /// <summary>
        /// Program demonstrating an enemy handler and spawner.
        /// Do not do as I do and have different names for classes
        /// and their associated files.
        /// </summary>
        static void Main(string[] args)
        {
            // Handler updates once every 2 seconds.
            // When it spawns an enemy, the handler
            // adds a random enemy and prints all
            // the enemies that have been spawned.
            EnemyHandler handler = new EnemyHandler();
            int iteration = 0;
            bool loop = true;

            do
            {
                // Updates the spawner and the enemies.
                // It updates every "tick", but the function only
                // returns true every 2 seconds.
                // This is inefficient! But works.
                if (handler.Update())
                {
                    // Spaces out the output.
                    Console.WriteLine("__________________");

                    // Loops up to 10 times.
                    if (iteration < 10)
                        iteration++;
                    else loop = false;
                }
            } while (loop);
        }
    }
}
