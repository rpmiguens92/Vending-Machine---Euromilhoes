namespace machine
{
    partial class btn1
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
            btnCha = new Button();
            btnChoco = new Button();
            btnCapuccino = new Button();
            btn2 = new Button();
            button1 = new Button();
            btn050 = new Button();
            btn020 = new Button();
            btn010 = new Button();
            btn005 = new Button();
            msgUser = new TextBox();
            btnchoice = new Button();
            lblWelcome = new Label();
            timerMsgBox = new System.Windows.Forms.Timer(components);
            txtInsertedAmount = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtchange = new TextBox();
        
            // 
            // btnCafe
            // 
            btnCafe.Location = new Point(108, 85);
            btnCafe.Name = "btnCafe";
            btnCafe.Size = new Size(129, 45);
            btnCafe.TabIndex = 0;
            btnCafe.Text = "Café";
            btnCafe.UseVisualStyleBackColor = true;
            btnCafe.Click += btnCafe_Click;
            // 
            // btnCha
            // 
            btnCha.Location = new Point(108, 168);
            btnCha.Name = "btnCha";
            btnCha.Size = new Size(129, 45);
            btnCha.TabIndex = 1;
            btnCha.Text = "Chá";
            btnCha.UseVisualStyleBackColor = true;
            btnCha.Click += btnCha_Click;
            // 
            // btnChoco
            // 
            btnChoco.Location = new Point(108, 250);
            btnChoco.Name = "btnChoco";
            btnChoco.Size = new Size(129, 45);
            btnChoco.TabIndex = 2;
            btnChoco.Text = "Chocolate";
            btnChoco.UseVisualStyleBackColor = true;
            btnChoco.Click += btnChoco_Click;
            // 
            // btnCapuccino
            // 
            btnCapuccino.Location = new Point(108, 331);
            btnCapuccino.Name = "btnCapuccino";
            btnCapuccino.Size = new Size(129, 45);
            btnCapuccino.TabIndex = 3;
            btnCapuccino.Text = "Capuccino";
            btnCapuccino.UseVisualStyleBackColor = true;
            btnCapuccino.Click += btnCapuccino_Click;
            // 
            // btn2
            // 
            btn2.Location = new Point(108, 428);
            btn2.Name = "btn2";
            btn2.Size = new Size(72, 45);
            btn2.TabIndex = 4;
            btn2.Text = "2€";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += btn2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(195, 428);
            button1.Name = "button1";
            button1.Size = new Size(72, 45);
            button1.TabIndex = 5;
            button1.Text = "1€";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btn050
            // 
            btn050.Location = new Point(281, 428);
            btn050.Name = "btn050";
            btn050.Size = new Size(72, 45);
            btn050.TabIndex = 6;
            btn050.Text = "0,50€";
            btn050.UseVisualStyleBackColor = true;
            btn050.Click += btn050_Click;
            // 
            // btn020
            // 
            btn020.Location = new Point(368, 428);
            btn020.Name = "btn020";
            btn020.Size = new Size(72, 45);
            btn020.TabIndex = 7;
            btn020.Text = "0.20€";
            btn020.UseVisualStyleBackColor = true;
            btn020.Click += btn020_Click;
            // 
            // btn010
            // 
            btn010.Location = new Point(455, 428);
            btn010.Name = "btn010";
            btn010.Size = new Size(72, 45);
            btn010.TabIndex = 8;
            btn010.Text = "0.10€";
            btn010.UseVisualStyleBackColor = true;
            btn010.Click += btn010_Click;
            // 
            // btn005
            // 
            btn005.Location = new Point(543, 428);
            btn005.Name = "btn005";
            btn005.Size = new Size(75, 45);
            btn005.TabIndex = 9;
            btn005.Text = "0.05€";
            btn005.UseVisualStyleBackColor = true;
            btn005.Click += btn005_Click;
            // 
            // msgUser
            // 
            msgUser.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            msgUser.Location = new Point(256, 130);
            msgUser.Name = "msgUser";
            msgUser.Size = new Size(362, 31);
            msgUser.TabIndex = 10;
            msgUser.Text = "Escolha o artigo e efectue pagamento!";
            msgUser.TextAlign = HorizontalAlignment.Center;
            // 
            // btnchoice
            // 
            btnchoice.Location = new Point(464, 353);
            btnchoice.Name = "btnchoice";
            btnchoice.Size = new Size(154, 45);
            btnchoice.TabIndex = 11;
            btnchoice.Text = "Confirmar Pedido";
            btnchoice.UseVisualStyleBackColor = true;
            btnchoice.Click += btnchoice_Click;
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblWelcome.Location = new Point(339, 41);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(160, 38);
            lblWelcome.TabIndex = 12;
            lblWelcome.Text = "Bem vindo!";
            lblWelcome.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // timerMsgBox
            // 
            timerMsgBox.Interval = 1000;
            timerMsgBox.Tick += timerMsgBox_Tick;
            // 
            // txtInsertedAmount
            // 
            txtInsertedAmount.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtInsertedAmount.Location = new Point(390, 186);
            txtInsertedAmount.Name = "txtInsertedAmount";
            txtInsertedAmount.Size = new Size(228, 31);
            txtInsertedAmount.TabIndex = 14;
            txtInsertedAmount.TextChanged += txtInsertedAmount_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(113, 46);
            label1.Name = "label1";
            label1.Size = new Size(100, 28);
            label1.TabIndex = 13;
            label1.Text = "Produtos:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(108, 397);
            label2.Name = "label2";
            label2.Size = new Size(155, 28);
            label2.TabIndex = 15;
            label2.Text = "Moedas Aceites";
            // 
            // txtchange
            // 
            txtchange.Location = new Point(464, 240);
            txtchange.Name = "txtchange";
            txtchange.Size = new Size(146, 27);
            txtchange.TabIndex = 16;
            txtchange.Text = "Troco:";
            // 
            // btn1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(713, 508);
            Controls.Add(txtchange);
            Controls.Add(label2);
            Controls.Add(txtInsertedAmount);
            Controls.Add(label1);
            Controls.Add(lblWelcome);
            Controls.Add(btnchoice);
            Controls.Add(msgUser);
            Controls.Add(btn005);
            Controls.Add(btn010);
            Controls.Add(btn020);
            Controls.Add(btn050);
            Controls.Add(button1);
            Controls.Add(btn2);
            Controls.Add(btnCapuccino);
            Controls.Add(btnChoco);
            Controls.Add(btnCha);
            Controls.Add(btnCafe);
            Name = "btn1";
            Text = "Vending Machine";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCafe;
        private Button btnCha;
        private Button btnChoco;
        private Button btnCapuccino;
        private Button btn2;
        private Button button1;
        private Button btn050;
        private Button btn020;
        private Button btn010;
        private Button btn005;
        private TextBox msgUser;
        private Button btnchoice;
        private Label lblWelcome;
        private System.Windows.Forms.Timer timerMsgBox;
        private TextBox txtInsertedAmount;
        private Label label1;
        private Label label2;
        private TextBox txtchange;
    }
}
