using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4
{
    public partial class Form1 : Form
    {

        List<SingleRoom> SingleDeluxRoom = new List<SingleRoom>();
        List<SingleRoom> SingleStandardRoom = new List<SingleRoom>();
        List<SingleRoom> DoubleDeluxRoom = new List<SingleRoom>();
        List<SingleRoom> DoubleSuitRoom = new List<SingleRoom>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string Name = SingleRoomNameBox.Text;
            int TV = Convert.ToInt32(SingleTVBox.Text);
            int Refrigerator = Convert.ToInt32(SingleRefrigeratorBox);
            int Qty = Convert.ToInt32(SingleQtyBox);
            int AirCondition = Convert.ToInt32(SingleAirConditionBox.Text);

          SingleRoom dummy1 = new SingleRoom(Name, TV, Refrigerator, Qty, AirCondition);
          SingleStandardRoom.Add(dummy1);
          MessageBox.Show("Single Standard Room Added Successfully");

          SingleRoom dummy2 = new SingleRoom(Name, TV, Refrigerator, Qty, AirCondition);
          SingleDeluxRoom.Add(dummy2);
          MessageBox.Show("Single Double Room has been  added successfully");

        }

        private void button3_Click(object sender, EventArgs e)
        {
            

        }

        private void button5_Click(object sender, EventArgs e)
        {
            string Name1 = DoubleRoomNameBox.Text;
            int TV1 = Convert.ToInt32(DoubleTVBox.Text);
            int ExtraTV1 = Convert.ToInt32(DoubleExtraTVBox.Text); 
            int Refrigerator1 = Convert.ToInt32(DoubleRefrigeratorBox);
            int Qty1 = Convert.ToInt32(DoubleQtyBox);
            int AirCondition1 = Convert.ToInt32(DoubleAirConditionBox.Text);
        }
    }
}
