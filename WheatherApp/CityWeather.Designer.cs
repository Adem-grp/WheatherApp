using System.Windows.Forms;

namespace WheatherApp
{
    partial class CityWeather
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
            this.buttonRef = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // buttonRef
            // 
            this.buttonRef.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.buttonRef.Location = new System.Drawing.Point(1082, 659);
            this.buttonRef.Name = "buttonRef";
            this.buttonRef.Size = new System.Drawing.Size(127, 97);
            this.buttonRef.TabIndex = 0;
            this.buttonRef.Text = "Refresh";
            this.buttonRef.UseVisualStyleBackColor = false;
            this.buttonRef.Click += new System.EventHandler(this.buttonRef_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Gainsboro;
            this.flowLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(70, 61);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(582, 574);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // CityWeather
            // 
            
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WheatherApp.Properties.Resources.weather;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1245, 801);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.buttonRef);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CityWeather_FormClosed);
            this.Name = "CityWeather";
            this.Text = "CityWeather";
            this.Load += new System.EventHandler(this.CityWeather_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonRef;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}