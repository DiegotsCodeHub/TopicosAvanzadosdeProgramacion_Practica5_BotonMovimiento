namespace CruzPatinoDiego_Practica5_BotonMovimiento
{
    partial class FrmPrincipal
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
            btn_movercosas = new Button();
            label1 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // btn_movercosas
            // 
            btn_movercosas.BackColor = SystemColors.InactiveBorder;
            btn_movercosas.Font = new Font("Stencil", 15.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btn_movercosas.ForeColor = Color.Red;
            btn_movercosas.Location = new Point(275, 314);
            btn_movercosas.Name = "btn_movercosas";
            btn_movercosas.Size = new Size(272, 91);
            btn_movercosas.TabIndex = 0;
            btn_movercosas.Text = "CERRAR PROGRAMA";
            btn_movercosas.UseVisualStyleBackColor = false;
            btn_movercosas.Click += btn_movercosas_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Stencil", 20.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(183, 35);
            label1.Name = "label1";
            label1.Size = new Size(419, 32);
            label1.TabIndex = 1;
            label1.Text = "Cruz Patino Diego - 22210297";
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 500;
            timer1.Tick += timer1_Tick;
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._301715550_1455526414960299_6030906415453088477_n;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(btn_movercosas);
            Name = "FrmPrincipal";
            Text = "CruzPatinoDiego Practica5 BotonMovimiento";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_movercosas;
        private Label label1;
        private System.Windows.Forms.Timer timer1;
    }
}
