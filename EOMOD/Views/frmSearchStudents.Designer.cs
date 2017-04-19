namespace EOMOD.Views
{
    partial class frmSearchStudents
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSearchStudents));
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbmGrado = new System.Windows.Forms.ComboBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.btnViewDetail = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.cbmGenero = new System.Windows.Forms.ComboBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.txbIdentidad = new System.Windows.Forms.TextBox();
            this.txbApellido = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txbName = new System.Windows.Forms.TextBox();
            this.pnlRegistroCode = new System.Windows.Forms.Panel();
            this.lblRegistroCode = new System.Windows.Forms.Label();
            this.txbRegistroCode = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.panel1.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.pnlRegistroCode.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbmGrado);
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Controls.Add(this.btnViewDetail);
            this.panel1.Controls.Add(this.btnClear);
            this.panel1.Controls.Add(this.cbmGenero);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.txbIdentidad);
            this.panel1.Controls.Add(this.txbApellido);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.txbName);
            this.panel1.Controls.Add(this.pnlRegistroCode);
            this.panel1.Controls.Add(this.txbRegistroCode);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(637, 88);
            this.panel1.TabIndex = 0;
            // 
            // cbmGrado
            // 
            this.cbmGrado.FormattingEnabled = true;
            this.cbmGrado.Location = new System.Drawing.Point(319, 7);
            this.cbmGrado.Name = "cbmGrado";
            this.cbmGrado.Size = new System.Drawing.Size(191, 21);
            this.cbmGrado.TabIndex = 13;
            this.cbmGrado.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbmGenero_KeyDown);
            this.cbmGrado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbmGenero_KeyPress);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.DimGray;
            this.panel7.Controls.Add(this.label5);
            this.panel7.Location = new System.Drawing.Point(254, 7);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(68, 21);
            this.panel7.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(13, 5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Grado";
            // 
            // btnViewDetail
            // 
            this.btnViewDetail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewDetail.Location = new System.Drawing.Point(516, 5);
            this.btnViewDetail.Name = "btnViewDetail";
            this.btnViewDetail.Size = new System.Drawing.Size(106, 23);
            this.btnViewDetail.TabIndex = 12;
            this.btnViewDetail.Text = "Selecionar";
            this.btnViewDetail.UseVisualStyleBackColor = true;
            this.btnViewDetail.Click += new System.EventHandler(this.SelecRegistreDetail_Click);
            // 
            // btnClear
            // 
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Location = new System.Drawing.Point(516, 34);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(106, 23);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "Limpiar Filtros";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // cbmGenero
            // 
            this.cbmGenero.FormattingEnabled = true;
            this.cbmGenero.Location = new System.Drawing.Point(76, 34);
            this.cbmGenero.Name = "cbmGenero";
            this.cbmGenero.Size = new System.Drawing.Size(169, 21);
            this.cbmGenero.TabIndex = 2;
            this.cbmGenero.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbmGenero_KeyDown);
            this.cbmGenero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbmGenero_KeyPress);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.DimGray;
            this.panel6.Controls.Add(this.label4);
            this.panel6.Location = new System.Drawing.Point(11, 34);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(68, 21);
            this.panel6.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(13, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Genero";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.DimGray;
            this.panel5.Controls.Add(this.label3);
            this.panel5.Location = new System.Drawing.Point(254, 34);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(68, 20);
            this.panel5.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(8, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Identidad";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DimGray;
            this.panel4.Controls.Add(this.label2);
            this.panel4.Location = new System.Drawing.Point(254, 60);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(68, 20);
            this.panel4.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(13, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Apellido";
            // 
            // txbIdentidad
            // 
            this.txbIdentidad.Location = new System.Drawing.Point(319, 34);
            this.txbIdentidad.Name = "txbIdentidad";
            this.txbIdentidad.Size = new System.Drawing.Size(192, 20);
            this.txbIdentidad.TabIndex = 3;
            this.txbIdentidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txbIdentidad.TextChanged += new System.EventHandler(this.txbIdentidad_TextChanged);
            // 
            // txbApellido
            // 
            this.txbApellido.Location = new System.Drawing.Point(319, 60);
            this.txbApellido.Name = "txbApellido";
            this.txbApellido.Size = new System.Drawing.Size(192, 20);
            this.txbApellido.TabIndex = 5;
            this.txbApellido.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txbApellido.TextChanged += new System.EventHandler(this.txbApellido_TextChanged);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DimGray;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(11, 60);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(68, 20);
            this.panel3.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(13, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nombre";
            // 
            // txbName
            // 
            this.txbName.Location = new System.Drawing.Point(76, 60);
            this.txbName.Name = "txbName";
            this.txbName.Size = new System.Drawing.Size(169, 20);
            this.txbName.TabIndex = 4;
            this.txbName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txbName.TextChanged += new System.EventHandler(this.txbName_TextChanged);
            // 
            // pnlRegistroCode
            // 
            this.pnlRegistroCode.BackColor = System.Drawing.Color.DimGray;
            this.pnlRegistroCode.Controls.Add(this.lblRegistroCode);
            this.pnlRegistroCode.Location = new System.Drawing.Point(11, 8);
            this.pnlRegistroCode.Name = "pnlRegistroCode";
            this.pnlRegistroCode.Size = new System.Drawing.Size(68, 20);
            this.pnlRegistroCode.TabIndex = 7;
            // 
            // lblRegistroCode
            // 
            this.lblRegistroCode.AutoSize = true;
            this.lblRegistroCode.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblRegistroCode.Location = new System.Drawing.Point(13, 3);
            this.lblRegistroCode.Name = "lblRegistroCode";
            this.lblRegistroCode.Size = new System.Drawing.Size(46, 13);
            this.lblRegistroCode.TabIndex = 4;
            this.lblRegistroCode.Text = "Registro";
            // 
            // txbRegistroCode
            // 
            this.txbRegistroCode.Location = new System.Drawing.Point(76, 8);
            this.txbRegistroCode.Name = "txbRegistroCode";
            this.txbRegistroCode.Size = new System.Drawing.Size(169, 20);
            this.txbRegistroCode.TabIndex = 1;
            this.txbRegistroCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txbRegistroCode.TextChanged += new System.EventHandler(this.txbRegistroCode_TextChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Location = new System.Drawing.Point(516, 60);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(106, 23);
            this.btnSearch.TabIndex = 7;
            this.btnSearch.Text = "Buscar";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Location = new System.Drawing.Point(0, 94);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(637, 242);
            this.panel2.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(637, 242);
            this.dataGridView1.TabIndex = 0;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 339);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(634, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // frmSearchStudents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 361);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(650, 400);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(650, 400);
            this.Name = "frmSearchStudents";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Busqueda";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmSearchStudents_FormClosed);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.pnlRegistroCode.ResumeLayout(false);
            this.pnlRegistroCode.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txbRegistroCode;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Panel pnlRegistroCode;
        private System.Windows.Forms.Label lblRegistroCode;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbIdentidad;
        private System.Windows.Forms.TextBox txbApellido;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbName;
        private System.Windows.Forms.ComboBox cbmGenero;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnViewDetail;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ComboBox cbmGrado;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label5;
    }
}