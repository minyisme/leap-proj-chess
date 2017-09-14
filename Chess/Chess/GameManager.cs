using Chess.Interfaces;
using System;

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
        private Board board;

        /// <summary>
        /// The output provider
        /// </summary>
        private IOutputProvider outputProvider;

        // create something to keep track of the current player
        // remember to use interfaces whenever possible

        /// <summary>
        /// The game state
        /// </summary>
        public GameState GameState { get; private set; }

        /// <summary>
        /// Default constructor, uses a new Board and ConsoleOutputProvider
        /// </summary>
        public GameManager() : this(new Board(), new ConsoleOutputProvider())
        {

        }

        /// <summary>
        /// Constructor used for unit testing
        /// </summary>
        /// <param name="board"></param>
        public GameManager(Board board) : this(board, new ConsoleOutputProvider())
        {

        }

        /// <summary>
        /// Constructor used for unit testing
        /// </summary>
        /// <param name="board"></param>
        /// <param name="outputProvider"></param>
        public GameManager(Board board, IOutputProvider outputProvider)
        {
            // validate the inputs
            // if board is null, throw an ArgumentNullException
            // if outputProvider is null, throw an ArgumentNullException

            this.board = board;
            this.outputProvider = outputProvider;
            GameState = GameState.WaitingToStart;
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
            // write the logic to perform a single turn
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
