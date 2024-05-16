namespace Ganancias_Packet_On.Vistas
{
    partial class FormaCalculo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormaCalculo));
            lbl_Escenario = new Label();
            btn_Regresar = new Button();
            btn_Siguiente = new Button();
            lbl_Porcentaje = new Label();
            lbl_Gastos_tot = new Label();
            lbl_Ganancias_tot = new Label();
            lbl_Precio_envio = new Label();
            lbl_Ganancias_cant = new Label();
            lbl_Envio_cant = new Label();
            lbl_Gastos_cant = new Label();
            lbl_Pesos_ganancias = new Label();
            lbl_pesos_envio = new Label();
            lbl_pesos_gastos = new Label();
            lbl_mxn_ganancias = new Label();
            lbl_mxn_envio = new Label();
            lbl_mxn_gastos = new Label();
            pctb_animacion = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pctb_animacion).BeginInit();
            SuspendLayout();
            // 
            // lbl_Escenario
            // 
            lbl_Escenario.AutoSize = true;
            lbl_Escenario.Font = new Font("Segoe UI", 16.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lbl_Escenario.Location = new Point(73, 30);
            lbl_Escenario.Name = "lbl_Escenario";
            lbl_Escenario.Size = new Size(152, 38);
            lbl_Escenario.TabIndex = 0;
            lbl_Escenario.Text = "Escenario x";
            // 
            // btn_Regresar
            // 
            btn_Regresar.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_Regresar.Location = new Point(226, 389);
            btn_Regresar.Name = "btn_Regresar";
            btn_Regresar.Size = new Size(167, 40);
            btn_Regresar.TabIndex = 1;
            btn_Regresar.Text = "Menú principal";
            btn_Regresar.UseVisualStyleBackColor = true;
            btn_Regresar.Click += btn_Regresar_Click;
            // 
            // btn_Siguiente
            // 
            btn_Siguiente.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_Siguiente.Location = new Point(411, 389);
            btn_Siguiente.Name = "btn_Siguiente";
            btn_Siguiente.Size = new Size(167, 40);
            btn_Siguiente.TabIndex = 2;
            btn_Siguiente.Text = "Siguiente escenario";
            btn_Siguiente.UseVisualStyleBackColor = true;
            btn_Siguiente.Click += BotonSiguiente_Click;
            // 
            // lbl_Porcentaje
            // 
            lbl_Porcentaje.AutoSize = true;
            lbl_Porcentaje.Font = new Font("Segoe UI", 16.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lbl_Porcentaje.Location = new Point(387, 30);
            lbl_Porcentaje.Name = "lbl_Porcentaje";
            lbl_Porcentaje.Size = new Size(328, 38);
            lbl_Porcentaje.TabIndex = 3;
            lbl_Porcentaje.Text = "Porcentaje de ganancia: x";
            // 
            // lbl_Gastos_tot
            // 
            lbl_Gastos_tot.AutoSize = true;
            lbl_Gastos_tot.Font = new Font("Segoe UI", 13.2000008F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lbl_Gastos_tot.Location = new Point(82, 333);
            lbl_Gastos_tot.Name = "lbl_Gastos_tot";
            lbl_Gastos_tot.Size = new Size(154, 31);
            lbl_Gastos_tot.TabIndex = 4;
            lbl_Gastos_tot.Text = "Gastos totales:";
            // 
            // lbl_Ganancias_tot
            // 
            lbl_Ganancias_tot.AutoSize = true;
            lbl_Ganancias_tot.Font = new Font("Segoe UI", 13.2000008F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lbl_Ganancias_tot.Location = new Point(82, 241);
            lbl_Ganancias_tot.Name = "lbl_Ganancias_tot";
            lbl_Ganancias_tot.Size = new Size(250, 31);
            lbl_Ganancias_tot.TabIndex = 5;
            lbl_Ganancias_tot.Text = "Ganancias netas totales:";
            // 
            // lbl_Precio_envio
            // 
            lbl_Precio_envio.AutoSize = true;
            lbl_Precio_envio.Font = new Font("Segoe UI", 13.2000008F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lbl_Precio_envio.Location = new Point(82, 288);
            lbl_Precio_envio.Name = "lbl_Precio_envio";
            lbl_Precio_envio.Size = new Size(305, 31);
            lbl_Precio_envio.TabIndex = 6;
            lbl_Precio_envio.Text = "Cada envío se debe cobrar en:";
            // 
            // lbl_Ganancias_cant
            // 
            lbl_Ganancias_cant.AutoSize = true;
            lbl_Ganancias_cant.Font = new Font("Segoe UI", 13.2000008F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lbl_Ganancias_cant.Location = new Point(517, 241);
            lbl_Ganancias_cant.Name = "lbl_Ganancias_cant";
            lbl_Ganancias_cant.Size = new Size(129, 31);
            lbl_Ganancias_cant.TabIndex = 7;
            lbl_Ganancias_cant.Text = "x,xxx,xxx,xxx";
            // 
            // lbl_Envio_cant
            // 
            lbl_Envio_cant.AutoSize = true;
            lbl_Envio_cant.Font = new Font("Segoe UI", 13.2000008F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lbl_Envio_cant.Location = new Point(517, 288);
            lbl_Envio_cant.Name = "lbl_Envio_cant";
            lbl_Envio_cant.Size = new Size(129, 31);
            lbl_Envio_cant.TabIndex = 8;
            lbl_Envio_cant.Text = "x,xxx,xxx,xxx";
            // 
            // lbl_Gastos_cant
            // 
            lbl_Gastos_cant.AutoSize = true;
            lbl_Gastos_cant.Font = new Font("Segoe UI", 13.2000008F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lbl_Gastos_cant.Location = new Point(517, 333);
            lbl_Gastos_cant.Name = "lbl_Gastos_cant";
            lbl_Gastos_cant.Size = new Size(129, 31);
            lbl_Gastos_cant.TabIndex = 9;
            lbl_Gastos_cant.Text = "x,xxx,xxx,xxx";
            // 
            // lbl_Pesos_ganancias
            // 
            lbl_Pesos_ganancias.AutoSize = true;
            lbl_Pesos_ganancias.Font = new Font("Segoe UI", 13.2000008F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lbl_Pesos_ganancias.Location = new Point(459, 241);
            lbl_Pesos_ganancias.Name = "lbl_Pesos_ganancias";
            lbl_Pesos_ganancias.Size = new Size(26, 31);
            lbl_Pesos_ganancias.TabIndex = 10;
            lbl_Pesos_ganancias.Text = "$";
            // 
            // lbl_pesos_envio
            // 
            lbl_pesos_envio.AutoSize = true;
            lbl_pesos_envio.Font = new Font("Segoe UI", 13.2000008F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lbl_pesos_envio.Location = new Point(459, 288);
            lbl_pesos_envio.Name = "lbl_pesos_envio";
            lbl_pesos_envio.Size = new Size(26, 31);
            lbl_pesos_envio.TabIndex = 11;
            lbl_pesos_envio.Text = "$";
            // 
            // lbl_pesos_gastos
            // 
            lbl_pesos_gastos.AutoSize = true;
            lbl_pesos_gastos.Font = new Font("Segoe UI", 13.2000008F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lbl_pesos_gastos.Location = new Point(459, 333);
            lbl_pesos_gastos.Name = "lbl_pesos_gastos";
            lbl_pesos_gastos.Size = new Size(26, 31);
            lbl_pesos_gastos.TabIndex = 12;
            lbl_pesos_gastos.Text = "$";
            // 
            // lbl_mxn_ganancias
            // 
            lbl_mxn_ganancias.AutoSize = true;
            lbl_mxn_ganancias.Font = new Font("Segoe UI", 13.2000008F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lbl_mxn_ganancias.Location = new Point(665, 241);
            lbl_mxn_ganancias.Name = "lbl_mxn_ganancias";
            lbl_mxn_ganancias.Size = new Size(64, 31);
            lbl_mxn_ganancias.TabIndex = 13;
            lbl_mxn_ganancias.Text = "MXN";
            // 
            // lbl_mxn_envio
            // 
            lbl_mxn_envio.AutoSize = true;
            lbl_mxn_envio.Font = new Font("Segoe UI", 13.2000008F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lbl_mxn_envio.Location = new Point(665, 288);
            lbl_mxn_envio.Name = "lbl_mxn_envio";
            lbl_mxn_envio.Size = new Size(64, 31);
            lbl_mxn_envio.TabIndex = 14;
            lbl_mxn_envio.Text = "MXN";
            // 
            // lbl_mxn_gastos
            // 
            lbl_mxn_gastos.AutoSize = true;
            lbl_mxn_gastos.Font = new Font("Segoe UI", 13.2000008F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lbl_mxn_gastos.Location = new Point(665, 333);
            lbl_mxn_gastos.Name = "lbl_mxn_gastos";
            lbl_mxn_gastos.Size = new Size(64, 31);
            lbl_mxn_gastos.TabIndex = 15;
            lbl_mxn_gastos.Text = "MXN";
            // 
            // pctb_animacion
            // 
            pctb_animacion.Image = (Image)resources.GetObject("pctb_animacion.Image");
            pctb_animacion.Location = new Point(48, 89);
            pctb_animacion.Name = "pctb_animacion";
            pctb_animacion.Size = new Size(700, 130);
            pctb_animacion.TabIndex = 16;
            pctb_animacion.TabStop = false;
            // 
            // FormaCalculo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pctb_animacion);
            Controls.Add(lbl_mxn_gastos);
            Controls.Add(lbl_mxn_envio);
            Controls.Add(lbl_mxn_ganancias);
            Controls.Add(lbl_pesos_gastos);
            Controls.Add(lbl_pesos_envio);
            Controls.Add(lbl_Pesos_ganancias);
            Controls.Add(lbl_Gastos_cant);
            Controls.Add(lbl_Envio_cant);
            Controls.Add(lbl_Ganancias_cant);
            Controls.Add(lbl_Precio_envio);
            Controls.Add(lbl_Ganancias_tot);
            Controls.Add(lbl_Gastos_tot);
            Controls.Add(lbl_Porcentaje);
            Controls.Add(btn_Siguiente);
            Controls.Add(btn_Regresar);
            Controls.Add(lbl_Escenario);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "FormaCalculo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculo de escenarios - Packet-On";
            ((System.ComponentModel.ISupportInitialize)pctb_animacion).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_Escenario;
        private Button btn_Regresar;
        private Button btn_Siguiente;
        private Label lbl_Porcentaje;
        private Label lbl_Gastos_tot;
        private Label lbl_Ganancias_tot;
        private Label lbl_Precio_envio;
        private Label lbl_Ganancias_cant;
        private Label lbl_Envio_cant;
        private Label lbl_Gastos_cant;
        private Label lbl_Pesos_ganancias;
        private Label lbl_pesos_envio;
        private Label lbl_pesos_gastos;
        private Label lbl_mxn_ganancias;
        private Label lbl_mxn_envio;
        private Label lbl_mxn_gastos;
        private PictureBox pctb_animacion;
    }
}