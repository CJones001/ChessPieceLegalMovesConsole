using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessBoardModel
{
    public class Board
    {
        // The board is always square, usually 8X8
        public int Size { get; set; }

        // 2d array of Cell Objects
        public Cell[,] theGrid;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="s"></param>
        public Board(int s)
        {
            // The grid can be any size, but we'll make it 8X8 in our case later on
            Size = s;

            // Initialize the array to avoid null excetion errors
            theGrid = new Cell[Size, Size];
            for(int i = 0; i < Size; i++)
            {
                for(int j = 0; j < Size; j++)
                {
                    // Make every position in the array a Cell
                    theGrid[i, j] = new Cell(i, j);
                }
            }
        }

        public void MarkNextLegalMoves(Cell currentCell, string chessPiece)
        {
            for(int r = 0; r< Size;  r++)
            {
                for (int c = 0;  c < Size; c++)
                {
                    theGrid[r, c].LegalNextMove = false;
                }
            }
            switch (chessPiece)
            {
                case "Knight":
                    theGrid[currentCell.RowNumber - 2, currentCell.ColumnNumber - 1].LegalNextMove = true;
                    theGrid[currentCell.RowNumber - 2, currentCell.ColumnNumber + 1].LegalNextMove = true;
                    theGrid[currentCell.RowNumber - 1, currentCell.ColumnNumber - 2].LegalNextMove = true;
                    theGrid[currentCell.RowNumber - 1, currentCell.ColumnNumber + 2].LegalNextMove = true;
                    theGrid[currentCell.RowNumber + 2, currentCell.ColumnNumber - 1].LegalNextMove = true;
                    theGrid[currentCell.RowNumber + 2, currentCell.ColumnNumber + 1].LegalNextMove = true;
                    theGrid[currentCell.RowNumber + 1, currentCell.ColumnNumber - 2].LegalNextMove = true;
                    theGrid[currentCell.RowNumber + 1, currentCell.ColumnNumber + 2].LegalNextMove = true;
                    break;

                case "King":
                    theGrid[currentCell.RowNumber - 1, currentCell.ColumnNumber].LegalNextMove = true;
                    theGrid[currentCell.RowNumber + 1, currentCell.ColumnNumber].LegalNextMove = true;
                    theGrid[currentCell.RowNumber, currentCell.ColumnNumber - 1].LegalNextMove = true;
                    theGrid[currentCell.RowNumber, currentCell.ColumnNumber + 1].LegalNextMove = true;
                    theGrid[currentCell.RowNumber + 1, currentCell.ColumnNumber - 1].LegalNextMove = true;
                    theGrid[currentCell.RowNumber + 1, currentCell.ColumnNumber + 1].LegalNextMove = true;
                    theGrid[currentCell.RowNumber - 1, currentCell.ColumnNumber - 1].LegalNextMove = true;
                    theGrid[currentCell.RowNumber - 1, currentCell.ColumnNumber + 1].LegalNextMove = true;
                    break;

                case "Rook":
                    // Up
                    for (int i = 1; i < 8; i++)
                    {
                        theGrid[currentCell.RowNumber + i, currentCell.ColumnNumber].LegalNextMove = true;
                    }
                    // Down
                    for (int i = 1; i < 8; i++)
                    {
                        theGrid[currentCell.RowNumber - i, currentCell.ColumnNumber].LegalNextMove = true;
                    }
                    // Right
                    for (int i = 1; i < 8; i++)
                    {
                        theGrid[currentCell.RowNumber, currentCell.ColumnNumber + i].LegalNextMove = true;
                    }
                    // Left
                    for (int i = 1; i < 8; i++)
                    {
                        theGrid[currentCell.RowNumber, currentCell.ColumnNumber - i].LegalNextMove = true;
                    }
                    break;

                case "Bishop":
                    // Up - Right
                    for (int i = 1; i < 8; i++)
                    {
                        theGrid[currentCell.RowNumber + i, currentCell.ColumnNumber + i].LegalNextMove = true;
                    }
                    // Up - Left
                    for (int i = 1; i < 8; i++)
                    {
                        theGrid[currentCell.RowNumber + i, currentCell.ColumnNumber - i].LegalNextMove = true;
                    }
                    // Down - Right
                    for (int i = 1; i < 8; i++)
                    {
                        theGrid[currentCell.RowNumber - i, currentCell.ColumnNumber + i].LegalNextMove = true;
                    }
                    // Down - Left
                    for (int i = 1; i < 8; i++)
                    {
                        theGrid[currentCell.RowNumber - i, currentCell.ColumnNumber - i].LegalNextMove = true;
                    }
                    break;

                case "Queen":
                    // Up - Right
                    for (int i = 1; i < 8; i++)
                    {
                        theGrid[currentCell.RowNumber + i, currentCell.ColumnNumber + i].LegalNextMove = true;
                    }
                    // Up - Left
                    for (int i = 1; i < 8; i++)
                    {
                        theGrid[currentCell.RowNumber + i, currentCell.ColumnNumber - i].LegalNextMove = true;
                    }
                    // Down - Right
                    for (int i = 1; i < 8; i++)
                    {
                        theGrid[currentCell.RowNumber - i, currentCell.ColumnNumber + i].LegalNextMove = true;
                    }
                    // Down - Left
                    for (int i = 1; i < 8; i++)
                    {
                        theGrid[currentCell.RowNumber - i, currentCell.ColumnNumber - i].LegalNextMove = true;
                    }
                    // Up
                    for (int i = 1; i < 8; i++)
                    {
                        theGrid[currentCell.RowNumber + i, currentCell.ColumnNumber].LegalNextMove = true;
                    }
                    // Down
                    for (int i = 1; i < 8; i++)
                    {
                        theGrid[currentCell.RowNumber - i, currentCell.ColumnNumber].LegalNextMove = true;
                    }
                    // Right
                    for (int i = 1; i < 8; i++)
                    {
                        theGrid[currentCell.RowNumber, currentCell.ColumnNumber + i].LegalNextMove = true;
                    }
                    // Left
                    for (int i = 1; i < 8; i++)
                    {
                        theGrid[currentCell.RowNumber, currentCell.ColumnNumber - i].LegalNextMove = true;
                    }
                    break;

                default: 
                    break;
            }
        }
    }
}
