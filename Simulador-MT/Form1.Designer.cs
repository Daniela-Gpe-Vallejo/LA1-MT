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
            lblPosicionInicial = new Label();
            lblCadenaEntrada = new Label();
            grpAlfabeto = new GroupBox();
            lblAlfabeto = new Label();
            grpCinta = new GroupBox();
            lstCompuesta = new ListBox();
            btnPaso = new Button();
            btnEjecutar = new Button();
            grpMaquinaCompuesta = new GroupBox();
            btnReset = new Button();
            radMoverIzquierda = new RadioButton();
            grpMaquina = new GroupBox();
            radMoverDerecha = new RadioButton();
            radEscribirDerecha = new RadioButton();
            radBuscarDerecha = new RadioButton();
            radBuscaeIzquierda = new RadioButton();
            radEscribirIzquierda = new RadioButton();
            radBorrarDerecha = new RadioButton();
            radBorrarIzquierda = new RadioButton();
            radGuardar = new RadioButton();
            ((System.ComponentModel.ISupportInitialize)numInicio).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridCinta).BeginInit();
            GrpCadenaDeEntrada.SuspendLayout();
            grpAlfabeto.SuspendLayout();
            grpCinta.SuspendLayout();
            grpMaquinaCompuesta.SuspendLayout();
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
            btnInicializar.Location = new Point(62, 68);
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
            lblAlfabetoHint.Location = new Point(6, 50);
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
            // lblPosicionInicial
            // 
            lblPosicionInicial.AutoSize = true;
            lblPosicionInicial.Location = new Point(6, 67);
            lblPosicionInicial.Name = "lblPosicionInicial";
            lblPosicionInicial.Size = new Size(150, 15);
            lblPosicionInicial.TabIndex = 3;
            lblPosicionInicial.Text = "Posicion inicial del cabezal:";
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
            // grpAlfabeto
            // 
            grpAlfabeto.Controls.Add(lblAlfabeto);
            grpAlfabeto.Controls.Add(txtAlfabeto);
            grpAlfabeto.Controls.Add(lblAlfabetoHint);
            grpAlfabeto.Controls.Add(btnInicializar);
            grpAlfabeto.Location = new Point(21, 135);
            grpAlfabeto.Name = "grpAlfabeto";
            grpAlfabeto.Size = new Size(240, 98);
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
            // grpCinta
            // 
            grpCinta.Controls.Add(radGuardar);
            grpCinta.Controls.Add(radBorrarIzquierda);
            grpCinta.Controls.Add(radBorrarDerecha);
            grpCinta.Controls.Add(radEscribirIzquierda);
            grpCinta.Controls.Add(radBuscaeIzquierda);
            grpCinta.Controls.Add(radBuscarDerecha);
            grpCinta.Controls.Add(radEscribirDerecha);
            grpCinta.Controls.Add(radMoverDerecha);
            grpCinta.Controls.Add(radMoverIzquierda);
            grpCinta.Location = new Point(21, 261);
            grpCinta.Name = "grpCinta";
            grpCinta.Size = new Size(444, 169);
            grpCinta.TabIndex = 10;
            grpCinta.TabStop = false;
            grpCinta.Text = "Cinta";
            // 
            // lstCompuesta
            // 
            lstCompuesta.FormattingEnabled = true;
            lstCompuesta.ItemHeight = 15;
            lstCompuesta.Items.AddRange(new object[] { "Mover a la Izquierda (L)", "Mover a la Derecha (R)", "Guardar simbolo actual", "Mover Derecha (R)", "Mover Izquierda (L)", "Escribir \"X\"", "Buscar " });
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
            grpMaquinaCompuesta.Location = new Point(527, 261);
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
            // radMoverIzquierda
            // 
            radMoverIzquierda.AutoSize = true;
            radMoverIzquierda.Location = new Point(23, 22);
            radMoverIzquierda.Name = "radMoverIzquierda";
            radMoverIzquierda.Size = new Size(127, 19);
            radMoverIzquierda.TabIndex = 16;
            radMoverIzquierda.TabStop = true;
            radMoverIzquierda.Text = "Mover Izquierda (L)";
            radMoverIzquierda.UseVisualStyleBackColor = true;
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
            // radMoverDerecha
            // 
            radMoverDerecha.AutoSize = true;
            radMoverDerecha.Location = new Point(23, 44);
            radMoverDerecha.Name = "radMoverDerecha";
            radMoverDerecha.Size = new Size(123, 19);
            radMoverDerecha.TabIndex = 17;
            radMoverDerecha.TabStop = true;
            radMoverDerecha.Text = "Mover Derecha (R)";
            radMoverDerecha.UseVisualStyleBackColor = true;
            // 
            // radEscribirDerecha
            // 
            radEscribirDerecha.AutoSize = true;
            radEscribirDerecha.Location = new Point(23, 69);
            radEscribirDerecha.Name = "radEscribirDerecha";
            radEscribirDerecha.Size = new Size(109, 19);
            radEscribirDerecha.TabIndex = 18;
            radEscribirDerecha.TabStop = true;
            radEscribirDerecha.Text = "Escribir Derecha";
            radEscribirDerecha.UseVisualStyleBackColor = true;
            // 
            // radBuscarDerecha
            // 
            radBuscarDerecha.AutoSize = true;
            radBuscarDerecha.Location = new Point(23, 121);
            radBuscarDerecha.Name = "radBuscarDerecha";
            radBuscarDerecha.Size = new Size(172, 19);
            radBuscarDerecha.TabIndex = 19;
            radBuscarDerecha.TabStop = true;
            radBuscarDerecha.Text = "Buscar simbolo a la derecha";
            radBuscarDerecha.UseVisualStyleBackColor = true;
            // 
            // radBuscaeIzquierda
            // 
            radBuscaeIzquierda.AutoSize = true;
            radBuscaeIzquierda.Location = new Point(23, 146);
            radBuscaeIzquierda.Name = "radBuscaeIzquierda";
            radBuscaeIzquierda.Size = new Size(178, 19);
            radBuscaeIzquierda.TabIndex = 20;
            radBuscaeIzquierda.TabStop = true;
            radBuscaeIzquierda.Text = "Buscar simbolo a la izquierda";
            radBuscaeIzquierda.UseVisualStyleBackColor = true;
            // 
            // radEscribirIzquierda
            // 
            radEscribirIzquierda.AutoSize = true;
            radEscribirIzquierda.Location = new Point(23, 94);
            radEscribirIzquierda.Name = "radEscribirIzquierda";
            radEscribirIzquierda.Size = new Size(114, 19);
            radEscribirIzquierda.TabIndex = 21;
            radEscribirIzquierda.TabStop = true;
            radEscribirIzquierda.Text = "Escribir Izquierda";
            radEscribirIzquierda.UseVisualStyleBackColor = true;
            // 
            // radBorrarDerecha
            // 
            radBorrarDerecha.AutoSize = true;
            radBorrarDerecha.Location = new Point(262, 22);
            radBorrarDerecha.Name = "radBorrarDerecha";
            radBorrarDerecha.Size = new Size(123, 19);
            radBorrarDerecha.TabIndex = 22;
            radBorrarDerecha.TabStop = true;
            radBorrarDerecha.Text = "Borrar a la derecha";
            radBorrarDerecha.UseVisualStyleBackColor = true;
            // 
            // radBorrarIzquierda
            // 
            radBorrarIzquierda.AutoSize = true;
            radBorrarIzquierda.Location = new Point(262, 44);
            radBorrarIzquierda.Name = "radBorrarIzquierda";
            radBorrarIzquierda.Size = new Size(129, 19);
            radBorrarIzquierda.TabIndex = 23;
            radBorrarIzquierda.TabStop = true;
            radBorrarIzquierda.Text = "Borrar a la izquierda";
            radBorrarIzquierda.UseVisualStyleBackColor = true;
            // 
            // radGuardar
            // 
            radGuardar.AutoSize = true;
            radGuardar.Location = new Point(262, 69);
            radGuardar.Name = "radGuardar";
            radGuardar.Size = new Size(67, 19);
            radGuardar.TabIndex = 24;
            radGuardar.TabStop = true;
            radGuardar.Text = "Guardar";
            radGuardar.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(grpMaquina);
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
            grpCinta.PerformLayout();
            grpMaquinaCompuesta.ResumeLayout(false);
            grpMaquina.ResumeLayout(false);
            ResumeLayout(false);
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
        private RadioButton radMoverIzquierda;
        private GroupBox grpMaquina;
        private RadioButton radBuscaeIzquierda;
        private RadioButton radBuscarDerecha;
        private RadioButton radEscribirDerecha;
        private RadioButton radMoverDerecha;
        private RadioButton radEscribirIzquierda;
        private RadioButton radGuardar;
        private RadioButton radBorrarIzquierda;
        private RadioButton radBorrarDerecha;
    }
}