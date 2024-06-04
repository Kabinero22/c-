namespace Fargoline
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtconte = new TextBox();
            txttara = new TextBox();
            txtpeso = new TextBox();
            cbconte = new ComboBox();
            cbtama = new ComboBox();
            btnagrega = new Button();
            btnelimina = new Button();
            btnedita = new Button();
            dataGridView1 = new DataGridView();
            label6 = new Label();
            txtid = new TextBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 69);
            label1.Name = "label1";
            label1.Size = new Size(131, 15);
            label1.TabIndex = 1;
            label1.Text = "Numero de contenedor";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 111);
            label2.Name = "label2";
            label2.Size = new Size(96, 15);
            label2.TabIndex = 2;
            label2.Text = "Tipo Contenedor";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 145);
            label3.Name = "label3";
            label3.Size = new Size(113, 15);
            label3.TabIndex = 3;
            label3.Text = "Tamaño contenedor";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(14, 187);
            label4.Name = "label4";
            label4.Size = new Size(96, 15);
            label4.TabIndex = 4;
            label4.Text = "Peso contenedor";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(14, 224);
            label5.Name = "label5";
            label5.Size = new Size(92, 15);
            label5.TabIndex = 5;
            label5.Text = "Tara contenedor";
            // 
            // txtconte
            // 
            txtconte.Location = new Point(170, 69);
            txtconte.Name = "txtconte";
            txtconte.Size = new Size(155, 23);
            txtconte.TabIndex = 6;
            // 
            // txttara
            // 
            txttara.Location = new Point(170, 216);
            txttara.Name = "txttara";
            txttara.Size = new Size(155, 23);
            txttara.TabIndex = 7;
            // 
            // txtpeso
            // 
            txtpeso.Location = new Point(170, 179);
            txtpeso.Name = "txtpeso";
            txtpeso.Size = new Size(155, 23);
            txtpeso.TabIndex = 8;
            // 
            // cbconte
            // 
            cbconte.FormattingEnabled = true;
            cbconte.Items.AddRange(new object[] { "HIG CUBE", "REFFER", "OPEN TOP" });
            cbconte.Location = new Point(170, 108);
            cbconte.Name = "cbconte";
            cbconte.Size = new Size(155, 23);
            cbconte.TabIndex = 9;
            cbconte.Text = "Seleccionar...";
            // 
            // cbtama
            // 
            cbtama.FormattingEnabled = true;
            cbtama.Items.AddRange(new object[] { "20", "40" });
            cbtama.Location = new Point(170, 142);
            cbtama.Name = "cbtama";
            cbtama.Size = new Size(155, 23);
            cbtama.TabIndex = 10;
            cbtama.Text = "Seleccionar...";
            // 
            // btnagrega
            // 
            btnagrega.BackColor = Color.PaleGreen;
            btnagrega.Location = new Point(361, 48);
            btnagrega.Name = "btnagrega";
            btnagrega.Size = new Size(101, 57);
            btnagrega.TabIndex = 11;
            btnagrega.Text = "Guardar";
            btnagrega.UseVisualStyleBackColor = false;
            btnagrega.Click += button1_Click;
            // 
            // btnelimina
            // 
            btnelimina.BackColor = Color.Tomato;
            btnelimina.Location = new Point(468, 48);
            btnelimina.Name = "btnelimina";
            btnelimina.Size = new Size(101, 57);
            btnelimina.TabIndex = 13;
            btnelimina.Text = "Eliminar";
            btnelimina.UseVisualStyleBackColor = false;
            btnelimina.Click += btnelimina_Click;
            // 
            // btnedita
            // 
            btnedita.BackColor = SystemColors.ActiveCaption;
            btnedita.Location = new Point(388, 124);
            btnedita.Name = "btnedita";
            btnedita.Size = new Size(156, 53);
            btnedita.TabIndex = 15;
            btnedita.Text = "Limpiar";
            btnedita.UseVisualStyleBackColor = false;
            btnedita.Click += btnedita_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 275);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(566, 265);
            dataGridView1.TabIndex = 16;
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(14, 29);
            label6.Name = "label6";
            label6.Size = new Size(18, 15);
            label6.TabIndex = 17;
            label6.Text = "ID";
            // 
            // txtid
            // 
            txtid.CausesValidation = false;
            txtid.Location = new Point(170, 26);
            txtid.Name = "txtid";
            txtid.Size = new Size(100, 23);
            txtid.TabIndex = 18;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSkyBlue;
            ClientSize = new Size(590, 563);
            Controls.Add(txtid);
            Controls.Add(label6);
            Controls.Add(dataGridView1);
            Controls.Add(btnedita);
            Controls.Add(btnelimina);
            Controls.Add(btnagrega);
            Controls.Add(cbtama);
            Controls.Add(cbconte);
            Controls.Add(txtpeso);
            Controls.Add(txttara);
            Controls.Add(txtconte);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "CRUD - Fargoline";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtconte;
        private TextBox txttara;
        private TextBox txtpeso;
        private ComboBox cbconte;
        private ComboBox cbtama;
        private Button btnagrega;
        private Button btnelimina;
        private Button btnedita;
        private DataGridView dataGridView1;
        private Label label6;
        private TextBox txtid;
        private ContextMenuStrip contextMenuStrip1;
    }
}