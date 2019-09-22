using System;
using System.Collections.Generic;
using System.Globalization;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MathNet.Numerics.LinearAlgebra.Double;
using Geodezija.MetodaNajmanjihKvadrata;

namespace NIvelman
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;
            
            InitializeComponent();

            radioBtnTezina();
            lblSigmaNula.Text = "σ";
            lblSigmaNulaKvadrat.Text = "σ²";
            rbTezinaD.Text = "σ² / d";
            rbTezinaSqrtD.Text = "σ² / d²";

            lblGlobalniAlfa.Text = "α";
            lblLokalniAlfa.Text = "α";
            lblLokalniBeta.Text = "β";

            //test1();
        }



        #region Sigma nula

        private void tbSigmaNula_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // samo jedna decimalna tocka
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void tbSigmaNulaKvadrat_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // samo jedna decimalna tocka
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void sigmaNova()
        {
            double sigmaNulaKvadrat = Convert.ToDouble(tbSigmaNulaKvadrat.Text);

            foreach (ListViewItem item in lvMjerenje.Items)
            {
                if (item.SubItems[8].Text != "")
                {
                    double varijanca = Convert.ToDouble(item.SubItems[8].Text);
                    double tezina = sigmaNulaKvadrat / varijanca;

                    item.SubItems[4].Text = tezina.ToString();
                }
            }
        }

        private void tbSigmaNulaKvadrat_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                tbSigmaNula.Text = Math.Round(Math.Sqrt(Convert.ToDouble(tbSigmaNulaKvadrat.Text)), 12).ToString();

                if (lvMjerenje.Items.Count > 0)
                {
                    DialogResult dialogResult = MessageBox.Show("Promjena sigme nula utjecat će na promjenu težina na onim mjerenjima na kojima su težine izračunate preko sigme (standardnog odstupanja mjerenja). Ako su direktno unesene težine one se neće mijenjati. \nŽelite li preračunati sve težine koje su izračunate preko sigme (standardnog odstupanja mjerenja)", "Upozorenje", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (dialogResult == DialogResult.Yes)
                    {
                        sigmaNova();
                    }
                }

            }
            catch { }
        }

        private void tbSigmaNula_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                tbSigmaNulaKvadrat.Text = Math.Round(Convert.ToDouble(tbSigmaNula.Text) * Convert.ToDouble(tbSigmaNula.Text), 12).ToString();

                if (lvMjerenje.Items.Count > 0)
                {
                    DialogResult dialogResult = MessageBox.Show("Promjena sigme nula utjecat će na promjenu težina na onim mjerenjima na kojima su težine izračunate preko sigme (standardnog odstupanja mjerenja). Ako su direktno unesene težine one se neće mijenjati. \nŽelite li preračunati sve težine koje su izračunate preko sigme (standardnog odstupanja mjerenja)", "Upozorenje", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (dialogResult == DialogResult.Yes)
                    {
                        sigmaNova();
                    }
                }
            }
            catch { }
        }

        #endregion Sigma nula       

        #region Unos Tocaka

        private void tbVisina_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // samo jedna decimalna tocka
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void btnDodajTocku_Click(object sender, EventArgs e)
        {
            bool tockaJeVecUnesna = false;

            foreach (ListViewItem lvi in lvTocke.Items)
            {
                if (tbTocka.Text == lvi.SubItems[1].Text)
                {
                    tockaJeVecUnesna = true;
                    break;
                }
            }

            if (tbTocka.Text == "")
                MessageBox.Show("Naziv točke nije unesen", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (tbVisina.Text == "")
                MessageBox.Show("Visina točke nije unesena", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (tockaJeVecUnesna)
                MessageBox.Show("Točka je već unesena", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                ListViewItem item = new ListViewItem();
                item.SubItems.Add(tbTocka.Text);
                item.SubItems.Add(tbVisina.Text);
                lvTocke.Items.Add(item);

                PopunjavanjeComboBoxOd();
                tbTocka.Clear();
                tbVisina.Clear();

                foreach (ColumnHeader column in lvTocke.Columns)
                {
                    column.Width = -2;
                }
            }
        }

        private void lvTocke_MouseDown(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Right:
                    {
                        cmsLvTocke.Show(this, this.PointToClient(Cursor.Position));
                    }
                    break;
            }

        }

        private void izbrisiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lvTocke.SelectedItems.Count > 0)
            {
                var item = lvTocke.SelectedItems[0];

                DialogResult dialogResult = MessageBox.Show("Želite li izbrisati točku " + item.SubItems[1].Text + "?", "Brisanje", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    lvTocke.Items.Remove(item);
                }

                PopunjavanjeComboBoxOd();
            }
        }

        private void izmjeniToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lvTocke.SelectedItems.Count > 0)
            {
                var item = lvTocke.SelectedItems[0];
                tbTocka.Text = item.SubItems[1].Text;
                tbVisina.Text = item.SubItems[2].Text;
                lvTocke.Items.Remove(item);
            }
        }

        private ListViewItem lastItemChecked;

        private void lvTocke_ItemCheck(object sender, ItemCheckEventArgs e)
        {

            if (rbKlasicanNacin.Checked)
            {
                if (lastItemChecked != null && lastItemChecked.Checked && lastItemChecked != lvTocke.Items[e.Index])
                    lastItemChecked.Checked = false;

                lastItemChecked = lvTocke.Items[e.Index];
            }

        }

        #endregion Unos Tocaka

        // koristi se za popunjavanje combo box-a vizure te provjeru da li je vec tocka unesena - ako je unesena sa 
        // stajalista ona se ne unosi
        private void PopunjavanjeComboBoxDo(ListView zaPretraguDaLiJeUneseno, ComboBox zaPopunit, string stajaliste)
        {
            cmbDo.SelectedIndex = -1;
            zaPopunit.Items.Clear();

            foreach (ListViewItem item in lvTocke.Items)
            {
                bool uneseno = false;
                string vizura = item.SubItems[1].Text;

                if (stajaliste != vizura)
                {
                    foreach (ListViewItem lvi in zaPretraguDaLiJeUneseno.Items)
                    {
                        if (lvi.SubItems[1].Text == stajaliste && lvi.SubItems[2].Text == vizura)
                        {
                            uneseno = true;
                            break;
                        }
                    }

                    if (uneseno == false)
                        zaPopunit.Items.Add(vizura);
                }
            }
        }

        private void PopunjavanjeComboBoxOd()
        {
            cmbOd.SelectedIndex = -1;
            cmbOd.Items.Clear();

            foreach (ListViewItem item in lvTocke.Items)
            {
                cmbOd.Items.Add(item.SubItems[1].Text);
            }
        }

        private double returnMjerenje(string tocka)
        {
            double num = 0;

            foreach (ListViewItem item in lvTocke.Items)
            {
                if (tocka == item.SubItems[1].Text)
                    return Convert.ToDouble(item.SubItems[2].Text, CultureInfo.InvariantCulture);
            }

            return num;
        }

        private void cmbOd_SelectedIndexChanged(object sender, EventArgs e)
        {
            PopunjavanjeComboBoxDo(lvMjerenje, cmbDo, cmbOd.Text);
        }

        private void tbMjerenje_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '-') && (sender as TextBox).SelectionStart != 0)
            {
                e.Handled = true;
            }
        }

        private void tbUdaljenost_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // samo jedna decimalna tocka
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void btnDodajMjerenje_Click(object sender, EventArgs e)
        {
            if (cmbOd.Text == "")
                MessageBox.Show("Niste unijeli početnu točku [Od]", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (tbSigmaNulaKvadrat.Text == "")
                MessageBox.Show("Niste unijeli a priori varijancu mjerenja", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (cmbDo.Text == "")
                MessageBox.Show("Niste unijeli završnu točku [Do]", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (tbMjerenje.Text == "")
                MessageBox.Show("Niste unijeli mjerenje", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (tbUdaljenost.Text == "")
                MessageBox.Show("Niste unijeli udaljenost izmedu točka", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (tbTolerancija.Text == "")
                MessageBox.Show("Niste unijeli toleranciju na grube greške u unosu podataka", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                if (rbTezina.Checked && tbTezina.Text == "")
                    MessageBox.Show("Niste unijeli tezinu mjerenja", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else if (rbTezinaPpm.Checked && tbPPM.Text == "")
                    MessageBox.Show("Niste unijeli tezinu mjerenja [ppm]", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else if (rbTezinaPpm.Checked && tbMM.Text == "")
                    MessageBox.Show("Niste unijeli tezinu mjerenja [mm]", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                {
                    double sigmaNulaKvadrat = Convert.ToDouble(tbSigmaNulaKvadrat.Text, CultureInfo.InvariantCulture);
                    double udaljenost = Convert.ToDouble(tbUdaljenost.Text, CultureInfo.InvariantCulture);
                    double tolerancija = Convert.ToDouble(tbTolerancija.Text, CultureInfo.InvariantCulture);

                    double tezina, varijanca;

                    string Od = cmbOd.Text;
                    double OdMjerenja = returnMjerenje(Od);

                    string Do = cmbDo.Text;
                    double DoMjerenje = returnMjerenje(Do);

                    double fmj = ((DoMjerenje - OdMjerenja) - Convert.ToDouble(tbMjerenje.Text, CultureInfo.InvariantCulture));
                    fmj = Math.Round(fmj, 8);
                    string kontrola = "OK";

                    if (Math.Abs(tolerancija) < Math.Abs(fmj))
                        kontrola = "GRESKA";

                    if (rbTezinaD.Checked)
                    {
                        varijanca = udaljenost;
                        tezina = sigmaNulaKvadrat / udaljenost;
                    }
                    else if (rbTezinaSqrtD.Checked)
                    {
                        varijanca = udaljenost * udaljenost;
                        tezina = sigmaNulaKvadrat / (udaljenost * udaljenost);
                    }

                    else if (rbTezinaPpm.Checked)
                    {
                        varijanca = Convert.ToDouble(tbMM.Text, CultureInfo.InvariantCulture) + udaljenost * Convert.ToDouble(tbPPM.Text, CultureInfo.InvariantCulture) / 1000;
                        tezina = sigmaNulaKvadrat / varijanca;
                    }
                    else
                    {
                        varijanca = 0;
                        tezina = Convert.ToDouble(tbTezina.Text);
                    }


                    ListViewItem item = new ListViewItem(kontrola);
                    item.SubItems.Add(Od); //2
                    item.SubItems.Add(Do);
                    item.SubItems.Add(fmj.ToString()); //4
                    item.SubItems.Add(tezina.ToString());
                    item.SubItems.Add(tbMjerenje.Text); //6
                    item.SubItems.Add((DoMjerenje - OdMjerenja).ToString());
                    item.SubItems.Add(udaljenost.ToString()); //8

                    if (varijanca == 0)
                        item.SubItems.Add("");
                    else
                        item.SubItems.Add(varijanca.ToString());

                    lvMjerenje.Items.Add(item);

                    PopunjavanjeComboBoxDo(lvMjerenje, cmbDo, cmbOd.Text);

                    foreach (ColumnHeader column in lvMjerenje.Columns)
                    {
                        column.Width = -2;
                    }


                }

            }

        }

        #region Radio btn tezina

        private void radioBtnTezina()
        {
            if (rbTezinaSqrtD.Checked || rbTezinaD.Checked)
            {
                tbMM.Enabled = false;
                tbPPM.Enabled = false;
                tbTezina.Enabled = false;
            }
            else if (rbTezinaPpm.Checked)
            {
                tbMM.Enabled = true;
                tbPPM.Enabled = true;
                tbTezina.Enabled = false;
            }
            else if (rbTezina.Checked)
            {
                tbMM.Enabled = false;
                tbPPM.Enabled = false;
                tbTezina.Enabled = true;
            }
        }

        private void rbTezinaD_CheckedChanged(object sender, EventArgs e)
        {
            radioBtnTezina();
        }

        private void rbTezinaSqrtD_CheckedChanged(object sender, EventArgs e)
        {
            radioBtnTezina();
        }

        private void rbTezinaPpm_CheckedChanged(object sender, EventArgs e)
        {
            radioBtnTezina();
        }

        private void rbTezina_CheckedChanged(object sender, EventArgs e)
        {
            radioBtnTezina();
        }

        #endregion Radio btn tezina

        private void tbTolerancija_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // samo jedna decimalna tocka
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void tbMM_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // samo jedna decimalna tocka
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void tbPPM_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // samo jedna decimalna tocka
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void tbTezina_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // samo jedna decimalna tocka
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void tbGlobalniAlfa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // samo jedna decimalna tocka
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void tbLokalniAlfa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // samo jedna decimalna tocka
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void tbLokalniBeta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // samo jedna decimalna tocka
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        //izbrisi lvMjerenje item
        private void izbrisiToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (lvMjerenje.SelectedItems.Count > 0)
            {
                var item = lvMjerenje.SelectedItems[0];

                DialogResult dialogResult = MessageBox.Show("Želite li izbrisati mjerenje od " + item.SubItems[1].Text + " do " + item.SubItems[2].Text + "?", "Brisanje", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    lvMjerenje.Items.Remove(item);
                }

                PopunjavanjeComboBoxOd();
            }
        }

        #region Formiranje matrica i izjednacenje

        private void lvMjerenje_MouseDown(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Right:
                    {
                        cmsLvMjerenje.Show(this, this.PointToClient(Cursor.Position));
                    }
                    break;
            }
        }

        private vrstaIzjednacenja tipIzjednacenja()
        {
            if (rbIzjednacenjePrisila.Checked)
                return vrstaIzjednacenja.IzjednacenjePrisila;
            else if (rbKlasicanNacin.Checked)
                return vrstaIzjednacenja.KlasicanNacin;
            else if (rbMinimalniTrag.Checked)
                return vrstaIzjednacenja.MinimalniTrag;
            else
                return vrstaIzjednacenja.ParcijalniMinimalniTrag;
        }

        private void btnFormirajMatrice_Click(object sender, EventArgs e)
        {
            if (daLiSeMatriceMoguFormirati())
            {
                formirajMatrice();
                btnIzjednaci.Enabled = true;
            }
            else
                MessageBox.Show("Obustavljeno formiranje matrica za izjednačenje", "Nivelman", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private bool zastitaVarijanciiDrugo()
        {
            if (tbLokalniAlfa.Text == "")
            {
                MessageBox.Show("Niste unijeli nivo signifikantnosti za lokalni test", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if(tbGlobalniAlfa.Text =="")
            {
                MessageBox.Show("Niste unijeli nivo signifikantnosti za globalni test", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (tbLokalniBeta.Text == "")
            {
                MessageBox.Show("Niste unijeli snagu testa za lokalni test", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (tbSigmaNula.Text == "" ||tbSigmaNulaKvadrat.Text =="")
            {
                MessageBox.Show("Niste unijeli a priori varijancu", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private bool daLiSeMatriceMoguFormirati()
        {
            bool MatriceSeMoguFormirati = true;

            if (rbMinimalniTrag.Checked)
                lvTocke.Items.OfType<ListViewItem>().ToList().ForEach(item => item.Checked = true);
            else if (rbParcijalniMinimalniTrag.Checked)
            {
                int i = 0;

                foreach (ListViewItem item in lvTocke.Items)
                {
                    if (item.Checked)
                        i++;
                }

                if (i == 0)
                {
                    MessageBox.Show("Barem jedna točka [Datum] mora biti označena za izjednacenje s parcijalnim minimalnim tragom ", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    MatriceSeMoguFormirati = false;
                }
                else if (i == lvTocke.Items.Count)
                    MessageBox.Show("Izjedancenje s minimalnim tragom na sve točke", "Nivelman", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (rbKlasicanNacin.Checked)
            {
                int i = 0;

                foreach (ListViewItem item in lvTocke.Items)
                {
                    if (item.Checked)
                        i++;
                }

                if (i != 1)
                {
                    MessageBox.Show("Samo jedna točka [Datum] mora biti označena za izjednacenje klasičnim načinom ", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    MatriceSeMoguFormirati = false;
                }

            }
            else
            {
                int i = 0;

                foreach (ListViewItem item in lvTocke.Items)
                {
                    if (item.Checked)
                        i++;
                }

                if (i == 0)
                {
                    MessageBox.Show("Barem jedna točka [Datum] mora biti činiti datum ", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    MatriceSeMoguFormirati = false;
                }
                else if (i == lvTocke.Items.Count)
                {
                    MessageBox.Show("Ne mogu sve točke [Datum] činiti datum jer u tom slučaju nema izjednacenja", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    MatriceSeMoguFormirati = false;
                }

            }

            if (lvMjerenje.Items.Count < 2)
            {
                MessageBox.Show("Moraju postojiti barem dva mjerenja za formiranje matrica", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MatriceSeMoguFormirati = false;
            }
                

            if(!zastitaVarijanciiDrugo())
                MatriceSeMoguFormirati = false;

            return MatriceSeMoguFormirati;
        }

        private void formirajMatrice()
        {
            FormirajAPf matrice = new FormirajAPf();

            matrice.FormirajA(lvA, lvTocke, lvMjerenje, tipIzjednacenja());
            matrice.FormirajP(lvP, lvTocke, lvMjerenje);
            matrice.Formirajf(lvF, lvTocke, lvMjerenje);
            matrice.FormirajG(lvG, lvTocke, tipIzjednacenja());

            #region Mjerenje izmedu datuma

            foreach (ListViewItem item in lvA.Items)
            {
                bool prekiniFormiranje = true;

                for (int i = 1; i < item.SubItems.Count; i++)
                {
                    if (item.SubItems[i].Text != "0")
                    {
                        prekiniFormiranje = false;
                        break;
                    }

                }

                if (prekiniFormiranje)
                {
                    MessageBox.Show("Mjerenje " + item.SubItems[0].Text + " je mjerenje između točaka koje čine datum. \nIzbacite mjerenje i ponovo formirajte matrice kako ne bi utjecalo na rezultate!", "Važno", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

            #endregion Mjerenje izmedu datuma

            #region Tocka nije u izjednacenju 

            foreach (ColumnHeader header in lvA.Columns)
            {
                bool prekiniFormiranje = true;
                int index = lvA.Columns.IndexOf(header);

                foreach(ListViewItem item in lvA.Items)
                {
                    if(item.SubItems[index].Text != "0")
                    {
                        prekiniFormiranje = false;
                        break;
                    }
                }

                if (prekiniFormiranje)
                {
                    MessageBox.Show("Reper " + header.Text + " ne sudjeluje u izjednačenju. \nIzbacite reper i ponovo formirajte matrice kako ne bi utjecalo na rezultate!", "Važno", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

            #endregion Tocka nije u izjednacenju 
        }

        private void Izjednacenje()
        {
            tcIzjednacenje.TabPages.Clear();
            lvOcjenaFunkcija.Items.Clear();

            PosrednoIzjednacenje MNK;
            MatrixVectorAndControls mvc = new MatrixVectorAndControls();
            

            DenseMatrix A = mvc.ListViewToMatrix(lvA);
            DenseMatrix P = mvc.ListViewToMatrix(lvP);
            DenseVector f = mvc.ListViewToVector(lvF);
            DenseMatrix G;

            int fprekobrojnost = Math.Abs(A.ColumnCount - A.RowCount);

            if (lvG.Items.Count == 0)
            {
                 MNK = new PosrednoIzjednacenje(A, P, f);
            }
            else
            {
                G = mvc.ListViewToMatrix(lvG);
                MNK = new PosrednoIzjednacenje(A, P, f, G);
                fprekobrojnost++;
            }

            ListView Alv = new ListView();
            mvc.MatrixToTabPage(tcIzjednacenje, "A", Alv, A, mvc.ListViewColumnHeaderToList(lvA), mvc.ListViewColumnHeaderToList(lvP));

            ListView Plv = new ListView();
            mvc.MatrixToTabPage(tcIzjednacenje, "P", Plv, P, mvc.ListViewColumnHeaderToList(lvP), mvc.ListViewColumnHeaderToList(lvP));

            ListView flv = new ListView();
            mvc.VectorToTabPage(tcIzjednacenje, "f", flv, f, "", mvc.ListViewColumnHeaderToList(lvP));

            

            prikaz(MNK);
            ocjenaFunkcija(MNK);

            izjednaceneVrijednosti izjednaceno = new izjednaceneVrijednosti(MNK);
            izjednaceno.lvMjerenja(lvIzjednacenaMjerenja, lvMjerenje, Convert.ToDouble(tbSigmaNulaKvadrat.Text, CultureInfo.InvariantCulture));
            izjednaceno.lvReperi(lvReperi, lvTocke, Convert.ToDouble(tbSigmaNulaKvadrat.Text, CultureInfo.InvariantCulture), rbIzjednacenjePrisila.Checked);

            double alfa = Convert.ToDouble(tbLokalniAlfa.Text, CultureInfo.InvariantCulture) /100;
            double beta = Convert.ToDouble(tbLokalniBeta.Text, CultureInfo.InvariantCulture)/100;
            double alfaGlob = Convert.ToDouble(tbGlobalniAlfa.Text, CultureInfo.InvariantCulture) / 100;


            Statistika test = new Statistika(MNK, Convert.ToDouble(tbSigmaNulaKvadrat.Text, CultureInfo.InvariantCulture), alfa, beta, fprekobrojnost, alfaGlob);

            test.LokalniTest(lvStatistika, lvP);

            tsslGlobalniTest.Text = test.Gtest;
            tsslGlobalniTest.Text = test.Gtest;

        }

        private void StatusStrip(PosrednoIzjednacenje mnk)
        {
            if (rbIzjednacenjePrisila.Checked)
                tsslVrstaIzjednacenja.Text = rbIzjednacenjePrisila.Text;
            if (rbKlasicanNacin.Checked)
                tsslVrstaIzjednacenja.Text = rbKlasicanNacin.Text;
            if (rbMinimalniTrag.Checked)
                tsslVrstaIzjednacenja.Text = rbMinimalniTrag.Text;
            if (rbParcijalniMinimalniTrag.Checked)
                tsslVrstaIzjednacenja.Text = rbParcijalniMinimalniTrag.Text;

            tsslSigmaKvadrat.Text = "    σ²: " + tbSigmaNulaKvadrat.Text;
            tsslSigma.Text = "    σ: " + tbSigmaNula.Text;
            tsslSo2.Text = "    s²: " + mnk.sKvadrat.ToString();
            tsslSo.Text = "    s: " + Math.Sqrt(mnk.sKvadrat).ToString();

            int u = mnk.N.ColumnCount;
            int n = mnk.Ql.ColumnCount;
            int f, d;

            if(lvG.Items.Count == 0)
            {
                d = 0;
                f = n - u + d;
            }
            else
            {
                d = 1;
                f = n - u + d;
            }

            tssln.Text = "    n: " + n.ToString();
            tsslu.Text = "    u: " + u.ToString();
            tssld.Text = "    d: " + d.ToString();
            tsslf.Text = "    f: " + f.ToString();

        }

        private void prikaz(PosrednoIzjednacenje mnk)
        {
            MatrixVectorAndControls mvc = new MatrixVectorAndControls();

            double dd = mnk.N[1, 1];

            StatusStrip(mnk);


            ListView N = new ListView();
            mvc.MatrixToTabPage(tcIzjednacenje, "N", N, mnk.N, mvc.ListViewColumnHeaderToList(lvA), mvc.ListViewColumnHeaderToList(lvA));

            ListView n = new ListView();
            mvc.VectorToTabPage(tcIzjednacenje, "n", n, mnk.n, "n", mvc.ListViewColumnHeaderToList(lvA));

            ListView Qx = new ListView();
            mvc.MatrixToTabPage(tcIzjednacenje, "Qx", Qx, mnk.Qx, mvc.ListViewColumnHeaderToList(lvA), mvc.ListViewColumnHeaderToList(lvA));

            ListView x2d = new ListView();
            mvc.VectorToTabPage(tcIzjednacenje, "x", x2d, mnk.x, "x", mvc.ListViewColumnHeaderToList(lvA));

            ListView v = new ListView();
            mvc.VectorToTabPage(tcIzjednacenje, "v", v, mnk.v, "v", mvc.ListViewColumnHeaderToList(lvP));

            ListView Qlcap = new ListView();
            mvc.MatrixToTabPage(tcIzjednacenje, "Qî", Qlcap, mnk.Qlcap, mvc.ListViewColumnHeaderToList(lvP), mvc.ListViewColumnHeaderToList(lvP));

            ListView Qv = new ListView();
            mvc.MatrixToTabPage(tcIzjednacenje, "Qv", Qv, mnk.Qv, mvc.ListViewColumnHeaderToList(lvP), mvc.ListViewColumnHeaderToList(lvP));

            ListView Ql = new ListView();
            mvc.MatrixToTabPage(tcIzjednacenje, "Ql", Ql, mnk.Ql, mvc.ListViewColumnHeaderToList(lvP), mvc.ListViewColumnHeaderToList(lvP));

            ListView R = new ListView();
            mvc.MatrixToTabPage(tcIzjednacenje, "R", R, mnk.R, mvc.ListViewColumnHeaderToList(lvP), mvc.ListViewColumnHeaderToList(lvP));

            ListView U = new ListView();
            mvc.MatrixToTabPage(tcIzjednacenje, "U", U, mnk.U, mvc.ListViewColumnHeaderToList(lvP), mvc.ListViewColumnHeaderToList(lvP));

            ListView RU = new ListView();
            mvc.MatrixToTabPage(tcIzjednacenje, "R + U = I", RU, mnk.R + mnk.U, mvc.ListViewColumnHeaderToList(lvP), mvc.ListViewColumnHeaderToList(lvP));
        }

        private void btnIzjednaci_Click(object sender, EventArgs e)
        {
            Izjednacenje();
            //excel();
        }

        private void ocjenaFunkcija(PosrednoIzjednacenje mnk)
        {
            foreach (ListViewItem item in lvA.Items)
            {
                ListViewItem ocjena = new ListViewItem(item.SubItems[0].Text);
                List<double> hLista = new List<double>();

                for (int i = 1; i < item.SubItems.Count; i++)
                {
                    hLista.Add(Convert.ToDouble(item.SubItems[i].Text));
                }

                DenseVector h = new DenseVector(hLista.ToArray());

                OcjenjivostFunkcija funk = new OcjenjivostFunkcija(h, mnk.Qx, mnk.N);

                if (funk.FunkcijaJeOcjeniva)
                    ocjena.SubItems.Add("DA");
                else
                    ocjena.SubItems.Add("-NE-");

                double sigmaNulaKvadrat = Convert.ToDouble(tbSigmaNulaKvadrat.Text, CultureInfo.InvariantCulture);

                ocjena.SubItems.Add(funk.s(sigmaNulaKvadrat).ToString());
                ocjena.SubItems.Add(Math.Sqrt(funk.s(sigmaNulaKvadrat)).ToString());

                lvOcjenaFunkcija.Items.Add(ocjena);

            }

            for (int i = 1; i < lvA.Columns.Count; i++)
            {
                DenseVector h = new DenseVector(lvA.Columns.Count - 1);
                h[i-1] = 1;

                ListViewItem ocjena = new ListViewItem(lvA.Columns[i].Text);
                OcjenjivostFunkcija funk = new OcjenjivostFunkcija(h, mnk.Qx, mnk.N);

                if (funk.FunkcijaJeOcjeniva)
                    ocjena.SubItems.Add("DA");
                else
                    ocjena.SubItems.Add("-NE-");

                double sigmaNulaKvadrat = Convert.ToDouble(tbSigmaNulaKvadrat.Text, CultureInfo.InvariantCulture);

                ocjena.SubItems.Add(funk.s(sigmaNulaKvadrat).ToString());
                ocjena.SubItems.Add(Math.Sqrt(funk.s(sigmaNulaKvadrat)).ToString());
                lvOcjenaFunkcija.Items.Add(ocjena);
            }
        }

        private void ToExcel()
        {
            Microsoft.Office.Interop.Excel.Application app = new Microsoft.Office.Interop.Excel.Application();
            app.Visible = true;
            Microsoft.Office.Interop.Excel.Workbook wb = app.Workbooks.Add(1);
            Microsoft.Office.Interop.Excel.Worksheet ws = (Microsoft.Office.Interop.Excel.Worksheet)wb.Worksheets[1];
            int i = 1;
            int i2 = 1;
            foreach (ListViewItem lvi in lvA.Items)
            {
                i = 1;
                foreach (ListViewItem.ListViewSubItem lvs in lvi.SubItems)
                {
                    ws.Cells[i2, i] = lvs.Text;
                    i++;
                }
                i2++;
            }
        }

        #endregion Formiranje matrica i izjednacenje

        private void test1()
        {
            ListViewItem i1 = new ListViewItem("-");
            ListViewItem i2 = new ListViewItem("-");
            ListViewItem i3 = new ListViewItem("-");
            ListViewItem i4 = new ListViewItem("-");
            ListViewItem i5 = new ListViewItem("-");
            ListViewItem i6 = new ListViewItem("-");
            ListViewItem i7 = new ListViewItem("-");
            ListViewItem i8 = new ListViewItem("-");
            ListViewItem i9 = new ListViewItem("-");
            ListViewItem i10 = new ListViewItem("-");
            ListViewItem i11 = new ListViewItem("-");
            ListViewItem i12 = new ListViewItem("-");
            ListViewItem i13 = new ListViewItem("-");
            ListViewItem i14 = new ListViewItem("-");
            ListViewItem i15 = new ListViewItem("-");

            i1.SubItems.Add("H1");
            i2.SubItems.Add("H3");
            i3.SubItems.Add("H3");
            i4.SubItems.Add("H4");
            i5.SubItems.Add("H5");
            i6.SubItems.Add("H6");
            i7.SubItems.Add("H1");
            i8.SubItems.Add("H1");
            i9.SubItems.Add("H8");
            i10.SubItems.Add("H10");
            i11.SubItems.Add("H3");
            i12.SubItems.Add("H1");
            i13.SubItems.Add("H11");
            i14.SubItems.Add("H3");
            i15.SubItems.Add("H10");


            i1.SubItems.Add("H2");
            i2.SubItems.Add("H2");
            i3.SubItems.Add("H4");
            i4.SubItems.Add("H5");
            i5.SubItems.Add("H6");
            i6.SubItems.Add("H7");
            i7.SubItems.Add("H7");
            i8.SubItems.Add("H8");
            i9.SubItems.Add("H10");
            i10.SubItems.Add("H9");
            i11.SubItems.Add("H9");
            i12.SubItems.Add("H11");
            i13.SubItems.Add("H3");
            i14.SubItems.Add("H10");
            i15.SubItems.Add("H5");

            i1.SubItems.Add("-0.1");
            i2.SubItems.Add("-0.6");
            i3.SubItems.Add("-0.3");
            i4.SubItems.Add("-0.1");
            i5.SubItems.Add("-0.7");
            i6.SubItems.Add("0.7");
            i7.SubItems.Add("-0.1");
            i8.SubItems.Add("0.7");
            i9.SubItems.Add("0.5");
            i10.SubItems.Add("-0.7");
            i11.SubItems.Add("0.1");
            i12.SubItems.Add("-0.1");
            i13.SubItems.Add("0.9");
            i14.SubItems.Add("1.3");
            i15.SubItems.Add("-0.1");

            i1.SubItems.Add("4.184100418");
            i2.SubItems.Add("3.236245955");
            i3.SubItems.Add("4.716981132");
            i4.SubItems.Add("2.7100271");
            i5.SubItems.Add("4.347826087");
            i6.SubItems.Add("3.205128205");
            i7.SubItems.Add("4.201680672");
            i8.SubItems.Add("3.412969283");
            i9.SubItems.Add("20");
            i10.SubItems.Add("5.263157895");
            i11.SubItems.Add("6.329113924");
            i12.SubItems.Add("6.024096386");
            i13.SubItems.Add("5.025125628");
            i14.SubItems.Add("4.854368932");
            i15.SubItems.Add("7.874015748");

            i1.SubItems.Add("10.3861");
            i2.SubItems.Add("7.0456");
            i3.SubItems.Add("3.4743");
            i4.SubItems.Add("0.5191");
            i5.SubItems.Add("9.1627");
            i6.SubItems.Add("-4.9607");
            i7.SubItems.Add("11.5361");
            i8.SubItems.Add("1.3173");
            i9.SubItems.Add("-1.5755");
            i10.SubItems.Add("1.0097");
            i11.SubItems.Add("-2.5891");
            i12.SubItems.Add("0.2051");
            i13.SubItems.Add("3.1351");
            i14.SubItems.Add("-3.5993");
            i15.SubItems.Add("7.5911");

            

            lvMjerenje.Items.Add(i1);
            lvMjerenje.Items.Add(i2);
            lvMjerenje.Items.Add(i3);
            lvMjerenje.Items.Add(i4);
            lvMjerenje.Items.Add(i5);
            lvMjerenje.Items.Add(i6);
            lvMjerenje.Items.Add(i7);
            lvMjerenje.Items.Add(i8);
            lvMjerenje.Items.Add(i9);
            lvMjerenje.Items.Add(i10);
            lvMjerenje.Items.Add(i11);
            lvMjerenje.Items.Add(i12);
            lvMjerenje.Items.Add(i13);
            lvMjerenje.Items.Add(i14);
            lvMjerenje.Items.Add(i15);

        }

        private void excel()
        {

            int n = lvA.Items.Count;
            int u = lvA.Items[0].SubItems.Count - 1;
            int f, d;

            if (lvG.Items.Count == 0)
            {
                d = 0;
                f = n - u + d;
            }
            else
            {
                d = 1;
                f = n - u + d;
            }

            Excell e = new Excell(tsslVrstaIzjednacenja.Text, n, u, d, f);
            e.DataToExcel(lvTocke, lvMjerenje, lvOcjenaFunkcija, tcIzjednacenje, tcIzjednaceneVrijednosti, lvStatistika);


        }

        #region Radio Button

        private void radioButton()
        {
            if (rbMinimalniTrag.Checked)
                lvTocke.Items.OfType<ListViewItem>().ToList().ForEach(item => item.Checked = true);
            else if (rbKlasicanNacin.Checked)
            {
                lvTocke.Items.OfType<ListViewItem>().ToList().ForEach(item => item.Checked = false);
                try
                {
                    lvTocke.Items[0].Checked = true;
                }
                catch (Exception)
                {
                }

            }
            else if (rbParcijalniMinimalniTrag.Checked)
                lvTocke.Items.OfType<ListViewItem>().ToList().ForEach(item => item.Checked = false);
            else
            {
                lvTocke.Items.OfType<ListViewItem>().ToList().ForEach(item => item.Checked = false);
                try
                {
                    lvTocke.Items[0].Checked = true;
                }
                catch (Exception)
                {
                }

            }

        }

        private void rbMinimalniTrag_CheckedChanged(object sender, EventArgs e)
        {
            radioButton();
        }

        private void rbParcijalniMinimalniTrag_CheckedChanged(object sender, EventArgs e)
        {
            radioButton();
        }

        private void rbKlasicanNacin_CheckedChanged(object sender, EventArgs e)
        {
            radioButton();
        }

        private void rbIzjednacenjePrisila_CheckedChanged(object sender, EventArgs e)
        {
            radioButton();
        }


        #endregion Radio Button

        private void tbTocka_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && tbTocka.Text != "")
                tbVisina.Focus();
        }

        private void tbVisina_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && tbTocka.Text != "" && tbVisina.Text != "")
            {
                btnDodajTocku.Focus();
                btnDodajTocku.PerformClick();
            }                
            else if(e.KeyCode == Keys.Enter && tbTocka.Text == "" && tbVisina.Text != "")
                tbVisina.Focus();
        }

        private void tbMjerenje_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && tbMjerenje.Text != "")
                tbUdaljenost.Focus();
        }

        private void tbUdaljenost_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && tbMjerenje.Text != "" && tbUdaljenost.Text != "")
            {
                btnDodajMjerenje.Focus();
                btnDodajMjerenje.PerformClick();
            }
            else if (e.KeyCode == Keys.Enter && tbMjerenje.Text == "" && tbUdaljenost.Text != "")
                tbMjerenje.Focus();
        }
    }
}
