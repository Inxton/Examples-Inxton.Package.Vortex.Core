namespace Simple.WinForms
{
    partial class SimpleWinForm
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
            this.tbCounterValue = new System.Windows.Forms.TextBox();
            this.btnToggleCounter = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbCounterValue
            // 
            this.tbCounterValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbCounterValue.Location = new System.Drawing.Point(264, 47);
            this.tbCounterValue.Name = "tbCounterValue";
            this.tbCounterValue.Size = new System.Drawing.Size(190, 26);
            this.tbCounterValue.TabIndex = 0;
            // 
            // btnToggleCounter
            // 
            this.btnToggleCounter.Location = new System.Drawing.Point(288, 96);
            this.btnToggleCounter.Name = "btnToggleCounter";
            this.btnToggleCounter.Size = new System.Drawing.Size(146, 51);
            this.btnToggleCounter.TabIndex = 1;
            this.btnToggleCounter.Text = "Counting...";
            this.btnToggleCounter.UseVisualStyleBackColor = true;
            this.btnToggleCounter.Click += new System.EventHandler(this.btnToggleCounter_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(288, 167);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(146, 51);
            this.btnReset.TabIndex = 2;
            this.btnReset.Text = "Reset counter";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // SimpleWinForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnToggleCounter);
            this.Controls.Add(this.tbCounterValue);
            this.Name = "SimpleWinForm";
            this.Text = "Simple.WinForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbCounterValue;
        private System.Windows.Forms.Button btnToggleCounter;
        private System.Windows.Forms.Button btnReset;
    }
}

