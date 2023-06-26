namespace DesktopAPP.View
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.pnlMasterContainer = new System.Windows.Forms.Panel();
            this.pnlBody = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.btnPaymentRanking = new System.Windows.Forms.Button();
            this.btnPayments = new System.Windows.Forms.Button();
            this.btnBuilding = new System.Windows.Forms.Button();
            this.btnCities = new System.Windows.Forms.Button();
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnExercises = new System.Windows.Forms.Button();
            this.pnlMasterContainer.SuspendLayout();
            this.pnlBody.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.pnlHeader.SuspendLayout();
            this.pnlMenu.SuspendLayout();
            this.pnlLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMasterContainer
            // 
            this.pnlMasterContainer.Controls.Add(this.pnlBody);
            this.pnlMasterContainer.Controls.Add(this.pnlHeader);
            this.pnlMasterContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMasterContainer.Location = new System.Drawing.Point(220, 0);
            this.pnlMasterContainer.Name = "pnlMasterContainer";
            this.pnlMasterContainer.Size = new System.Drawing.Size(695, 594);
            this.pnlMasterContainer.TabIndex = 3;
            // 
            // pnlBody
            // 
            this.pnlBody.BackColor = System.Drawing.Color.Gainsboro;
            this.pnlBody.Controls.Add(this.pictureBox2);
            this.pnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBody.Location = new System.Drawing.Point(0, 66);
            this.pnlBody.Name = "pnlBody";
            this.pnlBody.Size = new System.Drawing.Size(695, 528);
            this.pnlBody.TabIndex = 1;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(245, 188);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(222, 138);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.RoyalBlue;
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(695, 66);
            this.pnlHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Arial", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTitle.Location = new System.Drawing.Point(21, 23);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(113, 40);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Home";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.RoyalBlue;
            this.pnlMenu.Controls.Add(this.btnExercises);
            this.pnlMenu.Controls.Add(this.btnPaymentRanking);
            this.pnlMenu.Controls.Add(this.btnPayments);
            this.pnlMenu.Controls.Add(this.btnBuilding);
            this.pnlMenu.Controls.Add(this.btnCities);
            this.pnlMenu.Controls.Add(this.pnlLogo);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(220, 594);
            this.pnlMenu.TabIndex = 4;
            // 
            // btnPaymentRanking
            // 
            this.btnPaymentRanking.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPaymentRanking.FlatAppearance.BorderSize = 0;
            this.btnPaymentRanking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPaymentRanking.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPaymentRanking.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnPaymentRanking.Location = new System.Drawing.Point(0, 290);
            this.btnPaymentRanking.Name = "btnPaymentRanking";
            this.btnPaymentRanking.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnPaymentRanking.Size = new System.Drawing.Size(220, 50);
            this.btnPaymentRanking.TabIndex = 4;
            this.btnPaymentRanking.Text = "Ranking de pagamentos";
            this.btnPaymentRanking.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPaymentRanking.UseVisualStyleBackColor = true;
            this.btnPaymentRanking.Click += new System.EventHandler(this.btnPaymentRanking_Click);
            // 
            // btnPayments
            // 
            this.btnPayments.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPayments.FlatAppearance.BorderSize = 0;
            this.btnPayments.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPayments.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPayments.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnPayments.Location = new System.Drawing.Point(0, 240);
            this.btnPayments.Name = "btnPayments";
            this.btnPayments.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnPayments.Size = new System.Drawing.Size(220, 50);
            this.btnPayments.TabIndex = 3;
            this.btnPayments.Text = "Pagamentos";
            this.btnPayments.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPayments.UseVisualStyleBackColor = true;
            this.btnPayments.Click += new System.EventHandler(this.btnPayments_Click);
            // 
            // btnBuilding
            // 
            this.btnBuilding.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBuilding.FlatAppearance.BorderSize = 0;
            this.btnBuilding.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuilding.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuilding.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBuilding.Location = new System.Drawing.Point(0, 190);
            this.btnBuilding.Name = "btnBuilding";
            this.btnBuilding.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnBuilding.Size = new System.Drawing.Size(220, 50);
            this.btnBuilding.TabIndex = 2;
            this.btnBuilding.Text = "Edificios";
            this.btnBuilding.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuilding.UseVisualStyleBackColor = true;
            this.btnBuilding.Click += new System.EventHandler(this.btnBuilding_Click);
            // 
            // btnCities
            // 
            this.btnCities.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCities.FlatAppearance.BorderSize = 0;
            this.btnCities.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCities.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCities.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCities.Location = new System.Drawing.Point(0, 140);
            this.btnCities.Name = "btnCities";
            this.btnCities.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnCities.Size = new System.Drawing.Size(220, 50);
            this.btnCities.TabIndex = 1;
            this.btnCities.Text = "Cidades";
            this.btnCities.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCities.UseVisualStyleBackColor = true;
            this.btnCities.Click += new System.EventHandler(this.btnCities_Click);
            // 
            // pnlLogo
            // 
            this.pnlLogo.Controls.Add(this.pictureBox1);
            this.pnlLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLogo.Location = new System.Drawing.Point(0, 0);
            this.pnlLogo.Name = "pnlLogo";
            this.pnlLogo.Size = new System.Drawing.Size(220, 140);
            this.pnlLogo.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(190, 108);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnExercises
            // 
            this.btnExercises.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnExercises.FlatAppearance.BorderSize = 0;
            this.btnExercises.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExercises.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExercises.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnExercises.Location = new System.Drawing.Point(0, 340);
            this.btnExercises.Name = "btnExercises";
            this.btnExercises.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnExercises.Size = new System.Drawing.Size(220, 50);
            this.btnExercises.TabIndex = 5;
            this.btnExercises.Text = "Atividades";
            this.btnExercises.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExercises.UseVisualStyleBackColor = true;
            this.btnExercises.Click += new System.EventHandler(this.btnExercises_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 594);
            this.Controls.Add(this.pnlMasterContainer);
            this.Controls.Add(this.pnlMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestão de condominios";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.pnlMasterContainer.ResumeLayout(false);
            this.pnlBody.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlMenu.ResumeLayout(false);
            this.pnlLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlMasterContainer;
        private System.Windows.Forms.Panel pnlBody;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Panel pnlLogo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnCities;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnBuilding;
        private System.Windows.Forms.Button btnPayments;
        private System.Windows.Forms.Button btnPaymentRanking;
        private System.Windows.Forms.Button btnExercises;
    }
}