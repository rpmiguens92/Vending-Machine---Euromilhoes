namespace vending_machine
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
            btnCafe = new Button();
            btnCapuccino = new Button();
            btnCha = new Button();
            btnChoco = new Button();
            btn2 = new Button();
            btn1 = new Button();
            btn050 = new Button();
            btn020 = new Button();
            btn010 = new Button();
            btn005 = new Button();
            msgUser = new TextBox();
            btnChoice = new Button();
            lblCoins = new Label();
            label1 = new Label();
            txtInsertedAmount = new TextBox();
            btnCancel = new Button();
            lblAux = new Label();
            btnstart = new Button();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            lblEntryDrink = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnCafe
            // 
            btnCafe.Enabled = false;
            btnCafe.Location = new Point(853, 110);
            btnCafe.Name = "btnCafe";
            btnCafe.Size = new Size(134, 45);
            btnCafe.TabIndex = 0;
            btnCafe.Text = "Café 0,25€";
            btnCafe.UseVisualStyleBackColor = true;
            btnCafe.Visible = false;
            btnCafe.Click += btnCafe_Click;
            // 
            // btnCapuccino
            // 
            btnCapuccino.Enabled = false;
            btnCapuccino.Location = new Point(853, 167);
            btnCapuccino.Name = "btnCapuccino";
            btnCapuccino.Size = new Size(134, 45);
            btnCapuccino.TabIndex = 1;
            btnCapuccino.Text = "Cappuccino 0,30€";
            btnCapuccino.UseVisualStyleBackColor = true;
            btnCapuccino.Visible = false;
            btnCapuccino.Click += btnCapuccino_Click;
            // 
            // btnCha
            // 
            btnCha.Enabled = false;
            btnCha.Location = new Point(1001, 167);
            btnCha.Name = "btnCha";
            btnCha.Size = new Size(134, 45);
            btnCha.TabIndex = 2;
            btnCha.Text = "Chá 0,20€";
            btnCha.UseVisualStyleBackColor = true;
            btnCha.Visible = false;
            btnCha.Click += btnCha_Click;
            // 
            // btnChoco
            // 
            btnChoco.Enabled = false;
            btnChoco.Location = new Point(1001, 110);
            btnChoco.Name = "btnChoco";
            btnChoco.Size = new Size(134, 45);
            btnChoco.TabIndex = 3;
            btnChoco.Text = "Chocolate 0,35€";
            btnChoco.UseVisualStyleBackColor = true;
            btnChoco.Visible = false;
            btnChoco.Click += btnChoco_Click;
            // 
            // btn2
            // 
            btn2.BackColor = Color.FromArgb(253, 183, 36);
            btn2.Enabled = false;
            btn2.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn2.ForeColor = Color.Black;
            btn2.Location = new Point(78, 605);
            btn2.Name = "btn2";
            btn2.Size = new Size(69, 42);
            btn2.TabIndex = 4;
            btn2.Text = "2€";
            btn2.UseVisualStyleBackColor = false;
            btn2.Visible = false;
            btn2.Click += btn2_Click;
            // 
            // btn1
            // 
            btn1.BackColor = Color.FromArgb(253, 183, 36);
            btn1.Enabled = false;
            btn1.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn1.Location = new Point(198, 605);
            btn1.Name = "btn1";
            btn1.Size = new Size(69, 42);
            btn1.TabIndex = 5;
            btn1.Text = "1€";
            btn1.UseVisualStyleBackColor = false;
            btn1.Visible = false;
            btn1.Click += btn1_Click;
            // 
            // btn050
            // 
            btn050.BackColor = Color.FromArgb(253, 183, 36);
            btn050.Enabled = false;
            btn050.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn050.Location = new Point(318, 605);
            btn050.Name = "btn050";
            btn050.Size = new Size(69, 42);
            btn050.TabIndex = 6;
            btn050.Text = "0,50€";
            btn050.UseVisualStyleBackColor = false;
            btn050.Visible = false;
            btn050.Click += btn050_Click;
            // 
            // btn020
            // 
            btn020.BackColor = Color.FromArgb(253, 183, 36);
            btn020.Enabled = false;
            btn020.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn020.Location = new Point(438, 605);
            btn020.Name = "btn020";
            btn020.Size = new Size(69, 42);
            btn020.TabIndex = 7;
            btn020.Text = "0,20€";
            btn020.UseVisualStyleBackColor = false;
            btn020.Visible = false;
            btn020.Click += btn020_Click;
            // 
            // btn010
            // 
            btn010.BackColor = Color.FromArgb(253, 183, 36);
            btn010.Enabled = false;
            btn010.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn010.Location = new Point(558, 605);
            btn010.Name = "btn010";
            btn010.Size = new Size(69, 42);
            btn010.TabIndex = 8;
            btn010.Text = "0,10€";
            btn010.UseVisualStyleBackColor = false;
            btn010.Visible = false;
            btn010.Click += btn010_Click;
            // 
            // btn005
            // 
            btn005.BackColor = Color.FromArgb(253, 183, 36);
            btn005.Enabled = false;
            btn005.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn005.Location = new Point(678, 605);
            btn005.Name = "btn005";
            btn005.Size = new Size(69, 42);
            btn005.TabIndex = 9;
            btn005.Text = "0,05€";
            btn005.UseVisualStyleBackColor = false;
            btn005.Visible = false;
            btn005.Click += btn005_Click;
            // 
            // msgUser
            // 
            msgUser.Enabled = false;
            msgUser.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            msgUser.Location = new Point(856, 247);
            msgUser.Name = "msgUser";
            msgUser.Size = new Size(274, 27);
            msgUser.TabIndex = 10;
            msgUser.Text = "Escolha o produto e insira as moedas!";
            msgUser.TextAlign = HorizontalAlignment.Center;
            msgUser.Visible = false;
            // 
            // btnChoice
            // 
            btnChoice.Enabled = false;
            btnChoice.FlatStyle = FlatStyle.Flat;
            btnChoice.Location = new Point(905, 533);
            btnChoice.Name = "btnChoice";
            btnChoice.Size = new Size(175, 45);
            btnChoice.TabIndex = 12;
            btnChoice.Text = "Confirmar Pedido";
            btnChoice.UseVisualStyleBackColor = true;
            btnChoice.Visible = false;
            btnChoice.Click += btnChoice_Click;
            // 
            // lblCoins
            // 
            lblCoins.AutoSize = true;
            lblCoins.BackColor = Color.FromArgb(253, 183, 36);
            lblCoins.Enabled = false;
            lblCoins.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCoins.Location = new Point(31, 561);
            lblCoins.Name = "lblCoins";
            lblCoins.Size = new Size(220, 23);
            lblCoins.TabIndex = 13;
            lblCoins.Text = "Introduza as moedas:";
            lblCoins.Visible = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(253, 183, 36);
            label1.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(287, 101);
            label1.Name = "label1";
            label1.Size = new Size(175, 41);
            label1.TabIndex = 14;
            label1.Text = "Bem-vindo!";
            // 
            // txtInsertedAmount
            // 
            txtInsertedAmount.Enabled = false;
            txtInsertedAmount.Location = new Point(901, 329);
            txtInsertedAmount.Name = "txtInsertedAmount";
            txtInsertedAmount.ReadOnly = true;
            txtInsertedAmount.Size = new Size(179, 27);
            txtInsertedAmount.TabIndex = 16;
            txtInsertedAmount.Text = "Valor Inserido:";
            txtInsertedAmount.TextAlign = HorizontalAlignment.Center;
            txtInsertedAmount.Visible = false;
            // 
            // btnCancel
            // 
            btnCancel.Enabled = false;
            btnCancel.FlatStyle = FlatStyle.Popup;
            btnCancel.Location = new Point(948, 596);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(112, 45);
            btnCancel.TabIndex = 17;
            btnCancel.Text = "Cancelar";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Visible = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // lblAux
            // 
            lblAux.AutoSize = true;
            lblAux.Enabled = false;
            lblAux.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAux.Location = new Point(905, 378);
            lblAux.Name = "lblAux";
            lblAux.Size = new Size(45, 20);
            lblAux.TabIndex = 18;
            lblAux.Text = "troco";
            // 
            // btnstart
            // 
            btnstart.Location = new Point(328, 323);
            btnstart.Name = "btnstart";
            btnstart.Size = new Size(192, 28);
            btnstart.TabIndex = 19;
            btnstart.Text = "Clique para iniciar.";
            btnstart.UseVisualStyleBackColor = true;
            btnstart.Click += btnstart_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(29, 141, 163);
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = Properties.Resources.cafeeeeee1;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1139, 673);
            pictureBox1.TabIndex = 20;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(253, 183, 36);
            label2.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(41, 233);
            label2.Name = "label2";
            label2.Size = new Size(349, 41);
            label2.TabIndex = 21;
            label2.Text = "Desfrute da sua bebida...";
            // 
            // lblEntryDrink
            // 
            lblEntryDrink.AutoSize = true;
            lblEntryDrink.BackColor = Color.FromArgb(9, 141, 163);
            lblEntryDrink.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEntryDrink.Location = new Point(859, 53);
            lblEntryDrink.Name = "lblEntryDrink";
            lblEntryDrink.Size = new Size(201, 23);
            lblEntryDrink.TabIndex = 22;
            lblEntryDrink.Text = "Selecione a bebida:";
            lblEntryDrink.Visible = false;
            // 
            // timer1
            // 
            timer1.Interval = 5000;
            timer1.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(29, 141, 163);
            ClientSize = new Size(1139, 673);
            Controls.Add(lblEntryDrink);
            Controls.Add(label2);
            Controls.Add(btnstart);
            Controls.Add(lblAux);
            Controls.Add(btnCancel);
            Controls.Add(txtInsertedAmount);
            Controls.Add(label1);
            Controls.Add(lblCoins);
            Controls.Add(btnChoice);
            Controls.Add(msgUser);
            Controls.Add(btn005);
            Controls.Add(btn010);
            Controls.Add(btn020);
            Controls.Add(btn050);
            Controls.Add(btn1);
            Controls.Add(btn2);
            Controls.Add(btnChoco);
            Controls.Add(btnCha);
            Controls.Add(btnCapuccino);
            Controls.Add(btnCafe);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "Form1";
            Text = "Vending Machine";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCafe;
        private Button btnCapuccino;
        private Button btnCha;
        private Button btnChoco;
        private Button btn2;
        private Button btn1;
        private Button btn050;
        private Button btn020;
        private Button btn010;
        private Button btn005;
        private TextBox msgUser;
        private Button btnChoice;
        private Label lblCoins;
        private Label label1;
        private TextBox txtInsertedAmount;
        private Button btnCancel;
        private Label lblAux;
        private Button btnstart;
        private PictureBox pictureBox1;
        private Label label2;
        private Label lblEntryDrink;
        private System.Windows.Forms.Timer timer1;
    }
}
