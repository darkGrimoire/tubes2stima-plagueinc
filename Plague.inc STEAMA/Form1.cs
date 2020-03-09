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
    }

    public class City 
    {
        private Dictionary<City, double> neighbors;
        private int penduduk, waktuInfeksiAwal;
        private bool statusInfeksi;
        public int getPenduduk()
        {
            return penduduk;
        }
        public int getT()
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

        public void setWaktuInfeksiAwal(int waktuInfeksiAwal)
        {
            this.waktuInfeksiAwal = waktuInfeksiAwal;
        }
        public void setStatusInfeksi()
        {
            statusInfeksi = !(statusInfeksi);
        }
    }

    /*public class ListCity
    {
        private List<City> daftarKota;
        private int jumlahKota;
        public int getJumlahKota()
        {
            return jumlahKota;
        }
        public City getCity(int temp)
        {
            return daftarKota[temp];
        }

    }*/

    public class PlagueInc 
    {
        private List<City> daftarKota;
        private int jumlahKota;
        public double fungsiLogistik(City kota, int hari)
        {
            return (kota.getPenduduk() / (1 + (kota.getPenduduk() - 1)*Math.Exp(-0.25*hari-kota.getT())));
        }

        public double fungsiPenyebaran(City A, City B, int hari)
        {
            return fungsiLogistik(A, hari) * A.getNeighbors(B);
        }

        public int getWaktuPenyebaran(City A, City B)
        {
            return Convert.ToInt32(Math.Ceiling(Math.Log((A.getPenduduk() * A.getNeighbors(B) - 1) / (A.getPenduduk() - 1)) / (-0.25)));
        }

        public void mulaiPenyebaran(City kotaAwal, int batasHari)
        {
            List<City> tempAntrian = new List<City>();
            tempAntrian.Add(kotaAwal);
            kotaAwal.setStatusInfeksi();

            while (tempAntrian.Count != 0)
            {
                City prevKota = kotaAwal;
                City nowKota = tempAntrian[0];
                tempAntrian.RemoveAt(0);
                for (int i = 0; i < jumlahKota; i++)
                {
                    City kotaSelanjutnya = daftarKota[i];
                    if ((nowKota != kotaSelanjutnya) && (nowKota.getNeighbors(kotaSelanjutnya) != 0) && (kotaSelanjutnya != prevKota) )
                    {
                        double probabilitasPenyebaran = fungsiPenyebaran(nowKota, kotaSelanjutnya, batasHari);
                        if (probabilitasPenyebaran > 1)
                        {
                            int waktuPenyebaran = getWaktuPenyebaran(nowKota, kotaSelanjutnya);
                            if (!kotaSelanjutnya.getStatusInfeksi())
                            {
                                kotaSelanjutnya.setStatusInfeksi();
                                kotaSelanjutnya.setWaktuInfeksiAwal(waktuPenyebaran);
                                tempAntrian.Add(kotaSelanjutnya);
                            }
                        }
                    }
                }
            }
        }

        



    }

}
