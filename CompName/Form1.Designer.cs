namespace CompName
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblTimeZone = new System.Windows.Forms.Label();
            this.btnInject = new System.Windows.Forms.Button();
            this.cbTimeZone = new System.Windows.Forms.ComboBox();
            this.txtHostname = new System.Windows.Forms.TextBox();
            this.lblHostname = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSelectXML = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTimeZone
            // 
            this.lblTimeZone.AutoSize = true;
            this.lblTimeZone.Location = new System.Drawing.Point(166, 9);
            this.lblTimeZone.Name = "lblTimeZone";
            this.lblTimeZone.Size = new System.Drawing.Size(61, 13);
            this.lblTimeZone.TabIndex = 9;
            this.lblTimeZone.Text = "Time Zone:";
            // 
            // btnInject
            // 
            this.btnInject.Location = new System.Drawing.Point(109, 98);
            this.btnInject.Name = "btnInject";
            this.btnInject.Size = new System.Drawing.Size(132, 57);
            this.btnInject.TabIndex = 12;
            this.btnInject.Text = "Inject Into Unattend.xml";
            this.btnInject.UseVisualStyleBackColor = true;
            this.btnInject.TextChanged += new System.EventHandler(this.XmlFileExists);
            this.btnInject.Click += new System.EventHandler(this.btnInject_Click);
            // 
            // cbTimeZone
            // 
            this.cbTimeZone.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTimeZone.FormattingEnabled = true;
            this.cbTimeZone.Items.AddRange(new object[] {
            "---------- USA / Canada ----------",
            "Eastern Standard Time",
            "Central Standard Time",
            "Mountain Standard Time",
            "Pacific Standard Time",
            "Alaskan Standard Timeb",
            "Hawaiian Standard Time",
            "----------- International -----------",
            "Central Standard Time (Mexico)",
            "Mountain Standard Time (Mexico)",
            "China Standard Time",
            "Central Brazilian Standard Time",
            "E. Australia Standard Time",
            "Cen. Australia Standard Time",
            "W. Australia Standard Time"});
            this.cbTimeZone.Location = new System.Drawing.Point(169, 25);
            this.cbTimeZone.Name = "cbTimeZone";
            this.cbTimeZone.Size = new System.Drawing.Size(167, 21);
            this.cbTimeZone.TabIndex = 10;
            // 
            // txtHostname
            // 
            this.txtHostname.HideSelection = false;
            this.txtHostname.Location = new System.Drawing.Point(12, 25);
            this.txtHostname.Name = "txtHostname";
            this.txtHostname.Size = new System.Drawing.Size(151, 20);
            this.txtHostname.TabIndex = 14;
            this.txtHostname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblHostname
            // 
            this.lblHostname.AutoSize = true;
            this.lblHostname.Location = new System.Drawing.Point(50, 9);
            this.lblHostname.Name = "lblHostname";
            this.lblHostname.Size = new System.Drawing.Size(55, 13);
            this.lblHostname.TabIndex = 15;
            this.lblHostname.Text = "Hostname";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 66);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(239, 20);
            this.textBox1.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Unattend.xml Location:";
            // 
            // btnSelectXML
            // 
            this.btnSelectXML.Location = new System.Drawing.Point(257, 56);
            this.btnSelectXML.Name = "btnSelectXML";
            this.btnSelectXML.Size = new System.Drawing.Size(79, 38);
            this.btnSelectXML.TabIndex = 18;
            this.btnSelectXML.Text = "Select Unattend.xml";
            this.btnSelectXML.UseVisualStyleBackColor = true;
            this.btnSelectXML.Click += new System.EventHandler(this.btnSelectXML_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(61, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(228, 12);
            this.label2.TabIndex = 19;
            this.label2.Text = "Copyright © 2020 Joshua Parnell - All Rights Reserved";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 189);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSelectXML);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtHostname);
            this.Controls.Add(this.lblHostname);
            this.Controls.Add(this.btnInject);
            this.Controls.Add(this.cbTimeZone);
            this.Controls.Add(this.lblTimeZone);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "CompName++";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.Form1_PreviewKeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTimeZone;
        private System.Windows.Forms.Button btnInject;
        private System.Windows.Forms.ComboBox cbTimeZone;
        private System.Windows.Forms.TextBox txtHostname;
        private System.Windows.Forms.Label lblHostname;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSelectXML;
        private System.Windows.Forms.Label label2;
    }
}

