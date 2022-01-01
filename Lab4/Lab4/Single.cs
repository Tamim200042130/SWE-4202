using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    internal class SingleRoom

    {
        private string name;
        private int tV;
        private int refrigerator;
        private int qty;
        private int airCondition;

        public SingleRoom()
        {
        }

        public SingleRoom(string name, int tV, int refrigerator, int qty, int airCondition)
        {
            this.name = name;
            this.tV = tV;
            this.refrigerator = refrigerator;
            this.qty = qty;
            this.airCondition = airCondition;
        }

        public static implicit operator List<object>(SingleRoom v)
        {
            throw new NotImplementedException();
        }
    }
}
