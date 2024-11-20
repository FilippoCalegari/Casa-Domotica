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
            this.panel_App = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_signIn = new System.Windows.Forms.Button();
            this.btn_login = new System.Windows.Forms.Button();
            this.tb_insertPassword = new System.Windows.Forms.TextBox();
            this.lb_insertPassword = new System.Windows.Forms.Label();
            this.tb_insertName = new System.Windows.Forms.TextBox();
            this.lb_insertName = new System.Windows.Forms.Label();
            this.lb_appTitleCred = new System.Windows.Forms.Label();
            this.lb_orSignIn = new System.Windows.Forms.Label();
            this.panel_App.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_entrances
            // 
            this.btn_entrances.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_entrances.BackgroundImage")));
            this.btn_entrances.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_entrances.Font = new System.Drawing.Font("Agency FB", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.btn_entrances.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(90)))), ((int)(((byte)(114)))));
            this.btn_entrances.Location = new System.Drawing.Point(0, 354);
            this.btn_entrances.Name = "btn_entrances";
            this.btn_entrances.Size = new System.Drawing.Size(160, 80);
            this.btn_entrances.TabIndex = 0;
            this.btn_entrances.Text = "Porte";
            this.btn_entrances.UseVisualStyleBackColor = true;
            this.btn_entrances.Click += new System.EventHandler(this.btn_entrances_Click);
            // 
            // btn_watering
            // 
            this.btn_watering.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_watering.BackgroundImage")));
            this.btn_watering.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_watering.Font = new System.Drawing.Font("Agency FB", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.btn_watering.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(90)))), ((int)(((byte)(114)))));
            this.btn_watering.Location = new System.Drawing.Point(0, 268);
            this.btn_watering.Name = "btn_watering";
            this.btn_watering.Size = new System.Drawing.Size(160, 80);
            this.btn_watering.TabIndex = 1;
            this.btn_watering.Text = "Irrigazione";
            this.btn_watering.UseVisualStyleBackColor = true;
            this.btn_watering.Click += new System.EventHandler(this.btn_watering_Click);
            // 
            // btn_TV
            // 
            this.btn_TV.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_TV.BackgroundImage")));
            this.btn_TV.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_TV.Font = new System.Drawing.Font("Agency FB", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.btn_TV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(90)))), ((int)(((byte)(114)))));
            this.btn_TV.Location = new System.Drawing.Point(0, 182);
            this.btn_TV.Name = "btn_TV";
            this.btn_TV.Size = new System.Drawing.Size(160, 80);
            this.btn_TV.TabIndex = 2;
            this.btn_TV.Text = "TV";
            this.btn_TV.UseVisualStyleBackColor = true;
            this.btn_TV.Click += new System.EventHandler(this.btn_TV_Click);
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
            this.btn_lights.Location = new System.Drawing.Point(0, 96);
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
            this.lb_appTitle.Location = new System.Drawing.Point(0, 0);
            this.lb_appTitle.Name = "lb_appTitle";
            this.lb_appTitle.Size = new System.Drawing.Size(159, 42);
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
            this.lb_subTitle.Location = new System.Drawing.Point(0, 45);
            this.lb_subTitle.Name = "lb_subTitle";
            this.lb_subTitle.Size = new System.Drawing.Size(160, 42);
            this.lb_subTitle.TabIndex = 5;
            this.lb_subTitle.Text = "La tua app di domotica";
            this.lb_subTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lb_subTitle.UseMnemonic = false;
            // 
            // panel_App
            // 
            this.panel_App.BackColor = System.Drawing.Color.Transparent;
            this.panel_App.Controls.Add(this.btn_lights);
            this.panel_App.Controls.Add(this.lb_subTitle);
            this.panel_App.Controls.Add(this.btn_entrances);
            this.panel_App.Controls.Add(this.lb_appTitle);
            this.panel_App.Controls.Add(this.btn_watering);
            this.panel_App.Controls.Add(this.btn_TV);
            this.panel_App.Location = new System.Drawing.Point(12, 12);
            this.panel_App.Name = "panel_App";
            this.panel_App.Size = new System.Drawing.Size(159, 435);
            this.panel_App.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BackgroundImage = global::Proprietari_di_casa__Client_.Properties.Resources.Gradient_Background_Credentials;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.lb_orSignIn);
            this.panel1.Controls.Add(this.btn_signIn);
            this.panel1.Controls.Add(this.btn_login);
            this.panel1.Controls.Add(this.tb_insertPassword);
            this.panel1.Controls.Add(this.lb_insertPassword);
            this.panel1.Controls.Add(this.tb_insertName);
            this.panel1.Controls.Add(this.lb_insertName);
            this.panel1.Controls.Add(this.lb_appTitleCred);
            this.panel1.Location = new System.Drawing.Point(276, 14);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(159, 435);
            this.panel1.TabIndex = 7;
            // 
            // btn_signIn
            // 
            this.btn_signIn.BackColor = System.Drawing.SystemColors.Control;
            this.btn_signIn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_signIn.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_signIn.FlatAppearance.BorderSize = 0;
            this.btn_signIn.Font = new System.Drawing.Font("Agency FB", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_signIn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(90)))), ((int)(((byte)(114)))));
            this.btn_signIn.Location = new System.Drawing.Point(3, 408);
            this.btn_signIn.Name = "btn_signIn";
            this.btn_signIn.Size = new System.Drawing.Size(153, 24);
            this.btn_signIn.TabIndex = 11;
            this.btn_signIn.Text = "Registrati";
            this.btn_signIn.UseVisualStyleBackColor = false;
            // 
            // btn_login
            // 
            this.btn_login.BackColor = System.Drawing.SystemColors.Control;
            this.btn_login.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_login.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_login.FlatAppearance.BorderSize = 0;
            this.btn_login.Font = new System.Drawing.Font("Agency FB", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_login.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(90)))), ((int)(((byte)(114)))));
            this.btn_login.Location = new System.Drawing.Point(3, 289);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(153, 35);
            this.btn_login.TabIndex = 6;
            this.btn_login.Text = "Accedi";
            this.btn_login.UseVisualStyleBackColor = false;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // tb_insertPassword
            // 
            this.tb_insertPassword.Location = new System.Drawing.Point(3, 248);
            this.tb_insertPassword.Name = "tb_insertPassword";
            this.tb_insertPassword.Size = new System.Drawing.Size(153, 20);
            this.tb_insertPassword.TabIndex = 10;
            // 
            // lb_insertPassword
            // 
            this.lb_insertPassword.BackColor = System.Drawing.Color.Transparent;
            this.lb_insertPassword.Font = new System.Drawing.Font("Agency FB", 15F, System.Drawing.FontStyle.Bold);
            this.lb_insertPassword.ForeColor = System.Drawing.Color.White;
            this.lb_insertPassword.Location = new System.Drawing.Point(-1, 203);
            this.lb_insertPassword.Name = "lb_insertPassword";
            this.lb_insertPassword.Size = new System.Drawing.Size(160, 42);
            this.lb_insertPassword.TabIndex = 9;
            this.lb_insertPassword.Text = "Inserisci la password";
            this.lb_insertPassword.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lb_insertPassword.UseMnemonic = false;
            // 
            // tb_insertName
            // 
            this.tb_insertName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_insertName.Location = new System.Drawing.Point(3, 180);
            this.tb_insertName.Name = "tb_insertName";
            this.tb_insertName.Size = new System.Drawing.Size(153, 20);
            this.tb_insertName.TabIndex = 8;
            // 
            // lb_insertName
            // 
            this.lb_insertName.BackColor = System.Drawing.Color.Transparent;
            this.lb_insertName.Font = new System.Drawing.Font("Agency FB", 15F, System.Drawing.FontStyle.Bold);
            this.lb_insertName.ForeColor = System.Drawing.Color.White;
            this.lb_insertName.Location = new System.Drawing.Point(-1, 135);
            this.lb_insertName.Name = "lb_insertName";
            this.lb_insertName.Size = new System.Drawing.Size(160, 42);
            this.lb_insertName.TabIndex = 6;
            this.lb_insertName.Text = "Inserisci il nome";
            this.lb_insertName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lb_insertName.UseMnemonic = false;
            // 
            // lb_appTitleCred
            // 
            this.lb_appTitleCred.BackColor = System.Drawing.Color.Transparent;
            this.lb_appTitleCred.Font = new System.Drawing.Font("Agency FB", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_appTitleCred.ForeColor = System.Drawing.Color.White;
            this.lb_appTitleCred.Location = new System.Drawing.Point(0, 77);
            this.lb_appTitleCred.Name = "lb_appTitleCred";
            this.lb_appTitleCred.Size = new System.Drawing.Size(159, 42);
            this.lb_appTitleCred.TabIndex = 4;
            this.lb_appTitleCred.Text = "MyHome";
            this.lb_appTitleCred.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_orSignIn
            // 
            this.lb_orSignIn.BackColor = System.Drawing.Color.Transparent;
            this.lb_orSignIn.Font = new System.Drawing.Font("Agency FB", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_orSignIn.ForeColor = System.Drawing.Color.White;
            this.lb_orSignIn.Location = new System.Drawing.Point(0, 363);
            this.lb_orSignIn.Name = "lb_orSignIn";
            this.lb_orSignIn.Size = new System.Drawing.Size(159, 42);
            this.lb_orSignIn.TabIndex = 12;
            this.lb_orSignIn.Text = "oppure";
            this.lb_orSignIn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lb_orSignIn.UseMnemonic = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(507, 461);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel_App);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel_App.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_entrances;
        private System.Windows.Forms.Button btn_watering;
        private System.Windows.Forms.Button btn_TV;
        private System.Windows.Forms.Button btn_lights;
        private System.Windows.Forms.Label lb_subTitle;
        private System.Windows.Forms.Panel panel_App;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lb_appTitleCred;
        private System.Windows.Forms.Label lb_appTitle;
        private System.Windows.Forms.Label lb_insertName;
        private System.Windows.Forms.TextBox tb_insertName;
        private System.Windows.Forms.TextBox tb_insertPassword;
        private System.Windows.Forms.Label lb_insertPassword;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Button btn_signIn;
        private System.Windows.Forms.Label lb_orSignIn;
    }
}

