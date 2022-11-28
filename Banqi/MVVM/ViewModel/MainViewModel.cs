using Banqi.MVVM.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Data;

namespace Banqi.MVVM.ViewModel
{
    class MainViewModel : INotifyPropertyChanged
    {
        public Setting Setting { get; set; }
        public Piece[][] Board { get; set; }


        public MainViewModel()
        {
            Setting = new Setting();
            Board = Setting.Board;
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public bool FlipPieceRequest(int row, int col)
        {
            bool IsFlipped = Setting.FlipPiece(row, col);
            return IsFlipped;
        }

        public MoveState MovePieceRequest(int row, int col)
        {
            MoveState moveState = Setting.MovePiece(row, col);
            OnPropertyChanged(nameof(Board));
            //OnPropertyChanged(nameof(Setting));
            OnPropertyChanged(nameof(Setting.FirstPiece.Item1));
            OnPropertyChanged(nameof(Setting.FirstPiece.Item2));
            return moveState;
        }
    }
}
