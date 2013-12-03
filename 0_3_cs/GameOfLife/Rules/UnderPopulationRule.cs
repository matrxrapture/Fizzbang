﻿using System;
using System.Linq;
using Common.Logging;
using GameOfLife.Worlds;
using GameOfLife.Worlds.Cells;

namespace GameOfLife.Rules
{
    public class UnderPopulationRule : IGameOfLifeRule
    {
        private static readonly ILog log = LogManager.GetLogger<UnderPopulationRule>();

        public void Apply(World world)
        {
            foreach (var row in world.Rows)
            {
                ApplyRule(world, row);
            }
        }

        private void ApplyRule(World world, WorldRow row)
        {
            var baseType = typeof (AliveState);
            foreach (var cell in row.Cells)
            {
                var neighbours = world.GetNeighbors(row.RowNumber, cell.CellNumber);
                var livingCells = neighbours.Count(n => n.State.GetType() == baseType);

                if (livingCells < 2)
                {
                    log.InfoFormat("Killing {0},{1} because less than 2 neighbours, got {2} neighbours", 
                        cell.CellNumber, 
                        cell.RowNumber,
                        livingCells);

                    cell.Die();
                }
                else
                {
                    log.DebugFormat("Ignoring {0}, {1} has {2} neighbours", cell.CellNumber, cell.RowNumber, livingCells);
                }
            }
        }
    }
}