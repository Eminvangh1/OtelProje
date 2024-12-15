using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtelProje
{
    public partial class FormGiderListele : Form
    {
        public FormGiderListele()
        {
            InitializeComponent();
        }

        private void FormGiderListele_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'otelDataSet3.OtelGiderler' table. You can move, or remove it, as needed.
            this.otelGiderlerTableAdapter.Fill(this.otelDataSet3.OtelGiderler);

        }
    }
}
