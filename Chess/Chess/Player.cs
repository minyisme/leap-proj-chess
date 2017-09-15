﻿using Chess.Interfaces;
using System;

namespace Chess
{
    /// <summary>
    /// The HumanPlayer class, represents a human player
    /// </summary>
    public class Player : IPlayer
    {
        /// <summary>
        /// The player's name
        /// </summary>
        public string Name { get; private set; }

        /// <summary>
        /// The side of the board the player is on, used to validate moves
        /// </summary>
        public BoardSide Side { get; private set; }

        /// <summary>
        /// The move provider, used for getting moves
        /// </summary>
        private IMoveProvider mp;

        /// <summary>
        /// Constructor that uses the default move provider which reads from the console
        /// </summary>
        /// <param name="name">The player name</param>
        /// <param name="side">The side of the board the player sits on</param>
        public Player(string name, BoardSide side) : this(name, side, new MoveProvider())
        {

        }

        /// <summary>
        /// Constructor that uses a specific IMoveProvider, used for unit testing
        /// </summary>
        /// <param name="name">The name of the player</param>
        /// <param name="side">The side of the board the player sits on</param>
        /// <param name="mp">The move provider</param>
        public Player(string name, BoardSide side, IMoveProvider mp)
        {
            // validate the inputs
            // If name is null or empty, throw an ArgumentNullException
            // If mp is null, throw an ArgumentNullException

            Name = name;
            Side = side;
            this.mp = mp;
        }

        /// <summary>
        /// Get a move
        /// </summary>
        /// <returns>The move</returns>
        public Move GetMove()
        {
            // get the move from the move provider
            // set the move owner to the current player (using "this") since this is used during validation
            throw new NotImplementedException();
        }
    }
}