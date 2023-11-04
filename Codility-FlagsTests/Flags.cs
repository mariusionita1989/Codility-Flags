using Codility_Flags;

namespace Codility_FlagsTests
{
    public class SolutionTests
    {
        [Fact]
        public void Solution_ExampleTest()
        {
            // Arrange
            Solution solution = new Solution();
            int[] A = new int[] { 1, 5, 3, 4, 3, 4, 1, 2, 3, 4, 6, 2 };

            // Act
            int result = solution.solution(A);

            // Assert
            Assert.Equal(3, result);
        }

        [Fact]
        public void Solution_EmptyArray_ReturnsMinusOne()
        {
            // Arrange
            Solution solution = new Solution();
            int[] A = new int[] { };

            // Act
            int result = solution.solution(A);

            // Assert
            Assert.Equal(-1, result);
        }

        [Fact]
        public void Solution_SingleElementArray_ReturnsOne()
        {
            // Arrange
            Solution solution = new Solution();
            int[] A = new int[] { 5 };

            // Act
            int result = solution.solution(A);

            // Assert
            Assert.Equal(1, result);
        }

        [Fact]
        public void Solution_TwoElementArray_ReturnsOne()
        {
            // Arrange
            Solution solution = new Solution();
            int[] A = new int[] { 5, 10 };

            // Act
            int result = solution.solution(A);

            // Assert
            Assert.Equal(1, result);
        }

        [Fact]
        public void Solution_ThreeElementArray_ReturnsOne()
        {
            // Arrange
            Solution solution = new Solution();
            int[] A = new int[] { 5, 10, 5 };

            // Act
            int result = solution.solution(A);

            // Assert
            Assert.Equal(1, result);
        }

        [Fact]
        public void Solution_PeaksAtBothEnds_ReturnsOne()
        {
            // Arrange
            Solution solution = new Solution();
            int[] A = new int[] { 10, 2, 3, 4, 5, 1, 6, 8 };

            // Act
            int result = solution.solution(A);

            // Assert
            Assert.Equal(1, result);
        }
    }
}