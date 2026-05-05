namespace WinFormsApp1
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.txtGuess = new TextBox();
            this.btnCheck = new Button();
            this.lblResult = new Label();
            this.lblAttempts = new Label();
            SuspendLayout();

            // txtGuess
            this.txtGuess.Location = new Point(80, 66);
            this.txtGuess.Name = "txtGuess";
            this.txtGuess.Size = new Size(125, 27);
            this.txtGuess.TabIndex = 0;

            // btnCheck
            this.btnCheck.Location = new Point(80, 110);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new Size(125, 30);
            this.btnCheck.Text = "Перевірити";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += btnCheck_Click;

            // lblResult
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new Point(80, 160);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new Size(60, 20);
            this.lblResult.Text = "Слово:";

            // lblAttempts
            this.lblAttempts.AutoSize = true;
            this.lblAttempts.Location = new Point(80, 190);
            this.lblAttempts.Name = "lblAttempts";
            this.lblAttempts.Size = new Size(60, 20);
            this.lblAttempts.Text = "Спроби:";

            // Form1
            this.ClientSize = new Size(400, 300);
            this.Controls.Add(this.txtGuess);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblAttempts);
            this.Name = "Form1";
            this.Text = "Гра в слова";

            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private TextBox txtGuess;
        private Button btnCheck;
        private Label lblResult;
        private Label lblAttempts;
    }
}