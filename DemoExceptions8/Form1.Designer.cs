namespace DemoExceptions8
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Number1Entry = new System.Windows.Forms.TextBox();
            this.Number2Entry = new System.Windows.Forms.TextBox();
            this.DivideButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.ResultEntry = new System.Windows.Forms.TextBox();
            this.MultiplyButton = new System.Windows.Forms.Button();
            this.AssignButton = new System.Windows.Forms.Button();
            this.InitializeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Number 2";
            // 
            // Number1Entry
            // 
            this.Number1Entry.Location = new System.Drawing.Point(126, 59);
            this.Number1Entry.Name = "Number1Entry";
            this.Number1Entry.Size = new System.Drawing.Size(100, 20);
            this.Number1Entry.TabIndex = 2;
            // 
            // Number2Entry
            // 
            this.Number2Entry.Location = new System.Drawing.Point(126, 104);
            this.Number2Entry.Name = "Number2Entry";
            this.Number2Entry.Size = new System.Drawing.Size(100, 20);
            this.Number2Entry.TabIndex = 3;
            // 
            // DivideButton
            // 
            this.DivideButton.Location = new System.Drawing.Point(38, 157);
            this.DivideButton.Name = "DivideButton";
            this.DivideButton.Size = new System.Drawing.Size(75, 23);
            this.DivideButton.TabIndex = 4;
            this.DivideButton.Text = "Divide";
            this.DivideButton.UseVisualStyleBackColor = true;
            this.DivideButton.Click += new System.EventHandler(this.DivideButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 214);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Result";
            // 
            // ResultEntry
            // 
            this.ResultEntry.Enabled = false;
            this.ResultEntry.Location = new System.Drawing.Point(126, 206);
            this.ResultEntry.Name = "ResultEntry";
            this.ResultEntry.ReadOnly = true;
            this.ResultEntry.Size = new System.Drawing.Size(100, 20);
            this.ResultEntry.TabIndex = 6;
            // 
            // MultiplyButton
            // 
            this.MultiplyButton.Location = new System.Drawing.Point(312, 157);
            this.MultiplyButton.Name = "MultiplyButton";
            this.MultiplyButton.Size = new System.Drawing.Size(106, 23);
            this.MultiplyButton.TabIndex = 7;
            this.MultiplyButton.Text = "Multiply";
            this.MultiplyButton.UseVisualStyleBackColor = true;
            this.MultiplyButton.Click += new System.EventHandler(this.MultiplyButton_Click);
            // 
            // AssignButton
            // 
            this.AssignButton.Location = new System.Drawing.Point(312, 101);
            this.AssignButton.Name = "AssignButton";
            this.AssignButton.Size = new System.Drawing.Size(106, 23);
            this.AssignButton.TabIndex = 8;
            this.AssignButton.Text = "Assign to Array";
            this.AssignButton.UseVisualStyleBackColor = true;
            this.AssignButton.Click += new System.EventHandler(this.AssignButton_Click);
            // 
            // InitializeButton
            // 
            this.InitializeButton.Location = new System.Drawing.Point(312, 59);
            this.InitializeButton.Name = "InitializeButton";
            this.InitializeButton.Size = new System.Drawing.Size(106, 23);
            this.InitializeButton.TabIndex = 9;
            this.InitializeButton.Text = "Initialize";
            this.InitializeButton.UseVisualStyleBackColor = true;
            this.InitializeButton.Click += new System.EventHandler(this.InitializeButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.InitializeButton);
            this.Controls.Add(this.AssignButton);
            this.Controls.Add(this.MultiplyButton);
            this.Controls.Add(this.ResultEntry);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DivideButton);
            this.Controls.Add(this.Number2Entry);
            this.Controls.Add(this.Number1Entry);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Number1Entry;
        private System.Windows.Forms.TextBox Number2Entry;
        private System.Windows.Forms.Button DivideButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ResultEntry;
        private System.Windows.Forms.Button MultiplyButton;
        private System.Windows.Forms.Button AssignButton;
        private System.Windows.Forms.Button InitializeButton;
    }
}

