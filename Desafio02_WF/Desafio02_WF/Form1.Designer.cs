namespace Desafio02_WF
{
    partial class FormDesafio02
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
            this.components = new System.ComponentModel.Container();
            this.labelPlacaVeiculo = new System.Windows.Forms.Label();
            this.labelData = new System.Windows.Forms.Label();
            this.labelHora = new System.Windows.Forms.Label();
            this.textBoxPlacaVeiculo = new System.Windows.Forms.TextBox();
            this.buttonEntrada = new System.Windows.Forms.Button();
            this.buttonSaida = new System.Windows.Forms.Button();
            this.dateTimePickerData = new System.Windows.Forms.DateTimePicker();
            this.textBoxHora = new System.Windows.Forms.TextBox();
            this.listBoxListaVeiculosEntrada = new System.Windows.Forms.ListBox();
            this.listBoxListaVeiculosSaida = new System.Windows.Forms.ListBox();
            this.labelDataAtual = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.labelCadastro = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.labelEstac = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelPlacaVeiculo
            // 
            this.labelPlacaVeiculo.AutoSize = true;
            this.labelPlacaVeiculo.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelPlacaVeiculo.Location = new System.Drawing.Point(60, 33);
            this.labelPlacaVeiculo.Name = "labelPlacaVeiculo";
            this.labelPlacaVeiculo.Size = new System.Drawing.Size(168, 18);
            this.labelPlacaVeiculo.TabIndex = 0;
            this.labelPlacaVeiculo.Text = "Placa do Veículo";
            // 
            // labelData
            // 
            this.labelData.AutoSize = true;
            this.labelData.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelData.Location = new System.Drawing.Point(60, 121);
            this.labelData.Name = "labelData";
            this.labelData.Size = new System.Drawing.Size(48, 18);
            this.labelData.TabIndex = 1;
            this.labelData.Text = "Data";
            // 
            // labelHora
            // 
            this.labelHora.AutoSize = true;
            this.labelHora.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelHora.Location = new System.Drawing.Point(345, 121);
            this.labelHora.Name = "labelHora";
            this.labelHora.Size = new System.Drawing.Size(48, 18);
            this.labelHora.TabIndex = 2;
            this.labelHora.Text = "Hora";
            // 
            // textBoxPlacaVeiculo
            // 
            this.textBoxPlacaVeiculo.Location = new System.Drawing.Point(60, 54);
            this.textBoxPlacaVeiculo.Multiline = true;
            this.textBoxPlacaVeiculo.Name = "textBoxPlacaVeiculo";
            this.textBoxPlacaVeiculo.Size = new System.Drawing.Size(427, 43);
            this.textBoxPlacaVeiculo.TabIndex = 3;
            this.textBoxPlacaVeiculo.TextChanged += new System.EventHandler(this.textBoxPlacaVeiculo_TextChanged);
            // 
            // buttonEntrada
            // 
            this.buttonEntrada.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buttonEntrada.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEntrada.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonEntrada.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(61)))), ((int)(((byte)(86)))));
            this.buttonEntrada.Location = new System.Drawing.Point(60, 219);
            this.buttonEntrada.Name = "buttonEntrada";
            this.buttonEntrada.Size = new System.Drawing.Size(200, 43);
            this.buttonEntrada.TabIndex = 4;
            this.buttonEntrada.Text = "Entrada";
            this.buttonEntrada.UseVisualStyleBackColor = false;
            this.buttonEntrada.Click += new System.EventHandler(this.buttonEntrada_Click);
            // 
            // buttonSaida
            // 
            this.buttonSaida.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buttonSaida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSaida.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonSaida.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(61)))), ((int)(((byte)(86)))));
            this.buttonSaida.Location = new System.Drawing.Point(287, 219);
            this.buttonSaida.Name = "buttonSaida";
            this.buttonSaida.Size = new System.Drawing.Size(200, 43);
            this.buttonSaida.TabIndex = 5;
            this.buttonSaida.Text = "Saída";
            this.buttonSaida.UseVisualStyleBackColor = false;
            this.buttonSaida.Click += new System.EventHandler(this.buttonSaida_Click);
            // 
            // dateTimePickerData
            // 
            this.dateTimePickerData.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTimePickerData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerData.Location = new System.Drawing.Point(60, 144);
            this.dateTimePickerData.Name = "dateTimePickerData";
            this.dateTimePickerData.Size = new System.Drawing.Size(168, 26);
            this.dateTimePickerData.TabIndex = 9;
            // 
            // textBoxHora
            // 
            this.textBoxHora.Location = new System.Drawing.Point(345, 144);
            this.textBoxHora.Multiline = true;
            this.textBoxHora.Name = "textBoxHora";
            this.textBoxHora.Size = new System.Drawing.Size(142, 26);
            this.textBoxHora.TabIndex = 10;
            this.textBoxHora.TextChanged += new System.EventHandler(this.textBoxHora_TextChanged);
            // 
            // listBoxListaVeiculosEntrada
            // 
            this.listBoxListaVeiculosEntrada.BackColor = System.Drawing.SystemColors.Menu;
            this.listBoxListaVeiculosEntrada.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listBoxListaVeiculosEntrada.FormattingEnabled = true;
            this.listBoxListaVeiculosEntrada.HorizontalScrollbar = true;
            this.listBoxListaVeiculosEntrada.ItemHeight = 15;
            this.listBoxListaVeiculosEntrada.Location = new System.Drawing.Point(0, 40);
            this.listBoxListaVeiculosEntrada.Name = "listBoxListaVeiculosEntrada";
            this.listBoxListaVeiculosEntrada.Size = new System.Drawing.Size(657, 304);
            this.listBoxListaVeiculosEntrada.TabIndex = 11;
            // 
            // listBoxListaVeiculosSaida
            // 
            this.listBoxListaVeiculosSaida.BackColor = System.Drawing.SystemColors.Menu;
            this.listBoxListaVeiculosSaida.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listBoxListaVeiculosSaida.ForeColor = System.Drawing.SystemColors.WindowText;
            this.listBoxListaVeiculosSaida.FormattingEnabled = true;
            this.listBoxListaVeiculosSaida.HorizontalScrollbar = true;
            this.listBoxListaVeiculosSaida.ItemHeight = 15;
            this.listBoxListaVeiculosSaida.Location = new System.Drawing.Point(0, 377);
            this.listBoxListaVeiculosSaida.Name = "listBoxListaVeiculosSaida";
            this.listBoxListaVeiculosSaida.Size = new System.Drawing.Size(657, 289);
            this.listBoxListaVeiculosSaida.TabIndex = 12;
            // 
            // labelDataAtual
            // 
            this.labelDataAtual.AutoSize = true;
            this.labelDataAtual.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelDataAtual.Location = new System.Drawing.Point(38, 7);
            this.labelDataAtual.Name = "labelDataAtual";
            this.labelDataAtual.Size = new System.Drawing.Size(89, 30);
            this.labelDataAtual.TabIndex = 13;
            this.labelDataAtual.Text = "13:36:52";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.panel8);
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1319, 790);
            this.panel1.TabIndex = 14;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.Black;
            this.panel8.Controls.Add(this.label1);
            this.panel8.Location = new System.Drawing.Point(648, 86);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(657, 45);
            this.panel8.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(218, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 18);
            this.label1.TabIndex = 15;
            this.label1.Text = "Veículos na Garagem";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Black;
            this.panel7.Controls.Add(this.labelCadastro);
            this.panel7.Location = new System.Drawing.Point(13, 86);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(637, 45);
            this.panel7.TabIndex = 16;
            // 
            // labelCadastro
            // 
            this.labelCadastro.AutoSize = true;
            this.labelCadastro.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelCadastro.ForeColor = System.Drawing.Color.Gray;
            this.labelCadastro.Location = new System.Drawing.Point(206, 11);
            this.labelCadastro.Name = "labelCadastro";
            this.labelCadastro.Size = new System.Drawing.Size(178, 18);
            this.labelCadastro.TabIndex = 13;
            this.labelCadastro.Text = "Cadastrar Veículo";
            this.labelCadastro.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.panel9);
            this.panel3.Controls.Add(this.listBoxListaVeiculosEntrada);
            this.panel3.Controls.Add(this.listBoxListaVeiculosSaida);
            this.panel3.Location = new System.Drawing.Point(648, 86);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(657, 669);
            this.panel3.TabIndex = 18;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.Black;
            this.panel9.Controls.Add(this.label2);
            this.panel9.Location = new System.Drawing.Point(0, 335);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(657, 45);
            this.panel9.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(218, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 18);
            this.label2.TabIndex = 16;
            this.label2.Text = "Veículos com Saída";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Black;
            this.panel4.Controls.Add(this.panel2);
            this.panel4.Controls.Add(this.pictureBox4);
            this.panel4.Controls.Add(this.labelEstac);
            this.panel4.Controls.Add(this.pictureBox3);
            this.panel4.Controls.Add(this.pictureBox2);
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1319, 51);
            this.panel4.TabIndex = 14;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Controls.Add(this.labelDataAtual);
            this.panel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel2.Location = new System.Drawing.Point(998, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(168, 47);
            this.panel2.TabIndex = 0;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Desafio02_WF.Properties.Resources.user__2_;
            this.pictureBox4.Location = new System.Drawing.Point(1172, 0);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(74, 51);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox4.TabIndex = 16;
            this.pictureBox4.TabStop = false;
            // 
            // labelEstac
            // 
            this.labelEstac.AutoSize = true;
            this.labelEstac.BackColor = System.Drawing.Color.Black;
            this.labelEstac.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelEstac.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.labelEstac.Location = new System.Drawing.Point(111, 14);
            this.labelEstac.Name = "labelEstac";
            this.labelEstac.Size = new System.Drawing.Size(250, 27);
            this.labelEstac.TabIndex = 15;
            this.labelEstac.Text = "Estacionamento JR";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Black;
            this.pictureBox3.Image = global::Desafio02_WF.Properties.Resources.power_switch__1_;
            this.pictureBox3.Location = new System.Drawing.Point(1242, -2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(74, 52);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox3.TabIndex = 14;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Desafio02_WF.Properties.Resources.parking_sign__1_;
            this.pictureBox2.Location = new System.Drawing.Point(0, -1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(105, 51);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Gainsboro;
            this.panel6.Controls.Add(this.panel5);
            this.panel6.Location = new System.Drawing.Point(12, 86);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(641, 669);
            this.panel6.TabIndex = 17;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Controls.Add(this.labelPlacaVeiculo);
            this.panel5.Controls.Add(this.textBoxPlacaVeiculo);
            this.panel5.Controls.Add(this.labelData);
            this.panel5.Controls.Add(this.dateTimePickerData);
            this.panel5.Controls.Add(this.buttonSaida);
            this.panel5.Controls.Add(this.buttonEntrada);
            this.panel5.Controls.Add(this.textBoxHora);
            this.panel5.Controls.Add(this.labelHora);
            this.panel5.ForeColor = System.Drawing.Color.Gray;
            this.panel5.Location = new System.Drawing.Point(36, 179);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(546, 317);
            this.panel5.TabIndex = 15;
            // 
            // FormDesafio02
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(1317, 788);
            this.Controls.Add(this.panel1);
            this.MaximumSize = new System.Drawing.Size(1333, 827);
            this.MinimumSize = new System.Drawing.Size(1333, 827);
            this.Name = "FormDesafio02";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estacionamento";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormDesafio02_Load);
            this.panel1.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Label labelPlacaVeiculo;
        private Label labelData;
        private Label labelHora;
        private TextBox textBoxPlacaVeiculo;
        private Button buttonEntrada;
        private Button buttonSaida;
        private DateTimePicker dateTimePickerData;
        private TextBox textBoxHora;
        private ListBox listBoxListaVeiculosEntrada;
        private ListBox listBoxListaVeiculosSaida;
        private Label labelDataAtual;
        private System.Windows.Forms.Timer timer1;
        private Panel panel1;
        private Label labelCadastro;
        private Panel panel2;
        private Panel panel4;
        private PictureBox pictureBox2;
        private Panel panel5;
        private PictureBox pictureBox3;
        private Label label2;
        private Label label1;
        private Panel panel3;
        private PictureBox pictureBox4;
        private Label labelEstac;
        private Panel panel6;
        private Panel panel7;
        private Panel panel8;
        private Panel panel9;
    }
}