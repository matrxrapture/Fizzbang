using System;

namespace GameOfLife.Worlds.Cells
{
    public class DeadState : IWorldCellState
    {
        private readonly WorldCell cell;
        private IWorldCellState nextState;

        public DeadState(WorldCell cell)
        {
            this.cell = cell;
        }

        public override string ToString()
        {
            return string.Format("Dead with next state {0}", nextState == null ? "NULL" : nextState.ToString());
        }

        public void PrepareTransition(IWorldCellState transitionTo)
        {
            nextState = transitionTo;
        }

        public void Print(Action<string> output)
        {
            output(" ");
        }

        public void ApplyTransition()
        {
            if (nextState == null)
                return;

            cell.State = nextState;
        }
    }
}