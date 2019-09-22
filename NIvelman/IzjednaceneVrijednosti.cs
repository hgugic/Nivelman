using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using System.Globalization;
using Geodezija.MetodaNajmanjihKvadrata;


namespace NIvelman
{
    public class izjednaceneVrijednosti
    {

        public void lvMjerenja(ListView lv, ListView mjerenja, double sigmaNulaKvadrat)
        {
            lv.Clear();

            lv.Columns.Add("Mjerenje");
            lv.Columns.Add("Izmjereno");
            lv.Columns.Add("Popravka [mm]");
            lv.Columns.Add("Izjednaceno mjerenje");
            lv.Columns.Add("Qî[i,i]");
            lv.Columns.Add("√Qî[i,i]");
            lv.Columns.Add("σ² Qî[i,i]");
            lv.Columns.Add("σ √Qî[i,i] (st. dev)");
            lv.Columns.Add("s² Qî[i,i]");
            lv.Columns.Add("s √Qî[i,i] (st. dev)");

            int i = 0;
            foreach (ListViewItem mjerenje in mjerenja.Items)
            {
                ListViewItem item = new ListViewItem(mjerenje.SubItems[1].Text + "-" + mjerenje.SubItems[2].Text);
                item.SubItems.Add(mjerenje.SubItems[5].Text);
                item.SubItems.Add(mnk.v[i].ToString());
                item.SubItems.Add(IzjednacenoMjerenje(Convert.ToDouble(mjerenje.SubItems[5].Text), mnk.v[i]).ToString());

                item.SubItems.Add(mnk.Qlcap[i,i].ToString());
                item.SubItems.Add((Math.Sqrt(mnk.Qlcap[i, i]).ToString()));

     
                item.SubItems.Add((sigmaNulaKvadrat * mnk.Qlcap[i, i]).ToString());
                item.SubItems.Add((Math.Sqrt(sigmaNulaKvadrat * mnk.Qlcap[i, i]).ToString()));

                item.SubItems.Add((mnk.sKvadrat * mnk.Qlcap[i, i]).ToString());
                item.SubItems.Add((Math.Sqrt(mnk.sKvadrat * mnk.Qlcap[i, i]).ToString()));

                i++;

                lv.Items.Add(item);
            }
        }

        public void lvReperi(ListView lv, ListView tocke, double sigmaNulaKvadrat, bool prisila)
        {
            lv.Clear();

            lv.Columns.Add("Reper");
            lv.Columns.Add("Visina");
            lv.Columns.Add("Popravka [mm]");
            lv.Columns.Add("Izjednacena visina");
            lv.Columns.Add("Qx[i,i]");
            lv.Columns.Add("√Qx[i,i]");
            lv.Columns.Add("σ² Qx[i,i]");
            lv.Columns.Add("σ √Qx[i,i] (st. dev)");
            lv.Columns.Add("s² Qx[i,i]");
            lv.Columns.Add("s √Qx[i,i] (st. dev)");

            int i = 0;
            foreach (ListViewItem reper in tocke.Items)
            {
                if (!prisila)
                {
                    ListViewItem item = new ListViewItem(reper.SubItems[1].Text);
                    item.SubItems.Add(reper.SubItems[2].Text);
                    item.SubItems.Add(mnk.x[i].ToString());
                    item.SubItems.Add(IzjednacenoMjerenje(Convert.ToDouble(reper.SubItems[2].Text), mnk.x[i]).ToString());

                    item.SubItems.Add(mnk.Qx[i, i].ToString());
                    item.SubItems.Add((Math.Sqrt(mnk.Qx[i, i]).ToString()));


                    item.SubItems.Add((sigmaNulaKvadrat * mnk.Qx[i, i]).ToString());
                    item.SubItems.Add((Math.Sqrt(sigmaNulaKvadrat * mnk.Qx[i, i]).ToString()));

                    item.SubItems.Add((mnk.sKvadrat * mnk.Qx[i, i]).ToString());
                    item.SubItems.Add((Math.Sqrt(mnk.sKvadrat * mnk.Qx[i, i]).ToString()));

                    i++;

                    lv.Items.Add(item);
                }
                else
                {
                    if(reper.Checked)
                    {
                        ListViewItem item = new ListViewItem(reper.SubItems[1].Text);
                       
                    }
                    else
                    {
                        ListViewItem item = new ListViewItem(reper.SubItems[1].Text);
                        item.SubItems.Add(reper.SubItems[2].Text);
                        item.SubItems.Add(mnk.x[i].ToString());
                        item.SubItems.Add(IzjednacenoMjerenje(Convert.ToDouble(reper.SubItems[2].Text), mnk.x[i]).ToString());

                        item.SubItems.Add(mnk.Qx[i, i].ToString());
                        item.SubItems.Add((Math.Sqrt(mnk.Qx[i, i]).ToString()));


                        item.SubItems.Add((sigmaNulaKvadrat * mnk.Qx[i, i]).ToString());
                        item.SubItems.Add((Math.Sqrt(sigmaNulaKvadrat * mnk.Qx[i, i]).ToString()));

                        item.SubItems.Add((mnk.sKvadrat * mnk.Qx[i, i]).ToString());
                        item.SubItems.Add((Math.Sqrt(mnk.sKvadrat * mnk.Qx[i, i]).ToString()));

                        i++;

                        lv.Items.Add(item);
                    }
                }
            }
        }

        PosrednoIzjednacenje mnk;
        //double sigmaNulaKvadrat = 0;



        public izjednaceneVrijednosti(PosrednoIzjednacenje mnk)
        {
            this.mnk = mnk;
            //this.sigmaNulaKvadrat = sigmaNulaKvadrat;
        }

        private double IzjednacenoMjerenje(double mjerenje, double popravka)
        {
            return mjerenje + popravka / 1000;
        }





    }
}
