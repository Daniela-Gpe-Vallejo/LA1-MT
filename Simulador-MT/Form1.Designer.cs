namespace Simulador_MT
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
            txtEntrada = new TextBox();
            numInicio = new NumericUpDown();
            btnInicializar = new Button();
            txtAlfabeto = new TextBox();
            lblAlfabetoHint = new Label();
            gridCinta = new DataGridView();
            GrpCadenaDeEntrada = new GroupBox();
            lblCadenaEntrada = new Label();
            lblPosicionInicial = new Label();
            grpAlfabeto = new GroupBox();
            lblAlfabeto = new Label();
            lstOperaciones = new ListBox();
            btnAgregarOp = new Button();
            grpCinta = new GroupBox();
            btnQuitarOp = new Button();
            lstCompuesta = new ListBox();
            btnPaso = new Button();
            btnEjecutar = new Button();
            grpMaquinaCompuesta = new GroupBox();
            btnReset = new Button();
            numDelay = new NumericUpDown();
            radioButton1 = new RadioButton();
            grpMaquina = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)numInicio).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridCinta).BeginInit();
            GrpCadenaDeEntrada.SuspendLayout();
            grpAlfabeto.SuspendLayout();
            grpCinta.SuspendLayout();
            grpMaquinaCompuesta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numDelay).BeginInit();
            grpMaquina.SuspendLayout();
            SuspendLayout();
            // 
            // txtEntrada
            // 
            txtEntrada.Location = new Point(129, 22);
            txtEntrada.Name = "txtEntrada";
            txtEntrada.Size = new Size(92, 23);
            txtEntrada.TabIndex = 0;
            // 
            // numInicio
            // 
            numInicio.Location = new Point(163, 65);
            numInicio.Name = "numInicio";
            numInicio.Size = new Size(58, 23);
            numInicio.TabIndex = 1;
            // 
            // btnInicializar
            // 
            btnInicializar.Location = new Point(63, 88);
            btnInicializar.Name = "btnInicializar";
            btnInicializar.Size = new Size(104, 23);
            btnInicializar.TabIndex = 2;
            btnInicializar.Text = "Inicializar cinta";
            btnInicializar.UseVisualStyleBackColor = true;
            // 
            // txtAlfabeto
            // 
            txtAlfabeto.Location = new Point(74, 24);
            txtAlfabeto.Name = "txtAlfabeto";
            txtAlfabeto.Size = new Size(141, 23);
            txtAlfabeto.TabIndex = 3;
            txtAlfabeto.TextChanged += txtAlfabeto_TextChanged;
            // 
            // lblAlfabetoHint
            // 
            lblAlfabetoHint.AutoSize = true;
            lblAlfabetoHint.ForeColor = SystemColors.ControlDarkDark;
            lblAlfabetoHint.Location = new Point(6, 59);
            lblAlfabetoHint.Name = "lblAlfabetoHint";
            lblAlfabetoHint.Size = new Size(221, 15);
            lblAlfabetoHint.TabIndex = 4;
            lblAlfabetoHint.Text = "Separado por comas. Usa _ como blanco";
            // 
            // gridCinta
            // 
            gridCinta.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridCinta.Location = new Point(6, 24);
            gridCinta.Name = "gridCinta";
            gridCinta.RowTemplate.Height = 25;
            gridCinta.Size = new Size(482, 102);
            gridCinta.TabIndex = 5;
            // 
            // GrpCadenaDeEntrada
            // 
            GrpCadenaDeEntrada.Controls.Add(lblPosicionInicial);
            GrpCadenaDeEntrada.Controls.Add(lblCadenaEntrada);
            GrpCadenaDeEntrada.Controls.Add(numInicio);
            GrpCadenaDeEntrada.Controls.Add(txtEntrada);
            GrpCadenaDeEntrada.Location = new Point(21, 12);
            GrpCadenaDeEntrada.Name = "GrpCadenaDeEntrada";
            GrpCadenaDeEntrada.Size = new Size(240, 102);
            GrpCadenaDeEntrada.TabIndex = 6;
            GrpCadenaDeEntrada.TabStop = false;
            GrpCadenaDeEntrada.Text = "Cadena de entrada";
            // 
            // lblCadenaEntrada
            // 
            lblCadenaEntrada.AutoSize = true;
            lblCadenaEntrada.Location = new Point(6, 30);
            lblCadenaEntrada.Name = "lblCadenaEntrada";
            lblCadenaEntrada.Size = new Size(109, 15);
            lblCadenaEntrada.TabIndex = 2;
            lblCadenaEntrada.Text = "Cadena de entrada:";
            // 
            // lblPosicionInicial
            // 
            lblPosicionInicial.AutoSize = true;
            lblPosicionInicial.Location = new Point(6, 67);
            lblPosicionInicial.Name = "lblPosicionInicial";
            lblPosicionInicial.Size = new Size(150, 15);
            lblPosicionInicial.TabIndex = 3;
            lblPosicionInicial.Text = "Posicion inicial del cabezal:";
            // 
            // grpAlfabeto
            // 
            grpAlfabeto.Controls.Add(lblAlfabeto);
            grpAlfabeto.Controls.Add(txtAlfabeto);
            grpAlfabeto.Controls.Add(lblAlfabetoHint);
            grpAlfabeto.Controls.Add(btnInicializar);
            grpAlfabeto.Location = new Point(21, 120);
            grpAlfabeto.Name = "grpAlfabeto";
            grpAlfabeto.Size = new Size(240, 123);
            grpAlfabeto.TabIndex = 7;
            grpAlfabeto.TabStop = false;
            grpAlfabeto.Text = "Alfabeto";
            // 
            // lblAlfabeto
            // 
            lblAlfabeto.AutoSize = true;
            lblAlfabeto.Location = new Point(13, 27);
            lblAlfabeto.Name = "lblAlfabeto";
            lblAlfabeto.Size = new Size(55, 15);
            lblAlfabeto.TabIndex = 5;
            lblAlfabeto.Text = "Alfabeto:";
            // 
            // lstOperaciones
            // 
            lstOperaciones.FormattingEnabled = true;
            lstOperaciones.ItemHeight = 15;
            lstOperaciones.Location = new Point(7, 22);
            lstOperaciones.Name = "lstOperaciones";
            lstOperaciones.Size = new Size(221, 124);
            lstOperaciones.TabIndex = 8;
            // 
            // btnAgregarOp
            // 
            btnAgregarOp.Location = new Point(34, 152);
            btnAgregarOp.Name = "btnAgregarOp";
            btnAgregarOp.Size = new Size(75, 23);
            btnAgregarOp.TabIndex = 9;
            btnAgregarOp.Text = "Agregar";
            btnAgregarOp.UseVisualStyleBackColor = true;
            // 
            // grpCinta
            // 
            grpCinta.Controls.Add(btnQuitarOp);
            grpCinta.Controls.Add(lstOperaciones);
            grpCinta.Controls.Add(btnAgregarOp);
            grpCinta.Location = new Point(27, 255);
            grpCinta.Name = "grpCinta";
            grpCinta.Size = new Size(234, 183);
            grpCinta.TabIndex = 10;
            grpCinta.TabStop = false;
            grpCinta.Text = "Cinta";
            // 
            // btnQuitarOp
            // 
            btnQuitarOp.Location = new Point(134, 152);
            btnQuitarOp.Name = "btnQuitarOp";
            btnQuitarOp.Size = new Size(75, 23);
            btnQuitarOp.TabIndex = 10;
            btnQuitarOp.Text = "Quitar";
            btnQuitarOp.UseVisualStyleBackColor = true;
            // 
            // lstCompuesta
            // 
            lstCompuesta.FormattingEnabled = true;
            lstCompuesta.ItemHeight = 15;
            lstCompuesta.Location = new Point(18, 22);
            lstCompuesta.Name = "lstCompuesta";
            lstCompuesta.Size = new Size(205, 94);
            lstCompuesta.TabIndex = 11;
            // 
            // btnPaso
            // 
            btnPaso.Location = new Point(82, 124);
            btnPaso.Name = "btnPaso";
            btnPaso.Size = new Size(60, 23);
            btnPaso.TabIndex = 12;
            btnPaso.Text = "Paso";
            btnPaso.UseVisualStyleBackColor = true;
            // 
            // btnEjecutar
            // 
            btnEjecutar.Location = new Point(148, 124);
            btnEjecutar.Name = "btnEjecutar";
            btnEjecutar.Size = new Size(75, 23);
            btnEjecutar.TabIndex = 13;
            btnEjecutar.Text = "Ejecutar";
            btnEjecutar.UseVisualStyleBackColor = true;
            // 
            // grpMaquinaCompuesta
            // 
            grpMaquinaCompuesta.Controls.Add(btnReset);
            grpMaquinaCompuesta.Controls.Add(lstCompuesta);
            grpMaquinaCompuesta.Controls.Add(btnPaso);
            grpMaquinaCompuesta.Controls.Add(btnEjecutar);
            grpMaquinaCompuesta.Location = new Point(540, 277);
            grpMaquinaCompuesta.Name = "grpMaquinaCompuesta";
            grpMaquinaCompuesta.Size = new Size(238, 153);
            grpMaquinaCompuesta.TabIndex = 14;
            grpMaquinaCompuesta.TabStop = false;
            grpMaquinaCompuesta.Text = "Maquina compuesta";
            // 
            // btnReset
            // 
            btnReset.Location = new Point(6, 124);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(59, 23);
            btnReset.TabIndex = 15;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            // 
            // numDelay
            // 
            numDelay.Location = new Point(558, 210);
            numDelay.Name = "numDelay";
            numDelay.Size = new Size(64, 23);
            numDelay.TabIndex = 15;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(427, 302);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(94, 19);
            radioButton1.TabIndex = 16;
            radioButton1.TabStop = true;
            radioButton1.Text = "radioButton1";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // grpMaquina
            // 
            grpMaquina.Controls.Add(gridCinta);
            grpMaquina.Location = new Point(294, 18);
            grpMaquina.Name = "grpMaquina";
            grpMaquina.Size = new Size(494, 134);
            grpMaquina.TabIndex = 17;
            grpMaquina.TabStop = false;
            grpMaquina.Text = "Maquina compuesta";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(grpMaquina);
            Controls.Add(radioButton1);
            Controls.Add(numDelay);
            Controls.Add(grpMaquinaCompuesta);
            Controls.Add(grpCinta);
            Controls.Add(grpAlfabeto);
            Controls.Add(GrpCadenaDeEntrada);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)numInicio).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridCinta).EndInit();
            GrpCadenaDeEntrada.ResumeLayout(false);
            GrpCadenaDeEntrada.PerformLayout();
            grpAlfabeto.ResumeLayout(false);
            grpAlfabeto.PerformLayout();
            grpCinta.ResumeLayout(false);
            grpMaquinaCompuesta.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numDelay).EndInit();
            grpMaquina.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtEntrada;
        private NumericUpDown numInicio;
        private Button btnInicializar;
        private TextBox txtAlfabeto;
        private Label lblAlfabetoHint;
        private DataGridView gridCinta;
        private GroupBox GrpCadenaDeEntrada;
        private Label lblPosicionInicial;
        private Label lblCadenaEntrada;
        private GroupBox grpAlfabeto;
        private Label lblAlfabeto;
        private ListBox lstOperaciones;
        private Button btnAgregarOp;
        private GroupBox grpCinta;
        private Button btnQuitarOp;
        private ListBox lstCompuesta;
        private Button btnPaso;
        private Button btnEjecutar;
        private GroupBox grpMaquinaCompuesta;
        private Button btnReset;
        private NumericUpDown numDelay;
        private RadioButton radioButton1;
        private GroupBox grpMaquina;
    }
}