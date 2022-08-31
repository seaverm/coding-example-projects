namespace PigLatinWriter
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
            this.txtBox_Input = new System.Windows.Forms.TextBox();
            this.btn_Translate = new System.Windows.Forms.Button();
            this.txtBox_Output = new System.Windows.Forms.TextBox();
            this.lbl_AppTitle = new System.Windows.Forms.Label();
            this.lbl_EnterEnglishText = new System.Windows.Forms.Label();
            this.lbl_PigLatinTranslation = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtBox_Input
            // 
            this.txtBox_Input.Location = new System.Drawing.Point(26, 176);
            this.txtBox_Input.Name = "txtBox_Input";
            this.txtBox_Input.Size = new System.Drawing.Size(734, 23);
            this.txtBox_Input.TabIndex = 0;
            this.txtBox_Input.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btn_Translate
            // 
            this.btn_Translate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Translate.Location = new System.Drawing.Point(301, 217);
            this.btn_Translate.Name = "btn_Translate";
            this.btn_Translate.Size = new System.Drawing.Size(182, 56);
            this.btn_Translate.TabIndex = 1;
            this.btn_Translate.Text = "Translate to Pig Latin";
            this.btn_Translate.UseVisualStyleBackColor = true;
            this.btn_Translate.Click += new System.EventHandler(this.btn_Translate_Click);
            // 
            // txtBox_Output
            // 
            this.txtBox_Output.Location = new System.Drawing.Point(26, 327);
            this.txtBox_Output.Name = "txtBox_Output";
            this.txtBox_Output.Size = new System.Drawing.Size(734, 23);
            this.txtBox_Output.TabIndex = 2;
            this.txtBox_Output.TextChanged += new System.EventHandler(this.txtBox_Output_TextChanged);
            // 
            // lbl_AppTitle
            // 
            this.lbl_AppTitle.AutoSize = true;
            this.lbl_AppTitle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_AppTitle.Location = new System.Drawing.Point(69, 19);
            this.lbl_AppTitle.Name = "lbl_AppTitle";
            this.lbl_AppTitle.Size = new System.Drawing.Size(658, 74);
            this.lbl_AppTitle.TabIndex = 3;
            this.lbl_AppTitle.Text = "English to Pig Latin Translater by Matthew Seaver.\r\n\r\n";
            this.lbl_AppTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_EnterEnglishText
            // 
            this.lbl_EnterEnglishText.AutoSize = true;
            this.lbl_EnterEnglishText.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_EnterEnglishText.Location = new System.Drawing.Point(318, 143);
            this.lbl_EnterEnglishText.Name = "lbl_EnterEnglishText";
            this.lbl_EnterEnglishText.Size = new System.Drawing.Size(137, 15);
            this.lbl_EnterEnglishText.TabIndex = 4;
            this.lbl_EnterEnglishText.Text = "Enter English Text Here";
            // 
            // lbl_PigLatinTranslation
            // 
            this.lbl_PigLatinTranslation.AutoSize = true;
            this.lbl_PigLatinTranslation.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_PigLatinTranslation.Location = new System.Drawing.Point(332, 299);
            this.lbl_PigLatinTranslation.Name = "lbl_PigLatinTranslation";
            this.lbl_PigLatinTranslation.Size = new System.Drawing.Size(117, 15);
            this.lbl_PigLatinTranslation.TabIndex = 5;
            this.lbl_PigLatinTranslation.Text = "Pig Latin Translation";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_PigLatinTranslation);
            this.Controls.Add(this.lbl_EnterEnglishText);
            this.Controls.Add(this.lbl_AppTitle);
            this.Controls.Add(this.txtBox_Output);
            this.Controls.Add(this.btn_Translate);
            this.Controls.Add(this.txtBox_Input);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Pig Latin Writer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtBox_Input;
        private Button btn_Translate;
        private TextBox txtBox_Output;
        private Label lbl_AppTitle;
        private Label lbl_EnterEnglishText;
        private Label lbl_PigLatinTranslation;
    }
}