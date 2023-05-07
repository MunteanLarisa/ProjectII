using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proiect.Views;
using Proiect.Presenters;

namespace Proiect
{
<<<<<<< HEAD:Proiect/MainPage.cs
    public partial class MainPage : Form
    {
        public MainPage()
=======
    public partial class Form1 : Form, IPachete
    {
        public string Destinatia { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string OrasDePlecare { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Transport { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DateTime DataPlecarii { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int NrDeNopti { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int NrDeCamere { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int Adulti { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int Copii { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string PetFriendly { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public Form1()
>>>>>>> 828e088114de08e4732d6fb33093224112fda8ba:Proiect/Form1.cs
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

<<<<<<< HEAD:Proiect/MainPage.cs
        private void label3_Click(object sender, EventArgs e)
=======
        private void tabPage1_Click(object sender, EventArgs e)
>>>>>>> 828e088114de08e4732d6fb33093224112fda8ba:Proiect/Form1.cs
        {

        }

<<<<<<< HEAD:Proiect/MainPage.cs
        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label25_Click(object sender, EventArgs e)
        {
=======
        private void DestmenuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

            PachetePresenter presenter = new PachetePresenter(this);
            
>>>>>>> 828e088114de08e4732d6fb33093224112fda8ba:Proiect/Form1.cs

        }
    }


}
