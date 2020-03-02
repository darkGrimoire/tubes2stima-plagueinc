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
    }

    public class City 
    {
        private Dictionary<City, double> neighbors;
        private int penduduk, waktuInfeksiAwal;
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

        public void setWaktuInfeksiAwal(int waktuInfeksiAwal)
        {
            this.waktuInfeksiAwal = waktuInfeksiAwal;
        }
    }


    public class PlagueInc 
    {
        private List<City> cityColection;
        int jumlahCity;
        public double fungsiLogistik(City kota, int hari)
        {
            return (kota.getPenduduk() / (1 + (kota.getPenduduk() - 1)*Math.Exp(-0.25*hari-kota.getT())));
        }

        public double fungsiPenyebaran(City A, City B, int hari)
        {
            return fungsiLogistik(A, hari) * A.getNeighbors(B);
        }

        public void initializeCity()
        {
            
        }




    }

}
