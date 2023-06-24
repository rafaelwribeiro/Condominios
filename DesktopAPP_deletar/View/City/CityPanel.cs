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
        private Button button;
        private DataGridView dataGridView;
        private Panel topPanel;

        public CityPanel()
        {
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

            // Define as colunas do DataGridView
            /*dataGridView.Columns.Add("Id", "Código");
            dataGridView.Columns.Add("Column2", "Nome");
            dataGridView.Columns.Add("Column3", "UF");*/

            // Adiciona o DataGridView ao Panel
            this.Controls.Add(dataGridView);

            this.BringToFront();


            PopulateGrid();

        }

        private void PopulateGrid()
        {

            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Id", typeof(int));
            dataTable.Columns.Add("Nome", typeof(string));
            dataTable.Columns.Add("UF", typeof(string));

            dataGridView.DataSource = dataTable;

            var cidades = new List<Cidade>
            {
                new Cidade { Id = 1, Nome = "São Paulo", UF = "SP" },
                new Cidade { Id = 2, Nome = "Rio de Janeiro", UF = "RJ" },
                new Cidade { Id = 3, Nome = "Belo Horizonte", UF = "MG" }
            };

            foreach (Cidade cidade in cidades)
            {
                dataTable.Rows.Add(cidade.Id, cidade.Nome, cidade.UF);
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

    public class Cidade
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string UF { get; set; }
    }
}
