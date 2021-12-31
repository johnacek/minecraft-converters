namespace converters
{
    partial class NetherPortalLinking
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
            this.components = new System.ComponentModel.Container();
            this.x = new System.Windows.Forms.TextBox();
            this.z = new System.Windows.Forms.TextBox();
            this.zOut = new System.Windows.Forms.TextBox();
            this.xOut = new System.Windows.Forms.TextBox();
            this.bttConvert = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bttBack = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // x
            // 
            this.x.Location = new System.Drawing.Point(29, 8);
            this.x.Name = "x";
            this.x.Size = new System.Drawing.Size(100, 20);
            this.x.TabIndex = 0;
            // 
            // z
            // 
            this.z.Location = new System.Drawing.Point(29, 34);
            this.z.Name = "z";
            this.z.Size = new System.Drawing.Size(100, 20);
            this.z.TabIndex = 1;
            // 
            // zOut
            // 
            this.zOut.Location = new System.Drawing.Point(216, 34);
            this.zOut.Name = "zOut";
            this.zOut.ReadOnly = true;
            this.zOut.Size = new System.Drawing.Size(100, 20);
            this.zOut.TabIndex = 4;
            // 
            // xOut
            // 
            this.xOut.Location = new System.Drawing.Point(216, 8);
            this.xOut.Name = "xOut";
            this.xOut.ReadOnly = true;
            this.xOut.Size = new System.Drawing.Size(100, 20);
            this.xOut.TabIndex = 3;
            // 
            // bttConvert
            // 
            this.bttConvert.Location = new System.Drawing.Point(135, 22);
            this.bttConvert.Name = "bttConvert";
            this.bttConvert.Size = new System.Drawing.Size(75, 20);
            this.bttConvert.TabIndex = 6;
            this.bttConvert.Text = "Convert";
            this.bttConvert.UseVisualStyleBackColor = true;
            this.bttConvert.Click += new System.EventHandler(this.bttConvert_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "X";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Z";
            // 
            // bttBack
            // 
            this.bttBack.Location = new System.Drawing.Point(12, 60);
            this.bttBack.Name = "bttBack";
            this.bttBack.Size = new System.Drawing.Size(75, 20);
            this.bttBack.TabIndex = 10;
            this.bttBack.Text = "Back";
            this.bttBack.UseVisualStyleBackColor = true;
            this.bttBack.Click += new System.EventHandler(this.bttBack_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(296, 98);
            this.label4.MaximumSize = new System.Drawing.Size(0, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 11;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.textBox1.Location = new System.Drawing.Point(29, 89);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(287, 82);
            this.textBox1.TabIndex = 12;
            this.textBox1.Text = "If you linking nether portals, convert the coordinations from overworld in this c" +
    "alculator a build the portal at location in nether from the right column.";
            // 
            // NetherPortalLinking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 166);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.bttBack);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bttConvert);
            this.Controls.Add(this.zOut);
            this.Controls.Add(this.xOut);
            this.Controls.Add(this.z);
            this.Controls.Add(this.x);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "NetherPortalLinking";
            this.Text = "NetherPortalLinking";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.NetherPortalLinking_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox x;
        private System.Windows.Forms.TextBox z;
        private System.Windows.Forms.TextBox zOut;
        private System.Windows.Forms.TextBox xOut;
        private System.Windows.Forms.Button bttConvert;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bttBack;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox textBox1;
    }
}