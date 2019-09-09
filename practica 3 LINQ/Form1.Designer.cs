namespace practica_3_LINQ
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.ctapellido = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ctnombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ctcedula = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.ctsexo = new System.Windows.Forms.ComboBox();
            this.ctsexo1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1284, 353);
            this.dataGridView1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ctsexo1);
            this.panel1.Controls.Add(this.ctsexo);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.ctapellido);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.ctnombre);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.ctcedula);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1284, 97);
            this.panel1.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(453, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Apellido";
            // 
            // ctapellido
            // 
            this.ctapellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctapellido.Location = new System.Drawing.Point(457, 53);
            this.ctapellido.Name = "ctapellido";
            this.ctapellido.Size = new System.Drawing.Size(141, 26);
            this.ctapellido.TabIndex = 4;
            this.ctapellido.TextChanged += new System.EventHandler(this.ctcedula_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(266, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nombre";
            // 
            // ctnombre
            // 
            this.ctnombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctnombre.Location = new System.Drawing.Point(270, 53);
            this.ctnombre.Name = "ctnombre";
            this.ctnombre.Size = new System.Drawing.Size(141, 26);
            this.ctnombre.TabIndex = 2;
            this.ctnombre.TextChanged += new System.EventHandler(this.ctcedula_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(81, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cedula";
            // 
            // ctcedula
            // 
            this.ctcedula.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctcedula.Location = new System.Drawing.Point(76, 53);
            this.ctcedula.Name = "ctcedula";
            this.ctcedula.Size = new System.Drawing.Size(141, 26);
            this.ctcedula.TabIndex = 0;
            this.ctcedula.TextChanged += new System.EventHandler(this.ctcedula_TextChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 97);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1284, 353);
            this.panel2.TabIndex = 2;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(0, 0);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 3;
            // 
            // ctsexo
            // 
            this.ctsexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctsexo.FormattingEnabled = true;
            this.ctsexo.Items.AddRange(new object[] {
            "Todos",
            "M",
            "F"});
            this.ctsexo.Location = new System.Drawing.Point(714, 53);
            this.ctsexo.Name = "ctsexo";
            this.ctsexo.Size = new System.Drawing.Size(121, 28);
            this.ctsexo.TabIndex = 6;
            this.ctsexo.SelectedIndexChanged += new System.EventHandler(this.ctcedula_TextChanged);
            // 
            // ctsexo1
            // 
            this.ctsexo1.AutoSize = true;
            this.ctsexo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctsexo1.Location = new System.Drawing.Point(710, 30);
            this.ctsexo1.Name = "ctsexo1";
            this.ctsexo1.Size = new System.Drawing.Size(49, 20);
            this.ctsexo1.TabIndex = 7;
            this.ctsexo1.Text = "Sexo";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 450);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ctcedula;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ctapellido;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ctnombre;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label ctsexo1;
        private System.Windows.Forms.ComboBox ctsexo;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

