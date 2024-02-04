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

namespace Listbox_szovegfajl_CRUD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_Insert_Click(object sender, EventArgs e)  //Felvétel
        {
            Form_Gyumolcs form_Gyumolcs = new Form_Gyumolcs("insert");
            form_Gyumolcs.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e) // Betöltés
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog.Title = "Betöltés fájlból";
            openFileDialog.FilterIndex = 1;
            openFileDialog.RestoreDirectory = true;
            openFileDialog.InitialDirectory = Environment.CurrentDirectory;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string adatFile = openFileDialog.FileName;
                listBox_Gyumolcsok.Items.Clear();

                try
                {
                    using (StreamReader sr = new StreamReader(adatFile))
                    {
                        while (!sr.EndOfStream)
                        {
                            string[] sor = sr.ReadLine().Split(';');

                            Gyumolcs ujgyumi = new Gyumolcs(ulong.Parse(sor[0]), sor[1], int.Parse(sor[2]));
                            listBox_Gyumolcsok.Items.Add(adatFile);
                        }
                    }
                    MessageBox.Show("Sikeres betöltés!", "Siker", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Hiba történt a betöltéskor: {ex.Message}", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }

        private void listBox_Gyumolcsok_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void button_Update_Click(object sender, EventArgs e)
        {
            if(listBox_Gyumolcsok.SelectedIndex < 0)
            {
                MessageBox.Show("Nincs kiválasztott adat");
                return;
            }
            Gyumolcs gyumolcs = (Gyumolcs)listBox_Gyumolcsok.SelectedItem;
            listBox_Gyumolcsok.Items.Remove(gyumolcs);
            Form_Gyumolcs form_Gyumolcs = new Form_Gyumolcs("update",gyumolcs);
            form_Gyumolcs.ShowDialog();
        }

        private void button_Load_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog.FilterIndex = 1;
            openFileDialog.RestoreDirectory = true;
            openFileDialog.InitialDirectory = Environment.CurrentDirectory;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string adatFile = openFileDialog.FileName;
                using (StreamReader sr = new StreamReader(adatFile))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] sor = sr.ReadLine().Split(';');
                        Gyumolcs uj= new Gyumolcs(ulong.Parse(sor[0]), sor[1],int.Parse(sor[2]));
                        listBox_Gyumolcsok.Items.Add(uj);
                    }
                }
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button_Delete_Click(object sender, EventArgs e)
        {
            if (listBox_Gyumolcsok.SelectedIndex<0)
            {
                MessageBox.Show("Nincs kiválasztott gyümolcs !");
                return;
            }
            Gyumolcs gyumolcs = (Gyumolcs)listBox_Gyumolcsok.SelectedItem;
            listBox_Gyumolcsok.Items.Remove(gyumolcs);
        }

        private void button_Save_Click(object sender, EventArgs e)
        {

            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 1;
            saveFileDialog1.RestoreDirectory = true;
            saveFileDialog1.InitialDirectory = Environment.CurrentDirectory;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string filename = saveFileDialog1.FileName;
                using (StreamWriter myStream = new StreamWriter(filename))
                {
                    foreach (Gyumolcs item in listBox_Gyumolcsok.Items)
                    {
                        myStream.Write(item.toTxt());
                    }
                    myStream.Flush();
                }
                
            }
        }
    }
}
