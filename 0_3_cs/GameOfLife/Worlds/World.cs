using System.Collections.Generic;
using System.Linq;
using GameOfLife.Printers;
using GameOfLife.Rules;
using GameOfLife.Worlds.Cells;

namespace GameOfLife.Worlds
{
    public class World
    {
        private readonly List<WorldRow> rows = new List<WorldRow>();

        public void AddRow()
        {
            rows.Add(new WorldRow(rows.Count));
        }

        public void AddCell(bool alive)
        {
            rows.Last().AddCell(alive);
        }

        public IEnumerable<WorldRow> Rows
        {
            get
            {
                return rows;
            }
        }

        public IEnumerable<WorldCell> GetNeighbors(int rowNumber, int cellNumber)
        {
            // implement functionality to find neighbours 
            // for the cell located at the coordinates as defined by rowNumber and cellNumber

            return new List<WorldCell>();
        }

        public void Run(List<IGameOfLifeRule> rules)
        {
            foreach (var rule in rules)
                rule.Apply(this);

            foreach (var row in rows)
                row.ApplyTransitions();
        }

        public void Print(List<IOutputWorldState> outputGenerators)
        {
            foreach (var output in outputGenerators)
            {
                output.Output(this);
            }
        }

    }
}
