using System;

namespace CarRacing
{
    internal class Game
    {
        public int Time { get; }

        public delegate void MethodStart();
        public event MethodStart onStart;

        public delegate void MethodDrive();
        public event MethodDrive onDrive;

        public delegate void MethodFinish();
        public event MethodFinish onFinish;

        public Game(int time)
        {
            Time = time;
        }

        public void Start()
        {
            for (int i = 0; i < Time; i++)
            {
                if (i == 0)
                {
                    onStart();
                    Console.WriteLine();
                }
                else if (i == (int)(Time * 0.25))
                {
                    onDrive();
                    Console.WriteLine();
                }
                else if (i == (int)(Time * 0.5))
                {
                    onDrive();
                    Console.WriteLine();
                }
                else if (i == (int)(Time * 0.75))
                {
                    onDrive();
                    Console.WriteLine();
                }
                else if (i == Time - 1)
                {
                    onFinish();
                    Console.WriteLine();
                }
                else
                {

                    ;
                }
            }
        }
    }
}
