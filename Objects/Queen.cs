using System;
using System.Collections.Generic;

namespace QueenAttack
{
    public class Queen
    {
        public Queen(int[] newQueenPosition, int[] newMoveLocation)
        {
            _queenPosition = newQueenPosition;
            _moveLocation = newMoveLocation;
        }

        private int[] _queenPosition;
        private int[] _moveLocation;

        public int[] GetQueenPosition()
        {
            return _queenPosition;
        }
        public int[] GetMoveLocation()
        {
            return _moveLocation;
        }
        public bool CompareQueenToMove()
        {
            if (_queenPosition[0] == _moveLocation[0] || _queenPosition[1] == _moveLocation[1])
            {
                Console.WriteLine("return one");
                return true;
            }
            else if (Math.Abs(((_queenPosition[1] - _moveLocation[1]) / (_queenPosition[0] - _moveLocation[0]))) == 1)
            {
                Console.WriteLine("return two");
                return true;
            }
            return false;
        }
    }
}
