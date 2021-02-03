
namespace MathApp
{
    partial class Form1
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
            this.addButton = new System.Windows.Forms.Button();
            this.subtractButton = new System.Windows.Forms.Button();
            this.multiplyButton = new System.Windows.Forms.Button();
            this.divisionButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.firstNum = new System.Windows.Forms.TextBox();
            this.secondNum = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.VerificationLabel = new System.Windows.Forms.Label();
            this.WelcomeLabel = new System.Windows.Forms.Label();
            this.VerificationLabel2 = new System.Windows.Forms.Label();
            this.OutputLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // addButton
            // 
            this.addButton.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButton.Location = new System.Drawing.Point(38, 210);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(165, 48);
            this.addButton.TabIndex = 0;
            this.addButton.Text = "Addition";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.Button_Click);
            // 
            // subtractButton
            // 
            this.subtractButton.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtractButton.Location = new System.Drawing.Point(38, 265);
            this.subtractButton.Name = "subtractButton";
            this.subtractButton.Size = new System.Drawing.Size(165, 48);
            this.subtractButton.TabIndex = 1;
            this.subtractButton.Text = "Subtraction";
            this.subtractButton.UseVisualStyleBackColor = true;
            this.subtractButton.Click += new System.EventHandler(this.Button_Click);
            // 
            // multiplyButton
            // 
            this.multiplyButton.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.multiplyButton.Location = new System.Drawing.Point(38, 319);
            this.multiplyButton.Name = "multiplyButton";
            this.multiplyButton.Size = new System.Drawing.Size(165, 48);
            this.multiplyButton.TabIndex = 2;
            this.multiplyButton.Text = "Multiplication";
            this.multiplyButton.UseVisualStyleBackColor = true;
            this.multiplyButton.Click += new System.EventHandler(this.Button_Click);
            // 
            // divisionButton
            // 
            this.divisionButton.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.divisionButton.Location = new System.Drawing.Point(38, 373);
            this.divisionButton.Name = "divisionButton";
            this.divisionButton.Size = new System.Drawing.Size(165, 47);
            this.divisionButton.TabIndex = 3;
            this.divisionButton.Text = "Division";
            this.divisionButton.UseVisualStyleBackColor = true;
            this.divisionButton.Click += new System.EventHandler(this.Button_Click);
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(201, 528);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(154, 30);
            this.exitButton.TabIndex = 4;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.Button_Click);
            // 
            // firstNum
            // 
            this.firstNum.Location = new System.Drawing.Point(343, 236);
            this.firstNum.Name = "firstNum";
            this.firstNum.Size = new System.Drawing.Size(154, 22);
            this.firstNum.TabIndex = 5;
            // 
            // secondNum
            // 
            this.secondNum.Location = new System.Drawing.Point(343, 365);
            this.secondNum.Name = "secondNum";
            this.secondNum.Size = new System.Drawing.Size(154, 22);
            this.secondNum.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(376, 265);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Enter first number";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(353, 390);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Enter second number";
            // 
            // VerificationLabel
            // 
            this.VerificationLabel.AutoSize = true;
            this.VerificationLabel.Font = new System.Drawing.Font("Baskerville Old Face", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VerificationLabel.ForeColor = System.Drawing.Color.Red;
            this.VerificationLabel.Location = new System.Drawing.Point(209, 210);
            this.VerificationLabel.Name = "VerificationLabel";
            this.VerificationLabel.Size = new System.Drawing.Size(217, 19);
            this.VerificationLabel.TabIndex = 13;
            this.VerificationLabel.Text = "That is not a valid number!";
            // 
            // WelcomeLabel
            // 
            this.WelcomeLabel.AutoSize = true;
            this.WelcomeLabel.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WelcomeLabel.Location = new System.Drawing.Point(23, 10);
            this.WelcomeLabel.Name = "WelcomeLabel";
            this.WelcomeLabel.Size = new System.Drawing.Size(98, 23);
            this.WelcomeLabel.TabIndex = 14;
            this.WelcomeLabel.Text = "Welcome! ";
            // 
            // VerificationLabel2
            // 
            this.VerificationLabel2.AutoSize = true;
            this.VerificationLabel2.Font = new System.Drawing.Font("Baskerville Old Face", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VerificationLabel2.ForeColor = System.Drawing.Color.Red;
            this.VerificationLabel2.Location = new System.Drawing.Point(209, 335);
            this.VerificationLabel2.Name = "VerificationLabel2";
            this.VerificationLabel2.Size = new System.Drawing.Size(217, 19);
            this.VerificationLabel2.TabIndex = 15;
            this.VerificationLabel2.Text = "That is not a valid number!";
            // 
            // OutputLabel
            // 
            this.OutputLabel.AutoSize = true;
            this.OutputLabel.Font = new System.Drawing.Font("Baskerville Old Face", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OutputLabel.Location = new System.Drawing.Point(22, 464);
            this.OutputLabel.Name = "OutputLabel";
            this.OutputLabel.Size = new System.Drawing.Size(100, 27);
            this.OutputLabel.TabIndex = 16;
            this.OutputLabel.Text = "Output: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 629);
            this.Controls.Add(this.OutputLabel);
            this.Controls.Add(this.VerificationLabel2);
            this.Controls.Add(this.WelcomeLabel);
            this.Controls.Add(this.VerificationLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.secondNum);
            this.Controls.Add(this.firstNum);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.divisionButton);
            this.Controls.Add(this.multiplyButton);
            this.Controls.Add(this.subtractButton);
            this.Controls.Add(this.addButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Math Application                                                                " +
    "                                                                                " +
    "                 ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button subtractButton;
        private System.Windows.Forms.Button multiplyButton;
        private System.Windows.Forms.Button divisionButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.TextBox firstNum;
        private System.Windows.Forms.TextBox secondNum;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label VerificationLabel;
        private System.Windows.Forms.Label WelcomeLabel;
        private System.Windows.Forms.Label VerificationLabel2;
        private System.Windows.Forms.Label OutputLabel;
    }
}

