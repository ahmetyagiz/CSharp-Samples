using System;

class HollowCircleDrawing
{
    static void Main()
    {
        int radius = int.Parse(Console.ReadLine());

        double aspectRatio = 2.0; // Genişlik/Yükseklik oranı

        for (int y = -radius; y <= radius; y++)
        {
            for (int x = -radius * (int)aspectRatio; x <= radius * (int)aspectRatio; x++)
            {
                double distance = Math.Sqrt((x / aspectRatio) * (x / aspectRatio) + y * y);

                if (distance > radius - 0.5 && distance < radius + 0.5)
                {
                    Console.Write("*");
                }
                else
                {
                    Console.Write(" ");
                }
            }
            Console.WriteLine();
        }
    }
}
