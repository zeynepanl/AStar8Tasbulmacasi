using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A_star_8tasbulmacasi
{
    public partial class hedefmatrisform : Form
    {
        private TextBox[,] txtHedefMatris;

        public int[,] HedefMatris { get; private set; }
        public int EmptyTileRow { get; private set; }
        public int EmptyTileCol { get; private set; }

        public hedefmatrisform()
        {
            InitializeComponent();
            // TextBox dizisini oluştur
            txtHedefMatris = new TextBox[,]
            {
                { txtHedef00, txtHedef01, txtHedef02 },
                { txtHedef10, txtHedef11, txtHedef12 },
                { txtHedef20, txtHedef21, txtHedef22 }
            };
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            // TextBox'lardan alınan değerleri bir matrise çevir
            HedefMatris = new int[3, 3];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j++)
                {

                }
            }
        }
    }
}
    

