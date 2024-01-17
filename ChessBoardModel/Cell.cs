using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessBoardModel
{
    internal class Cell
    {
        // Row and Column for the Cells location on the grdi
        public int RowNumber { get; set; }
        public int ColumnNumber { get; set; }

        // T/F; is the chess piece on this cell?
        public bool CurrentlyOccupied { get; set; }

        // T/F; is this cell legal for the chess piece to move to?
        public bool LegalNextMove { get; set; }
    }
}
