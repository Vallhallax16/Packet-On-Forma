
namespace Ganancias_Packet_On
{
    partial class FormaInicial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormaInicial));
            btn_Iniciar = new Button();
            btn_Ajustar_param = new Button();
            btn_Salir = new Button();
            pctb_relleno_1 = new PictureBox();
            pctb_relleno_2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pctb_relleno_1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pctb_relleno_2).BeginInit();
            SuspendLayout();
            // 
            // btn_Iniciar
            // 
            btn_Iniciar.Location = new Point(306, 83);
            btn_Iniciar.Name = "btn_Iniciar";
            btn_Iniciar.Size = new Size(168, 57);
            btn_Iniciar.TabIndex = 0;
            btn_Iniciar.Text = "Iniciar escenarios y simulación";
            btn_Iniciar.UseVisualStyleBackColor = true;
            btn_Iniciar.Click += btn_Iniciar_Click;
            // 
            // btn_Ajustar_param
            // 
            btn_Ajustar_param.Location = new Point(306, 186);
            btn_Ajustar_param.Name = "btn_Ajustar_param";
            btn_Ajustar_param.Size = new Size(168, 56);
            btn_Ajustar_param.TabIndex = 1;
            btn_Ajustar_param.Text = "Ajustar parámetros";
            btn_Ajustar_param.UseVisualStyleBackColor = true;
            btn_Ajustar_param.Click += btn_Ajustar_param_Click;
            // 
            // btn_Salir
            // 
            btn_Salir.Location = new Point(306, 301);
            btn_Salir.Name = "btn_Salir";
            btn_Salir.Size = new Size(168, 56);
            btn_Salir.TabIndex = 2;
            btn_Salir.Text = "Salir";
            btn_Salir.UseVisualStyleBackColor = true;
            btn_Salir.Click += btn_Salir_Click;
            // 
            // pctb_relleno_1
            // 
            pctb_relleno_1.Image = (Image)resources.GetObject("pctb_relleno_1.Image");
            pctb_relleno_1.Location = new Point(35, 129);
            pctb_relleno_1.Name = "pctb_relleno_1";
            pctb_relleno_1.Size = new Size(212, 183);
            pctb_relleno_1.TabIndex = 3;
            pctb_relleno_1.TabStop = false;
            // 
            // pctb_relleno_2
            // 
            pctb_relleno_2.Image = (Image)resources.GetObject("pctb_relleno_2.Image");
            pctb_relleno_2.Location = new Point(543, 129);
            pctb_relleno_2.Name = "pctb_relleno_2";
            pctb_relleno_2.Size = new Size(212, 183);
            pctb_relleno_2.TabIndex = 4;
            pctb_relleno_2.TabStop = false;
            // 
            // FormaInicial
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pctb_relleno_2);
            Controls.Add(pctb_relleno_1);
            Controls.Add(btn_Salir);
            Controls.Add(btn_Ajustar_param);
            Controls.Add(btn_Iniciar);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "FormaInicial";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ganancias Packet-On";
            ((System.ComponentModel.ISupportInitialize)pctb_relleno_1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pctb_relleno_2).EndInit();
            ResumeLayout(false);
        }

        private void btn_Iniciar_MouseClick(object sender, MouseEventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Button btn_Iniciar;
        private Button btn_Ajustar_param;
        private Button btn_Salir;
        private PictureBox pctb_relleno_1;
        private PictureBox pctb_relleno_2;
    }
}
