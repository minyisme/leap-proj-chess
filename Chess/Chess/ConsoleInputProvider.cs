using Chess.Interfaces;
using System;

namespace Chess
{
    /// <summary>
    /// Ths ConsoleInputProvider class, provides inputs from the Console
    /// </summary>
    public class ConsoleInputProvider : IInputProvider
    {
        /// <summary>
        /// Read a line from the console
        /// </summary>
        /// <returns></returns>
        public string Read()
        {
            // This function should read a line from the console and return it
            return Console.ReadLine();
        }
    }
}
