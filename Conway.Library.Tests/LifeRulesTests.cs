using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Conway.Library.Tests
{
    /*Any Live cell with fewer than 2 live neighbors dies
     * Any live cell with two or three live neighbors lives
     * Any cell with more than three live neighbors dies
     * Any dead cell with exactly three live neighbors comes to life*/
     [TestFixture]
    public class LifeRulesTests
    {
         [Test]
         public void LiveCell_FewerThan2LiveNeighbors_Dies(
             [Values(0,1)]int liveNeighbors)
         {
             var currentState = CellState.Alive;


             CellState newState = LifeRules.GetNewState(currentState, liveNeighbors);

            Assert.AreEqual(CellState.Dead, newState);
         }

         [Test]
         public void LiveCell_2or3LiveNeighbors_Lives(
             [Values(2, 3)] int liveNeighbors)
         {
            var currentState = CellState.Alive;


            CellState newState = LifeRules.GetNewState(currentState, liveNeighbors);

            Assert.AreEqual(CellState.Alive, newState);
        }

        [Test]
        public void LiveCell_MoreThan3LiveNeighbors_Dies(
             [Range(4,8)] int liveNeighbors)
        {
            var currentState = CellState.Alive;


            CellState newState = LifeRules.GetNewState(currentState, liveNeighbors);

            Assert.AreEqual(CellState.Dead, newState);
        }

         [Test]
         public void DeadCell_HasExactly3LiveNeighbors_Lives()
         {
             var liveNeighbors = 3;

             var currentState = CellState.Dead;

            CellState newState = LifeRules.GetNewState(currentState, liveNeighbors);

            Assert.AreEqual(CellState.Alive, newState);
        }

         [Test]
         public void DeadCell_FewerThan3LiveNeighbors_StaysDead([Range(0, 2)] int liveNeighbors)
         {
            var currentState = CellState.Dead;

            CellState newState = LifeRules.GetNewState(currentState, liveNeighbors);

            Assert.AreEqual(CellState.Dead, newState);
        }

         [Test]
         public void DeadCell_MoreThan3LiveNeighbors_StaysDead([Range(4, 8)] int liveNeighbors)
         {
            var currentState = CellState.Dead;

            CellState newState = LifeRules.GetNewState(currentState, liveNeighbors);

            Assert.AreEqual(CellState.Dead, newState);
        }
    }
}
