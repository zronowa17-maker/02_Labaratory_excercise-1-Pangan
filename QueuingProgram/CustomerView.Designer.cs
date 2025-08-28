namespace QueuingProgram
{
    partial class CustomerView
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
            LblNowServing = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // LblNowServing
            // 
            LblNowServing.AutoSize = true;
            LblNowServing.Font = new Font("Rockwell", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LblNowServing.Location = new Point(188, 205);
            LblNowServing.Name = "LblNowServing";
            LblNowServing.Size = new Size(0, 72);
            LblNowServing.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Rockwell", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(30, 84);
            label1.Name = "label1";
            label1.Size = new Size(331, 54);
            label1.TabIndex = 1;
            label1.Text = "*Now Serving";
            // 
            // CustomerView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1051, 450);
            Controls.Add(label1);
            Controls.Add(LblNowServing);
            Name = "CustomerView";
            Text = "CustomerView";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNowServing;
        private Label LblNowServing;
        private Label label1;
    }
}