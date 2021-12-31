namespace converters
{
    partial class StackToBlock
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
            this.bttBack = new System.Windows.Forms.Button();
            this.bttConvert = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.output = new System.Windows.Forms.TextBox();
            this.input = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // bttBack
            // 
            this.bttBack.Location = new System.Drawing.Point(3, 9);
            this.bttBack.Name = "bttBack";
            this.bttBack.Size = new System.Drawing.Size(75, 23);
            this.bttBack.TabIndex = 9;
            this.bttBack.Text = "Back";
            this.bttBack.UseVisualStyleBackColor = true;
            this.bttBack.Click += new System.EventHandler(this.bttBack_Click);
            // 
            // bttConvert
            // 
            this.bttConvert.Location = new System.Drawing.Point(242, 11);
            this.bttConvert.Name = "bttConvert";
            this.bttConvert.Size = new System.Drawing.Size(66, 20);
            this.bttConvert.TabIndex = 8;
            this.bttConvert.Text = "Convert";
            this.bttConvert.UseVisualStyleBackColor = true;
            this.bttConvert.Click += new System.EventHandler(this.bttConvert_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(81, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Stacks";
            // 
            // output
            // 
            this.output.Location = new System.Drawing.Point(314, 12);
            this.output.Name = "output";
            this.output.ReadOnly = true;
            this.output.Size = new System.Drawing.Size(141, 20);
            this.output.TabIndex = 6;
            // 
            // input
            // 
            this.input.Location = new System.Drawing.Point(136, 11);
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(100, 20);
            this.input.TabIndex = 5;
            this.input.KeyDown += new System.Windows.Forms.KeyEventHandler(this.input_KeyDown);
            // 
            // StackToBlock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 39);
            this.Controls.Add(this.bttBack);
            this.Controls.Add(this.bttConvert);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.output);
            this.Controls.Add(this.input);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "StackToBlock";
            this.Text = "Stacks to blocks";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.StackToBlock_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bttBack;
        private System.Windows.Forms.Button bttConvert;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox output;
        private System.Windows.Forms.TextBox input;
    }
}