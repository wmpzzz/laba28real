namespace laba28
{
    partial class MainForm
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
            ToEx1Button = new Button();
            ToEx2Button = new Button();
            ToEx3Button = new Button();
            SuspendLayout();
            // 
            // ToEx1Button
            // 
            ToEx1Button.Location = new Point(155, 56);
            ToEx1Button.Name = "ToEx1Button";
            ToEx1Button.Size = new Size(180, 81);
            ToEx1Button.TabIndex = 0;
            ToEx1Button.Text = "Задание 1";
            ToEx1Button.UseVisualStyleBackColor = true;
            ToEx1Button.Click += ToEx1Button_Click;
            // 
            // ToEx2Button
            // 
            ToEx2Button.Location = new Point(155, 160);
            ToEx2Button.Name = "ToEx2Button";
            ToEx2Button.Size = new Size(180, 81);
            ToEx2Button.TabIndex = 1;
            ToEx2Button.Text = "Задание 2";
            ToEx2Button.UseVisualStyleBackColor = true;
            ToEx2Button.Click += ToEx2Button_Click;
            // 
            // ToEx3Button
            // 
            ToEx3Button.Location = new Point(155, 262);
            ToEx3Button.Name = "ToEx3Button";
            ToEx3Button.Size = new Size(180, 81);
            ToEx3Button.TabIndex = 2;
            ToEx3Button.Text = "Задание 3";
            ToEx3Button.UseVisualStyleBackColor = true;
            ToEx3Button.Click += ToEx3Button_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(501, 450);
            Controls.Add(ToEx3Button);
            Controls.Add(ToEx2Button);
            Controls.Add(ToEx1Button);
            Name = "MainForm";
            Text = "Лабораторная работа 27";
            ResumeLayout(false);
        }

        #endregion

        private Button ToEx1Button;
        private Button ToEx2Button;
        private Button ToEx3Button;
    }
}
