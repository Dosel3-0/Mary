using MySql.Data.MySqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        private List<Kontinent> KontinentList;
        private Datenbank db = new Datenbank();


        public Form1()
        {
            InitializeComponent();
            KontinentList = db.getKontinente();
            dispKontinente();
        }

        private void dispKontinente()
        {
            foreach (Kontinent k in KontinentList)
            {
                listBox1.Items.Add(k.KontName);
                listBox2.Items.Add(k.KontLoc);
                listBox3.Items.Add(k.KontDesc);
            }
        }

        private void listbox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                textBox1.Text = KontinentList[listBox1.SelectedIndex].KontNr.ToString();
                textBox2.Text = KontinentList[listBox1.SelectedIndex].KontName;
            }
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
