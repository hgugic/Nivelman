using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using System.Globalization;
using Geodezija.MetodaNajmanjihKvadrata;
using MathNet.Numerics.LinearAlgebra.Double;


namespace NIvelman
{


    public class Statistika
    {
        PosrednoIzjednacenje mnk;
        LokalniTestDataSnooping baarda;
        LokalniTestTau tauTest;
        double alfa, beta;
        int f;

        List<double> G = new List<double>();
        List<double> Delta = new List<double>();

        string gtest;
        GlobalniTest globTest;

        public GlobalniTest GlobTest
        {
            get
            {
                return globTest;
            }

            set
            {
                globTest = value;
            }
        }

        public string Gtest
        {
            get
            {
                return gtest;
            }

            set
            {
                gtest = value;
            }
        }

        public Statistika(PosrednoIzjednacenje mnk, double sigmaNulaKvadrat, double alfa, double beta, int f, double alfaGlob)
        {
            this.alfa = alfa;
            this.beta = beta;
            this.f = f;
            this.mnk = mnk;


            baarda = new LokalniTestDataSnooping(sigmaNulaKvadrat, mnk.v, mnk.Ql, mnk.R, alfa, beta);
            tauTest = new LokalniTestTau(mnk.sKvadrat, mnk.v, mnk.Qv, alfa, f);
            Gi(sigmaNulaKvadrat);

            globTest = new GlobalniTest(sigmaNulaKvadrat, mnk.sKvadrat, f, alfaGlob);
            gtest = "Globalni test: " + globTest.Minimum.ToString() + " < " + sigmaNulaKvadrat.ToString() + " < " + globTest.Maximum.ToString() + " : ";

            if (globTest.TestProlazi)
                gtest = gtest + " OK";
            else
                gtest = gtest + " Pad testa :(";
        }


        

        private void Gi(double sigmaNulaKvadrat)
        {
            DenseVector p = (DenseVector)mnk.Ql.Inverse().Diagonal();
            DenseVector qv = (DenseVector)mnk.Qv.Diagonal();

            DenseVector r = (DenseVector)mnk.R.Diagonal();
            DenseVector sigmaL = mnk.sKvadrat * (DenseVector)mnk.Qlcap.Diagonal();

            //-------------------------------------------------------------------ovdje ide delta----------------------------
            for (int i = 0; i < p.Count; i++)
            {
                double g = sigmaNulaKvadrat * baarda.LambdaKorijen / (p[i] * Math.Sqrt(qv[i]));
                G.Add(g);

                double d = Math.Sqrt(sigmaL[i]) / Math.Sqrt(r[i]);
                Delta.Add(d);

                     
            }

        }

        public void LokalniTest(ListView lv, ListView Tezina)
        {
            lv.Clear();

            lv.Columns.Add("Mjerenje");

            lv.Columns.Add("Data snooping");
            lv.Columns.Add("T(α=" + alfa + ", β=" + beta + ")");
            lv.Columns.Add("Test [prolazi]");
            lv.Columns.Add("Gi");
            lv.Columns.Add("Δi");

            lv.Columns.Add("Tau");
            lv.Columns.Add("T(α=" + alfa + ", f=" + f + ")");
            lv.Columns.Add("Test [prolazi]");

            for (int i = 0; i < Tezina.Items.Count; i++)
            {
                ListViewItem item = new ListViewItem(Tezina.Items[i].SubItems[0].Text);
                item.SubItems.Add(baarda.tList[i].ToString());
                item.SubItems.Add(baarda.LambdaKorijen.ToString());


                if(baarda.RezultatTesta()[i])
                    item.SubItems.Add("DA");
                else
                    item.SubItems.Add("-NE-");

                item.SubItems.Add(G[i].ToString());
                item.SubItems.Add(Delta[i].ToString());


                item.SubItems.Add(tauTest.TauList[i].ToString());
                item.SubItems.Add(tauTest.TauDistribucija.ToString());

                if (tauTest.RezultatTesta()[i])
                    item.SubItems.Add("DA");
                else
                    item.SubItems.Add("-NE-");

                lv.Items.Add(item);
            }


        }


    }
}
