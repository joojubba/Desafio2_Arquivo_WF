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
            this.SuspendLayout();
            // 
            // labelPlacaVeiculo
            // 
            this.labelPlacaVeiculo.AutoSize = true;
            this.labelPlacaVeiculo.Location = new System.Drawing.Point(24, 52);
            this.labelPlacaVeiculo.Name = "labelPlacaVeiculo";
            this.labelPlacaVeiculo.Size = new System.Drawing.Size(93, 15);
            this.labelPlacaVeiculo.TabIndex = 0;
            this.labelPlacaVeiculo.Text = "Placa do Veículo";
            // 
            // labelData
            // 
            this.labelData.AutoSize = true;
            this.labelData.Location = new System.Drawing.Point(39, 111);
            this.labelData.Name = "labelData";
            this.labelData.Size = new System.Drawing.Size(31, 15);
            this.labelData.TabIndex = 1;
            this.labelData.Text = "Data";
            // 
            // labelHora
            // 
            this.labelHora.AutoSize = true;
            this.labelHora.Location = new System.Drawing.Point(39, 140);
            this.labelHora.Name = "labelHora";
            this.labelHora.Size = new System.Drawing.Size(33, 15);
            this.labelHora.TabIndex = 2;
            this.labelHora.Text = "Hora";
            // 
            // textBoxPlacaVeiculo
            // 
            this.textBoxPlacaVeiculo.Location = new System.Drawing.Point(137, 49);
            this.textBoxPlacaVeiculo.Name = "textBoxPlacaVeiculo";
            this.textBoxPlacaVeiculo.Size = new System.Drawing.Size(187, 23);
            this.textBoxPlacaVeiculo.TabIndex = 3;
            this.textBoxPlacaVeiculo.TextChanged += new System.EventHandler(this.textBoxPlacaVeiculo_TextChanged);
            // 
            // buttonEntrada
            // 
            this.buttonEntrada.Location = new System.Drawing.Point(24, 196);
            this.buttonEntrada.Name = "buttonEntrada";
            this.buttonEntrada.Size = new System.Drawing.Size(86, 27);
            this.buttonEntrada.TabIndex = 4;
            this.buttonEntrada.Text = "Entrada";
            this.buttonEntrada.UseVisualStyleBackColor = true;
            this.buttonEntrada.Click += new System.EventHandler(this.buttonEntrada_Click);
            // 
            // buttonSaida
            // 
            this.buttonSaida.Location = new System.Drawing.Point(137, 200);
            this.buttonSaida.Name = "buttonSaida";
            this.buttonSaida.Size = new System.Drawing.Size(97, 23);
            this.buttonSaida.TabIndex = 5;
            this.buttonSaida.Text = "Saida";
            this.buttonSaida.UseVisualStyleBackColor = true;
            this.buttonSaida.Click += new System.EventHandler(this.buttonSaida_Click);
            // 
            // dateTimePickerData
            // 
            this.dateTimePickerData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerData.Location = new System.Drawing.Point(124, 105);
            this.dateTimePickerData.Name = "dateTimePickerData";
            this.dateTimePickerData.Size = new System.Drawing.Size(324, 23);
            this.dateTimePickerData.TabIndex = 9;
            this.dateTimePickerData.ValueChanged += new System.EventHandler(this.dateTimePickerData_ValueChanged);
            // 
            // textBoxHora
            // 
            this.textBoxHora.Location = new System.Drawing.Point(124, 137);
            this.textBoxHora.Name = "textBoxHora";
            this.textBoxHora.Size = new System.Drawing.Size(187, 23);
            this.textBoxHora.TabIndex = 10;
            this.textBoxHora.TextChanged += new System.EventHandler(this.textBoxHora_TextChanged);
            // 
            // listBoxListaVeiculosEntrada
            // 
            this.listBoxListaVeiculosEntrada.FormattingEnabled = true;
            this.listBoxListaVeiculosEntrada.ItemHeight = 15;
            this.listBoxListaVeiculosEntrada.Location = new System.Drawing.Point(477, 337);
            this.listBoxListaVeiculosEntrada.Name = "listBoxListaVeiculosEntrada";
            this.listBoxListaVeiculosEntrada.Size = new System.Drawing.Size(702, 154);
            this.listBoxListaVeiculosEntrada.TabIndex = 11;
            // 
            // listBoxListaVeiculosSaida
            // 
            this.listBoxListaVeiculosSaida.FormattingEnabled = true;
            this.listBoxListaVeiculosSaida.ItemHeight = 15;
            this.listBoxListaVeiculosSaida.Location = new System.Drawing.Point(446, 545);
            this.listBoxListaVeiculosSaida.Name = "listBoxListaVeiculosSaida";
            this.listBoxListaVeiculosSaida.Size = new System.Drawing.Size(743, 94);
            this.listBoxListaVeiculosSaida.TabIndex = 12;
            // 
            // FormDesafio02
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1222, 719);
            this.Controls.Add(this.listBoxListaVeiculosSaida);
            this.Controls.Add(this.listBoxListaVeiculosEntrada);
            this.Controls.Add(this.textBoxHora);
            this.Controls.Add(this.dateTimePickerData);
            this.Controls.Add(this.buttonSaida);
            this.Controls.Add(this.buttonEntrada);
            this.Controls.Add(this.textBoxPlacaVeiculo);
            this.Controls.Add(this.labelHora);
            this.Controls.Add(this.labelData);
            this.Controls.Add(this.labelPlacaVeiculo);
            this.Name = "FormDesafio02";
            this.Text = "Estacionamento";
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}