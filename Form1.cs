using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace W7__Latihan_Senin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_konversi_Click(object sender, EventArgs e)
        {
            string input = txt_input.Text;
            char[] chars = txt_input.Text.ToUpper().ToCharArray();
            //int index = char.ToUpper(chars[0]);
            int indexAwal = char.ToUpper(txt_hurufsebelum.Text.ToUpper().ToCharArray()[0]);
            int indexSesudah = char.ToUpper(txt_hurufsesudah.Text.ToUpper().ToCharArray()[0]);
            int selisih = 0;
            int[] urutanIndex = new int[99999];
            char[] urutanHuruf = new char[99999];


            //Hitung selisih 
            selisih = indexAwal - indexSesudah;

            //Ganti Character 
            for (int i = 0; i < txt_input.Text.Length; i++)
            {

                //urutanIndex = char.ToUpper(chars[i]) + selisih;
                urutanIndex[i] = char.ToUpper(chars[i]) - selisih;
                
                urutanHuruf[i] = Convert.ToChar(urutanIndex[i]);
                
                if (urutanIndex[i] < 65)
                {
                    urutanIndex[90] = char.ToUpper(chars[i]) - selisih;
                }
                else if (urutanIndex[i] > 90)
                {
                    urutanIndex[65] = char.ToUpper(chars[i]) - selisih;
                }

            }
            //Ganti Character 
           

            
            //Nulis Character
            string output = "";
            for(int j = 0; j < txt_input.Text.Length; j++)
            {


                output += urutanHuruf[j].ToString();



            }
            lbl_hasil.Text = output.ToUpper().ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
