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
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Syncfusion.Windows.Forms.Grid;
using Syncfusion.Drawing;
using Syncfusion.Windows.Forms;
using System.Drawing.Drawing2D;

namespace EssentialBlocks
{
    public partial class BlocksForm : Office2007Form
    {
        #region Constructor
        private BlocksGame game;
        private NextPieceForm nextPieceForm;

        public BlocksForm()
        {
            InitializeComponent();
            game = new BlocksGame();
            SetPauseBarItemStatus();

            // Disable Grid interaction
            gridBoard.AllowDragSelectedCols = false;
            gridBoard.AllowDragSelectedRows = false;
            gridBoard.AllowSelection = GridSelectionFlags.None;
            gridBoard.ResizeColsBehavior = GridResizeCellsBehavior.None;
            gridBoard.ResizeRowsBehavior = GridResizeCellsBehavior.None;

            // Create Next Piece display
            nextPieceForm = new NextPieceForm(game, this);
            nextPieceForm.TopLevel = false;
            this.nextPiecePanel.Controls.Add(nextPieceForm.gridNextPiece);
            nextPieceForm.gridNextPiece.Dock = DockStyle.Fill;
            this.Focus();
        }
        #endregion

        #region Menu Click Events
        private void exitBarItem_Click(object sender, EventArgs e)
        {
            // Pause the game for the Exit Dialog
            gameTimer.Stop();

            if (AbandonGame())
            {
                game.QuitGame();
                Application.Exit();
            }

            // Restart the game, if necessary
            if (game.IsGameRunning)
            {
                gameTimer.Start();
            }
        }

        private void newGameBarItem_Click(object sender, EventArgs e)
        {
            // Pause the game for the Exit Dialog
            gameTimer.Stop();

            if (AbandonGame())
            {
                if (game.IsGameStarted)
                {
                    game.QuitGame();
                    game = new BlocksGame();
                }

                nextPieceForm.BGame = game;
                game.StartGame();
                gridBoard.Invalidate();
                gridBoard.Update();
                SetPauseBarItemStatus();
            }

            // Restart (or start) the game, if necessary
            if (game.IsGameRunning)
            {
                gameTimer.Start();
            }
        }

        private void pauseBarItem_Click(object sender, EventArgs e)
        {
            gameTimer.Stop();

            if (game.IsGameRunning)
            {
                game.PauseGame();
            }
            else
            {
                game.ResumeGame();
                gameTimer.Start();
            }

            gridBoard.Invalidate();
            gridBoard.Update();
            nextPieceForm.ForceUpdate();

            SetPauseBarItemStatus();
        }

        private void aboutBarItem_Click(object sender, EventArgs e)
        {
            gameTimer.Stop();
            Form aboutForm = new AboutForm();
            aboutForm.ShowDialog(this);
            if (game.IsGameRunning)
            {
                gameTimer.Start();
            }
        }

        private void howToPlayBarItem_Click(object sender, EventArgs e)
        {
            gameTimer.Stop();
            Form howToPlayForm = new HowToPlayForm();
            howToPlayForm.ShowDialog(this);
            if (game.IsGameRunning)
            {
                gameTimer.Start();
            }
        }

        // Detects game settings and sets the display of the Pause item appropriately
        private void SetPauseBarItemStatus()
        {
            if (!game.IsGameStarted || game.IsGameOver)
            {
                pauseBarItem.Enabled = false;
                pauseBarItem.Text = "&Pause Game";
            }
            else if (game.IsGameRunning)
            {
                pauseBarItem.Enabled = true;
                pauseBarItem.Text = "&Pause Game";
                gridBoard.CoveredRanges.Clear();
            }
            else
            {
                pauseBarItem.Enabled = true;
                pauseBarItem.Text = "&Resume Game";
                gridBoard.CoveredRanges.Add(GridRangeInfo.Cells(6, 3, 7, 6));
            }
        }
        #endregion

        #region Dialogs

        // Returns true if the game is over or hasn't started.
        // Otherwise, asks the user if he wants to abandon his game
        private bool AbandonGame()
        {
            bool canExit;

            if (game.IsGameStarted && !game.IsGameOver)
            {
                DialogResult result = MessageBox.Show("Do you want to abandon your game?", "Exit Essential Blocks", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    canExit = true;
                }
                else
                {
                    canExit = false;
                }
            }
            else
            {
                canExit = true;
            }

            return canExit;
        }
        #endregion

        #region QueryCellInfo
        // Used to draw Pause and Game Over text
        private static GridFontInfo ArialFontInfo = new GridFontInfo(new Font("Arial", 22, FontStyle.Bold));

        // Called by the Grid during an Update for each visible cell
        private void gridBoard_QueryCellInfo(object sender, Syncfusion.Windows.Forms.Grid.GridQueryCellInfoEventArgs e)
        {
            // Disallow editing
            e.Style.Enabled = false;

            if (e.ColIndex > 0 && e.RowIndex > 0)
            {
                if (game.IsGameRunning)
                {
                    e.Style.Interior = GetGradient(game.GetBoardSquare(e.ColIndex, e.RowIndex));
                }
                else
                {
                    // Being able to see the board while paused is a significant advantage
                    e.Style.BackColor = Color.White;
                }
            }

            // Add text to the CoveredCells for Game Over and Paused messages
            if (e.RowIndex == 6)
            {
                if (game.IsGameOver && e.ColIndex == 2)
                {
                    e.Style.Text = "Game Over";
                    e.Style.Font = ArialFontInfo;
                }
                else if (!game.IsGameRunning && game.IsGameStarted && !game.IsGameOver && e.ColIndex == 3)
                {
                    e.Style.Text = "Paused";
                    e.Style.Font = ArialFontInfo;
                }
            }
        }
        #endregion

        #region Color Mappings  
        // Each entry in this array corresponds to a different piece
        private static Color[] colors = new Color[] { Color.White, Color.FromArgb(226, 144, 88), Color.FromArgb(79, 116, 186), Color.FromArgb(247, 115, 30), Color.FromArgb(117, 166, 47), Color.FromArgb(128, 0, 0), Color.FromArgb(196, 76, 74), Color.FromArgb(146, 145, 174) };
        

        // Returns the appropriate gradient for a cell value
        public static BrushInfo GetGradient(int index)
        {
            if (index > 0)
            {
                return new BrushInfo(GradientStyle.PathRectangle, Color.White, colors[index]);
            }
            else
            {
                // There shouldn't be a gradient on a blank cell
                return new BrushInfo(Color.White);
            }
        }
        #endregion

        #region Tick Events
        // Used internally to track the game speed
        private int level = 1;

        // Handles the periodic updates of the game
        private void gameTimer_Tick(object sender, EventArgs e)
        {
            game.Tick();
            gridBoard.Invalidate();
            gridBoard.Update();
            nextPieceForm.ForceUpdate();

            if (game.IsGameOver)
            {
                gameTimer.Stop();
                gridBoard.CoveredRanges.Add(GridRangeInfo.Cells(6, 2, 7, 7));
                SetPauseBarItemStatus();
            }
            else
            {
                // Tracks the games speed
                label1.Text = "Score: " + game.GetScore().ToString();

                // Level    Score
                // --------------
                //     1        0
                //     2      100
                //     3      400
                //     4      900
                //     5     1600
                //     6     2500
                //     7     3600
                //     8     4900
                //     9     6400
                //    10     8100
                //    11    10000
                //    12    12100
                //    13    14400
                level = Convert.ToInt32(Math.Sqrt(game.GetScore() / 100)) + 1;

                // Max level is 13
                if (level > 13)
                {
                    level = 13;
                }

                progressBarAdv1.Value = level;

                // Game speed ranges from 2 updates a second to about 6 updates a second
                gameTimer.Interval = 3000 / (5 + level);
            }
        }
        #endregion

        #region Keyboard Input

        // Used to grab the arrow key input
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            AcceptInput(keyData);

            return base.ProcessCmdKey(ref msg, keyData);
        }

        // Public so that the NextPieceForm can forward key presses.
        // Otherwise, there would be confusion if the NextPieceForm has focus.
        public void AcceptInput(Keys keyData)
        {
            // Without this call the tick event will never be processed if a key is held down
            Application.DoEvents();

            if (game.IsGameRunning)
            {
                bool refresh = false;

                switch (keyData)
                {
                    case Keys.Down:
                        game.MoveDown();
                        refresh = true;
                        break;
                    case Keys.Left:
                        game.MoveLeft();
                        refresh = true;
                        break;
                    case Keys.Right:
                        game.MoveRight();
                        refresh = true;
                        break;
                    case Keys.Up:
                        game.Rotate();
                        refresh = true;
                        break;
                }

                if (refresh)
                {
                    gridBoard.Invalidate();
                    gridBoard.Update();
                    nextPieceForm.ForceUpdate();
                }
            }
        }
        #endregion

        private void showNextPieceItem_Click(object sender, EventArgs e)
        {
            showNextPieceItem.Checked = !showNextPieceItem.Checked;
            if (showNextPieceItem.Checked)
                this.Width = 429;
            else
                this.Width = 289;
        }

    }
}