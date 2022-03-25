namespace InterfazImpresora
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
            this.btnEnviarImp = new System.Windows.Forms.Button();
            this.txtInstruccionImp = new System.Windows.Forms.TextBox();
            this.lblInstruccion = new System.Windows.Forms.Label();
            this.btnCerrarImp = new System.Windows.Forms.Button();
            this.txtRespuestaImp = new System.Windows.Forms.TextBox();
            this.btnConsultarImp = new System.Windows.Forms.Button();
            this.btnCerrarPLC = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Start = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.chkRemoto = new System.Windows.Forms.CheckBox();
            this.chkAutomatico = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnOrden = new System.Windows.Forms.Button();
            this.chkManual = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnMotorAtras = new System.Windows.Forms.Button();
            this.btnMotorAdelante = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtCodigoImpreso = new System.Windows.Forms.TextBox();
            this.btnOnOff = new System.Windows.Forms.Button();
            this.btnOpenClose = new System.Windows.Forms.Button();
            this.btnGoStop = new System.Windows.Forms.Button();
            this.btnPreguntar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEnviarImp
            // 
            this.btnEnviarImp.Location = new System.Drawing.Point(106, 137);
            this.btnEnviarImp.Name = "btnEnviarImp";
            this.btnEnviarImp.Size = new System.Drawing.Size(75, 23);
            this.btnEnviarImp.TabIndex = 0;
            this.btnEnviarImp.Text = "Enviar";
            this.btnEnviarImp.UseVisualStyleBackColor = true;
            this.btnEnviarImp.Click += new System.EventHandler(this.btnEnviarImp_Click);
            // 
            // txtInstruccionImp
            // 
            this.txtInstruccionImp.Location = new System.Drawing.Point(101, 102);
            this.txtInstruccionImp.Name = "txtInstruccionImp";
            this.txtInstruccionImp.Size = new System.Drawing.Size(242, 23);
            this.txtInstruccionImp.TabIndex = 3;
            // 
            // lblInstruccion
            // 
            this.lblInstruccion.AutoSize = true;
            this.lblInstruccion.Location = new System.Drawing.Point(25, 105);
            this.lblInstruccion.Name = "lblInstruccion";
            this.lblInstruccion.Size = new System.Drawing.Size(66, 15);
            this.lblInstruccion.TabIndex = 6;
            this.lblInstruccion.Text = "Instruccion";
            // 
            // btnCerrarImp
            // 
            this.btnCerrarImp.Location = new System.Drawing.Point(268, 137);
            this.btnCerrarImp.Name = "btnCerrarImp";
            this.btnCerrarImp.Size = new System.Drawing.Size(75, 23);
            this.btnCerrarImp.TabIndex = 8;
            this.btnCerrarImp.Text = "Cerrar";
            this.btnCerrarImp.UseVisualStyleBackColor = true;
            this.btnCerrarImp.Click += new System.EventHandler(this.btnCerrarImp_Click);
            // 
            // txtRespuestaImp
            // 
            this.txtRespuestaImp.Enabled = false;
            this.txtRespuestaImp.Location = new System.Drawing.Point(25, 167);
            this.txtRespuestaImp.Name = "txtRespuestaImp";
            this.txtRespuestaImp.Size = new System.Drawing.Size(318, 23);
            this.txtRespuestaImp.TabIndex = 9;
            // 
            // btnConsultarImp
            // 
            this.btnConsultarImp.Location = new System.Drawing.Point(187, 137);
            this.btnConsultarImp.Name = "btnConsultarImp";
            this.btnConsultarImp.Size = new System.Drawing.Size(75, 23);
            this.btnConsultarImp.TabIndex = 12;
            this.btnConsultarImp.Text = "Consultar";
            this.btnConsultarImp.UseVisualStyleBackColor = true;
            this.btnConsultarImp.Click += new System.EventHandler(this.btnConsultarImp_Click);
            // 
            // btnCerrarPLC
            // 
            this.btnCerrarPLC.Location = new System.Drawing.Point(557, 56);
            this.btnCerrarPLC.Name = "btnCerrarPLC";
            this.btnCerrarPLC.Size = new System.Drawing.Size(75, 23);
            this.btnCerrarPLC.TabIndex = 16;
            this.btnCerrarPLC.Text = "Cerrar";
            this.btnCerrarPLC.UseVisualStyleBackColor = true;
            this.btnCerrarPLC.Click += new System.EventHandler(this.btnCerrarPLC_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(135, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 15);
            this.label2.TabIndex = 20;
            this.label2.Text = "IMPRESORA";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(579, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 15);
            this.label3.TabIndex = 21;
            this.label3.Text = "PLC";
            // 
            // Start
            // 
            this.Start.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Start.Location = new System.Drawing.Point(462, 144);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(75, 23);
            this.Start.TabIndex = 22;
            this.Start.Text = "Start";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // btnStop
            // 
            this.btnStop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStop.Location = new System.Drawing.Point(462, 174);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 23);
            this.btnStop.TabIndex = 23;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(539, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 15);
            this.label4.TabIndex = 24;
            this.label4.Text = "CONTROL BANDA";
            // 
            // chkRemoto
            // 
            this.chkRemoto.AutoSize = true;
            this.chkRemoto.Location = new System.Drawing.Point(635, 148);
            this.chkRemoto.Name = "chkRemoto";
            this.chkRemoto.Size = new System.Drawing.Size(68, 19);
            this.chkRemoto.TabIndex = 25;
            this.chkRemoto.Text = "Remoto";
            this.chkRemoto.UseVisualStyleBackColor = true;
            this.chkRemoto.Click += new System.EventHandler(this.chkRemoto_Click);
            // 
            // chkAutomatico
            // 
            this.chkAutomatico.AutoSize = true;
            this.chkAutomatico.Location = new System.Drawing.Point(635, 177);
            this.chkAutomatico.Name = "chkAutomatico";
            this.chkAutomatico.Size = new System.Drawing.Size(89, 19);
            this.chkAutomatico.TabIndex = 26;
            this.chkAutomatico.Text = "Automático";
            this.chkAutomatico.UseVisualStyleBackColor = true;
            this.chkAutomatico.Click += new System.EventHandler(this.chkAutomatico_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(499, 251);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(167, 15);
            this.label5.TabIndex = 27;
            this.label5.Text = "CONDICIONES DE ARRANQUE";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // btnOrden
            // 
            this.btnOrden.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOrden.Location = new System.Drawing.Point(557, 281);
            this.btnOrden.Name = "btnOrden";
            this.btnOrden.Size = new System.Drawing.Size(75, 23);
            this.btnOrden.TabIndex = 28;
            this.btnOrden.Text = "Orden";
            this.btnOrden.UseVisualStyleBackColor = true;
            this.btnOrden.Click += new System.EventHandler(this.btnOrden_Click);
            // 
            // chkManual
            // 
            this.chkManual.AutoSize = true;
            this.chkManual.Location = new System.Drawing.Point(635, 202);
            this.chkManual.Name = "chkManual";
            this.chkManual.Size = new System.Drawing.Size(66, 19);
            this.chkManual.TabIndex = 29;
            this.chkManual.Text = "Manual";
            this.chkManual.UseVisualStyleBackColor = true;
            this.chkManual.Click += new System.EventHandler(this.chkManual_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(101, 281);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(157, 15);
            this.label6.TabIndex = 30;
            this.label6.Text = "CONTROL MOTOR MANUAL";
            // 
            // btnMotorAtras
            // 
            this.btnMotorAtras.BackColor = System.Drawing.Color.White;
            this.btnMotorAtras.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMotorAtras.Image = global::InterfazImpresora.Properties.Resources.izquierda;
            this.btnMotorAtras.Location = new System.Drawing.Point(91, 314);
            this.btnMotorAtras.Name = "btnMotorAtras";
            this.btnMotorAtras.Size = new System.Drawing.Size(75, 33);
            this.btnMotorAtras.TabIndex = 31;
            this.btnMotorAtras.UseVisualStyleBackColor = false;
            this.btnMotorAtras.Click += new System.EventHandler(this.btnMotorAtras_Click);
            // 
            // btnMotorAdelante
            // 
            this.btnMotorAdelante.BackColor = System.Drawing.Color.White;
            this.btnMotorAdelante.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMotorAdelante.Image = global::InterfazImpresora.Properties.Resources.derecho;
            this.btnMotorAdelante.Location = new System.Drawing.Point(197, 314);
            this.btnMotorAdelante.Name = "btnMotorAdelante";
            this.btnMotorAdelante.Size = new System.Drawing.Size(75, 33);
            this.btnMotorAdelante.TabIndex = 32;
            this.btnMotorAdelante.UseVisualStyleBackColor = false;
            this.btnMotorAdelante.Click += new System.EventHandler(this.btnMotorAdelante_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.White;
            this.btnReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReset.Image = global::InterfazImpresora.Properties.Resources.Reset;
            this.btnReset.Location = new System.Drawing.Point(557, 387);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 41);
            this.btnReset.TabIndex = 33;
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(568, 325);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 15);
            this.label7.TabIndex = 34;
            this.label7.Text = "ALARMA";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(462, 358);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(262, 23);
            this.textBox1.TabIndex = 35;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(25, 220);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(92, 15);
            this.lblCodigo.TabIndex = 36;
            this.lblCodigo.Text = "Codigo impreso";
            // 
            // txtCodigoImpreso
            // 
            this.txtCodigoImpreso.Location = new System.Drawing.Point(121, 217);
            this.txtCodigoImpreso.Name = "txtCodigoImpreso";
            this.txtCodigoImpreso.Size = new System.Drawing.Size(227, 23);
            this.txtCodigoImpreso.TabIndex = 37;
            // 
            // btnOnOff
            // 
            this.btnOnOff.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOnOff.Location = new System.Drawing.Point(42, 56);
            this.btnOnOff.Name = "btnOnOff";
            this.btnOnOff.Size = new System.Drawing.Size(75, 23);
            this.btnOnOff.TabIndex = 38;
            this.btnOnOff.Text = "On";
            this.btnOnOff.UseVisualStyleBackColor = true;
            this.btnOnOff.Click += new System.EventHandler(this.btnOnOff_Click);
            // 
            // btnOpenClose
            // 
            this.btnOpenClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOpenClose.Location = new System.Drawing.Point(135, 56);
            this.btnOpenClose.Name = "btnOpenClose";
            this.btnOpenClose.Size = new System.Drawing.Size(75, 23);
            this.btnOpenClose.TabIndex = 39;
            this.btnOpenClose.Text = "Open";
            this.btnOpenClose.UseVisualStyleBackColor = true;
            this.btnOpenClose.Click += new System.EventHandler(this.btnOpenClose_Click);
            // 
            // btnGoStop
            // 
            this.btnGoStop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGoStop.Location = new System.Drawing.Point(231, 56);
            this.btnGoStop.Name = "btnGoStop";
            this.btnGoStop.Size = new System.Drawing.Size(75, 23);
            this.btnGoStop.TabIndex = 40;
            this.btnGoStop.Text = "Go";
            this.btnGoStop.UseVisualStyleBackColor = true;
            this.btnGoStop.Click += new System.EventHandler(this.btnGoStop_Click);
            // 
            // btnPreguntar
            // 
            this.btnPreguntar.Location = new System.Drawing.Point(662, 387);
            this.btnPreguntar.Name = "btnPreguntar";
            this.btnPreguntar.Size = new System.Drawing.Size(75, 23);
            this.btnPreguntar.TabIndex = 41;
            this.btnPreguntar.Text = "?";
            this.btnPreguntar.UseVisualStyleBackColor = true;
            this.btnPreguntar.Click += new System.EventHandler(this.btnPreguntar_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(62, 390);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 23);
            this.button1.TabIndex = 42;
            this.button1.Text = "ConexionDb";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnConexionDb);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 464);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnPreguntar);
            this.Controls.Add(this.btnGoStop);
            this.Controls.Add(this.btnOpenClose);
            this.Controls.Add(this.btnOnOff);
            this.Controls.Add(this.txtCodigoImpreso);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnMotorAdelante);
            this.Controls.Add(this.btnMotorAtras);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.chkManual);
            this.Controls.Add(this.btnOrden);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.chkAutomatico);
            this.Controls.Add(this.chkRemoto);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCerrarPLC);
            this.Controls.Add(this.btnConsultarImp);
            this.Controls.Add(this.txtRespuestaImp);
            this.Controls.Add(this.btnCerrarImp);
            this.Controls.Add(this.lblInstruccion);
            this.Controls.Add(this.txtInstruccionImp);
            this.Controls.Add(this.btnEnviarImp);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnEnviarImp;
        private TextBox txtInstruccionImp;
        private Label lblInstruccion;
        private Button btnCerrarImp;
        private TextBox txtRespuestaImp;
        private Button btnConsultarImp;
        private Button btnCerrarPLC;
        private Label label2;
        private Label label3;
        private Button Start;
        private Button btnStop;
        private Label label4;
        private CheckBox chkRemoto;
        private CheckBox chkAutomatico;
        private Label label5;
        private Button btnOrden;
        private CheckBox chkManual;
        private Label label6;
        private Button btnMotorAtras;
        private Button btnMotorAdelante;
        private Button btnReset;
        private Label label7;
        private TextBox textBox1;
        private Label lblCodigo;
        private TextBox txtCodigoImpreso;
        private Button btnOnOff;
        private Button btnOpenClose;
        private Button btnGoStop;
        private Button btnPreguntar;
        private Button button1;
    }
}