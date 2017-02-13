using Xunit;

namespace QueenAttack
{
    public class QueenTest
    {
        [Fact]
        public void QueenPosition_Get_QueenPosition()
        {
            //Arrange
            int[] userInputQueen = new int[] {1,2};
            int[] userInputPosition = new int[] {2,3};

            //Act
            Queen QueenTest = new Queen(userInputQueen, userInputPosition);

            //Assert
            Assert.Equal(userInputQueen, QueenTest.GetQueenPosition());
        }
        [Fact]
        public void MovePosition_Get_MoveLocation()
        {
            //Arrange
            int[] userInputPosition = new int[] {2,3};

            //Act
            Queen QueenTest = new Queen(userInputPosition, userInputPosition);

            //Assert
            Assert.Equal(userInputPosition, QueenTest.GetMoveLocation());
        }
        [Fact]
        public void CompareQueenToMove_CanQueenMove_MoveToLocation()
        {
            //Arrange
            int[] userInputQueen = new int[] {1,2};
            int[] userInputPosition = new int[] {2,3};
            Queen QueenTest = new Queen(userInputQueen, userInputPosition);

            //Act
            bool moveQueen = QueenTest.CompareQueenToMove();

            //Assert
            Assert.Equal(true, moveQueen);
        }
    }
}
