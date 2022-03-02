
namespace BalancedSubstring
{
    partial class StringInput
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StringInput));
            this.TxtBox_EnterString = new System.Windows.Forms.TextBox();
            this.Label_EnterString = new System.Windows.Forms.Label();
            this.Button_CalculateSubstring = new System.Windows.Forms.Button();
            this.Label_Description = new System.Windows.Forms.Label();
            this.Label_AnswerTitle = new System.Windows.Forms.Label();
            this.Label_Answer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TxtBox_EnterString
            // 
            this.TxtBox_EnterString.Location = new System.Drawing.Point(38, 172);
            this.TxtBox_EnterString.Name = "TxtBox_EnterString";
            this.TxtBox_EnterString.Size = new System.Drawing.Size(683, 22);
            this.TxtBox_EnterString.TabIndex = 0;
            // 
            // Label_EnterString
            // 
            this.Label_EnterString.AutoSize = true;
            this.Label_EnterString.Location = new System.Drawing.Point(35, 143);
            this.Label_EnterString.Name = "Label_EnterString";
            this.Label_EnterString.Size = new System.Drawing.Size(118, 17);
            this.Label_EnterString.TabIndex = 1;
            this.Label_EnterString.Text = "Enter String Here";
            // 
            // Button_CalculateSubstring
            // 
            this.Button_CalculateSubstring.Location = new System.Drawing.Point(259, 211);
            this.Button_CalculateSubstring.Name = "Button_CalculateSubstring";
            this.Button_CalculateSubstring.Size = new System.Drawing.Size(256, 23);
            this.Button_CalculateSubstring.TabIndex = 2;
            this.Button_CalculateSubstring.Text = "Calculate Balanced Substring";
            this.Button_CalculateSubstring.UseVisualStyleBackColor = true;
            this.Button_CalculateSubstring.Click += new System.EventHandler(this.Button_CalculateSubstring_Click);
            // 
            // Label_Description
            // 
            this.Label_Description.AutoSize = true;
            this.Label_Description.Location = new System.Drawing.Point(35, 9);
            this.Label_Description.Name = "Label_Description";
            this.Label_Description.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label_Description.Size = new System.Drawing.Size(631, 68);
            this.Label_Description.TabIndex = 3;
            this.Label_Description.Text = resources.GetString("Label_Description.Text");
            // 
            // Label_AnswerTitle
            // 
            this.Label_AnswerTitle.AutoSize = true;
            this.Label_AnswerTitle.Location = new System.Drawing.Point(304, 256);
            this.Label_AnswerTitle.Name = "Label_AnswerTitle";
            this.Label_AnswerTitle.Size = new System.Drawing.Size(168, 17);
            this.Label_AnswerTitle.TabIndex = 4;
            this.Label_AnswerTitle.Text = "The smallest substring is:";
            // 
            // Label_Answer
            // 
            this.Label_Answer.AutoSize = true;
            this.Label_Answer.Location = new System.Drawing.Point(350, 288);
            this.Label_Answer.Name = "Label_Answer";
            this.Label_Answer.Size = new System.Drawing.Size(68, 17);
            this.Label_Answer.TabIndex = 5;
            this.Label_Answer.Text = "ANSWER";
            // 
            // StringInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Label_Answer);
            this.Controls.Add(this.Label_AnswerTitle);
            this.Controls.Add(this.Label_Description);
            this.Controls.Add(this.Button_CalculateSubstring);
            this.Controls.Add(this.Label_EnterString);
            this.Controls.Add(this.TxtBox_EnterString);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "StringInput";
            this.Text = "Balanced Substring Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtBox_EnterString;
        private System.Windows.Forms.Label Label_EnterString;
        private System.Windows.Forms.Button Button_CalculateSubstring;
        private System.Windows.Forms.Label Label_Description;
        private System.Windows.Forms.Label Label_AnswerTitle;
        private System.Windows.Forms.Label Label_Answer;
    }
}

