﻿namespace Exercise_3
{
    public sealed class MySingleton
    {
        private static MySingleton instance;

        private MySingleton(){}

        public static MySingleton Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new MySingleton();
                }
                return instance;
            }
        }

        public void Log()
        {
            Console.WriteLine("Test...");
        }
    }
}