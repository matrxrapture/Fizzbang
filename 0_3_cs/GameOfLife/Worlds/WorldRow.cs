using System.Collections.Generic;
using GameOfLife.Rules;
using GameOfLife.Worlds.Cells;

namespace GameOfLife.Worlds
{
    public class WorldRow
    {
        private readonly List<WorldCell> cells = new List<WorldCell>();

        public WorldRow(int rowNumber)
        {
            RowNumber = rowNumber;
        }

        public int RowNumber { get; private set; }

        public IEnumerable<WorldCell> Cells
        {
            get { return cells; }
        }

        public void AddCell(bool alive)
        {
            cells.Add(new WorldCell(cells.Count, RowNumber, alive));
        }

        public override string ToString()
        {
            return string.Format("I am row {0}", RowNumber);
        }

        public void ApplyTransitions()
        {
            foreach (var cell in Cells)
            {
                cell.ApplyTransition();
            }
        }
    }
}