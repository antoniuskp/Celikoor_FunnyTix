﻿using FunnyTix_LIB;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Celikoor_FunnyTix
{
    public partial class FormLaporan : Form
    {
        List<Laporan> listLaporan = new List<Laporan>();
        public FormLaporan()
        {
            InitializeComponent();
        }

        private void FormLaporan_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void comboBoxChoose_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxChoose.SelectedIndex == 0)
            {
                listLaporan = Laporan.laporanA();
                SetupGridView(listLaporan, 0);
            }
            else if (comboBoxChoose.SelectedIndex == 1)
            {
                listLaporan = Laporan.laporanB();
                SetupGridView(listLaporan, 1);
            }
            else if (comboBoxChoose.SelectedIndex == 2)
            {
                listLaporan = Laporan.laporanC();
                SetupGridView(listLaporan, 2);
            }
            else if (comboBoxChoose.SelectedIndex == 3)
            {
                listLaporan = Laporan.laporanD();
                SetupGridView(listLaporan, 3);
            }
            else if (comboBoxChoose.SelectedIndex == 4)
            {
                listLaporan = Laporan.laporanE();
                SetupGridView(listLaporan, 4);
            }
        }

        private void SetupGridView(List<Laporan> lst, int index)
        {
            IEnumerable data = null;
            switch (index)
            {
                case 0:
                    data = lst.Select(item => new
                    {
                        JudulFilm = item.JudulFilm,
                        JumlahTonton = item.JumlahTonton,
                        Bulan = item.Bulan
                    }).ToList();
                    
                    dataGridView.DataSource = data;
                    dataGridView.Refresh();
                    break;
                case 1:
                    data = lst.Select(item => new
                    {
                        GrandTotal = item.GrandTotal,
                        Cabang = item.Cabang,
                    }).ToList();
                    dataGridView.DataSource = data;
                    dataGridView.Refresh();
                    break;
                case 2:
                    data = lst.Select(item => new
                    {
                        JudulFilm = item.JudulFilm
                    }).ToList();
                    dataGridView.DataSource = data;
                    dataGridView.Refresh();
                    break;
                case 3:
                    data = lst.Select(item => new
                    {
                        Cabang = item.Cabang,
                        NamaStudio = item.NamaStudio,
                        Bulan = item.Bulan,
                        TingkatUtilitas = item.TingkatUtilitas
                    }).ToList();
                    dataGridView.DataSource = data;
                    dataGridView.Refresh();
                    break;
                case 4:
                    data = lst.Select(item => new
                    {
                        NamaKonsumen = item.NamaKonsumen,
                        Frekuensi = item.Frekuensi
                    }).ToList();
                    dataGridView.DataSource = data;
                    dataGridView.Refresh();
                    break;
            }
            for (int i = 0; i < dataGridView.Columns.Count; i++)
            {
                dataGridView.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            }

        }

        private void buttonExport_Click(object sender, EventArgs e)
        {
            Laporan.CetakLaporan(comboBoxChoose.Text, comboBoxChoose.SelectedIndex, listLaporan);

            MessageBox.Show("Berhasil");
            
        }
    }
}

