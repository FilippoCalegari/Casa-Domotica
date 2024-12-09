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
            this.pan_credInterface = new System.Windows.Forms.Panel();
            this.lb_accessRules = new System.Windows.Forms.Label();
            this.lb_orSignIn = new System.Windows.Forms.Label();
            this.btn_signIn = new System.Windows.Forms.Button();
            this.btn_login = new System.Windows.Forms.Button();
            this.tb_insertPassword = new System.Windows.Forms.TextBox();
            this.lb_insertPassword = new System.Windows.Forms.Label();
            this.tb_insertName = new System.Windows.Forms.TextBox();
            this.lb_insertName = new System.Windows.Forms.Label();
            this.lb_appTitleCred = new System.Windows.Forms.Label();
            this.pan_signUp = new System.Windows.Forms.Panel();
            this.tb_registerUsername = new System.Windows.Forms.TextBox();
            this.btn_signUp = new System.Windows.Forms.Button();
            this.tb_registerPassword = new System.Windows.Forms.TextBox();
            this.lb_registerUsername = new System.Windows.Forms.Label();
            this.lb_registerPassword = new System.Windows.Forms.Label();
            this.tb_registerName = new System.Windows.Forms.TextBox();
            this.lb_registerName = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel_App.SuspendLayout();
            this.pan_credInterface.SuspendLayout();
            this.pan_signUp.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_entrances
            // 
            this.btn_entrances.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_entrances.BackgroundImage")));
            this.btn_entrances.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_entrances.Font = new System.Drawing.Font("Agency FB", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.btn_entrances.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(90)))), ((int)(((byte)(114)))));
            this.btn_entrances.Location = new System.Drawing.Point(0, 545);
            this.btn_entrances.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_entrances.Name = "btn_entrances";
            this.btn_entrances.Size = new System.Drawing.Size(240, 123);
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
            this.btn_watering.Location = new System.Drawing.Point(0, 412);
            this.btn_watering.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_watering.Name = "btn_watering";
            this.btn_watering.Size = new System.Drawing.Size(240, 123);
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
            this.btn_TV.Location = new System.Drawing.Point(0, 280);
            this.btn_TV.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_TV.Name = "btn_TV";
            this.btn_TV.Size = new System.Drawing.Size(240, 123);
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
            this.btn_lights.Location = new System.Drawing.Point(0, 148);
            this.btn_lights.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_lights.Name = "btn_lights";
            this.btn_lights.Size = new System.Drawing.Size(240, 123);
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
            this.lb_appTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_appTitle.Name = "lb_appTitle";
            this.lb_appTitle.Size = new System.Drawing.Size(238, 65);
            this.lb_appTitle.TabIndex = 4;
            this.lb_appTitle.Text = "MyHome";
            this.lb_appTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lb_appTitle.Click += new System.EventHandler(this.lb_appTitle_Click);
            // 
            // lb_subTitle
            // 
            this.lb_subTitle.BackColor = System.Drawing.Color.Transparent;
            this.lb_subTitle.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_subTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(90)))), ((int)(((byte)(114)))));
            this.lb_subTitle.Location = new System.Drawing.Point(0, 69);
            this.lb_subTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_subTitle.Name = "lb_subTitle";
            this.lb_subTitle.Size = new System.Drawing.Size(240, 74);
            this.lb_subTitle.TabIndex = 5;
            this.lb_subTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel_App
            // 
            this.panel_App.BackColor = System.Drawing.Color.Transparent;
            this.panel_App.Controls.Add(this.pan_credInterface);
            this.panel_App.Controls.Add(this.btn_lights);
            this.panel_App.Controls.Add(this.lb_subTitle);
            this.panel_App.Controls.Add(this.btn_entrances);
            this.panel_App.Controls.Add(this.lb_appTitle);
            this.panel_App.Controls.Add(this.btn_watering);
            this.panel_App.Controls.Add(this.btn_TV);
            this.panel_App.Location = new System.Drawing.Point(0, 0);
            this.panel_App.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel_App.Name = "panel_App";
            this.panel_App.Size = new System.Drawing.Size(238, 669);
            this.panel_App.TabIndex = 6;
            // 
            // pan_credInterface
            // 
            this.pan_credInterface.BackColor = System.Drawing.Color.White;
            this.pan_credInterface.BackgroundImage = global::Proprietari_di_casa__Client_.Properties.Resources.Gradient_Background_Credentials;
            this.pan_credInterface.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pan_credInterface.Controls.Add(this.lb_accessRules);
            this.pan_credInterface.Controls.Add(this.lb_orSignIn);
            this.pan_credInterface.Controls.Add(this.btn_signIn);
            this.pan_credInterface.Controls.Add(this.btn_login);
            this.pan_credInterface.Controls.Add(this.tb_insertPassword);
            this.pan_credInterface.Controls.Add(this.lb_insertPassword);
            this.pan_credInterface.Controls.Add(this.tb_insertName);
            this.pan_credInterface.Controls.Add(this.lb_insertName);
            this.pan_credInterface.Controls.Add(this.lb_appTitleCred);
            this.pan_credInterface.Location = new System.Drawing.Point(0, 0);
            this.pan_credInterface.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pan_credInterface.Name = "pan_credInterface";
            this.pan_credInterface.Size = new System.Drawing.Size(238, 669);
            this.pan_credInterface.TabIndex = 7;
            this.pan_credInterface.Paint += new System.Windows.Forms.PaintEventHandler(this.pan_credInterface_Paint);
            // 
            // lb_accessRules
            // 
            this.lb_accessRules.BackColor = System.Drawing.Color.Transparent;
            this.lb_accessRules.Font = new System.Drawing.Font("Agency FB", 15F, System.Drawing.FontStyle.Bold);
            this.lb_accessRules.ForeColor = System.Drawing.Color.White;
            this.lb_accessRules.Location = new System.Drawing.Point(0, 503);
            this.lb_accessRules.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_accessRules.Name = "lb_accessRules";
            this.lb_accessRules.Size = new System.Drawing.Size(238, 85);
            this.lb_accessRules.TabIndex = 13;
            this.lb_accessRules.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lb_accessRules.UseMnemonic = false;
            // 
            // lb_orSignIn
            // 
            this.lb_orSignIn.BackColor = System.Drawing.Color.Transparent;
            this.lb_orSignIn.Font = new System.Drawing.Font("Agency FB", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_orSignIn.ForeColor = System.Drawing.Color.White;
            this.lb_orSignIn.Location = new System.Drawing.Point(0, 543);
            this.lb_orSignIn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_orSignIn.Name = "lb_orSignIn";
            this.lb_orSignIn.Size = new System.Drawing.Size(238, 65);
            this.lb_orSignIn.TabIndex = 12;
            this.lb_orSignIn.Text = "oppure";
            this.lb_orSignIn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lb_orSignIn.UseMnemonic = false;
            // 
            // btn_signIn
            // 
            this.btn_signIn.BackColor = System.Drawing.SystemColors.Control;
            this.btn_signIn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_signIn.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_signIn.FlatAppearance.BorderSize = 0;
            this.btn_signIn.Font = new System.Drawing.Font("Agency FB", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_signIn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(90)))), ((int)(((byte)(114)))));
            this.btn_signIn.Location = new System.Drawing.Point(4, 612);
            this.btn_signIn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_signIn.Name = "btn_signIn";
            this.btn_signIn.Size = new System.Drawing.Size(230, 37);
            this.btn_signIn.TabIndex = 11;
            this.btn_signIn.Text = "Registrati";
            this.btn_signIn.UseVisualStyleBackColor = false;
            this.btn_signIn.Click += new System.EventHandler(this.btn_signIn_Click);
            // 
            // btn_login
            // 
            this.btn_login.BackColor = System.Drawing.SystemColors.Control;
            this.btn_login.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_login.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_login.FlatAppearance.BorderSize = 0;
            this.btn_login.Font = new System.Drawing.Font("Agency FB", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_login.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(90)))), ((int)(((byte)(114)))));
            this.btn_login.Location = new System.Drawing.Point(4, 445);
            this.btn_login.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(230, 54);
            this.btn_login.TabIndex = 6;
            this.btn_login.Text = "Accedi";
            this.btn_login.UseVisualStyleBackColor = false;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // tb_insertPassword
            // 
            this.tb_insertPassword.Location = new System.Drawing.Point(4, 382);
            this.tb_insertPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_insertPassword.Name = "tb_insertPassword";
            this.tb_insertPassword.Size = new System.Drawing.Size(228, 26);
            this.tb_insertPassword.TabIndex = 10;
            // 
            // lb_insertPassword
            // 
            this.lb_insertPassword.BackColor = System.Drawing.Color.Transparent;
            this.lb_insertPassword.Font = new System.Drawing.Font("Agency FB", 15F, System.Drawing.FontStyle.Bold);
            this.lb_insertPassword.ForeColor = System.Drawing.Color.White;
            this.lb_insertPassword.Location = new System.Drawing.Point(0, 312);
            this.lb_insertPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_insertPassword.Name = "lb_insertPassword";
            this.lb_insertPassword.Size = new System.Drawing.Size(238, 65);
            this.lb_insertPassword.TabIndex = 9;
            this.lb_insertPassword.Text = "Inserisci la password";
            this.lb_insertPassword.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lb_insertPassword.UseMnemonic = false;
            // 
            // tb_insertName
            // 
            this.tb_insertName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_insertName.Location = new System.Drawing.Point(4, 277);
            this.tb_insertName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_insertName.Name = "tb_insertName";
            this.tb_insertName.Size = new System.Drawing.Size(228, 26);
            this.tb_insertName.TabIndex = 8;
            // 
            // lb_insertName
            // 
            this.lb_insertName.BackColor = System.Drawing.Color.Transparent;
            this.lb_insertName.Font = new System.Drawing.Font("Agency FB", 15F, System.Drawing.FontStyle.Bold);
            this.lb_insertName.ForeColor = System.Drawing.Color.White;
            this.lb_insertName.Location = new System.Drawing.Point(0, 208);
            this.lb_insertName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_insertName.Name = "lb_insertName";
            this.lb_insertName.Size = new System.Drawing.Size(238, 65);
            this.lb_insertName.TabIndex = 6;
            this.lb_insertName.Text = "Inserisci l\'username";
            this.lb_insertName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lb_insertName.UseMnemonic = false;
            // 
            // lb_appTitleCred
            // 
            this.lb_appTitleCred.BackColor = System.Drawing.Color.Transparent;
            this.lb_appTitleCred.Font = new System.Drawing.Font("Agency FB", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_appTitleCred.ForeColor = System.Drawing.Color.White;
            this.lb_appTitleCred.Location = new System.Drawing.Point(0, 118);
            this.lb_appTitleCred.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_appTitleCred.Name = "lb_appTitleCred";
            this.lb_appTitleCred.Size = new System.Drawing.Size(238, 65);
            this.lb_appTitleCred.TabIndex = 4;
            this.lb_appTitleCred.Text = "MyHome";
            this.lb_appTitleCred.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pan_signUp
            // 
            this.pan_signUp.BackColor = System.Drawing.Color.White;
            this.pan_signUp.BackgroundImage = global::Proprietari_di_casa__Client_.Properties.Resources.Gradient_Background_Credentials;
            this.pan_signUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pan_signUp.Controls.Add(this.tb_registerUsername);
            this.pan_signUp.Controls.Add(this.btn_signUp);
            this.pan_signUp.Controls.Add(this.tb_registerPassword);
            this.pan_signUp.Controls.Add(this.lb_registerUsername);
            this.pan_signUp.Controls.Add(this.lb_registerPassword);
            this.pan_signUp.Controls.Add(this.tb_registerName);
            this.pan_signUp.Controls.Add(this.lb_registerName);
            this.pan_signUp.Controls.Add(this.label5);
            this.pan_signUp.Location = new System.Drawing.Point(277, 0);
            this.pan_signUp.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pan_signUp.Name = "pan_signUp";
            this.pan_signUp.Size = new System.Drawing.Size(238, 669);
            this.pan_signUp.TabIndex = 14;
            this.pan_signUp.Visible = false;
            // 
            // tb_registerUsername
            // 
            this.tb_registerUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_registerUsername.Location = new System.Drawing.Point(4, 381);
            this.tb_registerUsername.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_registerUsername.Name = "tb_registerUsername";
            this.tb_registerUsername.Size = new System.Drawing.Size(228, 26);
            this.tb_registerUsername.TabIndex = 12;
            // 
            // btn_signUp
            // 
            this.btn_signUp.BackColor = System.Drawing.SystemColors.Control;
            this.btn_signUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_signUp.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_signUp.FlatAppearance.BorderSize = 0;
            this.btn_signUp.Font = new System.Drawing.Font("Agency FB", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_signUp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(90)))), ((int)(((byte)(114)))));
            this.btn_signUp.Location = new System.Drawing.Point(4, 531);
            this.btn_signUp.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_signUp.Name = "btn_signUp";
            this.btn_signUp.Size = new System.Drawing.Size(230, 54);
            this.btn_signUp.TabIndex = 6;
            this.btn_signUp.Text = "Registrati";
            this.btn_signUp.UseVisualStyleBackColor = false;
            this.btn_signUp.Click += new System.EventHandler(this.btn_signUp_Click);
            // 
            // tb_registerPassword
            // 
            this.tb_registerPassword.Location = new System.Drawing.Point(4, 482);
            this.tb_registerPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_registerPassword.Name = "tb_registerPassword";
            this.tb_registerPassword.Size = new System.Drawing.Size(228, 26);
            this.tb_registerPassword.TabIndex = 10;
            // 
            // lb_registerUsername
            // 
            this.lb_registerUsername.BackColor = System.Drawing.Color.Transparent;
            this.lb_registerUsername.Font = new System.Drawing.Font("Agency FB", 15F, System.Drawing.FontStyle.Bold);
            this.lb_registerUsername.ForeColor = System.Drawing.Color.White;
            this.lb_registerUsername.Location = new System.Drawing.Point(0, 312);
            this.lb_registerUsername.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_registerUsername.Name = "lb_registerUsername";
            this.lb_registerUsername.Size = new System.Drawing.Size(238, 65);
            this.lb_registerUsername.TabIndex = 11;
            this.lb_registerUsername.Text = "Registra l\'username";
            this.lb_registerUsername.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lb_registerUsername.UseMnemonic = false;
            // 
            // lb_registerPassword
            // 
            this.lb_registerPassword.BackColor = System.Drawing.Color.Transparent;
            this.lb_registerPassword.Font = new System.Drawing.Font("Agency FB", 15F, System.Drawing.FontStyle.Bold);
            this.lb_registerPassword.ForeColor = System.Drawing.Color.White;
            this.lb_registerPassword.Location = new System.Drawing.Point(0, 412);
            this.lb_registerPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_registerPassword.Name = "lb_registerPassword";
            this.lb_registerPassword.Size = new System.Drawing.Size(238, 65);
            this.lb_registerPassword.TabIndex = 9;
            this.lb_registerPassword.Text = "Registra la password";
            this.lb_registerPassword.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lb_registerPassword.UseMnemonic = false;
            // 
            // tb_registerName
            // 
            this.tb_registerName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_registerName.Location = new System.Drawing.Point(4, 277);
            this.tb_registerName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_registerName.Name = "tb_registerName";
            this.tb_registerName.Size = new System.Drawing.Size(228, 26);
            this.tb_registerName.TabIndex = 8;
            // 
            // lb_registerName
            // 
            this.lb_registerName.BackColor = System.Drawing.Color.Transparent;
            this.lb_registerName.Font = new System.Drawing.Font("Agency FB", 15F, System.Drawing.FontStyle.Bold);
            this.lb_registerName.ForeColor = System.Drawing.Color.White;
            this.lb_registerName.Location = new System.Drawing.Point(0, 208);
            this.lb_registerName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_registerName.Name = "lb_registerName";
            this.lb_registerName.Size = new System.Drawing.Size(238, 65);
            this.lb_registerName.TabIndex = 6;
            this.lb_registerName.Text = "Registra il nome";
            this.lb_registerName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lb_registerName.UseMnemonic = false;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Agency FB", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(0, 118);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(238, 65);
            this.label5.TabIndex = 4;
            this.label5.Text = "MyHome";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(788, 890);
            this.Controls.Add(this.pan_signUp);
            this.Controls.Add(this.panel_App);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel_App.ResumeLayout(false);
            this.pan_credInterface.ResumeLayout(false);
            this.pan_credInterface.PerformLayout();
            this.pan_signUp.ResumeLayout(false);
            this.pan_signUp.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_entrances;
        private System.Windows.Forms.Button btn_watering;
        private System.Windows.Forms.Button btn_TV;
        private System.Windows.Forms.Button btn_lights;
        private System.Windows.Forms.Label lb_subTitle;
        private System.Windows.Forms.Panel panel_App;
        private System.Windows.Forms.Panel pan_credInterface;
        private System.Windows.Forms.Label lb_appTitleCred;
        private System.Windows.Forms.Label lb_appTitle;
        private System.Windows.Forms.Label lb_insertName;
        private System.Windows.Forms.TextBox tb_insertName;
        private System.Windows.Forms.TextBox tb_insertPassword;
        private System.Windows.Forms.Label lb_insertPassword;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Button btn_signIn;
        private System.Windows.Forms.Label lb_orSignIn;
        private System.Windows.Forms.Label lb_accessRules;
        private System.Windows.Forms.Panel pan_signUp;
        private System.Windows.Forms.TextBox tb_registerUsername;
        private System.Windows.Forms.Button btn_signUp;
        private System.Windows.Forms.TextBox tb_registerPassword;
        private System.Windows.Forms.Label lb_registerUsername;
        private System.Windows.Forms.Label lb_registerPassword;
        private System.Windows.Forms.TextBox tb_registerName;
        private System.Windows.Forms.Label lb_registerName;
        private System.Windows.Forms.Label label5;
    }
}

