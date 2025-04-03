namespace FacadePattern
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
            btnMortgageApproval = new Button();
            SuspendLayout();
            // 
            // btnMortgageApproval
            // 
            btnMortgageApproval.Location = new Point(90, 88);
            btnMortgageApproval.Name = "btnMortgageApproval";
            btnMortgageApproval.Size = new Size(152, 66);
            btnMortgageApproval.TabIndex = 0;
            btnMortgageApproval.Text = "Mortgage Approval ";
            btnMortgageApproval.UseVisualStyleBackColor = true;
            btnMortgageApproval.Click += btnMortgageApproval_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnMortgageApproval);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btnMortgageApproval;
    }
}
