﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conway.Library
{
    public enum CellState

{
    Alive,
    Dead
}
    public class LifeRules
    {
        public static CellState GetNewState(CellState currentState, int liveNeighbors)
        {
            switch (currentState)
            {
                case CellState.Alive:
                    if(liveNeighbors < 2 || liveNeighbors > 3)
                        return CellState.Dead;
                    break;

                case CellState.Dead:
                    if(liveNeighbors == 3)
                        return CellState.Alive;
                    break;

            }
            //if (currentState == CellState.Alive && liveNeighbors < 2)
            //{
            //    return CellState.Dead;
            //}
            //if (currentState == CellState.Alive && liveNeighbors > 3)
            //{
            //    return CellState.Dead;
            //}
            //if (currentState == CellState.Dead && liveNeighbors == 3)
            //{
            //    return CellState.Alive;
            //}
            return currentState;
        }


    }
}