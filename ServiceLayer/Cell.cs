using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Reflection.Metadata.BlobBuilder;

namespace ServiceLayer
{
    public class Cell
    {
        public Cell(int positionX, int positionY)
        {
            AdjacentCells = new List<Cell>();
            IsDiscovered = false;
            IsFlagged = false;
            PositionX = positionX;
            PositionY = positionY;
        }
        internal void CalculateValue()
        {
            Value = Convert.ToChar(AdjacentCells.Where(x => x.Value == 'b').Count() + '0');   
        }
        public event EventHandler<EventArgs> RaiseGameOver;
        public char Value { get; set; }
        public int PositionX { get; set; }
        public int PositionY { get; set; }
        public ICollection<Cell> AdjacentCells { get; set; }
        public bool IsDiscovered { get; set; }
        public bool IsFlagged { get; set; }

        public virtual void GameOverCheck()
        {
            if(IsDiscovered && Value == 'b')
            {
                EventHandler<EventArgs> raiseEvent = RaiseGameOver;
                if (raiseEvent != null)
                {
                    raiseEvent(this, new EventArgs());
                }  
            }  
        }

        public override string ToString()
        {
            return Value.ToString();
        }
    }
}
