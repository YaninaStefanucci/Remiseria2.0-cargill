namespace Remiseria2._0
{
    partial class CalcularComision
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
            this.label1 = new System.Windows.Forms.Label();
            this.BoxChofer = new System.Windows.Forms.ComboBox();
            this.BtnCalcularComision = new System.Windows.Forms.Button();
            this.FechaFiltro = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Seleccione chofer a cobrar";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // BoxChofer
            // 
            this.BoxChofer.FormattingEnabled = true;
            this.BoxChofer.Location = new System.Drawing.Point(61, 56);
            this.BoxChofer.Margin = new System.Windows.Forms.Padding(2);
            this.BoxChofer.Name = "BoxChofer";
            this.BoxChofer.Size = new System.Drawing.Size(132, 21);
            this.BoxChofer.TabIndex = 1;
            this.BoxChofer.SelectedIndexChanged += new System.EventHandler(this.CmbBoxChofer_SelectedIndexChanged);
            // 
            // BtnCalcularComision
            // 
            this.BtnCalcularComision.Location = new System.Drawing.Point(74, 198);
            this.BtnCalcularComision.Margin = new System.Windows.Forms.Padding(2);
            this.BtnCalcularComision.Name = "BtnCalcularComision";
            this.BtnCalcularComision.Size = new System.Drawing.Size(103, 35);
            this.BtnCalcularComision.TabIndex = 2;
            this.BtnCalcularComision.Text = "Calcular Comision";
            this.BtnCalcularComision.UseVisualStyleBackColor = true;
            this.BtnCalcularComision.Click += new System.EventHandler(this.BtnCalcularComision_Click);
            // 
            // FechaFiltro
            // 
            this.FechaFiltro.Location = new System.Drawing.Point(25, 152);
            this.FechaFiltro.Name = "FechaFiltro";
            this.FechaFiltro.Size = new System.Drawing.Size(200, 20);
            this.FechaFiltro.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(76, 125);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Seleccione fecha";
            // 
            // CalcularComision
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(271, 257);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.FechaFiltro);
            this.Controls.Add(this.BtnCalcularComision);
            this.Controls.Add(this.BoxChofer);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "CalcularComision";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calcular Comision";
            this.Load += new System.EventHandler(this.CalcularComision_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox BoxChofer;
        private System.Windows.Forms.Button BtnCalcularComision;
        private System.Windows.Forms.DateTimePicker FechaFiltro;
        private System.Windows.Forms.Label label2;
    }
}