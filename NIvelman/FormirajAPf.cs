using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NIvelman
{
    public enum vrstaIzjednacenja
    {
        MinimalniTrag,
        ParcijalniMinimalniTrag,
        KlasicanNacin,
        IzjednacenjePrisila

    }

    public class FormirajAPf
    {
        public void FormirajA(ListView A, ListView Tocke, ListView Mjerenja, vrstaIzjednacenja vrsta)
        {
            #region postavke ListView-a

            A.Clear();
            A.Columns.Add("Mjerenje");

            foreach (ListViewItem item in Tocke.Items)
            {
                string tocka = item.SubItems[1].Text;
                bool postoji = false;

                foreach (ColumnHeader header in A.Columns)
                {
                    if (header.Text == tocka)
                    {
                        postoji = true;
                        break;
                    }
                }

                if (postoji == false)
                {
                    A.Columns.Add(tocka);
                }

            }

            #endregion postavke ListView-a

            #region postavljanje elemenata u matricu 

            foreach (ListViewItem item in Mjerenja.Items)
            {
                string Od = item.SubItems[1].Text;
                string Do = item.SubItems[2].Text;

                ListViewItem ItemForA = new ListViewItem( Od + "-" + Do);

                foreach (ColumnHeader header in A.Columns)
                {
                    if (header.Text == "Mjerenje")
                    {
                    }
                    else if (header.Text == Od)
                    {
                        ItemForA.SubItems.Add("-1");
                    }
                    else if (header.Text == Do)
                    {
                        ItemForA.SubItems.Add("1");
                    }
                    else
                    {
                        ItemForA.SubItems.Add("0");
                    }
                }

                A.Items.Add(ItemForA);


            }

            #endregion postavljanje elemenata u matricu 

            #region izbacivanje elemenata iz izjednacenja s prisilom

            if (vrsta == vrstaIzjednacenja.IzjednacenjePrisila)
            {
                List<string> columnsToRemove = new List<string>();

                foreach (ListViewItem item in Tocke.Items)
                {
                    if (item.Checked)
                        columnsToRemove.Add(item.SubItems[1].Text);
                }

                foreach (string column in columnsToRemove)
                {
                    int i = -1;

                    foreach (ColumnHeader h in A.Columns)
                    {
                        i++;

                        if (h.Text == column)
                        {
                            A.Columns.Remove(h);

                            foreach (ListViewItem lvi in A.Items)
                            {
                                lvi.SubItems.RemoveAt(i);
                            }
                            

                        }
                            
                    }
                }
            }

            foreach (ListViewItem item in A.Items)
            {
               int i =  item.SubItems.Count;
            }

                #endregion izbacivanje elemenata iz izjednacenja s prisilom

            }

        public void FormirajP(ListView P, ListView Tocke, ListView Mjerenja)
        {
            #region postavke ListView-a

            P.Clear();
            P.Columns.Add("Mjerenje");


            foreach (ListViewItem item in Mjerenja.Items)
            {
                string mjerenje = item.SubItems[1].Text + "-" + item.SubItems[2].Text;
                P.Columns.Add(mjerenje);
            }

            #endregion postavke ListView-a

            #region Matrica

            foreach (ListViewItem item in Mjerenja.Items)
            {
                string mjerenje = item.SubItems[1].Text + "-" + item.SubItems[2].Text;
                string tezina = item.SubItems[4].Text;


                ListViewItem ItemForP = new ListViewItem(mjerenje);

                foreach (ColumnHeader header in P.Columns)
                {
                    if (header.Text == "Mjerenje")
                    {
                    }
                    else if (header.Text == mjerenje)
                    {
                        ItemForP.SubItems.Add(tezina);
                    }
                    else
                    {
                        ItemForP.SubItems.Add("0");
                    }
                }

                P.Items.Add(ItemForP);

            }

            #endregion Matrica

        }

        public void Formirajf(ListView f, ListView Tocke, ListView Mjerenja)
        {
            f.Clear();
            f.Columns.Add("Mjerenje");
            f.Columns.Add("f");

            #region Vektor

            foreach (ListViewItem item in Mjerenja.Items)
            {
                string mjerenje = item.SubItems[1].Text + "-" + item.SubItems[2].Text;
                string F = item.SubItems[3].Text;

                ListViewItem ItemForf = new ListViewItem(mjerenje);
                ItemForf.SubItems.Add(F);
                f.Items.Add(ItemForf);
            }

            #endregion Vektor

        }

        public void FormirajG(ListView G, ListView Tocke, vrstaIzjednacenja vrsta)
        {
            G.Clear();
            G.Columns.Add("Mjerenje");
            G.Columns.Add("G");

            switch (vrsta)
            {
                case vrstaIzjednacenja.MinimalniTrag:

                    foreach (ListViewItem item in Tocke.Items)
                    {
                        ListViewItem itemForG = new ListViewItem(item.SubItems[1].Text);
                        itemForG.SubItems.Add("1");
                        G.Items.Add(itemForG);
                    }

                    break;

                case vrstaIzjednacenja.ParcijalniMinimalniTrag:

                    foreach (ListViewItem item in Tocke.Items)
                    {
                        ListViewItem itemForG = new ListViewItem(item.SubItems[1].Text);

                        if(item.Checked)
                            itemForG.SubItems.Add("1");
                        else
                            itemForG.SubItems.Add("0");

                        G.Items.Add(itemForG);
                    }

                    break;
                case vrstaIzjednacenja.KlasicanNacin:

                    foreach (ListViewItem item in Tocke.Items)
                    {
                        ListViewItem itemForG = new ListViewItem(item.SubItems[1].Text);

                        if (item.Checked)
                            itemForG.SubItems.Add("1");
                        else
                            itemForG.SubItems.Add("0");

                        G.Items.Add(itemForG);
                    }

                    break;
                case vrstaIzjednacenja.IzjednacenjePrisila:
                    G.Clear();
                    break;
                default:
                    G.Clear();
                    break;
            }
        }
    }
}
