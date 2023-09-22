namespace TaskPerformance1
{
    partial class QueueNumber
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
            label1 = new Label();
            lblNumber = new Label();
            labelNumber = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 14.25F, FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(12, 22);
            label1.Name = "label1";
            label1.Size = new Size(143, 23);
            label1.TabIndex = 0;
            label1.Text = "*Now Serving";
            // 
            // lblNumber
            // 
            lblNumber.AutoSize = true;
            lblNumber.Font = new Font("Verdana", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblNumber.Location = new Point(81, 88);
            lblNumber.Name = "lblNumber";
            lblNumber.Size = new Size(0, 32);
            lblNumber.TabIndex = 1;
            // 
            // labelNumber
            // 
            labelNumber.AutoSize = true;
            labelNumber.Font = new Font("Verdana", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelNumber.Location = new Point(102, 76);
            labelNumber.Name = "labelNumber";
            labelNumber.Size = new Size(0, 32);
            labelNumber.TabIndex = 2;
            // 
            // QueueNumber
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(339, 194);
            Controls.Add(labelNumber);
            Controls.Add(lblNumber);
            Controls.Add(label1);
            Name = "QueueNumber";
            Text = "QueueNumber";
            Load += QueueNumber_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblNumber;
        public Label labelNumber;
    }
}