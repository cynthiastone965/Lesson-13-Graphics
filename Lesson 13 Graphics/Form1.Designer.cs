namespace Lesson_13_Graphics
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            practiceFormButton = new Button();
            SuspendLayout();
            // 
            // practiceFormButton
            // 
            practiceFormButton.BackColor = Color.FromArgb(255, 255, 192);
            practiceFormButton.Location = new Point(12, 992);
            practiceFormButton.Name = "practiceFormButton";
            practiceFormButton.Size = new Size(353, 46);
            practiceFormButton.TabIndex = 0;
            practiceFormButton.Text = "Go To Practice Form";
            practiceFormButton.UseVisualStyleBackColor = false;
            practiceFormButton.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1423, 1050);
            Controls.Add(practiceFormButton);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Lesson 13 Graphics";
            Paint += Form1_Paint;
            ResumeLayout(false);
        }

        #endregion

        private Button practiceFormButton;
    }
}
