using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace StopWatch
{
    public partial class frmCr : Form
    {
        public frmCr()
        {
            InitializeComponent();
        }
        private TimeSpan el=new TimeSpan(0,0,0,0,0);
        private TimeSpan interval = new TimeSpan(0, 0, 0,1,0);

        private void cmdPl_Click(object sender, EventArgs e)
        {
            tmT.Start();
            cmdPl.Enabled = false;
            cmdPp.Enabled = true;
            cmdSt.Enabled = false;
            cmdSv.Enabled = true;
        }

        private void cmdPp_Click(object sender, EventArgs e)
        {
            tmT.Stop();
            cmdPl.Enabled = true;
            cmdPp.Enabled = false;
            cmdSt.Enabled = true;
            cmdSv.Enabled = true;
        }

        private void cmdSt_Click(object sender, EventArgs e)
        {
            el = new TimeSpan(0, 0, 0,0,0);
            txtDs.Text = el.Duration().ToString();
            cmdPl.Enabled = true;
            cmdPp.Enabled = false;
            cmdSt.Enabled = false;
            cmdSv.Enabled = false;
        }

        private void tmT_Tick(object sender, EventArgs e)
        {
            // O objeto TimeSpan "el" adiciona a si mesmo
            // o resultado da soma "el.Duration + el.Add(interval)".
            // Isso é semelhante ao que acontece com "n = n + 1",
            // para que "n" tenha um valor adicionado 1 unidade.
            el=el.Add  (interval);
            txtDs.Text = el.Duration().ToString ();
        }

        private void cmdSv_Click(object sender, EventArgs e)
        {
            lstSv.Items.Add(el.Duration().ToString());
        }
    }
}
