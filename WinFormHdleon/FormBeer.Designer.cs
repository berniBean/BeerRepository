namespace WinFormHdleon
{
    partial class FormBeer
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
            panel1 = new Panel();
            BtnNuevaCerveza = new Button();
            dataGridView1 = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(BtnNuevaCerveza);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 82);
            panel1.TabIndex = 1;
            // 
            // BtnNuevaCerveza
            // 
            BtnNuevaCerveza.Location = new Point(12, 12);
            BtnNuevaCerveza.Name = "BtnNuevaCerveza";
            BtnNuevaCerveza.Size = new Size(135, 23);
            BtnNuevaCerveza.TabIndex = 0;
            BtnNuevaCerveza.Text = "Nueva cerveza";
            BtnNuevaCerveza.UseVisualStyleBackColor = true;
            BtnNuevaCerveza.Click += BtnNuevaCerveza_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 82);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(800, 368);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // FormBeer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormBeer";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormBeer";
            Load += FormBeer_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button BtnNuevaCerveza;
        private DataGridView dataGridView1;
    }
}