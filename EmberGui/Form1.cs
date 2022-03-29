using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmberGui
{
    public partial class Form1 : Form
    {
        List<Ember> list;
        public Form1()
        {
            InitializeComponent();
            list = new List<Ember>();
            list.Add(new Ember("Péter", 18, "Róka utca", 133000));
        }

        private void Feltolt_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = list;
        }

        private void Hozzáad_Click(object sender, EventArgs e)
        {
            list.Add(new Ember(Nev.Text,Convert.ToInt32(Kor.Text),Cim.Text, Convert.ToInt32(Fizetes.Text)));
            MessageBox.Show("Sikeres hozzáadás", "Hozzáad", MessageBoxButtons.OK);
        }
    }
}
