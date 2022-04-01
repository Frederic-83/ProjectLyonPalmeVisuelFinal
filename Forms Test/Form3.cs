using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms_Test
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'fdegaudemarDataSet2.VMat'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.vMatTableAdapter.Fill(this.fdegaudemarDataSet2.VMat);
            // TODO: cette ligne de code charge les données dans la table 'fdegaudemarDataSet2.VPalmes'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.vPalmesTableAdapter.Fill(this.fdegaudemarDataSet2.VPalmes);

        }
    }
}
