namespace VendaPassagens
{
    partial class Form3
    {
        private System.ComponentModel.IContainer components = null;
        private Label lblOrigem;
        private TextBox txtOrigem;
        private TextBox txtDestino;
        private Label lblDestino;
        private Label lblDataHora;
        private DateTimePicker dtpDataHora;
        private TextBox txtCompanhia;
        private Label lblCompanhia;
        private Label lblPreco;
        private NumericUpDown numPreco;
        private Button btnSalvar;
        private Button btnCancelar;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            lblOrigem = new Label();
            txtOrigem = new TextBox();
            txtDestino = new TextBox();
            lblDestino = new Label();
            lblDataHora = new Label();
            dtpDataHora = new DateTimePicker();
            txtCompanhia = new TextBox();
            lblCompanhia = new Label();
            lblPreco = new Label();
            numPreco = new NumericUpDown();
            btnSalvar = new Button();
            btnCancelar = new Button();
            ((System.ComponentModel.ISupportInitialize)numPreco).BeginInit();
            SuspendLayout();
            // 
            // lblOrigem
            // 
            lblOrigem.AutoSize = true;
            lblOrigem.Location = new Point(58, 36);
            lblOrigem.Name = "lblOrigem";
            lblOrigem.Size = new Size(62, 20);
            lblOrigem.TabIndex = 0;
            lblOrigem.Text = "Origem:";
            // 
            // txtOrigem
            // 
            txtOrigem.Location = new Point(126, 33);
            txtOrigem.Name = "txtOrigem";
            txtOrigem.Size = new Size(318, 27);
            txtOrigem.TabIndex = 1;
            // 
            // txtDestino
            // 
            txtDestino.Location = new Point(126, 66);
            txtDestino.Name = "txtDestino";
            txtDestino.Size = new Size(318, 27);
            txtDestino.TabIndex = 3;
            // 
            // lblDestino
            // 
            lblDestino.AutoSize = true;
            lblDestino.Location = new Point(58, 69);
            lblDestino.Name = "lblDestino";
            lblDestino.Size = new Size(63, 20);
            lblDestino.TabIndex = 2;
            lblDestino.Text = "Destino:";
            // 
            // lblDataHora
            // 
            lblDataHora.AutoSize = true;
            lblDataHora.Location = new Point(36, 106);
            lblDataHora.Name = "lblDataHora";
            lblDataHora.Size = new Size(83, 20);
            lblDataHora.TabIndex = 4;
            lblDataHora.Text = "Data/Hora:";
            // 
            // dtpDataHora
            // 
            dtpDataHora.CustomFormat = "dd/MM/yyyy HH:mm";
            dtpDataHora.Format = DateTimePickerFormat.Custom;
            dtpDataHora.Location = new Point(126, 101);
            dtpDataHora.Name = "dtpDataHora";
            dtpDataHora.Size = new Size(318, 27);
            dtpDataHora.TabIndex = 5;
            // 
            // txtCompanhia
            // 
            txtCompanhia.Location = new Point(126, 134);
            txtCompanhia.Name = "txtCompanhia";
            txtCompanhia.Size = new Size(318, 27);
            txtCompanhia.TabIndex = 7;
            // 
            // lblCompanhia
            // 
            lblCompanhia.AutoSize = true;
            lblCompanhia.Location = new Point(35, 137);
            lblCompanhia.Name = "lblCompanhia";
            lblCompanhia.Size = new Size(88, 20);
            lblCompanhia.TabIndex = 6;
            lblCompanhia.Text = "Companhia:";
            // 
            // lblPreco
            // 
            lblPreco.AutoSize = true;
            lblPreco.Location = new Point(71, 170);
            lblPreco.Name = "lblPreco";
            lblPreco.Size = new Size(49, 20);
            lblPreco.TabIndex = 8;
            lblPreco.Text = "Preço:";
            // 
            // numPreco
            // 
            numPreco.DecimalPlaces = 2;
            numPreco.Location = new Point(126, 168);
            numPreco.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            numPreco.Name = "numPreco";
            numPreco.Size = new Size(150, 27);
            numPreco.TabIndex = 9;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(350, 225);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(94, 29);
            btnSalvar.TabIndex = 10;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(250, 225);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(94, 29);
            btnCancelar.TabIndex = 11;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // Form3
            // 
            AcceptButton = btnSalvar;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancelar;
            ClientSize = new Size(506, 284);
            Controls.Add(btnCancelar);
            Controls.Add(btnSalvar);
            Controls.Add(numPreco);
            Controls.Add(lblPreco);
            Controls.Add(txtCompanhia);
            Controls.Add(lblCompanhia);
            Controls.Add(dtpDataHora);
            Controls.Add(lblDataHora);
            Controls.Add(txtDestino);
            Controls.Add(lblDestino);
            Controls.Add(txtOrigem);
            Controls.Add(lblOrigem);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form3";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)numPreco).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
        #endregion
    }
}