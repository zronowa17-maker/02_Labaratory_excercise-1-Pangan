namespace QueuingProgram
{
    partial class QueuingForm
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
            lblQueue = new Label();
            label = new Label();
            btnOpenQueueForm_Click = new Button();
            SuspendLayout();
            // 
            // btnCashier
            // 
            btnCashier.BackColor = SystemColors.AppWorkspace;
            btnCashier.FlatStyle = FlatStyle.Popup;
            btnCashier.Font = new Font("Rockwell", 32.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCashier.Location = new Point(76, 132);
            btnCashier.Name = "btnCashier";
            btnCashier.Size = new Size(217, 157);
            btnCashier.TabIndex = 0;
            btnCashier.Text = "Cashier";
            btnCashier.UseVisualStyleBackColor = false;
            btnCashier.Click += btnCashier_Click;
            // 
            // lblQueue
            // 
            lblQueue.AutoSize = true;
            lblQueue.Font = new Font("Segoe UI", 32.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblQueue.Location = new Point(447, 230);
            lblQueue.Name = "lblQueue";
            lblQueue.Size = new Size(0, 59);
            lblQueue.TabIndex = 1;
            // 
            // label
            // 
            label.AutoSize = true;
            label.Font = new Font("Segoe UI", 32.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label.Location = new Point(367, 132);
            label.Name = "label";
            label.Size = new Size(356, 59);
            label.TabIndex = 2;
            label.Text = "Position in Queue";
            // 
            // btnOpenQueueForm_Click
            // 
            btnOpenQueueForm_Click.BackColor = SystemColors.ActiveCaption;
            btnOpenQueueForm_Click.FlatStyle = FlatStyle.Popup;
            btnOpenQueueForm_Click.Font = new Font("Rockwell", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnOpenQueueForm_Click.ForeColor = Color.Red;
            btnOpenQueueForm_Click.Location = new Point(41, 305);
            btnOpenQueueForm_Click.Name = "btnOpenQueueForm_Click";
            btnOpenQueueForm_Click.Size = new Size(306, 31);
            btnOpenQueueForm_Click.TabIndex = 3;
            btnOpenQueueForm_Click.Text = "*Click to get a number";
            btnOpenQueueForm_Click.UseVisualStyleBackColor = false;
            btnOpenQueueForm_Click.Click += btnOpenQueueForm_Click_Click;
            // 
            // QueuingForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(btnOpenQueueForm_Click);
            Controls.Add(label);
            Controls.Add(lblQueue);
            Controls.Add(btnCashier);
            Name = "QueuingForm";
            Text = "Form1";
            Load += QueuingForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCashier;
        private Label lblQueue;
        private Label label;
        private Button btnOpenQueueForm_Click;
    }
}
