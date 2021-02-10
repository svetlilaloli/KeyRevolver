using System;
using System.Collections.Generic;

namespace KeyRevolver
{
    class KeyRevolver
    {
        static void Main()
        {
            int bulletPrice = int.Parse(Console.ReadLine());
            int barrelSize = int.Parse(Console.ReadLine());
            Stack<int> allBullets = new Stack<int>(Array.ConvertAll(Console.ReadLine().Split(), int.Parse));
            Queue<int> bulletsInBarrel = new Queue<int>();
            Queue<int> locks = new Queue<int>(Array.ConvertAll(Console.ReadLine().Split(), int.Parse));
            int valueOfIntelligence = int.Parse(Console.ReadLine());
            bool bulletsLeft = true;
            int bulletsUsed = 0;

            bulletsInBarrel = LoadBarrel(barrelSize, allBullets);

            while (bulletsLeft && locks.Count > 0)
            {
                int bullet = bulletsInBarrel.Dequeue();
                bulletsUsed++;
                int currentLock = locks.Peek();

                if (bullet <= currentLock)
                {
                    Console.WriteLine("Bang!");
                    locks.Dequeue();
                }
                else
                {
                    Console.WriteLine("Ping!");
                }
                if (bulletsInBarrel.Count == 0 && allBullets.Count > 0)
                {
                    Console.WriteLine("Reloading!");
                    bulletsInBarrel = LoadBarrel(barrelSize, allBullets);
                }
                else if (bulletsInBarrel.Count == 0 && allBullets.Count == 0)
                {
                    bulletsLeft = false;
                    continue;
                }
            }

            if (locks.Count == 0)
            {
                Console.WriteLine($"{allBullets.Count + bulletsInBarrel.Count} bullets left. Earned ${valueOfIntelligence - bulletsUsed * bulletPrice}");
            }
            else if (bulletsLeft == false)
            {
                Console.WriteLine($"Couldn't get through. Locks left: {locks.Count}");
            } 
        }
        private static Queue<int> LoadBarrel(int barrelSize, Stack<int> allBullets)
        {
            int bullet;
            Queue<int> bulletsInBarrel = new Queue<int>();
            int min = barrelSize < allBullets.Count ? barrelSize : allBullets.Count;

            for (int i = 0; i < min; i++)
            {
                bullet = allBullets.Pop();
                bulletsInBarrel.Enqueue(bullet);
            }
            return bulletsInBarrel;
        }
    }
}
