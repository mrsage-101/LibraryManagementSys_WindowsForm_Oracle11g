namespace LibraryManagementSystem
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExitclick = new System.Windows.Forms.Button();
            this.btnStudentclick = new System.Windows.Forms.Button();
            this.btnAdminclick = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.btnExitclick);
            this.panel1.Controls.Add(this.btnStudentclick);
            this.panel1.Controls.Add(this.btnAdminclick);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(10, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1031, 511);
            this.panel1.TabIndex = 0;
            // 
            // btnExitclick
            // 
            this.btnExitclick.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExitclick.BackgroundImage")));
            this.btnExitclick.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExitclick.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnExitclick.Location = new System.Drawing.Point(508, 302);
            this.btnExitclick.Name = "btnExitclick";
            this.btnExitclick.Size = new System.Drawing.Size(124, 43);
            this.btnExitclick.TabIndex = 3;
            this.btnExitclick.Text = "EXIT";
            this.btnExitclick.UseVisualStyleBackColor = true;
            this.btnExitclick.Click += new System.EventHandler(this.btnExitclick_Click);
            // 
            // btnStudentclick
            // 
            this.btnStudentclick.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnStudentclick.BackgroundImage")));
            this.btnStudentclick.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStudentclick.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnStudentclick.Location = new System.Drawing.Point(508, 235);
            this.btnStudentclick.Name = "btnStudentclick";
            this.btnStudentclick.Size = new System.Drawing.Size(124, 43);
            this.btnStudentclick.TabIndex = 2;
            this.btnStudentclick.Text = "STUDENT";
            this.btnStudentclick.UseVisualStyleBackColor = true;
            this.btnStudentclick.Click += new System.EventHandler(this.btnStudentclick_Click);
            // 
            // btnAdminclick
            // 
            this.btnAdminclick.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAdminclick.BackgroundImage")));
            this.btnAdminclick.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdminclick.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAdminclick.Location = new System.Drawing.Point(508, 168);
            this.btnAdminclick.Name = "btnAdminclick";
            this.btnAdminclick.Size = new System.Drawing.Size(124, 43);
            this.btnAdminclick.TabIndex = 1;
            this.btnAdminclick.Text = "ADMIN";
            this.btnAdminclick.UseVisualStyleBackColor = true;
            this.btnAdminclick.Click += new System.EventHandler(this.btnAdminclick_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(333, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(507, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "LIBRARY MANAGEMENT SYSTEM";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1053, 546);
            this.Controls.Add(this.panel1);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnExitclick;
        private System.Windows.Forms.Button btnStudentclick;
        private System.Windows.Forms.Button btnAdminclick;
        private System.Windows.Forms.Label label1;
    }
}

