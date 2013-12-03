using System.Linq;
using System.Collections.Generic;

namespace GameOfLife.Worlds.Loaders
{
    public class RowConfiguration
    {
        private readonly List<CellConfiguration> cells = new List<CellConfiguration>();

        public RowConfiguration()
        {
        }

        public IEnumerable<CellConfiguration> GetCells()
        {
            return cells;
        }

        public void AddCell(CellConfiguration cell)
        {
            cells.Add(cell);
        }

        public override string ToString()
        {
            return string.Format("I have {0} living cells", cells.Count(c => c.Alive));
        }
    }
}