using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StakeBot.Controls
{
    public partial class Mines : UserControl
    {
        


        public Mines()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            List<string> selected = new List<string>();
            int square = 0;
            foreach (StrategySquare sq in sgSelect.Squares)
            {
                if (sq.IsGlowing)
                {
                    selected.Add(square.ToString());
                }

                square++;
            }

            MessageBox.Show(string.Join(",", selected));
        }

        private void Mines_Load(object sender, EventArgs e)
        {
           
        }
    }
}
