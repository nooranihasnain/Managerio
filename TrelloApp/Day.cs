using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrelloApp
{

    public class Day
    {
        public string DayName { get; set; }
        public List<Task> TList;
        public int DayIndex;
        public int YOffset;
        public Day(string DName, int DIndex)
        {
            YOffset = 0;
            this.DayName = DName;
            this.DayIndex = DIndex;
            TList = new List<Task>();
        }
    }
}
