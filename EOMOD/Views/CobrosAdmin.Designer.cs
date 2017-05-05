namespace EOMOD.Views
{
    partial class CobrosAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CobrosAdmin));
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txbName = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.pnlRegistroCode = new System.Windows.Forms.Panel();
            this.lblRegistroCode = new System.Windows.Forms.Label();
            this.txbRegistroCode = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel9 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.txbGrado = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.txbGenero = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.chkbCobros = new System.Windows.Forms.CheckBox();
            this.panel3.SuspendLayout();
            this.pnlRegistroCode.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel9.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DimGray;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(12, 38);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(68, 20);
            this.panel3.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(13, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Alumno";
            // 
            // txbName
            // 
            this.txbName.Location = new System.Drawing.Point(77, 38);
            this.txbName.Name = "txbName";
            this.txbName.ReadOnly = true;
            this.txbName.Size = new System.Drawing.Size(434, 20);
            this.txbName.TabIndex = 23;
            this.txbName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnSearch
            // 
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Location = new System.Drawing.Point(405, 10);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(106, 23);
            this.btnSearch.TabIndex = 22;
            this.btnSearch.Text = "Buscar";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // pnlRegistroCode
            // 
            this.pnlRegistroCode.BackColor = System.Drawing.Color.DimGray;
            this.pnlRegistroCode.Controls.Add(this.lblRegistroCode);
            this.pnlRegistroCode.Location = new System.Drawing.Point(12, 12);
            this.pnlRegistroCode.Name = "pnlRegistroCode";
            this.pnlRegistroCode.Size = new System.Drawing.Size(68, 20);
            this.pnlRegistroCode.TabIndex = 21;
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
            this.txbRegistroCode.Location = new System.Drawing.Point(77, 12);
            this.txbRegistroCode.MaximumSize = new System.Drawing.Size(154, 20);
            this.txbRegistroCode.MinimumSize = new System.Drawing.Size(154, 20);
            this.txbRegistroCode.Name = "txbRegistroCode";
            this.txbRegistroCode.Size = new System.Drawing.Size(154, 20);
            this.txbRegistroCode.TabIndex = 20;
            this.txbRegistroCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txbRegistroCode.TextChanged += new System.EventHandler(this.txbRegistroCode_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 111);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(499, 129);
            this.dataGridView1.TabIndex = 25;
            this.dataGridView1.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDoubleClick);
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.DimGray;
            this.panel9.Controls.Add(this.label9);
            this.panel9.Location = new System.Drawing.Point(193, 64);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(68, 20);
            this.panel9.TabIndex = 32;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label9.Location = new System.Drawing.Point(13, 3);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "Grado";
            // 
            // txbGrado
            // 
            this.txbGrado.Location = new System.Drawing.Point(258, 64);
            this.txbGrado.Multiline = true;
            this.txbGrado.Name = "txbGrado";
            this.txbGrado.ReadOnly = true;
            this.txbGrado.Size = new System.Drawing.Size(253, 20);
            this.txbGrado.TabIndex = 31;
            this.txbGrado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(12, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(68, 20);
            this.panel1.TabIndex = 34;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(13, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Genero";
            // 
            // txbGenero
            // 
            this.txbGenero.Location = new System.Drawing.Point(77, 64);
            this.txbGenero.Name = "txbGenero";
            this.txbGenero.ReadOnly = true;
            this.txbGenero.Size = new System.Drawing.Size(110, 20);
            this.txbGenero.TabIndex = 33;
            this.txbGenero.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 251);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(523, 22);
            this.statusStrip1.TabIndex = 35;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // chkbCobros
            // 
            this.chkbCobros.AutoSize = true;
            this.chkbCobros.Location = new System.Drawing.Point(258, 12);
            this.chkbCobros.Name = "chkbCobros";
            this.chkbCobros.Size = new System.Drawing.Size(127, 17);
            this.chkbCobros.TabIndex = 36;
            this.chkbCobros.Text = "Ver cobros realizados";
            this.chkbCobros.UseVisualStyleBackColor = true;
            this.chkbCobros.Visible = false;
            // 
            // CobrosAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 273);
            this.Controls.Add(this.chkbCobros);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txbGenero);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.txbGrado);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.txbName);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.pnlRegistroCode);
            this.Controls.Add(this.txbRegistroCode);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(539, 312);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(539, 312);
            this.Name = "CobrosAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Gestión de cobros";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CobrosAdmin_FormClosed);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.pnlRegistroCode.ResumeLayout(false);
            this.pnlRegistroCode.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbName;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Panel pnlRegistroCode;
        private System.Windows.Forms.Label lblRegistroCode;
        private System.Windows.Forms.TextBox txbRegistroCode;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txbGrado;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbGenero;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.CheckBox chkbCobros;
    }
}