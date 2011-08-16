namespace multiconvert_html
{
    partial class frmMain
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
            this.txtRaw = new System.Windows.Forms.TextBox();
            this.txtHTML = new System.Windows.Forms.TextBox();
            this.txtURL = new System.Windows.Forms.TextBox();
            this.lblRaw = new System.Windows.Forms.Label();
            this.lblUrl = new System.Windows.Forms.Label();
            this.lblHTML = new System.Windows.Forms.Label();
            this.tplMain = new System.Windows.Forms.TableLayoutPanel();
            this.btnURL = new System.Windows.Forms.Button();
            this.btnHTML = new System.Windows.Forms.Button();
            this.btnRaw = new System.Windows.Forms.Button();
            this.tplMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtRaw
            // 
            this.txtRaw.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtRaw.Location = new System.Drawing.Point(3, 25);
            this.txtRaw.Multiline = true;
            this.txtRaw.Name = "txtRaw";
            this.txtRaw.Size = new System.Drawing.Size(227, 236);
            this.txtRaw.TabIndex = 0;
            // 
            // txtHTML
            // 
            this.txtHTML.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtHTML.Location = new System.Drawing.Point(476, 25);
            this.txtHTML.Multiline = true;
            this.txtHTML.Name = "txtHTML";
            this.txtHTML.Size = new System.Drawing.Size(228, 236);
            this.txtHTML.TabIndex = 1;
            // 
            // txtURL
            // 
            this.txtURL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtURL.Location = new System.Drawing.Point(236, 25);
            this.txtURL.Multiline = true;
            this.txtURL.Name = "txtURL";
            this.txtURL.Size = new System.Drawing.Size(234, 236);
            this.txtURL.TabIndex = 2;
            // 
            // lblRaw
            // 
            this.lblRaw.AutoSize = true;
            this.lblRaw.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblRaw.Location = new System.Drawing.Point(3, 0);
            this.lblRaw.Name = "lblRaw";
            this.lblRaw.Size = new System.Drawing.Size(227, 22);
            this.lblRaw.TabIndex = 3;
            this.lblRaw.Text = "Raw data :";
            this.lblRaw.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblUrl
            // 
            this.lblUrl.AutoSize = true;
            this.lblUrl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblUrl.Location = new System.Drawing.Point(236, 0);
            this.lblUrl.Name = "lblUrl";
            this.lblUrl.Size = new System.Drawing.Size(234, 22);
            this.lblUrl.TabIndex = 4;
            this.lblUrl.Text = "URL data";
            this.lblUrl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblHTML
            // 
            this.lblHTML.AutoSize = true;
            this.lblHTML.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblHTML.Location = new System.Drawing.Point(476, 0);
            this.lblHTML.Name = "lblHTML";
            this.lblHTML.Size = new System.Drawing.Size(228, 22);
            this.lblHTML.TabIndex = 5;
            this.lblHTML.Text = "HTML data";
            this.lblHTML.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tplMain
            // 
            this.tplMain.ColumnCount = 3;
            this.tplMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tplMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34F));
            this.tplMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tplMain.Controls.Add(this.lblRaw, 0, 0);
            this.tplMain.Controls.Add(this.txtHTML, 2, 1);
            this.tplMain.Controls.Add(this.txtURL, 1, 1);
            this.tplMain.Controls.Add(this.lblHTML, 2, 0);
            this.tplMain.Controls.Add(this.lblUrl, 1, 0);
            this.tplMain.Controls.Add(this.txtRaw, 0, 1);
            this.tplMain.Controls.Add(this.btnURL, 1, 2);
            this.tplMain.Controls.Add(this.btnHTML, 2, 2);
            this.tplMain.Controls.Add(this.btnRaw, 0, 2);
            this.tplMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tplMain.Location = new System.Drawing.Point(0, 0);
            this.tplMain.Name = "tplMain";
            this.tplMain.RowCount = 3;
            this.tplMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tplMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tplMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tplMain.Size = new System.Drawing.Size(707, 292);
            this.tplMain.TabIndex = 6;
            // 
            // btnURL
            // 
            this.btnURL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnURL.Location = new System.Drawing.Point(236, 267);
            this.btnURL.Name = "btnURL";
            this.btnURL.Size = new System.Drawing.Size(234, 22);
            this.btnURL.TabIndex = 6;
            this.btnURL.Text = "Convert from URL";
            this.btnURL.UseVisualStyleBackColor = true;
            this.btnURL.Click += new System.EventHandler(this.btnURL_Click);
            // 
            // btnHTML
            // 
            this.btnHTML.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnHTML.Location = new System.Drawing.Point(476, 267);
            this.btnHTML.Name = "btnHTML";
            this.btnHTML.Size = new System.Drawing.Size(228, 22);
            this.btnHTML.TabIndex = 7;
            this.btnHTML.Text = "Convert from HTML";
            this.btnHTML.UseVisualStyleBackColor = true;
            this.btnHTML.Click += new System.EventHandler(this.btnHTML_Click);
            // 
            // btnRaw
            // 
            this.btnRaw.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRaw.Location = new System.Drawing.Point(3, 267);
            this.btnRaw.Name = "btnRaw";
            this.btnRaw.Size = new System.Drawing.Size(227, 22);
            this.btnRaw.TabIndex = 8;
            this.btnRaw.Text = "Convert from RAW";
            this.btnRaw.UseVisualStyleBackColor = true;
            this.btnRaw.Click += new System.EventHandler(this.btnRaw_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 292);
            this.Controls.Add(this.tplMain);
            this.Name = "frmMain";
            this.Text = "Multi converter";
            this.tplMain.ResumeLayout(false);
            this.tplMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtRaw;
        private System.Windows.Forms.TextBox txtHTML;
        private System.Windows.Forms.TextBox txtURL;
        private System.Windows.Forms.Label lblRaw;
        private System.Windows.Forms.Label lblUrl;
        private System.Windows.Forms.Label lblHTML;
        private System.Windows.Forms.TableLayoutPanel tplMain;
        private System.Windows.Forms.Button btnURL;
        private System.Windows.Forms.Button btnHTML;
        private System.Windows.Forms.Button btnRaw;
    }
}

