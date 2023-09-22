namespace TaskPerformance1
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
            btnCashier = new Button();
            label1 = new Label();
            lblQueue = new Label();
            lbclick = new LinkLabel();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            SuspendLayout();
            // 
            // btnCashier
            // 
            btnCashier.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnCashier.Location = new Point(26, 33);
            btnCashier.Name = "btnCashier";
            btnCashier.Size = new Size(124, 106);
            btnCashier.TabIndex = 0;
            btnCashier.Text = "Cashier";
            btnCashier.UseVisualStyleBackColor = true;
            btnCashier.Click += btnCashier_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(182, 62);
            label1.Name = "label1";
            label1.Size = new Size(118, 14);
            label1.TabIndex = 1;
            label1.Text = "Position in Queue";
            // 
            // lblQueue
            // 
            lblQueue.AutoSize = true;
            lblQueue.Font = new Font("Verdana", 24F, FontStyle.Regular, GraphicsUnit.Point);
            lblQueue.Location = new Point(156, 76);
            lblQueue.Name = "lblQueue";
            lblQueue.Size = new Size(173, 38);
            lblQueue.TabIndex = 2;
            lblQueue.Text = "P - 10007";
            // 
            // lbclick
            // 
            lbclick.AutoSize = true;
            lbclick.LinkColor = Color.Red;
            lbclick.Location = new Point(26, 142);
            lbclick.Name = "lbclick";
            lbclick.Size = new Size(124, 15);
            lbclick.TabIndex = 3;
            lbclick.TabStop = true;
            lbclick.Text = "*click to get a number";
            lbclick.LinkClicked += lbclick_LinkClicked;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(339, 194);
            Controls.Add(lbclick);
            Controls.Add(lblQueue);
            Controls.Add(label1);
            Controls.Add(btnCashier);
            ForeColor = SystemColors.ActiveCaptionText;
            Name = "Form1";
            Text = "Task Performance 1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCashier;
        private Label label1;
        private Label lblQueue;
        private LinkLabel lbclick;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}