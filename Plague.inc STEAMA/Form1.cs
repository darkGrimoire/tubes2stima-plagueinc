using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using Microsoft.Msagl;
using Microsoft.Msagl.GraphViewerGdi;

namespace Plague.inc_STEAMA
{
    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void panelLowerThird_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelMainMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelSideMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        bool hasStarted = false;
        private void startButton_Click(object sender, EventArgs e)
        {
            if (!hasStarted)
            {
            hasStarted = true;
            string temp2 = textBoxHari.Text;
            int hari = Convert.ToInt32(temp2);
            PlagueInc testing = new PlagueInc(textBoxPeta.Text, textBoxPopulasi.Text);
            testing.mulaiPenyebaran(hari);
            }
        }
        private void resetButton_Click(object sender, EventArgs e)
        {
            if (hasStarted)
            {
                hasStarted = false;
                textBoxHari.Text = "Hari Infeksi ke:";
                textBoxPeta.Text = "File Peta:";
                textBoxPopulasi.Text = "File Populasi";
                textBoxPeta.ForeColor = System.Drawing.SystemColors.InactiveCaption;
                textBoxHari.ForeColor = System.Drawing.SystemColors.InactiveCaption;
                textBoxPopulasi.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            }
        }
        private void browseButtonPeta_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
                InitialDirectory = @"C:\",
                Title = "Browse Text Files",

                CheckFileExists = true,
                CheckPathExists = true,

                DefaultExt = "txt",
                Filter = "txt files (*.txt)|*.txt",
                FilterIndex = 2,
                RestoreDirectory = true,

                ReadOnlyChecked = true,
                ShowReadOnly = true
            };

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBoxPeta.TextAlign = HorizontalAlignment.Right;
                textBoxPeta.Text = openFileDialog1.FileName;
                textBoxPeta.ForeColor = System.Drawing.SystemColors.WindowText;
            }
        }
        private void browseButtonPopulasi_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
                InitialDirectory = @"C:\",
                Title = "Browse Text Files",

                CheckFileExists = true,
                CheckPathExists = true,

                DefaultExt = "txt",
                Filter = "txt files (*.txt)|*.txt",
                FilterIndex = 2,
                RestoreDirectory = true,

                ReadOnlyChecked = true,
                ShowReadOnly = true
            };

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBoxPopulasi.TextAlign = HorizontalAlignment.Right;
                textBoxPopulasi.Text = openFileDialog1.FileName;
                textBoxPopulasi.ForeColor = System.Drawing.SystemColors.WindowText;
            }
        }

        bool hasBeenClicked = false;

        private void textBoxHari_Click(object sender, EventArgs e)
        {
            if (!hasBeenClicked)
            {
                textBoxHari.ForeColor = System.Drawing.SystemColors.WindowText;
                textBoxHari.Text = "";
                hasBeenClicked = true;
            }
        }

        private void textBoxPeta_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxHari_TextChanged(object sender, EventArgs e)
        {

        }
    }

    public class City 
    {
        private Dictionary<City, double> neighbors;
        private string nama;
        private int penduduk, waktuInfeksiAwal;
        private bool statusInfeksi;
        
        public City(int penduduk, string name)
        {
            this.penduduk = penduduk;
            this.waktuInfeksiAwal = 0;
            this.statusInfeksi = false;
            this.nama = name;
            this.neighbors = new Dictionary<City, double>();
        }
        public int getPenduduk()
        {
            return penduduk;
        }
        public int getWaktuInfeksiAwal()
        {
            return waktuInfeksiAwal;
        }
        public double getNeighbors(City B)
        {
            if (this.neighbors.ContainsKey(B))
            {
                return neighbors[B];
            }
            else
            {
                return 0;
            }
        }
        public bool getStatusInfeksi()
        {
            return statusInfeksi;
        }
        public string getNama()
        {
            return nama;
        }

        public void setPenduduk(int penduduk)
        {
            this.penduduk = penduduk;
        }
        public void setWaktuInfeksiAwal(int waktuInfeksiAwal)
        {
            this.waktuInfeksiAwal = waktuInfeksiAwal;
        }
        public void setNeighbors(City B, double trValue)
        {
            this.neighbors.Add(B, trValue);
        }
       
        public void setStatusInfeksi()
        {
            this.statusInfeksi = !(this.statusInfeksi);
        }
    }

    public class Graph
    {
        private System.Windows.Forms.Form form = new System.Windows.Forms.Form();
        private Microsoft.Msagl.GraphViewerGdi.GViewer viewer = new Microsoft.Msagl.GraphViewerGdi.GViewer();
        private Microsoft.Msagl.Drawing.Graph graph = new Microsoft.Msagl.Drawing.Graph();
        public void createNodeEdge(string name1, string name2)
        {
            this.graph.AddEdge(name1, name2).Attr.Color = Microsoft.Msagl.Drawing.Color.Black;            
        }

        public void infectNode(string name)
        {
            this.graph.FindNode(name).Attr.FillColor = Microsoft.Msagl.Drawing.Color.Red;
        }
        public void createInfectedNodeEdge(string name1, string name2)
        {
            this.graph.AddEdge(name1, name2).Attr.Color = Microsoft.Msagl.Drawing.Color.Red;
        }

        public void showResult()
        {
            this.viewer.Graph = this.graph;
            this.form.SuspendLayout();
            this.viewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.form.Controls.Add(this.viewer);
            this.form.ResumeLayout();
            this.form.ShowDialog();
        }
    }

    public class PlagueInc 
    {
        private List<City> daftarKota;
        private int jumlahKota;
        private string kotaAwalInfeksi;

        public PlagueInc(string filePeta, string filePopulasi)
        {
            this.bacaPopulasi(filePopulasi);
            this.bacaPeta(filePeta);
        }

        public void bacaPopulasi(string filePopulasi)
        {
            this.daftarKota = new List<City>();
            string[] lines = File.ReadAllLines(filePopulasi);
            bool first = true;
            foreach (string line in lines)
            {
                string[] words = line.Split(' ');
                if (first)
                {
                    this.jumlahKota = Convert.ToInt32(words[0]);
                    this.kotaAwalInfeksi = words[1];
                    first = false;
                }
                else
                {
                    City X = new City(Convert.ToInt32(words[1]), words[0]);
                    this.daftarKota.Add(X);
                }
            }
        }

        public void bacaPeta(string filePeta)
        {
            string[] lines = File.ReadAllLines(filePeta);
            int num = Convert.ToInt32(lines[0]);
            for (int i = 1; i < num; i++)
            {
                string[] words = lines[i].Split(' ');
                this.getCity(words[0]).setNeighbors(this.getCity(words[1]), double.Parse(words[2], System.Globalization.CultureInfo.InvariantCulture));
            }
        }
        public City getCity(string nama)
        {
            return this.daftarKota.Find(x => x.getNama() == nama);
        }
        
        
        public double fungsiLogistik(City kota, int hari)
        {
            return (kota.getPenduduk() / (1 + (kota.getPenduduk() - 1) * Math.Exp(-0.25 * hari)));
            
        }

        public double fungsiPenyebaran(City A, City B, int hari)
        {
            return fungsiLogistik(A, hari) * A.getNeighbors(B);
        }

        public int getWaktuPenyebaran(City A, City B)
        {
            double temp = Math.Log(((A.getPenduduk() * A.getNeighbors(B)) - 1) / (A.getPenduduk() - 1)) / (-0.25);
            if (temp - Math.Floor(temp) > 0)
            {
                return Convert.ToInt32(Math.Ceiling(temp));
            }
            else
            {
                return Convert.ToInt32(temp + 1);
            }
            
        }

        public void mulaiPenyebaran(int batasHari)
        {
            City kotaAwal = this.getCity(kotaAwalInfeksi);
            List<City> tempAntrian = new List<City>();  /* Queue dari City yang akan dicek */
            Graph graph = new Graph();
            for (int i = 0; i < jumlahKota; i++)
            {
                for (int j = 0; j < jumlahKota; j++)
                {
                    if (daftarKota[i].getNeighbors(daftarKota[j]) != 0)
                    {
                        graph.createNodeEdge(daftarKota[i].getNama(), daftarKota[j].getNama());
                    }
                }
            }
            graph.infectNode(kotaAwal.getNama());
            tempAntrian.Add(kotaAwal);                  /* Menambah City tempat infeksi pertama kali muncul ke Queue */
            kotaAwal.setStatusInfeksi();
            City nowKota = kotaAwal;
            while (tempAntrian.Count != 0)
            {
                City prevKota = nowKota;       /* Menampung City yang sebelumnya dicek */
                nowKota = tempAntrian[0];  /*Menampung City yang akan dicek */
                tempAntrian.RemoveAt(0);
                for (int i = 0; i < jumlahKota; i++)
                {
                    City kotaSelanjutnya = daftarKota[i];
                    if ( (nowKota.getNeighbors(kotaSelanjutnya) != 0)  )
                    {
                        double probabilitasPenyebaran = fungsiPenyebaran(nowKota, kotaSelanjutnya, batasHari - nowKota.getWaktuInfeksiAwal());
                        if ((probabilitasPenyebaran > 1) && (kotaSelanjutnya != prevKota))
                        {
                            int waktuPenyebaran = getWaktuPenyebaran(nowKota, kotaSelanjutnya);
                            if (!kotaSelanjutnya.getStatusInfeksi())
                            {
                                kotaSelanjutnya.setStatusInfeksi();
                                kotaSelanjutnya.setWaktuInfeksiAwal(waktuPenyebaran + nowKota.getWaktuInfeksiAwal());
                                tempAntrian.Add(kotaSelanjutnya);
                                graph.infectNode(kotaSelanjutnya.getNama());
                            }
                            graph.createInfectedNodeEdge(nowKota.getNama(), kotaSelanjutnya.getNama());
                        }
                    }
                }
            }
            
            graph.showResult();

        }

        



    }

}
