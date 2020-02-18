using System;

namespace FlaviusJosephusTask
{
    /// <summary>
    /// Static Class JosephusTask.
    /// </summary>
    public static class JosephusTask
    {
        /// <summary>
        /// Method that determines which player will stay.
        /// </summary>
        /// <param name="count">Counts of players.</param>
        /// <param name="k">Number of players, which should be deleted.</param>
        /// <returns>Number of player who stayed.</returns>
        /// <exception cref="ArgumentException">Throw when count or k is negative or zero.</exception>
        public static int Josephus(int count, int k)
        {
            if (count <= 0)
            {
                throw new ArgumentException($"{count} cannot be zero or negative.");
            }

            if (k <= 0)
            {
                throw new ArgumentException($"{k} cannot be zero or negative.");
            }

            if (count == 1)
            {
                return 1;
            }
            else
            {
                return ((Josephus(count - 1, k) + k - 1) % count) + 1;
            }
        }
    }
}
