using Chess.Interfaces;
using System;

namespace Chess
{
    /// <summary>
    /// Ths ConsoleOutputProvider class, provides outputs to the Console
    /// </summary>
    class ConsoleOutputProvider : IOutputProvider
    {
        /// <summary>
        /// Write the specified output to the console
        /// </summary>
        /// <param name="output">The output</param>
        public void Write(string output)
        {
            // This function should write the specified output to the console
            Console.WriteLine(output);
        }

        /// <summary>
        /// Write the output with a new line
        /// </summary>
        /// <param name="output"></param>
        public void WriteLine(string output)
        {
            // This function should write the specified output to the console, with a newline at the end
            Console.WriteLine(output);
            Console.WriteLine();
        }

        /// <summary>
        /// Write an empty new line
        /// </summary>
        public void WriteLine()
        {
            // This function should write an empty new line to the console
            Console.WriteLine();
        }

        /// <summary>
        /// Clear the output
        /// </summary>
        public void Clear()
        {
            // This function should clear the output
            Console.Clear();
        }
    }
}
