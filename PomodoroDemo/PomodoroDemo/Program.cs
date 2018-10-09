using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PomodoroEngine;

namespace PomodoroDemo
{
    class Program : INotifyObject
    {
        static void Main(string[] args)
        {
            var program = new Program();
            Console.ReadLine();
        }
         
        public Program()
        {
            var pomodoroTimer = new Pomodoro(this, 20);
            pomodoroTimer.Start();
        }

        public void Tick(int min, int sec)
        {
            Console.Clear();
            if (sec == 0 && min == 0)
            {
                Console.WriteLine("Ta en pause");
                Environment.Exit(0);
            }
            Console.WriteLine(min + ":" + sec.ToString("00"));
        }
    }
}
