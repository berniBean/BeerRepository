namespace WinFormHdleon
{
    partial class FormNewEditBrand
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
            label1 = new Label();
            TxtNombre = new TextBox();
            BtnGuardar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 27);
            label1.Name = "label1";
            label1.Size = new Size(87, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre marca";
            // 
            // TxtNombre
            // 
            TxtNombre.Location = new Point(114, 24);
            TxtNombre.Name = "TxtNombre";
            TxtNombre.Size = new Size(133, 23);
            TxtNombre.TabIndex = 1;
            // 
            // BtnGuardar
            // 
            BtnGuardar.Location = new Point(114, 80);
            BtnGuardar.Name = "BtnGuardar";
            BtnGuardar.Size = new Size(75, 23);
            BtnGuardar.TabIndex = 2;
            BtnGuardar.Text = "Guardar";
            BtnGuardar.UseVisualStyleBackColor = true;
            BtnGuardar.Click += BtnGuardar_Click;
            // 
            // FormNewEditBrand
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(473, 182);
            Controls.Add(BtnGuardar);
            Controls.Add(TxtNombre);
            Controls.Add(label1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormNewEditBrand";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormNewEditBrand";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox TxtNombre;
        private Button BtnGuardar;
    }
}