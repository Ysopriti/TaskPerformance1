namespace TaskPerformance1
{
    partial class CashierWindow2
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
            listCashierQueue = new ListView();
            btnRefresh = new Button();
            btnNext = new Button();
            SuspendLayout();
            // 
            // listCashierQueue
            // 
            listCashierQueue.Location = new Point(140, 24);
            listCashierQueue.Name = "listCashierQueue";
            listCashierQueue.Size = new Size(174, 158);
            listCashierQueue.TabIndex = 0;
            listCashierQueue.UseCompatibleStateImageBehavior = false;
            listCashierQueue.View = View.List;
            // 
            // btnRefresh
            // 
            btnRefresh.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnRefresh.Location = new Point(28, 24);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(106, 25);
            btnRefresh.TabIndex = 1;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click_1;
            // 
            // btnNext
            // 
            btnNext.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnNext.Location = new Point(28, 55);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(106, 25);
            btnNext.TabIndex = 2;
            btnNext.Text = "Next";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click_1;
            // 
            // CashierWindow2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(339, 194);
            Controls.Add(btnNext);
            Controls.Add(btnRefresh);
            Controls.Add(listCashierQueue);
            Name = "CashierWindow2";
            Text = "CashierWindow2";
            ResumeLayout(false);
        }

        #endregion

        private ListView listCashierQueue;
        private Button btnRefresh;
        private Button btnNext;
    }
}