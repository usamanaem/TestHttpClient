namespace TestHttpClient
{
    partial class Form1
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
            this.ddlCountry = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ddlCity = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ddlProviderType = new System.Windows.Forms.ComboBox();
            this.btnGetProviders = new System.Windows.Forms.Button();
            this.lstValues = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // ddlCountry
            // 
            this.ddlCountry.FormattingEnabled = true;
            this.ddlCountry.Location = new System.Drawing.Point(61, 24);
            this.ddlCountry.Name = "ddlCountry";
            this.ddlCountry.Size = new System.Drawing.Size(121, 21);
            this.ddlCountry.TabIndex = 0;
            this.ddlCountry.SelectedIndexChanged += new System.EventHandler(this.ddlCountry_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Country:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(201, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "City: ";
            // 
            // ddlCity
            // 
            this.ddlCity.FormattingEnabled = true;
            this.ddlCity.Location = new System.Drawing.Point(237, 23);
            this.ddlCity.Name = "ddlCity";
            this.ddlCity.Size = new System.Drawing.Size(121, 21);
            this.ddlCity.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(390, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Provider Type: ";
            // 
            // ddlProviderType
            // 
            this.ddlProviderType.FormattingEnabled = true;
            this.ddlProviderType.Items.AddRange(new object[] {
            "Hospitals",
            "Doctors and Health Practitioners"});
            this.ddlProviderType.Location = new System.Drawing.Point(475, 24);
            this.ddlProviderType.Name = "ddlProviderType";
            this.ddlProviderType.Size = new System.Drawing.Size(121, 21);
            this.ddlProviderType.TabIndex = 5;
            // 
            // btnGetProviders
            // 
            this.btnGetProviders.Location = new System.Drawing.Point(237, 63);
            this.btnGetProviders.Name = "btnGetProviders";
            this.btnGetProviders.Size = new System.Drawing.Size(98, 23);
            this.btnGetProviders.TabIndex = 6;
            this.btnGetProviders.Text = "Get Providers";
            this.btnGetProviders.UseVisualStyleBackColor = true;
            this.btnGetProviders.Click += new System.EventHandler(this.btnGetProviders_Click);
            // 
            // lstValues
            // 
            this.lstValues.FormattingEnabled = true;
            this.lstValues.Location = new System.Drawing.Point(75, 115);
            this.lstValues.Name = "lstValues";
            this.lstValues.Size = new System.Drawing.Size(283, 316);
            this.lstValues.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 488);
            this.Controls.Add(this.lstValues);
            this.Controls.Add(this.btnGetProviders);
            this.Controls.Add(this.ddlProviderType);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ddlCity);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ddlCountry);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ddlCountry;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox ddlCity;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox ddlProviderType;
        private System.Windows.Forms.Button btnGetProviders;
        private System.Windows.Forms.ListBox lstValues;
    }
}

