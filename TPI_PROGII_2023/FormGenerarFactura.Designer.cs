namespace TPI_PROGII_2023
{
    partial class FormGenerarFactura
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
            lblInmobiliaria = new Label();
            lblFactura = new Label();
            lblAgenteInmobiliario = new Label();
            lblCliente = new Label();
            cboAgenteInm = new ComboBox();
            cboCliente = new ComboBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // lblInmobiliaria
            // 
            lblInmobiliaria.AutoSize = true;
            lblInmobiliaria.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblInmobiliaria.Location = new Point(12, 11);
            lblInmobiliaria.Name = "lblInmobiliaria";
            lblInmobiliaria.Size = new Size(93, 21);
            lblInmobiliaria.TabIndex = 0;
            lblInmobiliaria.Text = "Inmobiliaria";
            // 
            // lblFactura
            // 
            lblFactura.AutoSize = true;
            lblFactura.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lblFactura.Location = new Point(12, 65);
            lblFactura.Name = "lblFactura";
            lblFactura.Size = new Size(141, 25);
            lblFactura.TabIndex = 1;
            lblFactura.Text = "FACTURA Nro:";
            // 
            // lblAgenteInmobiliario
            // 
            lblAgenteInmobiliario.AutoSize = true;
            lblAgenteInmobiliario.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblAgenteInmobiliario.Location = new Point(12, 98);
            lblAgenteInmobiliario.Name = "lblAgenteInmobiliario";
            lblAgenteInmobiliario.Size = new Size(115, 15);
            lblAgenteInmobiliario.TabIndex = 2;
            lblAgenteInmobiliario.Text = "Agente Inmobiliario:";
            // 
            // lblCliente
            // 
            lblCliente.AutoSize = true;
            lblCliente.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblCliente.Location = new Point(352, 98);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(47, 15);
            lblCliente.TabIndex = 4;
            lblCliente.Text = "Cliente:";
            // 
            // cboAgenteInm
            // 
            cboAgenteInm.FormattingEnabled = true;
            cboAgenteInm.Location = new Point(12, 116);
            cboAgenteInm.Name = "cboAgenteInm";
            cboAgenteInm.Size = new Size(320, 23);
            cboAgenteInm.TabIndex = 6;
            // 
            // cboCliente
            // 
            cboCliente.FormattingEnabled = true;
            cboCliente.Location = new Point(352, 116);
            cboCliente.Name = "cboCliente";
            cboCliente.Size = new Size(320, 23);
            cboCliente.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(570, 13);
            label1.Name = "label1";
            label1.Size = new Size(102, 15);
            label1.TabIndex = 8;
            label1.Text = "Fecha: 04/11/2023";
            // 
            // FormGenerarFactura
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(684, 861);
            Controls.Add(label1);
            Controls.Add(cboCliente);
            Controls.Add(cboAgenteInm);
            Controls.Add(lblCliente);
            Controls.Add(lblAgenteInmobiliario);
            Controls.Add(lblFactura);
            Controls.Add(lblInmobiliaria);
            Name = "FormGenerarFactura";
            StartPosition = FormStartPosition.CenterParent;
            Text = "FormGenerarFactura";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblInmobiliaria;
        private Label lblFactura;
        private Label lblAgenteInmobiliario;
        private Label lblCliente;
        private ComboBox cboAgenteInm;
        private ComboBox cboCliente;
        private Label label1;
    }
}