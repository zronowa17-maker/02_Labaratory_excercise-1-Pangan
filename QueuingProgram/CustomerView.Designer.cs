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
            SuspendLayout();
            // 
            // LblNowServing
            // 
            LblNowServing.AutoSize = true;
            LblNowServing.Location = new Point(295, 197);
            LblNowServing.Name = "LblNowServing";
            LblNowServing.Size = new Size(87, 15);
            LblNowServing.TabIndex = 0;
            LblNowServing.Text = "LblNowServing";
            // 
            // CustomerView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(LblNowServing);
            Name = "CustomerView";
            Text = "CustomerView";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNowServing;
        private Label LblNowServing;
    }
}