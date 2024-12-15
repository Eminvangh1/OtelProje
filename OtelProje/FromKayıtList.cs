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
    public partial class FromKayıtList : Form
    {
        public FromKayıtList()
        {
            InitializeComponent();
        }

        private void FromKayıtList_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'otelDataSet2.Kayıt' table. You can move, or remove it, as needed.
            this.kayıtTableAdapter.Fill(this.otelDataSet2.Kayıt);

        }
    }
}
