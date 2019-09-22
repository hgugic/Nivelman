using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using System.Globalization;


namespace NIvelman
{


    public class Excell
    {
        Microsoft.Office.Interop.Excel.Application app = new Microsoft.Office.Interop.Excel.Application();

        string vrstaIzjednacenja;
        int n, u, f, d;

        public Excell(string vrstaIzjednacenja, int n, int u, int d, int f)
        {
            this.vrstaIzjednacenja = vrstaIzjednacenja;
            this.n = n;
            this.u = u;
            this.f = f;
            this.d = d;
            app.Visible = true;
        }

        #region ListView To Excel

        public void ListViewToExcel(Worksheet ws, int red, int stupac, ListView lv, out int redPovrat, out int stupacPovrat)
        {

            redPovrat = red;
            stupacPovrat = stupac;

            foreach (ColumnHeader header in lv.Columns)
            {
                ws.Cells[red, stupac] = header.Text;
                ws.Cells[red, stupac].Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Yellow);
                stupac++;
            }
            red++;
            stupac = stupacPovrat;

            foreach (ListViewItem lvi in lv.Items)
            {
                foreach (ListViewItem.ListViewSubItem lvs in lvi.SubItems)
                {
                    try
                    {
                        ws.Cells[red, stupac] = Convert.ToDouble(lvs.Text);
                        ws.Cells[red, stupac].Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Aqua);
                        stupac++;
                    }
                    catch (Exception)
                    {
                        ws.Cells[red, stupac] = lvs.Text;
                        ws.Cells[red, stupac].Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Yellow);
                        stupac++;
                    }

                }
                red++;
                stupac = stupacPovrat;
            }

            redPovrat = red;
        }

        public void TockeListViewToExcel(Worksheet ws, int red, int stupac, ListView lv, out int redPovrat, out int stupacPovrat)
        {

            redPovrat = red;
            stupacPovrat = stupac;

            foreach (ColumnHeader header in lv.Columns)
            {
                ws.Cells[red, stupac] = header.Text;
                ws.Cells[red, stupac].Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Yellow);
                stupac++;
            }
            red++;
            stupac = stupacPovrat;

            foreach (ListViewItem lvi in lv.Items)
            {
                if (lvi.Checked)
                {
                    ws.Cells[red, stupac] = "DA";
                    ws.Cells[red, stupac].Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Gold);
                    stupac++;
                }
                else
                {
                    ws.Cells[red, stupac].Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.NavajoWhite);
                    stupac++;
                }

                foreach (ListViewItem.ListViewSubItem lvs in lvi.SubItems)
                {
                    if (lvs.Text != "")
                    {
                        try
                        {
                            ws.Cells[red, stupac] = Convert.ToDouble((lvs.Text));
                            ws.Cells[red, stupac].Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Aqua);
                            stupac++;
                        }
                        catch (Exception)
                        {
                            ws.Cells[red, stupac] = lvs.Text;
                            ws.Cells[red, stupac].Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Yellow);
                            stupac++;
                        }
                    }

                }
                red++;
                stupac = stupacPovrat;
            }

            redPovrat = red;
        }

        public void MjerenjaListViewToExcel(Worksheet ws, int red, int stupac, ListView lv, out int redPovrat, out int stupacPovrat)
        {
            
            redPovrat = red;
            stupacPovrat = stupac;
            
            foreach (ColumnHeader header in lv.Columns)
            {
                ws.Cells[red, stupac] = header.Text;
                ws.Cells[red, stupac].Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Yellow);
                stupac++;
            }
            red++;
            stupac = stupacPovrat;

            foreach (ListViewItem lvi in lv.Items)
            {
                foreach (ListViewItem.ListViewSubItem lvs in lvi.SubItems)
                {
                    try
                    {
                        if (lvs.Text == "OK" || lvs.Text == "GRESKA" || lvs.Text == "-")
                        {
                            if(lvs.Text == "OK")
                            {
                                ws.Cells[red, stupac] = "OK";
                                ws.Cells[red, stupac].Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.LimeGreen);
                            }
                            else if(lvs.Text == "GRESKA")
                            {
                                ws.Cells[red, stupac] = "GRESKA";
                                ws.Cells[red, stupac].Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.IndianRed);
                            }
                            else
                            {
                                ws.Cells[red, stupac] = "Sistem test/error";
                                ws.Cells[red, stupac].Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.LightCoral);
                            }
                            stupac++;
                        }
                        else
                        {
                            ws.Cells[red, stupac] = Convert.ToDouble(lvs.Text);
                            ws.Cells[red, stupac].Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Aqua);
                            stupac++;
                        }
                            
                    }
                    catch (Exception)
                    {
                        ws.Cells[red, stupac] = lvs.Text;
                        ws.Cells[red, stupac].Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Yellow);
                        stupac++;
                    }

                }
                red++;
                stupac = stupacPovrat;
            }

            redPovrat = red;
        }

        public void OcjenaFunkcijaListViewToExcel(Worksheet ws, int red, int stupac, ListView lv, out int redPovrat, out int stupacPovrat)
        {

            redPovrat = red;
            stupacPovrat = stupac;

            foreach (ColumnHeader header in lv.Columns)
            {
                ws.Cells[red, stupac] = header.Text;
                ws.Cells[red, stupac].Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Yellow);
                stupac++;
            }
            red++;
            stupac = stupacPovrat;

            foreach (ListViewItem lvi in lv.Items)
            {
                foreach (ListViewItem.ListViewSubItem lvs in lvi.SubItems)
                {
                    try
                    {
                        if (lvs.Text == "DA" || lvs.Text == "-NE-")
                        {
                            if (lvs.Text == "DA")
                            {
                                ws.Cells[red, stupac] = "DA";
                                ws.Cells[red, stupac].Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.LimeGreen);
                            }
                            else if (lvs.Text == "-NE-")
                            {
                                ws.Cells[red, stupac] = "-NE-";
                                ws.Cells[red, stupac].Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.IndianRed);
                            }
                            else
                            {
                                ws.Cells[red, stupac] = "Sistem test/error";
                                ws.Cells[red, stupac].Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.LightCoral);
                            }
                            stupac++;
                        }
                        else
                        {
                            ws.Cells[red, stupac] = Convert.ToDouble(lvs.Text);
                            ws.Cells[red, stupac].Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Aqua);
                            stupac++;
                        }

                    }
                    catch (Exception)
                    {
                        ws.Cells[red, stupac] = lvs.Text;
                        ws.Cells[red, stupac].Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Yellow);
                        stupac++;
                    }

                }
                red++;
                stupac = stupacPovrat;
            }

            redPovrat = red;
        }

        #endregion ListView To Excel

        public void TabControlTabPageListViewToExcel(Worksheet ws, int red, int stupac, TabControl tc)
        {


            foreach (TabPage tab in tc.TabPages)
            {

                foreach (Control ctn in tab.Controls)
                {
                    if (ctn is ListView)
                    {
                        red = red + 3;
                        ws.Cells[red, stupac] = "Matrica / Vektor: " + tab.Name;
                        red++;

                        ListViewToExcel(ws, red, stupac , (ListView)ctn, out red, out stupac);
                    }

                }
            }

        }

        public void IzjednacenaMjerenjaTabControlTabPageListViewToExcel(Worksheet ws, int red, int stupac, TabControl tc)
        {


            foreach (TabPage tab in tc.TabPages)
            {

                foreach (Control ctn in tab.Controls)
                {
                    if (ctn is ListView)
                    {
                        if (tab.Name == "tpMjerenja")
                        {
                            red = red + 3;
                            ws.Cells[red, stupac] = "Izjednacena mjerenja";
                            red++;

                            ListViewToExcel(ws, red, stupac, (ListView)ctn, out red, out stupac);
                        }
                        else
                        {
                            red = red + 3;
                            ws.Cells[red, stupac] = "Izjednaceni reperi";
                            red++;

                            ListViewToExcel(ws, red, stupac, (ListView)ctn, out red, out stupac);
                        }
                    }

                }
            }

        }

        public void DataToExcel(ListView tocke, ListView mjerenja, ListView ocjenaFunkcija, TabControl tc, TabControl izjednacene, ListView statistika)
        {

            CultureInfo ci = CultureInfo.InvariantCulture;

            app.UseSystemSeparators = false;
            app.DecimalSeparator = ci.NumberFormat.NumberDecimalSeparator;
            app.ThousandsSeparator = ci.NumberFormat.NumberGroupSeparator;
            

            Workbook wb = app.Workbooks.Add(1);

            Worksheet ws1 = (Worksheet)wb.Worksheets[1];
            ws1.Name = "Podaci";
           

            #region Verzija

            int red = 1;
            int stupac = 1;

            ws1.Cells[red, stupac] = "Nivelman";
            red++;
            ws1.Cells[red, stupac] = "Verzija: 1.0.0.0 ";
            red++;
            ws1.Cells[red, stupac] = "Hrvoje Gugic";
            red++;
            ws1.Cells[red, stupac] = "hgugic86@gmail.com";
            red++;
            ws1.Cells[red, stupac] = "2016-2017";
            red++;

            #endregion Verzija

            #region prekobrojnost

            red = 3;
            stupac = 9;

            ws1.Cells[red, stupac] = vrstaIzjednacenja;
            red++;
            ws1.Cells[red, stupac] = "n:";
            ws1.Cells[red, stupac].Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Yellow);
            ws1.Cells[red, stupac+1] = n;
            ws1.Cells[red, stupac+1].Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Aqua);
            red++;
            ws1.Cells[red, stupac] = "u:";
            ws1.Cells[red, stupac].Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Yellow);
            ws1.Cells[red, stupac+1] = u;
            ws1.Cells[red, stupac + 1].Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Aqua);
            red++;
            ws1.Cells[red, stupac] = "d:";
            ws1.Cells[red, stupac].Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Yellow);
            ws1.Cells[red, stupac+1] = d;
            ws1.Cells[red, stupac + 1].Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Aqua);
            red++;
            ws1.Cells[red, stupac] = "f";
            ws1.Cells[red, stupac].Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Yellow);
            ws1.Cells[red, stupac+1] = f;
            ws1.Cells[red, stupac + 1].Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Aqua);
            red++;

            #endregion prekobrojnost

            red = 3;
            stupac = 4;

            TockeListViewToExcel(ws1, red, stupac, tocke, out red, out stupac);

            red = red + 3;

            MjerenjaListViewToExcel(ws1, red, stupac, mjerenja, out red, out stupac);

            wb.Sheets.Add(After: wb.Sheets[wb.Sheets.Count]);
            Worksheet ws2 = (Worksheet)wb.Worksheets[wb.Sheets.Count];
            ws2.Name = "Matrice";

            red = 1;
            stupac = 3;

            TabControlTabPageListViewToExcel(ws2, red, stupac, tc);

            wb.Sheets.Add(After: wb.Sheets[wb.Sheets.Count]);
            Worksheet ws3 = (Worksheet)wb.Worksheets[wb.Sheets.Count];
            ws3.Name = "Ocjena funkcija";

            red = 3;
            stupac = 3;

            OcjenaFunkcijaListViewToExcel(ws3, red, stupac, ocjenaFunkcija, out red, out stupac);


            wb.Sheets.Add(After: wb.Sheets[wb.Sheets.Count]);
            Worksheet ws4 = (Worksheet)wb.Worksheets[wb.Sheets.Count];
            ws4.Name = "Izjednacene vrijednosti";

            red = 1;
            stupac = 3;

            IzjednacenaMjerenjaTabControlTabPageListViewToExcel(ws4, red, stupac, izjednacene);

            wb.Sheets.Add(After: wb.Sheets[wb.Sheets.Count]);
            Worksheet ws5 = (Worksheet)wb.Worksheets[wb.Sheets.Count];
            ws5.Name = "Statisticka testiranja";

            red = 1;
            stupac = 3;

            OcjenaFunkcijaListViewToExcel(ws5, red, stupac, statistika, out red, out stupac);



        }
    }
}
