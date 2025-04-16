namespace MoveWay.atividade
{
    partial class Inicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio));
            lblSetor = new Label();
            dgvSetores = new DataGridView();
            txtSetor = new TextBox();
            pictureBox1 = new PictureBox();
            lblid = new Label();
            txtId = new TextBox();
            lblNome = new Label();
            txtNome = new TextBox();
            btGravar = new Button();
            btEditar = new Button();
            btExcluir = new Button();
            btListar = new Button();
            btListarTodos = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvSetores).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblSetor
            // 
            lblSetor.AutoSize = true;
            lblSetor.Font = new Font("Calibri", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSetor.Location = new Point(64, 71);
            lblSetor.Margin = new Padding(2, 0, 2, 0);
            lblSetor.Name = "lblSetor";
            lblSetor.Size = new Size(207, 24);
            lblSetor.TabIndex = 0;
            lblSetor.Text = "Digite o nome do setor:";
            // 
            // dgvSetores
            // 
            dgvSetores.BackgroundColor = SystemColors.ActiveBorder;
            dgvSetores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSetores.Location = new Point(64, 129);
            dgvSetores.Margin = new Padding(2);
            dgvSetores.Name = "dgvSetores";
            dgvSetores.RowHeadersWidth = 62;
            dgvSetores.Size = new Size(725, 149);
            dgvSetores.TabIndex = 1;
            // 
            // txtSetor
            // 
            txtSetor.BackColor = SystemColors.ControlLight;
            txtSetor.Location = new Point(275, 68);
            txtSetor.Margin = new Padding(2);
            txtSetor.Name = "txtSetor";
            txtSetor.Size = new Size(514, 32);
            txtSetor.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(845, 180);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(283, 251);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // lblid
            // 
            lblid.AutoSize = true;
            lblid.Location = new Point(64, 355);
            lblid.Margin = new Padding(2, 0, 2, 0);
            lblid.Name = "lblid";
            lblid.Size = new Size(32, 24);
            lblid.TabIndex = 4;
            lblid.Text = "ID:";
            lblid.Click += label1_Click;
            // 
            // txtId
            // 
            txtId.BackColor = SystemColors.ControlLight;
            txtId.Location = new Point(101, 352);
            txtId.Name = "txtId";
            txtId.Size = new Size(150, 32);
            txtId.TabIndex = 5;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(343, 355);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(65, 24);
            lblNome.TabIndex = 6;
            lblNome.Text = "Nome:";
            // 
            // txtNome
            // 
            txtNome.BackColor = SystemColors.ControlLight;
            txtNome.Location = new Point(414, 352);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(375, 32);
            txtNome.TabIndex = 7;
            // 
            // btGravar
            // 
            btGravar.BackColor = Color.Gold;
            btGravar.ForeColor = SystemColors.ControlText;
            btGravar.Location = new Point(64, 459);
            btGravar.Name = "btGravar";
            btGravar.Size = new Size(112, 34);
            btGravar.TabIndex = 8;
            btGravar.Text = "Gravar";
            btGravar.UseVisualStyleBackColor = false;
            btGravar.Click += btGravar_Click;
            // 
            // btEditar
            // 
            btEditar.BackColor = Color.Gold;
            btEditar.Location = new Point(368, 459);
            btEditar.Name = "btEditar";
            btEditar.Size = new Size(112, 34);
            btEditar.TabIndex = 9;
            btEditar.Text = "Editar";
            btEditar.UseVisualStyleBackColor = false;
            // 
            // btExcluir
            // 
            btExcluir.BackColor = Color.Gold;
            btExcluir.Font = new Font("Calibri", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btExcluir.Location = new Point(677, 459);
            btExcluir.Name = "btExcluir";
            btExcluir.Size = new Size(112, 34);
            btExcluir.TabIndex = 10;
            btExcluir.Text = "Excluir";
            btExcluir.UseVisualStyleBackColor = false;
            // 
            // btListar
            // 
            btListar.BackColor = Color.DarkGray;
            btListar.Font = new Font("Calibri", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btListar.ForeColor = SystemColors.ControlText;
            btListar.Location = new Point(822, 68);
            btListar.Name = "btListar";
            btListar.Size = new Size(112, 34);
            btListar.TabIndex = 11;
            btListar.Text = "Listar";
            btListar.UseVisualStyleBackColor = false;
            // 
            // btListarTodos
            // 
            btListarTodos.BackColor = Color.DarkGray;
            btListarTodos.Location = new Point(960, 69);
            btListarTodos.Name = "btListarTodos";
            btListarTodos.Size = new Size(127, 34);
            btListarTodos.TabIndex = 12;
            btListarTodos.Text = "Listar todos";
            btListarTodos.UseVisualStyleBackColor = false;
            // 
            // Inicio
            // 
            AutoScaleDimensions = new SizeF(10F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1154, 578);
            Controls.Add(btListarTodos);
            Controls.Add(btListar);
            Controls.Add(btExcluir);
            Controls.Add(btEditar);
            Controls.Add(btGravar);
            Controls.Add(txtNome);
            Controls.Add(lblNome);
            Controls.Add(txtId);
            Controls.Add(lblid);
            Controls.Add(pictureBox1);
            Controls.Add(txtSetor);
            Controls.Add(dgvSetores);
            Controls.Add(lblSetor);
            Font = new Font("Calibri", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Inicio";
            Text = "MoveWay";
            Load += Inicio_Load;
            ((System.ComponentModel.ISupportInitialize)dgvSetores).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblSetor;
        private DataGridView dgvSetores;
        private TextBox txtSetor;
        private PictureBox pictureBox1;
        private Label lblid;
        private TextBox txtId;
        private Label lblNome;
        private TextBox txtNome;
        private Button btGravar;
        private Button btEditar;
        private Button btExcluir;
        private Button btListar;
        private Button btListarTodos;
    }
}
