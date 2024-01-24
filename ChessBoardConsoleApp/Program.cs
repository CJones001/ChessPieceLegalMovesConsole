using ChessBoardModel;
using System;
namespace ChessBoardConsoleApp
{
    class Program
    {
        static Board myBoard = new Board(8);

        static void Main(string[] args)
        {
            // show the empty chessboard
            printGrid(myBoard);
            // allow the user to select a piece
            string myPiece = setPiece();
            // get the location of the chess piece
            Cell myLocation = setCurrentCell();
            // calculate and mark the cells where legal moves are possible.
            myBoard.MarkNextLegalMoves(myLocation, myPiece);
            // show the chess board. Use . for an empty square, X for the piece location and + for a possible legal move
            printGrid(myBoard);
            // wait for another return key to end the program
            Console.ReadLine();
        }
        static public void printGrid(Board myBoard)
        {
            // print the board on the console. Use "X" for current location, "+" for legal move and "." for an empty square
            for (int i = 0; i < myBoard.Size; i++)
            {
                for (int j = 0;  j < myBoard.Size; j++)
                {
                   if (myBoard.theGrid[i, j].CurrentlyOccupied)
                    {
                        Console.Write("X");
                    }
                   else if (myBoard.theGrid[i, j].LegalNextMove)
                    {
                        Console.Write("+");
                    }
                   else
                    {
                        Console.Write(".");
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine("================================");
        }
        static public Cell setCurrentCell()
        {
            // Initialize the row and column
            int currentRow;
            int currentCol;

            do
            {
                Console.Out.Write("Enter your current row number ");
                currentRow = int.Parse(Console.ReadLine());
                // Display a message to the user for not entering a valid value
                if (currentRow < 0 || currentRow > 7)
                {
                    Console.WriteLine("Enter a value between 0 and 7 ");
                }
            } 
            // Make sure the user entered a valid value
            while (currentRow > 7 || currentRow < 0);

            do
            {
                Console.Out.Write("Enter your current column number ");
                currentCol = int.Parse(Console.ReadLine());

                if (currentCol < 0 || currentCol > 7)
                {
                    Console.WriteLine("Enter a value between 0 and 7 ");
                }
            } 
            while (currentCol > 7 || currentCol < 0);
            
            myBoard.theGrid[currentRow, currentCol].CurrentlyOccupied = true;

            return myBoard.theGrid[currentRow, currentCol];
        }

        static public string setPiece()
        {
            string myPiece = "";
            Console.Out.Write("Select a piece: n = knight, r = rook, q = queen, b = bishop, k = king ");
            string piece = Console.ReadLine();
            if (piece == "n")
            {
                myPiece = "Knight";
            }
            if (piece == "r")
            {
                myPiece = "Rook";
            }
            if (piece == "q")
            {
                myPiece = "Queen";
            }
            if (piece == "k")
            {
                myPiece = "King";
            }
            if (piece == "b")
            {
                myPiece = "Bishop";
            }
            
            return myPiece;
        }
    }
}