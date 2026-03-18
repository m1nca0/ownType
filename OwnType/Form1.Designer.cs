namespace OwnType
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textFirstX = new TextBox();
            textFirstY = new TextBox();
            textFirstZ = new TextBox();
            textSecondX = new TextBox();
            textSecondY = new TextBox();
            textSecondZ = new TextBox();
            label4 = new Label();
            label5 = new Label();
            txtResult = new TextBox();
            cm1 = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 3);
            label1.Name = "label1";
            label1.Size = new Size(13, 15);
            label1.TabIndex = 0;
            label1.Text = "x";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(82, 3);
            label2.Name = "label2";
            label2.Size = new Size(13, 15);
            label2.TabIndex = 1;
            label2.Text = "y";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(140, 3);
            label3.Name = "label3";
            label3.Size = new Size(12, 15);
            label3.TabIndex = 2;
            label3.Text = "z";
            // 
            // textFirstX
            // 
            textFirstX.Location = new Point(24, 21);
            textFirstX.Name = "textFirstX";
            textFirstX.Size = new Size(52, 23);
            textFirstX.TabIndex = 3;
            textFirstX.TextChanged += onValueChanged;
            // 
            // textFirstY
            // 
            textFirstY.Location = new Point(82, 21);
            textFirstY.Name = "textFirstY";
            textFirstY.Size = new Size(52, 23);
            textFirstY.TabIndex = 4;
            textFirstY.TextChanged += onValueChanged;
            // 
            // textFirstZ
            // 
            textFirstZ.Location = new Point(140, 21);
            textFirstZ.Name = "textFirstZ";
            textFirstZ.Size = new Size(52, 23);
            textFirstZ.TabIndex = 5;
            textFirstZ.TextChanged += onValueChanged;
            // 
            // textSecondX
            // 
            textSecondX.Location = new Point(24, 50);
            textSecondX.Name = "textSecondX";
            textSecondX.Size = new Size(52, 23);
            textSecondX.TabIndex = 6;
            textSecondX.TextChanged += onValueChanged;
            // 
            // textSecondY
            // 
            textSecondY.Location = new Point(82, 50);
            textSecondY.Name = "textSecondY";
            textSecondY.Size = new Size(52, 23);
            textSecondY.TabIndex = 7;
            textSecondY.TextChanged += onValueChanged;
            // 
            // textSecondZ
            // 
            textSecondZ.Location = new Point(140, 50);
            textSecondZ.Name = "textSecondZ";
            textSecondZ.Size = new Size(52, 23);
            textSecondZ.TabIndex = 8;
            textSecondZ.TextChanged += onValueChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(5, 24);
            label4.Name = "label4";
            label4.Size = new Size(13, 15);
            label4.TabIndex = 9;
            label4.Text = "a";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(4, 53);
            label5.Name = "label5";
            label5.Size = new Size(14, 15);
            label5.TabIndex = 10;
            label5.Text = "b";
            // 
            // txtResult
            // 
            txtResult.Location = new Point(24, 79);
            txtResult.Name = "txtResult";
            txtResult.ReadOnly = true;
            txtResult.Size = new Size(168, 23);
            txtResult.TabIndex = 11;
            // 
            // cm1
            // 
            cm1.FormattingEnabled = true;
            cm1.Items.AddRange(new object[] { "+", "-", "*", "&", "len a", "len b" });
            cm1.Location = new Point(198, 35);
            cm1.Name = "cm1";
            cm1.Size = new Size(48, 23);
            cm1.TabIndex = 12;
            cm1.Text = "+";
            cm1.SelectedIndexChanged += onValueChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(254, 113);
            Controls.Add(cm1);
            Controls.Add(txtResult);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(textSecondZ);
            Controls.Add(textSecondY);
            Controls.Add(textSecondX);
            Controls.Add(textFirstZ);
            Controls.Add(textFirstY);
            Controls.Add(textFirstX);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textFirstX;
        private TextBox textFirstY;
        private TextBox textFirstZ;
        private TextBox textSecondX;
        private TextBox textSecondY;
        private TextBox textSecondZ;
        private Label label4;
        private Label label5;
        private TextBox txtResult;
        private ComboBox cm1;
    }
}
