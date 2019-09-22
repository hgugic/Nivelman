using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MathNet.Numerics;
using MathNet.Numerics.LinearAlgebra.Double;
using System.Globalization;

namespace NIvelman
{
    public class MatrixVectorAndControls
    {
        #region Matrica u TabPage

        public void MatrixToListView(ListView lv, DenseMatrix matrica, List<string> lvColumnHeader, List<string> RowName)
        {
            lv.View = View.Details;
            lv.FullRowSelect = true;
            lv.GridLines = true;

            lv.Columns.Add("");

            foreach (string header in lvColumnHeader)
            {
                lv.Columns.Add(header);
            }

            for (int i = 0; i < matrica.RowCount; i++)
            {
                ListViewItem item = new ListViewItem(RowName[i]);

                for (int j = 0; j < matrica.ColumnCount; j++)
                {
                    item.SubItems.Add(matrica[i, j].ToString());
                }
                lv.Items.Add(item);
            }
        }

        public void VectorToListView(ListView lv, DenseVector vektor, string lvColumnHeader, List<string> RowName)
        {
            lv.View = View.Details;
            lv.FullRowSelect = true;
            lv.GridLines = true;

            lv.Columns.Add("");
            lv.Columns.Add(lvColumnHeader);

            for (int i = 0; i < vektor.Count; i++)
            {
                ListViewItem item = new ListViewItem(RowName[i]);
                item.SubItems.Add(vektor[i].ToString());
                lv.Items.Add(item);
            }
        }

        public void ListViewToTabPage(TabControl tc, string tabPage, ListView lv)
        {
            TabPage tp = new TabPage(tabPage);
            tp.Name = tabPage;
            tp.Controls.Add(lv);
            lv.Dock = DockStyle.Fill;
            tc.TabPages.Add(tp);

        }

        public void MatrixToTabPage(TabControl tc, string tabPage, ListView lv, DenseMatrix matrica, List<string> lvColumnHeader, List<string> RowName)
        {
            MatrixToListView(lv, matrica, lvColumnHeader, RowName);
            ListViewToTabPage(tc, tabPage, lv);
        }

        public void VectorToTabPage(TabControl tc, string tabPage, ListView lv, DenseVector matrica, string lvColumnHeader, List<string> RowName)
        {
            VectorToListView(lv, matrica, lvColumnHeader, RowName);
            ListViewToTabPage(tc, tabPage, lv);
        }

        #endregion Matrica u TabPage


        public DenseMatrix ListViewToMatrix(ListView lv)
        {
            int i = lv.Items.Count;
            int j = lv.Columns.Count;

            List<double> kolekcijaBrojevaZaMatricu = new List<double>();

            for (int stupac = 1; stupac < j; stupac++)
            {
                foreach (ListViewItem item in lv.Items)
                {
                    kolekcijaBrojevaZaMatricu.Add(Convert.ToDouble(item.SubItems[stupac].Text));
                    int d = item.SubItems.Count;
                }
            }

            j--; // smanjivanje zbog dimenzija matrice

            double[] mat = kolekcijaBrojevaZaMatricu.ToArray();

            DenseMatrix matrica = new DenseMatrix(i, j, mat);

            return matrica;
        }

        public DenseVector ListViewToVector(ListView lv)
        {
            List<double> kolekcijaBrojevaZaVektor = new List<double>();

            foreach (ListViewItem item in lv.Items)
            {
                kolekcijaBrojevaZaVektor.Add(Convert.ToDouble(item.SubItems[1].Text));
            }

            double[] vektor = kolekcijaBrojevaZaVektor.ToArray();
            DenseVector vector = new DenseVector(vektor);

            return vector;
        }

        public List<string> ListViewColumnHeaderToList(ListView lv)
        {
            List<string> header = new List<string>();

            foreach (ColumnHeader cHeader in lv.Columns)
            {
                header.Add(cHeader.Text);
            }

            header.RemoveAt(0);

            return header;
        }

    }
}
