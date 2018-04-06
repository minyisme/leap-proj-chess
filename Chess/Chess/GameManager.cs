using Chess.Interfaces;
using System;
using System.Collections.Generic;

namespace Chess
{
    /// <summary>
    /// The GameManager class, handles all game logic
    /// </summary>
    public class GameManager
    {
        /// <summary>
        /// The game board
        /// </summary>
        private IBoard board;

        /// <summary>
        /// The board renderer
        /// </summary>
        private IBoardRenderer renderer;

        /// <summary>
        /// The input provider
        /// </summary>
        private IInputProvider inputProvider;

        /// <summary>
        /// The output provider
        /// </summary>
        private IOutputProvider outputProvider;

        /// <summary>
        /// The players. This is a list so we can support any number of players in the future.
        /// This uses IPlayer so we can support any type of player in the future (human player, computer player, etc...)
        /// </summary>
        private List<IPlayer> players;

        /// <summary>
        /// The current player
        /// </summary>
        private IPlayer currentPlayer;

        /// <summary>
        /// The game state
        /// </summary>
        public GameState GameState { get; private set; }

        /// <summary>
        /// Default constructor, uses a new Board and ConsoleOutputProvider
        /// </summary>
        public GameManager() : this(
            new Board(),
            new ConsoleBoardRenderer(),
            new ConsoleInputProvider(),
            new ConsoleOutputProvider())
        {

        }

        /// <summary>
        /// Constructor used for unit testing
        /// </summary>
        /// <param name="board">The board</param>
        /// <param name="renderer">The board renderer</param>
        /// <param name="inputprovider">The input provider</param>
        /// <param name="outputProvider">The output provider</param>
        public GameManager(IBoard board, IBoardRenderer renderer, IInputProvider inputProvider, IOutputProvider outputProvider)
        {
            // validate the inputs

            this.board = board;
            this.renderer = renderer;
            this.inputProvider = inputProvider;
            this.outputProvider = outputProvider;

            // initialize the players list

            // set the game state to waiting to start
        }


        /// <summary>
        /// Start the game
        /// </summary>
        public void StartGame()
        {
            // write the logic to run the game
        }

        /// <summary>
        /// Helper function to perform a single turn
        /// Very useful for unit testing
        /// </summary>
        public void PerformSingleTurn(IPlayer player)
        {
            // Use a switch statement to check the current game state
            // and perform only logic valid for the appropriate current state
            
            // use the output provider for all outputs except drawing the board (use the board renderer for that)
        }

        /// <summary>
        /// Helper function to switch players
        /// </summary>
        private void SwitchPlayer()
        {

        }

        /// <summary>
        /// Helper function to pick the player that goes first
        /// </summary>
        /// <returns></returns>
        private IPlayer PickFirstPlayer()
        {
            throw new NotImplementedException();
        }
    }
}
