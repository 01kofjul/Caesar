using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Caeaar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnver_Click(object sender, EventArgs e)
        {
            String klartext = tbin.Text;
            Console.WriteLine("Geben sie den Schlüssel ein");
            int schluessel = Convert.ToInt16(tbs.Text);


            Char[] chararray = klartext.ToCharArray();
            Char[] buchstaben = new char[chararray.Length];
            int[] ascicode = new int[chararray.Length];

            for (int i = 0; i < chararray.Length; i++)
            {
                buchstaben[i] = chararray[i];
                ascicode[i] = Convert.ToInt32(buchstaben[i]);
                
            }

            Console.WriteLine("");

            for (int i = 0; i < ascicode.Length; i++)
            {
                ascicode[i] = ascicode[i] + schluessel;
            }

            string ausgabe = "";
            for (int i = 0; i < chararray.Length; i++)
            {
                chararray[i] = Convert.ToChar(ascicode[i]);
                ausgabe += Convert.ToString(chararray[i]);
                
            }
            tbout.Text = ausgabe;
        }

        private void btnentschl_Click(object sender, EventArgs e)
        {
            String klartext = tbout.Text;
            Console.WriteLine("Geben sie den Schlüssel ein");
            int schluessel = Convert.ToInt16(tbs.Text);

            if (schluessel > 0)            
                schluessel -= (2 * schluessel);
            
            else
            {
                schluessel -= (2 * schluessel);
            }

            Char[] chararray = klartext.ToCharArray();
            Char[] buchstaben = new char[chararray.Length];
            int[] ascicode = new int[chararray.Length];

            for (int i = 0; i < chararray.Length; i++)
            {
                buchstaben[i] = chararray[i];
                ascicode[i] = Convert.ToInt32(buchstaben[i]);

            }

            Console.WriteLine("");

            for (int i = 0; i < ascicode.Length; i++)
            {
                ascicode[i] = ascicode[i] + schluessel;
            }

            string ausgabe = "";
            for (int i = 0; i < chararray.Length; i++)
            {
                chararray[i] = Convert.ToChar(ascicode[i]);
                ausgabe += Convert.ToString(chararray[i]);

            }
            tbent.Text = ausgabe;
        }

        
    }
}
