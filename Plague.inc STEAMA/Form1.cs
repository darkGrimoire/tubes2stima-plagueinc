using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

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

        private void button1_Click(object sender, EventArgs e)
        {
            string temp2 = textBox2.Text;
            int hari = Convert.ToInt32(temp2);
            PlagueInc testing = new PlagueInc();
            string yes = testing.mulaiPenyebaran(testing.getCity(), hari);
            textBox3.Text = yes;
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
            return neighbors[B];
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
        public void setNeighbors(City B, double test)
        {
            this.neighbors.Add(B, test);
        }
       
        public void setStatusInfeksi()
        {
            this.statusInfeksi = !(this.statusInfeksi);
        }
    }

    public class PlagueInc 
    {
        private List<City> daftarKota;
        private int jumlahKota;
        

        public PlagueInc ()
        {
            this.jumlahKota = 4;
            this.daftarKota = new List<City>();
            City a = new City(1000, "a");
            City b = new City(5000, "b");
            City c = new City(1000, "c");
            City d = new City(1000, "d");
            a.setNeighbors(b, 0.02);
            a.setNeighbors(c, 0.005); 
            a.setNeighbors(d, 0);
            b.setNeighbors(a, 0.005);
            b.setNeighbors(c, 0);
            b.setNeighbors(d, 0.005);
            c.setNeighbors(a, 0.1);
            c.setNeighbors(b, 0.1);
            c.setNeighbors(d, 0);
            d.setNeighbors(a, 0.05);
            d.setNeighbors(b, 0);
            d.setNeighbors(c, 0.1);
            daftarKota.Add(a);
            daftarKota.Add(b);
            daftarKota.Add(c);
            daftarKota.Add(d);
        }
        public City getCity()
        {
            return this.daftarKota[0];
        }
        
        
        public double fungsiLogistik(City kota, int hari)
        {
            /*return ( kota.getPenduduk() / (1 + (kota.getPenduduk() - 1)*Math.Exp(-0.25*hari-kota.getPenduduk())) );*/
            return hari * kota.getPenduduk() / 20;
        }

        public double fungsiPenyebaran(City A, City B, int hari)
        {
            return fungsiLogistik(A, hari) * A.getNeighbors(B);
        }

        public int getWaktuPenyebaran(City A, City B)
        {
            /* double temp =Math.Log((A.getPenduduk() * A.getNeighbors(B) - 1) / (A.getPenduduk() - 1)) / (-0.25);
               if (temp - Math.Floor(temp) > 0)
               {
                    return Convert.ToInt32(Math.Ceiling(temp));
               }
               else
               {
                    return Convert.ToInt32(temp + 1);
               }*/
            double temp = 20 / ( A.getPenduduk() * A.getNeighbors(B) )  ;
            if (temp - Math.Floor(temp) > 0)
            {
                return Convert.ToInt32(Math.Ceiling(temp));
            }
            else
            {
                return Convert.ToInt32(temp + 1);
            }
        }

        public string mulaiPenyebaran(City kotaAwal, int batasHari)
        {
            List<City> tempAntrian = new List<City>();  /* Queue dari City yang akan dicek */
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
                    if ((nowKota != kotaSelanjutnya) && 
                        (nowKota.getNeighbors(kotaSelanjutnya) != 0) && 
                        (kotaSelanjutnya != prevKota) )
                    {
                        double probabilitasPenyebaran = fungsiPenyebaran(nowKota, kotaSelanjutnya, batasHari - nowKota.getWaktuInfeksiAwal());
                        if (probabilitasPenyebaran > 1)
                        {
                            int waktuPenyebaran = getWaktuPenyebaran(nowKota, kotaSelanjutnya);
                            if (!kotaSelanjutnya.getStatusInfeksi())
                            {
                                kotaSelanjutnya.setStatusInfeksi();
                                kotaSelanjutnya.setWaktuInfeksiAwal(waktuPenyebaran + nowKota.getWaktuInfeksiAwal());
                                tempAntrian.Add(kotaSelanjutnya);
                            }
                        }
                    }
                }
            }
            string tempText = "";
            for (int i = 0; i< jumlahKota; i++)
            {
                if (daftarKota[i].getStatusInfeksi())
                {
                    tempText = tempText + daftarKota[i].getNama() + " ";
                }
            }

            return tempText;

        }

        



    }

}
