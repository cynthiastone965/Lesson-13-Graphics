namespace Lesson_13_Graphics
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            instructionLabel = new Label();
            mainScreenButton = new Button();
            SuspendLayout();
            // 
            // instructionLabel
            // 
            instructionLabel.Location = new Point(0, 9);
            instructionLabel.Name = "instructionLabel";
            instructionLabel.Size = new Size(413, 822);
            instructionLabel.TabIndex = 0;
            instructionLabel.Text = resources.GetString("instructionLabel.Text");
            // 
            // mainScreenButton
            // 
            mainScreenButton.BackColor = Color.FromArgb(255, 255, 192);
            mainScreenButton.Location = new Point(0, 776);
            mainScreenButton.Name = "mainScreenButton";
            mainScreenButton.Size = new Size(376, 46);
            mainScreenButton.TabIndex = 1;
            mainScreenButton.Text = "Back to Main Screen";
            mainScreenButton.UseVisualStyleBackColor = false;
            mainScreenButton.Click += mainScreenButton_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(13F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1247, 822);
            Controls.Add(mainScreenButton);
            Controls.Add(instructionLabel);
            Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "Form2";
            Text = "Practice Form!";
            Load += Form2_Load;
            ResumeLayout(false);
        }

        #endregion

        private Label instructionLabel;
        private Button mainScreenButton;
    }
}