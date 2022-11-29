using Banqi.MVVM.Model.Pieces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Banqi.MVVM.Model
{
    class Setting
    {
        public Piece[][] Board { get; set; } = new Piece[4][];
        List<Piece> pieces;

        public Tuple<int, int>? FirstPiece { get; set; } = null;
        public Tuple<int, int>? SecondPiece { get; set; } = null;

        public Setting()
        {
            pieces = new List<Piece>();
            ShuffleBoard(pieces);
        }

        private void ShuffleBoard(List<Piece> pieces)
        {
            if (pieces.Count == 0)
            {
                pieces.Add(new General());
                pieces.Add(new GeneralB());
                for (int i = 0; i < 2; i++)
                {
                    pieces.Add(new Advisor());
                    pieces.Add(new AdvisorB());
                    pieces.Add(new Elephant());
                    pieces.Add(new ElephantB());
                    pieces.Add(new Horse());
                    pieces.Add(new HorseB());
                    pieces.Add(new Chariot());
                    pieces.Add(new ChariotB());
                    pieces.Add(new Cannon());
                    pieces.Add(new CannonB());
                }
                for (int i = 0; i < 5; i++)
                {
                    pieces.Add(new Soldier());
                    pieces.Add(new SoldierB());
                }
            }

            pieces.Shuffle();

            for (int i = 0; i < 4; i++)
            {
                Board[i] = new Piece[8];
            }

            for (int i = 0; i < pieces.Count; i++)
            {
                Board[i / 8][ i % 8] = pieces[i];
            }
        }

        public bool FlipPiece(int row, int col)
        {
            if (Board[row][col]?.Revealed == false)
            {
                Board[row][col].Revealed = true;
                return true;
            }
            return false;
        }

        public MoveState MovePiece(int row, int col)
        {
            if (Board[row][col]?.Revealed == true)
            {
                if (FirstPiece == null)
                {
                    // check not Empty position
                    if (Board[row][col].Rank != 0)
                    {
                        FirstPiece = Tuple.Create(row, col);
                        return MoveState.Selected;
                    }
                    return MoveState.None;
                }
                else
                {
                    SecondPiece = Tuple.Create(row, col);
                    // check not identical Positions
                    if (FirstPiece!=SecondPiece)
                    {
                        // check adjacent
                        if ((FirstPiece.Item2 == SecondPiece.Item2 && Math.Abs(FirstPiece.Item1 - SecondPiece.Item1) == 1) || (FirstPiece.Item1 == SecondPiece.Item1 && Math.Abs(FirstPiece.Item2 - SecondPiece.Item2) == 1))
                        {
                            // check Empty postion, move to Empty space
                            if (Board[SecondPiece.Item1][SecondPiece.Item2].Rank == 0)
                            {
                                Board[SecondPiece.Item1][SecondPiece.Item2] = Board[FirstPiece.Item1][FirstPiece.Item2];
                                Board[FirstPiece.Item1][FirstPiece.Item2] = new Empty();
                                FirstPiece = null;
                                SecondPiece = null;
                                return MoveState.Moved;
                            }
                            // check different teams
                            else if (Math.Abs(Board[FirstPiece.Item1][FirstPiece.Item2].Rank + Board[SecondPiece.Item1][SecondPiece.Item2].Rank) < Math.Abs(Board[FirstPiece.Item1][FirstPiece.Item2].Rank) + Math.Abs(Board[SecondPiece.Item1][SecondPiece.Item2].Rank))
                            {
                                // compare two ranks
                                if ((Math.Abs(Board[FirstPiece.Item1][FirstPiece.Item2].Rank) >= Math.Abs(Board[SecondPiece.Item1][SecondPiece.Item2].Rank)) || (Math.Abs(Board[FirstPiece.Item1][FirstPiece.Item2].Rank) == 1 && Math.Abs(Board[SecondPiece.Item1][SecondPiece.Item2].Rank) == 7))
                                {
                                    // option rule: General cannot capture Soldat
                                    if (Math.Abs(Board[FirstPiece.Item1][FirstPiece.Item2].Rank) == 7 && Math.Abs(Board[SecondPiece.Item1][SecondPiece.Item2].Rank) == 1)
                                    {
                                        FirstPiece = null;
                                        SecondPiece = null;
                                        return MoveState.Invalid;
                                    }

                                    Board[SecondPiece.Item1][SecondPiece.Item2] = Board[FirstPiece.Item1][FirstPiece.Item2];
                                    Board[FirstPiece.Item1][FirstPiece.Item2] = new Empty();
                                    FirstPiece = null;
                                    SecondPiece = null;
                                    return MoveState.Capture;
                                }
                            }
                        }
                    }
                    FirstPiece= null;
                    SecondPiece= null;
                    return MoveState.Invalid;
                }
            }
            return MoveState.None;
        }
    }
}
