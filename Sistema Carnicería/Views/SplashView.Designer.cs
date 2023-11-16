namespace Sistema_Carnicería.Views
{
    partial class SplashView
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SplashView));
            lblNombreSistema = new Label();
            timer = new System.Windows.Forms.Timer(components);
            progressBar = new ProgressBar();
            pbCarniceria = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pbCarniceria).BeginInit();
            SuspendLayout();
            // 
            // lblNombreSistema
            // 
            lblNombreSistema.AutoSize = true;
            lblNombreSistema.Font = new Font("Arial Black", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblNombreSistema.Location = new Point(392, 12);
            lblNombreSistema.Name = "lblNombreSistema";
            lblNombreSistema.Size = new Size(268, 33);
            lblNombreSistema.TabIndex = 0;
            lblNombreSistema.Text = "Sistema Carnicería";
            // 
            // timer
            // 
            timer.Enabled = true;
            timer.Interval = 35;
            timer.Tick += timer1_Tick;
            // 
            // progressBar
            // 
            progressBar.Location = new Point(447, 232);
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(213, 18);
            progressBar.TabIndex = 1;
            // 
            // pbCarniceria
            // 
            pbCarniceria.Image = (Image)resources.GetObject("pbCarniceria.Image");
            pbCarniceria.Location = new Point(12, 12);
            pbCarniceria.Name = "pbCarniceria";
            pbCarniceria.Size = new Size(369, 238);
            pbCarniceria.SizeMode = PictureBoxSizeMode.StretchImage;
            pbCarniceria.TabIndex = 2;
            pbCarniceria.TabStop = false;
            // 
            // SplashView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(672, 267);
            Controls.Add(pbCarniceria);
            Controls.Add(progressBar);
            Controls.Add(lblNombreSistema);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "SplashView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SplashView";
            Activated += SplashView_Activated;
            ((System.ComponentModel.ISupportInitialize)pbCarniceria).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNombreSistema;
        private System.Windows.Forms.Timer timer;
        private ProgressBar progressBar;
        private PictureBox pbCarniceria;
    }
}