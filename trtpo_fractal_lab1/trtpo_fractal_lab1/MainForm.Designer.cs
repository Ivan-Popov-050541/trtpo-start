
namespace trtpo_fractal_lab1
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.FractalPictureBox = new System.Windows.Forms.PictureBox();
            this.GenerateFractalButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.FractalPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // FractalPictureBox
            // 
            this.FractalPictureBox.BackColor = System.Drawing.SystemColors.Control;
            this.FractalPictureBox.Location = new System.Drawing.Point(258, 12);
            this.FractalPictureBox.Name = "FractalPictureBox";
            this.FractalPictureBox.Size = new System.Drawing.Size(512, 512);
            this.FractalPictureBox.TabIndex = 0;
            this.FractalPictureBox.TabStop = false;
            // 
            // GenerateFractalButton
            // 
            this.GenerateFractalButton.Location = new System.Drawing.Point(12, 12);
            this.GenerateFractalButton.Name = "GenerateFractalButton";
            this.GenerateFractalButton.Size = new System.Drawing.Size(214, 99);
            this.GenerateFractalButton.TabIndex = 1;
            this.GenerateFractalButton.Text = "Generate fractal";
            this.GenerateFractalButton.UseVisualStyleBackColor = true;
            this.GenerateFractalButton.Click += new System.EventHandler(this.GenerateFractalButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(782, 536);
            this.Controls.Add(this.GenerateFractalButton);
            this.Controls.Add(this.FractalPictureBox);
            this.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.FractalPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox FractalPictureBox;
        private System.Windows.Forms.Button GenerateFractalButton;
    }
}

