using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    internal class DoubleRoom
    {
        private string name;
        private int tV;
        private int refrigerator;
        private int qty;
        private int airCondition;

        public DoubleRoom(string name, int tV, int refrigerator, int qty, int airCondition, int airCondition1)
        {
            this.name = name;
            this.tV = tV;
            this.refrigerator = refrigerator;
            this.qty = qty;
            this.airCondition = airCondition;
        }
    }
}
