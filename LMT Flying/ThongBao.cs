using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LMT_Flying
{
    public partial class ThongBao : Form
    {
        public ThongBao()
        {
            InitializeComponent();
        }
        public string TB { get; set; }
        private void btnOK_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ThongBao_Load(object sender, EventArgs e)
        {
            labelThongBao.Text = TB;
        }
    }
}
