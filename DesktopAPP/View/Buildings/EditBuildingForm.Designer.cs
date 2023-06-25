namespace DesktopAPP.View.Buildings
{
    partial class EditBuildingForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditBuildingForm));
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFloors = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageApartamentos = new System.Windows.Forms.TabPage();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Floor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BadroomsQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SizeM2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnEdit = new System.Windows.Forms.LinkLabel();
            this.btnDelete = new System.Windows.Forms.LinkLabel();
            this.btnAdd = new System.Windows.Forms.LinkLabel();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCityName = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtCityId = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.txtFloors)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPageApartamentos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCityId)).BeginInit();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtName.BackColor = System.Drawing.SystemColors.Window;
            this.txtName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(97, 31);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(279, 26);
            this.txtName.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(93, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 19);
            this.label2.TabIndex = 8;
            this.label2.Text = "Nome";
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.Location = new System.Drawing.Point(16, 31);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(75, 26);
            this.txtId.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 19);
            this.label1.TabIndex = 7;
            this.label1.Text = "ID";
            // 
            // txtFloors
            // 
            this.txtFloors.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFloors.BackColor = System.Drawing.SystemColors.Window;
            this.txtFloors.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.txtFloors.Location = new System.Drawing.Point(382, 32);
            this.txtFloors.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.txtFloors.Name = "txtFloors";
            this.txtFloors.Size = new System.Drawing.Size(75, 26);
            this.txtFloors.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(384, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 19);
            this.label3.TabIndex = 9;
            this.label3.Text = "Andares";
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPageApartamentos);
            this.tabControl1.Location = new System.Drawing.Point(16, 114);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(445, 311);
            this.tabControl1.TabIndex = 12;
            // 
            // tabPageApartamentos
            // 
            this.tabPageApartamentos.BackColor = System.Drawing.Color.Gainsboro;
            this.tabPageApartamentos.Controls.Add(this.dataGridView);
            this.tabPageApartamentos.Controls.Add(this.panel1);
            this.tabPageApartamentos.Location = new System.Drawing.Point(4, 22);
            this.tabPageApartamentos.Name = "tabPageApartamentos";
            this.tabPageApartamentos.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageApartamentos.Size = new System.Drawing.Size(437, 285);
            this.tabPageApartamentos.TabIndex = 0;
            this.tabPageApartamentos.Text = "Apartamentos";
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Floor,
            this.BadroomsQuantity,
            this.SizeM2});
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView.Location = new System.Drawing.Point(3, 19);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(431, 263);
            this.dataGridView.TabIndex = 13;
            this.dataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellDoubleClick);
            // 
            // Id
            // 
            this.Id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Id.FillWeight = 50F;
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Id.Width = 50;
            // 
            // Floor
            // 
            this.Floor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Floor.HeaderText = "Andar";
            this.Floor.Name = "Floor";
            this.Floor.ReadOnly = true;
            this.Floor.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // BadroomsQuantity
            // 
            this.BadroomsQuantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.BadroomsQuantity.HeaderText = "Quantidade de quartos";
            this.BadroomsQuantity.Name = "BadroomsQuantity";
            this.BadroomsQuantity.ReadOnly = true;
            this.BadroomsQuantity.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // SizeM2
            // 
            this.SizeM2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.SizeM2.HeaderText = "Metragem (m²)";
            this.SizeM2.Name = "SizeM2";
            this.SizeM2.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnEdit);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(431, 16);
            this.panel1.TabIndex = 14;
            // 
            // btnEdit
            // 
            this.btnEdit.AutoSize = true;
            this.btnEdit.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnEdit.Location = new System.Drawing.Point(129, 0);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btnEdit.Size = new System.Drawing.Size(54, 13);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.TabStop = true;
            this.btnEdit.Text = "Editar";
            this.btnEdit.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.btnEdit_LinkClicked);
            // 
            // btnDelete
            // 
            this.btnDelete.AutoSize = true;
            this.btnDelete.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnDelete.Location = new System.Drawing.Point(71, 0);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btnDelete.Size = new System.Drawing.Size(58, 13);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.TabStop = true;
            this.btnDelete.Text = "Excluir";
            this.btnDelete.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.btnDelete_LinkClicked);
            // 
            // btnAdd
            // 
            this.btnAdd.AutoSize = true;
            this.btnAdd.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnAdd.Location = new System.Drawing.Point(0, 0);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btnAdd.Size = new System.Drawing.Size(71, 13);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.TabStop = true;
            this.btnAdd.Text = "Adicionar";
            this.btnAdd.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.btnAdd_LinkClicked);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 19);
            this.label4.TabIndex = 11;
            this.label4.Text = "Cidade";
            // 
            // txtCityName
            // 
            this.txtCityName.Enabled = false;
            this.txtCityName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCityName.Location = new System.Drawing.Point(127, 82);
            this.txtCityName.Name = "txtCityName";
            this.txtCityName.ReadOnly = true;
            this.txtCityName.Size = new System.Drawing.Size(330, 26);
            this.txtCityName.TabIndex = 5;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // btnSearch
            // 
            this.btnSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSearch.BackgroundImage")));
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Location = new System.Drawing.Point(97, 82);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(24, 24);
            this.btnSearch.TabIndex = 15;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(16, 431);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Salvar";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtCityId
            // 
            this.txtCityId.BackColor = System.Drawing.SystemColors.Window;
            this.txtCityId.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.txtCityId.Location = new System.Drawing.Point(16, 83);
            this.txtCityId.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.txtCityId.Name = "txtCityId";
            this.txtCityId.Size = new System.Drawing.Size(75, 26);
            this.txtCityId.TabIndex = 4;
            this.txtCityId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCityId_KeyPress);
            // 
            // EditBuildingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(473, 464);
            this.Controls.Add(this.txtCityId);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtCityName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtFloors);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditBuildingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cadastro de edificios";
            this.Load += new System.EventHandler(this.EditBuildingForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtFloors)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPageApartamentos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCityId)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown txtFloors;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageApartamentos;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCityName;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.NumericUpDown txtCityId;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.LinkLabel btnEdit;
        private System.Windows.Forms.LinkLabel btnDelete;
        private System.Windows.Forms.LinkLabel btnAdd;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Floor;
        private System.Windows.Forms.DataGridViewTextBoxColumn BadroomsQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn SizeM2;
    }
}