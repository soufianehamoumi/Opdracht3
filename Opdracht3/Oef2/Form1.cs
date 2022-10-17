using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Oef2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private bool IsEveritingDigit(String text)
        {
            foreach (char c in text)
            {
                if (!(char.IsDigit(c)))
                {
                    return false;
                }
            }
            return true;
        }

        Stapel<int> Integer = new Stapel<int>();
        Stapel<string> strings = new Stapel<string>();
        Stapel<Auto> auto = new Stapel<Auto>();

        private void StapelToe_Click(object sender, EventArgs e)
        {
               if (IsEveritingDigit(stapelLa.Text))
            {
                Integer.VStapel(int.Parse(stapelLa.Text));

            } else
            {
                MessageBox.Show("enkel integers toegelaten ! ");
                StapelToe.Text = null;
            }

            stapelLa.Text = null;
        }




        private void VerStapel_Click(object sender, EventArgs e)
        {
            if (Integer.ToString() != string.Empty)
            {
                Integer.AfStapel();
            }
            else
            {
                MessageBox.Show(" de stapel is al leeg ! ");
            }
        }

        private void LStapel_Click(object sender, EventArgs e)
        {
            Integer.StapelLeeg();

        }



        private void LZStapel_Click(object sender, EventArgs e)
        {
            label5.Text = "tapel nr: " + Integer.ToString();
        }

        private void CLabel_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" old list : " + Integer.ToString() + "\n new list  de nieuwe lijst is : " + " " +
             String.Join(",", Integer.CopyLijst()));
        }



        private void ToeSoort_Click(object sender, EventArgs e)
        {
            strings.VStapel(SoortLa.Text);

            SoortLa.Text = null;

        }

        private void VerSoort_Click(object sender, EventArgs e)
        {

            if (strings.ToString() != string.Empty)
            {
                strings.AfStapel();
            }
            else
            {
                MessageBox.Show("de stapel is al leeg !");
            }

        }

        private void LeegSoort_Click(object sender, EventArgs e)
        {
            strings.StapelLeeg();

        }

        private void ZienSoort_Click(object sender, EventArgs e)
        {
            soort.Text = "soort : " + strings.ToString();


        }

        private void ZoekSoort_Click(object sender, EventArgs e)
        {
            if (Integer.zoekInLable(int.Parse(SoortLa.Text)))
            {

                MessageBox.Show(SoortLa.Text + " " + "is aanwezig op de stapel van integers");
            }
            else
            {
                MessageBox.Show("sorry maar " + SoortLa.Text + " bestaat niet op de stapel");
            }

            SoortLa.Text = null;
        }

        private void CopySoort_Click(object sender, EventArgs e)
        {
            MessageBox.Show(strings.ToString() + "\n de nieuwe lijst is : " + " " +
               String.Join(",", strings.CopyLijst()));

        }

        private void VoegMKM_Click(object sender, EventArgs e)
        {

            if (MerlLa.Text == string.Empty || KMLa.Text == string.Empty)
            {

                MessageBox.Show("beide velden moeten ingevuld worden ! ");

            }
            else if (IsEveritingDigit(KMLa.Text) == false)
            {
                MessageBox.Show(" leeftijd moet enkel getallen bevatten");
            }

            else
            {
                auto.VStapel(new Auto(MerlLa.Text, double.Parse(KMLa.Text)));
            }

            MerlLa.Text = null;
            KMLa.Text = null;

        }

        private void VerMKM_Click(object sender, EventArgs e)
        {
            if (auto.ToString() != string.Empty)
            {
                auto.AfStapel();
            }
            else
            {
                MessageBox.Show("sorry maar de stapel is al leeg !");
            }

        }

        private void LeegMKM_Click(object sender, EventArgs e)
        {
            auto.StapelLeeg();
        }

        private void ZienMKM_Click(object sender, EventArgs e)
        {
            label7.Text = "merkt : " + auto.ToString();

        }

        private void ZoekMKM_Click(object sender, EventArgs e)
        {
            if ( auto.zoekInLable(new Auto(MerlLa.Text, int.Parse(KMLa.Text))))
            {
                MessageBox.Show(" de persoon met naam : " + " " + MerlLa.Text + " en met leeftijd : " + " " + KMLa.Text + " " + "is aanwezig in de lijst van personen");
            }
            else
            {
                MessageBox.Show("de persoon met naam : " + " " + MerlLa.Text + " " + "bestaat niet in de lijst");
            }
        }

        private void CopyMKM_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" old list : " + auto.ToString() + "\n new list  de nieuwe lijst is : " + " " +
               String.Join(":", auto.CopyLijst()));
        }
    }
}
