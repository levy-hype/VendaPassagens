namespace VendaPassagens
{
    partial class Form2
    {
        private System.ComponentModel.IContainer components = null;
        private DataGridView dgvPassagens;
        private Button btnAdicionar;
        private Button btnEditar;
        private Label lblTituloLista;

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
            dgvPassagens = new DataGridView();
            btnAdicionar = new Button();
            btnEditar = new Button();
            lblTituloLista = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvPassagens).BeginInit();
            SuspendLayout();
            // 
            // dgvPassagens
            // 
            dgvPassagens.AllowUserToAddRows = false;
            dgvPassagens.AllowUserToDeleteRows = false;
            dgvPassagens.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPassagens.Location = new Point(12, 60);
            dgvPassagens.MultiSelect = false;
            dgvPassagens.Name = "dgvPassagens";
            dgvPassagens.ReadOnly = true;
            dgvPassagens.RowHeadersWidth = 51;
            dgvPassagens.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPassagens.Size = new Size(776, 331);
            dgvPassagens.TabIndex = 0;
            // 
            // btnAdicionar
            // 
            btnAdicionar.Location = new Point(568, 403);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(107, 35);
            btnAdicionar.TabIndex = 1;
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.UseVisualStyleBackColor = true;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(681, 403);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(107, 35);
            btnEditar.TabIndex = 2;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // lblTituloLista
            // 
            lblTituloLista.AutoSize = true;
            lblTituloLista.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTituloLista.Location = new Point(12, 17);
            lblTituloLista.Name = "lblTituloLista";
            lblTituloLista.Size = new Size(256, 31);
            lblTituloLista.TabIndex = 3;
            lblTituloLista.Text = "Listagem de Passagens";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblTituloLista);
            Controls.Add(btnEditar);
            Controls.Add(btnAdicionar);
            Controls.Add(dgvPassagens);
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Listagem de Passagens";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPassagens).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
        #endregion
    }
}