namespace Proprietari_di_casa__Client_
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btn_entrances = new System.Windows.Forms.Button();
            this.btn_watering = new System.Windows.Forms.Button();
            this.btn_TV = new System.Windows.Forms.Button();
            this.btn_lights = new System.Windows.Forms.Button();
            this.lb_appTitle = new System.Windows.Forms.Label();
            this.lb_subTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_entrances
            // 
            this.btn_entrances.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_entrances.BackgroundImage")));
            this.btn_entrances.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_entrances.Font = new System.Drawing.Font("Agency FB", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.btn_entrances.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(90)))), ((int)(((byte)(114)))));
            this.btn_entrances.Location = new System.Drawing.Point(12, 369);
            this.btn_entrances.Name = "btn_entrances";
            this.btn_entrances.Size = new System.Drawing.Size(160, 80);
            this.btn_entrances.TabIndex = 0;
            this.btn_entrances.Text = "Porte";
            this.btn_entrances.UseVisualStyleBackColor = true;
            // 
            // btn_watering
            // 
            this.btn_watering.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_watering.BackgroundImage")));
            this.btn_watering.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_watering.Font = new System.Drawing.Font("Agency FB", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.btn_watering.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(90)))), ((int)(((byte)(114)))));
            this.btn_watering.Location = new System.Drawing.Point(12, 283);
            this.btn_watering.Name = "btn_watering";
            this.btn_watering.Size = new System.Drawing.Size(160, 80);
            this.btn_watering.TabIndex = 1;
            this.btn_watering.Text = "Irrigazione";
            this.btn_watering.UseVisualStyleBackColor = true;
            // 
            // btn_TV
            // 
            this.btn_TV.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_TV.BackgroundImage")));
            this.btn_TV.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_TV.Font = new System.Drawing.Font("Agency FB", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.btn_TV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(90)))), ((int)(((byte)(114)))));
            this.btn_TV.Location = new System.Drawing.Point(12, 197);
            this.btn_TV.Name = "btn_TV";
            this.btn_TV.Size = new System.Drawing.Size(160, 80);
            this.btn_TV.TabIndex = 2;
            this.btn_TV.Text = "TV";
            this.btn_TV.UseVisualStyleBackColor = true;
            // 
            // btn_lights
            // 
            this.btn_lights.BackColor = System.Drawing.SystemColors.Control;
            this.btn_lights.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_lights.BackgroundImage")));
            this.btn_lights.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_lights.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_lights.FlatAppearance.BorderSize = 0;
            this.btn_lights.Font = new System.Drawing.Font("Agency FB", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_lights.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(90)))), ((int)(((byte)(114)))));
            this.btn_lights.Location = new System.Drawing.Point(12, 111);
            this.btn_lights.Name = "btn_lights";
            this.btn_lights.Size = new System.Drawing.Size(160, 80);
            this.btn_lights.TabIndex = 3;
            this.btn_lights.Text = "Illuminazione";
            this.btn_lights.UseVisualStyleBackColor = false;
            this.btn_lights.Click += new System.EventHandler(this.btn_lights_Click);
            // 
            // lb_appTitle
            // 
            this.lb_appTitle.BackColor = System.Drawing.Color.Transparent;
            this.lb_appTitle.Font = new System.Drawing.Font("Agency FB", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_appTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(75)))), ((int)(((byte)(95)))));
            this.lb_appTitle.Location = new System.Drawing.Point(12, 15);
            this.lb_appTitle.Name = "lb_appTitle";
            this.lb_appTitle.Size = new System.Drawing.Size(160, 42);
            this.lb_appTitle.TabIndex = 4;
            this.lb_appTitle.Text = "MyHome";
            this.lb_appTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lb_appTitle.Click += new System.EventHandler(this.lb_appTitle_Click);
            // 
            // lb_subTitle
            // 
            this.lb_subTitle.BackColor = System.Drawing.Color.Transparent;
            this.lb_subTitle.Font = new System.Drawing.Font("Agency FB", 15F, System.Drawing.FontStyle.Bold);
            this.lb_subTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(90)))), ((int)(((byte)(114)))));
            this.lb_subTitle.Location = new System.Drawing.Point(12, 60);
            this.lb_subTitle.Name = "lb_subTitle";
            this.lb_subTitle.Size = new System.Drawing.Size(160, 42);
            this.lb_subTitle.TabIndex = 5;
            this.lb_subTitle.Text = "La tua app di domotica";
            this.lb_subTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lb_subTitle.UseMnemonic = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(184, 461);
            this.Controls.Add(this.lb_subTitle);
            this.Controls.Add(this.lb_appTitle);
            this.Controls.Add(this.btn_lights);
            this.Controls.Add(this.btn_TV);
            this.Controls.Add(this.btn_watering);
            this.Controls.Add(this.btn_entrances);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_entrances;
        private System.Windows.Forms.Button btn_watering;
        private System.Windows.Forms.Button btn_TV;
        private System.Windows.Forms.Button btn_lights;
        private System.Windows.Forms.Label lb_appTitle;
        private System.Windows.Forms.Label lb_subTitle;
    }
}

