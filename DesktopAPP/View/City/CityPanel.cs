﻿using DesktopAPP.Services;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopAPP.View.City
{
    public class CityPanel : Panel
    {
        private CityService cityService;
        private Button button;
        private DataGridView dataGridView;
        private Panel topPanel;

        public CityPanel()
        {
            cityService = CityService.GetInstance();

            string tabName = "aaa";
            // Configurações de estilo e texto da TabPage
            this.Text = tabName;
            this.Dock = DockStyle.Fill;


            topPanel = new Panel();
            topPanel.Dock = DockStyle.Top;
            topPanel.Height = 30;
            this.Controls.Add(topPanel);

            // Inicialize os componentes
            button = new Button();
            button.Text = "FECHAR";
            button.Location = new System.Drawing.Point(10, 10);
            button.Dock= DockStyle.Right;
            button.Click += Button_Click;
            topPanel.Controls.Add(button);

            dataGridView = new DataGridView();
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.ReadOnly = true;
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView.Top = topPanel.Height;
            dataGridView.Width = ClientSize.Width;
            dataGridView.Height = ClientSize.Height - topPanel.Height;
            dataGridView.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Bottom;
            dataGridView.ColumnWidthChanged += DataGridView_ColumnWidthChanged;

            this.Controls.Add(dataGridView);
            this.BringToFront();


            PopulateGrid();

        }

        private async Task PopulateGrid()
        {

            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Id", typeof(int));
            dataTable.Columns.Add("Nome", typeof(string));
            dataTable.Columns.Add("UF", typeof(string));

            dataGridView.DataSource = dataTable;

            var cidades = await cityService.GetAll();

            foreach (var city in cidades)
            {
                dataTable.Rows.Add(city.Id, city.Name, city.State);
            }
        }

        private void DataGridView_ColumnWidthChanged(object sender, DataGridViewColumnEventArgs e)
        {
            // Ajusta o tamanho da coluna do meio
            if (e.Column.Index == 1)
            {
                int remainingWidth = dataGridView.Width - dataGridView.RowHeadersWidth;
                remainingWidth -= dataGridView.Columns[0].Width + dataGridView.Columns[2].Width;
                dataGridView.Columns[1].Width = remainingWidth;
            }
        }

        

        private void Button_Click(object sender, EventArgs e)
        {
            Panel pnlContainer = this.Parent as Panel;
            if (pnlContainer != null)
            {
                pnlContainer.Controls.Remove(this);
            }
        }

        private void CityPanel_OnControlAdded(object sender, ControlEventArgs e)
        {
            if (e.Control != this) return;
            MessageBox.Show("oi");
        }
    }
}