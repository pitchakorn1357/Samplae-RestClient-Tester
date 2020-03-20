namespace RestClient_Tester
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSubmitRequest = new System.Windows.Forms.Button();
            this.comboBoxUrl = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxMethod = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxRequestBody = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabResponseBody = new System.Windows.Forms.TabPage();
            this.textBoxResponseBody = new System.Windows.Forms.TextBox();
            this.tabResponseHeader = new System.Windows.Forms.TabPage();
            this.textBoxResponseHeader = new System.Windows.Forms.TextBox();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabRequestBody = new System.Windows.Forms.TabPage();
            this.tabRequestHeader = new System.Windows.Forms.TabPage();
            this.textBoxRequestHeader = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabResponseBody.SuspendLayout();
            this.tabResponseHeader.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabRequestBody.SuspendLayout();
            this.tabRequestHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnSubmitRequest);
            this.groupBox1.Controls.Add(this.comboBoxUrl);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.comboBoxMethod);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(760, 84);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Request";
            // 
            // btnSubmitRequest
            // 
            this.btnSubmitRequest.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmitRequest.Location = new System.Drawing.Point(16, 46);
            this.btnSubmitRequest.Name = "btnSubmitRequest";
            this.btnSubmitRequest.Size = new System.Drawing.Size(102, 32);
            this.btnSubmitRequest.TabIndex = 5;
            this.btnSubmitRequest.Text = "Submit Request";
            this.btnSubmitRequest.UseVisualStyleBackColor = true;
            this.btnSubmitRequest.Click += new System.EventHandler(this.btnSubmitRequest_Click);
            // 
            // comboBoxUrl
            // 
            this.comboBoxUrl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxUrl.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.comboBoxUrl.FormattingEnabled = true;
            this.comboBoxUrl.Location = new System.Drawing.Point(170, 19);
            this.comboBoxUrl.Name = "comboBoxUrl";
            this.comboBoxUrl.Size = new System.Drawing.Size(584, 22);
            this.comboBoxUrl.TabIndex = 4;
            this.comboBoxUrl.SelectedValueChanged += new System.EventHandler(this.comboBoxUrl_SelectedValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(135, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 14);
            this.label2.TabIndex = 3;
            this.label2.Text = "URL";
            // 
            // comboBoxMethod
            // 
            this.comboBoxMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMethod.FormattingEnabled = true;
            this.comboBoxMethod.Items.AddRange(new object[] {
            "POST",
            "GET"});
            this.comboBoxMethod.Location = new System.Drawing.Point(62, 19);
            this.comboBoxMethod.Name = "comboBoxMethod";
            this.comboBoxMethod.Size = new System.Drawing.Size(56, 22);
            this.comboBoxMethod.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 14);
            this.label1.TabIndex = 1;
            this.label1.Text = "Method";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.tabControl2);
            this.groupBox2.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 102);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(760, 335);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Request Detail";
            // 
            // textBoxRequestBody
            // 
            this.textBoxRequestBody.AcceptsReturn = true;
            this.textBoxRequestBody.AcceptsTab = true;
            this.textBoxRequestBody.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxRequestBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxRequestBody.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxRequestBody.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textBoxRequestBody.Location = new System.Drawing.Point(0, 0);
            this.textBoxRequestBody.Multiline = true;
            this.textBoxRequestBody.Name = "textBoxRequestBody";
            this.textBoxRequestBody.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxRequestBody.Size = new System.Drawing.Size(746, 287);
            this.textBoxRequestBody.TabIndex = 0;
            this.textBoxRequestBody.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxRequestBody_KeyDown);
            this.textBoxRequestBody.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxRequestBody_KeyPress);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.tabControl1);
            this.groupBox3.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(12, 443);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(760, 306);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Response";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(675, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Notepad";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabResponseBody);
            this.tabControl1.Controls.Add(this.tabResponseHeader);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(3, 18);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Padding = new System.Drawing.Point(0, 0);
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(754, 285);
            this.tabControl1.TabIndex = 0;
            // 
            // tabResponseBody
            // 
            this.tabResponseBody.BackColor = System.Drawing.SystemColors.Control;
            this.tabResponseBody.Controls.Add(this.textBoxResponseBody);
            this.tabResponseBody.Location = new System.Drawing.Point(4, 23);
            this.tabResponseBody.Margin = new System.Windows.Forms.Padding(0);
            this.tabResponseBody.Name = "tabResponseBody";
            this.tabResponseBody.Size = new System.Drawing.Size(746, 258);
            this.tabResponseBody.TabIndex = 0;
            this.tabResponseBody.Text = "Response Body";
            // 
            // textBoxResponseBody
            // 
            this.textBoxResponseBody.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxResponseBody.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxResponseBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxResponseBody.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textBoxResponseBody.Location = new System.Drawing.Point(0, 0);
            this.textBoxResponseBody.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxResponseBody.Multiline = true;
            this.textBoxResponseBody.Name = "textBoxResponseBody";
            this.textBoxResponseBody.ReadOnly = true;
            this.textBoxResponseBody.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxResponseBody.Size = new System.Drawing.Size(746, 258);
            this.textBoxResponseBody.TabIndex = 1;
            // 
            // tabResponseHeader
            // 
            this.tabResponseHeader.BackColor = System.Drawing.SystemColors.Control;
            this.tabResponseHeader.Controls.Add(this.textBoxResponseHeader);
            this.tabResponseHeader.Location = new System.Drawing.Point(4, 23);
            this.tabResponseHeader.Margin = new System.Windows.Forms.Padding(0);
            this.tabResponseHeader.Name = "tabResponseHeader";
            this.tabResponseHeader.Size = new System.Drawing.Size(746, 258);
            this.tabResponseHeader.TabIndex = 1;
            this.tabResponseHeader.Text = "Response Header";
            // 
            // textBoxResponseHeader
            // 
            this.textBoxResponseHeader.AcceptsReturn = true;
            this.textBoxResponseHeader.AcceptsTab = true;
            this.textBoxResponseHeader.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxResponseHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxResponseHeader.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textBoxResponseHeader.Location = new System.Drawing.Point(0, 0);
            this.textBoxResponseHeader.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxResponseHeader.Multiline = true;
            this.textBoxResponseHeader.Name = "textBoxResponseHeader";
            this.textBoxResponseHeader.ReadOnly = true;
            this.textBoxResponseHeader.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxResponseHeader.Size = new System.Drawing.Size(746, 258);
            this.textBoxResponseHeader.TabIndex = 2;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabRequestBody);
            this.tabControl2.Controls.Add(this.tabRequestHeader);
            this.tabControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl2.Location = new System.Drawing.Point(3, 18);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(754, 314);
            this.tabControl2.TabIndex = 0;
            // 
            // tabRequestBody
            // 
            this.tabRequestBody.Controls.Add(this.textBoxRequestBody);
            this.tabRequestBody.Location = new System.Drawing.Point(4, 23);
            this.tabRequestBody.Margin = new System.Windows.Forms.Padding(0);
            this.tabRequestBody.Name = "tabRequestBody";
            this.tabRequestBody.Size = new System.Drawing.Size(746, 287);
            this.tabRequestBody.TabIndex = 0;
            this.tabRequestBody.Text = "Request Body";
            this.tabRequestBody.UseVisualStyleBackColor = true;
            // 
            // tabRequestHeader
            // 
            this.tabRequestHeader.Controls.Add(this.textBoxRequestHeader);
            this.tabRequestHeader.Location = new System.Drawing.Point(4, 23);
            this.tabRequestHeader.Margin = new System.Windows.Forms.Padding(0);
            this.tabRequestHeader.Name = "tabRequestHeader";
            this.tabRequestHeader.Size = new System.Drawing.Size(746, 287);
            this.tabRequestHeader.TabIndex = 1;
            this.tabRequestHeader.Text = "Request Header";
            this.tabRequestHeader.UseVisualStyleBackColor = true;
            // 
            // textBoxRequestHeader
            // 
            this.textBoxRequestHeader.AcceptsReturn = true;
            this.textBoxRequestHeader.AcceptsTab = true;
            this.textBoxRequestHeader.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxRequestHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxRequestHeader.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxRequestHeader.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textBoxRequestHeader.Location = new System.Drawing.Point(0, 0);
            this.textBoxRequestHeader.Multiline = true;
            this.textBoxRequestHeader.Name = "textBoxRequestHeader";
            this.textBoxRequestHeader.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxRequestHeader.Size = new System.Drawing.Size(746, 287);
            this.textBoxRequestHeader.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 761);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(800, 800);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RestClient";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabResponseBody.ResumeLayout(false);
            this.tabResponseBody.PerformLayout();
            this.tabResponseHeader.ResumeLayout(false);
            this.tabResponseHeader.PerformLayout();
            this.tabControl2.ResumeLayout(false);
            this.tabRequestBody.ResumeLayout(false);
            this.tabRequestBody.PerformLayout();
            this.tabRequestHeader.ResumeLayout(false);
            this.tabRequestHeader.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxMethod;
        private System.Windows.Forms.ComboBox comboBoxUrl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBoxRequestBody;
        private System.Windows.Forms.Button btnSubmitRequest;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabResponseBody;
        private System.Windows.Forms.TabPage tabResponseHeader;
        private System.Windows.Forms.TextBox textBoxResponseBody;
        private System.Windows.Forms.TextBox textBoxResponseHeader;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabRequestBody;
        private System.Windows.Forms.TabPage tabRequestHeader;
        private System.Windows.Forms.TextBox textBoxRequestHeader;

    }
}

