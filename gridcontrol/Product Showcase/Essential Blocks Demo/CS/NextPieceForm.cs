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

namespace EssentialBlocks
{
    public partial class NextPieceForm : Form
    {
        private BlocksGame game;
        private BlocksForm form;

        public NextPieceForm(BlocksGame bGame, BlocksForm bForm)
        {
            InitializeComponent();
            game = bGame;
            gridNextPiece.AllowDragSelectedCols = false;
            gridNextPiece.AllowDragSelectedRows = false;
            gridNextPiece.AllowSelection = GridSelectionFlags.None;
            gridNextPiece.ResizeColsBehavior = GridResizeCellsBehavior.None;
            gridNextPiece.ResizeRowsBehavior = GridResizeCellsBehavior.None;
            form = bForm;

            this.Left = bForm.Right;
            this.Top = bForm.Top;
        }

        public BlocksGame BGame
        {
            set
            {
                game = value;
                ForceUpdate();
            }
        }

        // Used so that the display of the next piece will always be accurate
        public void ForceUpdate()
        {
            gridNextPiece.Invalidate();
            gridNextPiece.Update();
        }

        #region "Events"
        // This isn't fundamentally different from the QueryCellInfo in BlocksForm, except that
        // game.GetNextPiece() is used instead.
        private void gridNextPiece_QueryCellInfo(object sender, Syncfusion.Windows.Forms.Grid.GridQueryCellInfoEventArgs e)
        {
            e.Style.Enabled = false;
            if (e.ColIndex > 0 && e.RowIndex > 0)
            {
                if (game.IsGameOver || !game.IsGameRunning || !game.IsGameStarted)
                {
                    e.Style.BackColor = Color.White;
                }
                else
                {
                    e.Style.Interior = BlocksForm.GetGradient(game.GetNextPiece()[e.ColIndex - 1, e.RowIndex - 1]);
                }
            }
        }

        // Forwards arrow keys to BlocksForm so they can be handled
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if ((keyData == Keys.Up) || (keyData == Keys.Down) || (keyData == Keys.Left) || (keyData == Keys.Right))
            {
                form.AcceptInput(keyData);
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }
        #endregion
    }
}