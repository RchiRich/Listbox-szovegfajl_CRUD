using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Listbox_szovegfajl_CRUD
{
    public partial class Form_Gyumolcs : Form
    {
        string muvelet;
        public Form_Gyumolcs(string muvelet, Object param=null)
        {
            InitializeComponent();
            this.muvelet = muvelet;
            switch (muvelet)
            {
                case "insert":
                    button1.Text = "ENTER";
                    this.Text = "Új gyümölcsök ";
                    break;
                case "update":
                    button1.Text = "VÁLTOZTAT";
                    this.Text = "Új gyümölcsök adatainak módosítása ";
                    //Gyumolcs dolgozo = (Gyumolcs)Program.nyitoForm.listBox_Gyumolcsok.SelectedItem;
                    Gyumolcs gyumolcs = (Gyumolcs)param;
                    textBox_termekKod.Text = gyumolcs.Termekkod.ToString();
                    textBox_nev.Text = gyumolcs.Nev.ToString();
                    textBox_mennyiseg.Text = gyumolcs.Mennyiseg.ToString();
                    break;
                default:
                    break;
            }
        }


        private void Form_Gyumolcs_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (muvelet)
            {
                case "insert":
                    ujGyumolcs();
                    break;
                case "update":
                    modosit();
                    break;
            }
 
        }
        private void ujGyumolcs()
        {
            ulong termekkod = (ulong)(Program.nyitoForm.listBox_Gyumolcsok.Items.Count + 1);
            if (string.IsNullOrEmpty(textBox_nev.Text) || string.IsNullOrEmpty(textBox_mennyiseg.Text))
            {
                MessageBox.Show("A rublikák kitőltése kötelező !","Figyelmeztetés", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string nev = textBox_nev.Text;

            if (!int.TryParse(textBox_mennyiseg.Text, out int mennyiseg) || mennyiseg <= 0)
            {
                MessageBox.Show("Hibás adat vagy mértékegység a rublikában !","Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Gyumolcs ujgyumolcs = new Gyumolcs(termekkod, nev, mennyiseg);
            Program.nyitoForm.listBox_Gyumolcsok.Items.Add(ujgyumolcs);
            this.Close(); 
        }

        private void modosit()
        {
            ulong termekkod = ulong.Parse(textBox_termekKod.Text);
            if (string.IsNullOrEmpty(textBox_nev.Text) || string.IsNullOrEmpty(textBox_mennyiseg.Text))
            {
                MessageBox.Show("A rublikák kitőltése kötelező !", "Figyelmeztetés", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string nev = textBox_nev.Text;

            if (!int.TryParse(textBox_mennyiseg.Text, out int mennyiseg) || mennyiseg <= 0)
            {
                MessageBox.Show("Hibás adat vagy mértékegység a rublikában !", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Gyumolcs ujgyumolcs = new Gyumolcs(termekkod, nev, mennyiseg);
            Program.nyitoForm.listBox_Gyumolcsok.Items.Add(ujgyumolcs);
            this.Close();
        }
            




        /*
                private void modosit()
                {
                    ulong id = ulong.Parse(textBox_termekKod.Text);
                    if (String.IsNullOrEmpty(textBox_nev.Text))
                    {
                        MessageBox.Show("Hiányzó adat .Kitöltése kötelező!");
                        textBox_nev.Focus();
                        return;
                    }
                    // az adatok elfogadhatóak
                    Gyumolcs gyumolcs = new Gyumolcs(id, nev, mennyiseg);
                    foreach (Gyumolcs item in Program.nyitoForm.listBox_Gyumolcsok.Items)
                    {
                        if (item.Id == id)
                        {
                            Program.nyitoForm.listBox_Gyumolcsok.Items.Remove(item);
                            this.Close();
                        }
                    }

                    Program.nyitoForm.listBox_Gyumolcsok.Items.Add(gyumolcs);
                }*/
    }
}
