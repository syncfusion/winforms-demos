#region Copyright Syncfusion Inc. 2001 - 2015
//
//  Copyright Syncfusion Inc. 2001 - 2015. All rights reserved.
//
//  Use of this code is subject to the terms of our license.
//  A copy of the current license can be obtained at any time by e-mailing
//  licensing@syncfusion.com. Any infringement will be prosecuted under
//  applicable laws. 
//
#endregion

using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace EssentialBlocks
{
    public class BlocksGame
    {
        #region Constructor
        Random rand = new Random();

        public BlocksGame()
        {
            isGameRunning = false;
            isGameStarted = false;
            isGameOver = false;

            board = new int[8, 20];
            for (int x = 0; x < 8; ++x)
            {
                for (int y = 0; y < 20; ++y)
                {
                    board[x, y] = 0;
                }
            }

            piece = new int[5, 5];
            for (int x = 0; x < 5; ++x)
            {
                for (int y = 0; y < 5; ++y)
                {
                    piece[x, y] = 0;
                }
            }

            nextpiece = NewPiece();

            pieceloc = new Point(0, 0);

            score = 0;
        }
        #endregion

        #region Game State
        private bool isGameRunning;
        public bool IsGameRunning
        {
            get
            {
                return isGameRunning;
            }
        }

        private bool isGameStarted;
        public bool IsGameStarted
        {
            get
            {
                return isGameStarted;
            }
        }

        private bool isGameOver;
        public bool IsGameOver
        {
            get
            {
                return isGameOver;
            }
        }
        #endregion

        #region Game Control
        public void StartGame()
        {
            if (!isGameStarted)
            {
                isGameStarted = true;
                isGameOver = false;
                isGameRunning = true;
                needNewPiece = true;
            }
        }

        public void PauseGame()
        {
            if (isGameStarted && !isGameOver && isGameRunning)
            {
                isGameRunning = false;
            }
        }

        public void ResumeGame()
        {
            if (isGameStarted && !isGameOver && !isGameRunning)
            {
                isGameRunning = true;
            }
        }

        public void QuitGame()
        {
            if (isGameStarted && !isGameOver)
            {
                isGameRunning = false;
                isGameOver = true;
            }
        }
        #endregion

        #region Piece Design
        private int[,] NewPiece()
        {
            int[,] piece = new int[5, 5];

            switch (rand.Next(0, 7))
            {
                case 0:
                    piece[0, 2] = 1;
                    piece[1, 2] = 1;
                    piece[2, 2] = 1;
                    piece[3, 2] = 1;
                    break;
                case 1:
                    piece[1, 1] = 2;
                    piece[2, 1] = 2;
                    piece[2, 2] = 2;
                    piece[2, 3] = 2;
                    break;
                case 2:
                    piece[3, 1] = 3;
                    piece[2, 1] = 3;
                    piece[2, 2] = 3;
                    piece[2, 3] = 3;
                    break;
                case 3:
                    piece[2, 1] = 4;
                    piece[1, 2] = 4;
                    piece[2, 2] = 4;
                    piece[3, 2] = 4;
                    break;
                case 4:
                    piece[1, 1] = 5;
                    piece[2, 1] = 5;
                    piece[1, 2] = 5;
                    piece[2, 2] = 5;
                    break;
                case 5:
                    piece[2, 1] = 6;
                    piece[2, 2] = 6;
                    piece[3, 2] = 6;
                    piece[3, 3] = 6;
                    break;
                case 6:
                    piece[2, 1] = 7;
                    piece[2, 2] = 7;
                    piece[1, 2] = 7;
                    piece[1, 3] = 7;
                    break;
            }

            return piece;

        }
        #endregion

        #region Game Action
        private bool needNewPiece;

        // Factored out logic for creating a new piece.
        private bool QueryNewPiece()
        {
            if (needNewPiece)
            {
                piece = nextpiece;
                pieceloc = new Point(3, -3);
                nextpiece = NewPiece();
                needNewPiece = false;
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Tick()
        {
            if (isGameRunning && !isGameOver)
            {
                if (!QueryNewPiece())
                {
                    MoveDown();
                }
            }
        }

        public void MoveDown()
        {
            if (!QueryNewPiece())
            {
                Point newloc = pieceloc;
                ++newloc.Y;

                if (!WillCollide(piece, newloc))
                {
                    ++pieceloc.Y;
                }
                else
                {
                    // The piece hit something going down, so it needs to be added to the display.
                    for (int x = 0; x < 5; ++x)
                    {
                        for (int y = 0; y < 5; ++y)
                        {
                            if (piece[x, y] > 0)
                            {
                                if (!isGameOver)
                                {
                                    if (y + pieceloc.Y < 1)
                                    {
                                        // This piece caused an overflow on the top of the board, so the game is over
                                        isGameOver = true;
                                    }
                                    else
                                    {
                                        // Add the block to the board
                                        board[x + pieceloc.X - 1, y + pieceloc.Y - 1] = piece[x, y];
                                    }
                                }
                            }
                        }
                    }
                    if (!isGameOver)
                    {
                        ClearPieces();
                        needNewPiece = true;
                        for (int x = 0; x < 5; ++x)
                        {
                            for (int y = 0; y < 5; ++y)
                            {
                                piece[x, y] = 0;
                            }
                        }
                    }
                    else
                    {
                        isGameRunning = false;
                    }
                }
            }
        }

        public void MoveLeft()
        {
            Point newloc = pieceloc;
            --newloc.X;

            if (!WillCollide(piece, newloc))
            {
                --pieceloc.X;
            }
        }

        public void MoveRight()
        {
            Point newloc = pieceloc;
            ++newloc.X;

            if (!WillCollide(piece, newloc))
            {
                ++pieceloc.X;
            }
        }

        public void Rotate()
        {
            int[,] newpiece = new int[5, 5];

            for (int x = 0; x < 5; ++x)
            {
                for (int y = 0; y < 5; ++y)
                {
                    newpiece[x, y] = piece[4 - y, x];
                }
            }

            if (!WillCollide(newpiece, pieceloc))
            {
                piece = newpiece;
            }
        }

        // Detects completed rows and removes them
        private void ClearPieces()
        {
            int clears = 0;

            for (int y = 0; y < 20; ++y)
            {
                bool clear = true;

                for (int x = 0; x < 8; ++x)
                {
                    clear = clear && (board[x, y] > 0);
                }

                if (clear)
                {
                    ++clears;
                    for (int j = y; j >= 0; --j)
                    {
                        for (int i = 0; i < 8; ++i)
                        {
                            if (j == 0)
                            {
                                board[i, j] = 0;
                            }
                            else
                            {
                                board[i, j] = board[i, j - 1];
                            }
                        }
                    }
                }
            }

            // If we removed something, score the points
            // Clears Score
            // ------------
            //      1   100
            //      2   200
            //      3   400
            //      4   800
            if (clears > 0)
            {
                score = score + (Convert.ToInt32(Math.Pow(2, clears - 1)) * 100);
            }
        }

        // Performs collision detection on each individual block in the piece.
        // Accepts both location and the piece so that rotation can be tested.
        private bool WillCollide(int[,] piece, Point newloc)
        {
            bool willCollide = false;

            for (int x = 0; x < 5; ++x)
            {
                for (int y = 0; y < 5; ++y)
                {
                    if (piece[x, y] > 0)
                    {
                        if (x + newloc.X <= 0)
                        {
                            willCollide = true;
                        }
                        else if (x + newloc.X >= 9)
                        {
                            willCollide = true;
                        }
                        else if (y + newloc.Y >= 21)
                        {
                            willCollide = true;
                        }
                        else if (newloc.Y + y > 0 && board[x + newloc.X - 1, y + newloc.Y - 1] > 0)
                        {
                            willCollide = true;
                        }
                    }
                }
            }

            return willCollide;
        }
        #endregion

        #region Game Data
        private int[,] piece;
        private int[,] nextpiece;
        private Point pieceloc;

        public int[,] GetNextPiece()
        {
            return nextpiece;
        }

        private int[,] board;
        public int GetBoardSquare(int x, int y)
        {
            if ((x >= pieceloc.X && x <= pieceloc.X + 4)
                && (y >= pieceloc.Y && y <= pieceloc.Y + 4)
                && (piece[x - pieceloc.X, y - pieceloc.Y] != 0))
            {
                return piece[x - pieceloc.X, y - pieceloc.Y];
            }
            else
            {
                return board[x - 1, y - 1];
            }
        }

        private int score;
        public int GetScore()
        {
            return score;
        }
        #endregion
    }
}
