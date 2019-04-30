namespace Randomizer
{
    partial class CSD_Randomizer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CSD_Randomizer));
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.generateButton = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.label3 = new System.Windows.Forms.Label();
            this.teamCountTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.personTextBox = new System.Windows.Forms.TextBox();
            this.teamTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // generateButton
            // 
            this.generateButton.Location = new System.Drawing.Point(563, 9);
            this.generateButton.Name = "generateButton";
            this.generateButton.Size = new System.Drawing.Size(96, 23);
            this.generateButton.TabIndex = 7;
            this.generateButton.Text = "Сгенерировать";
            this.generateButton.UseVisualStyleBackColor = true;
            this.generateButton.Click += new System.EventHandler(this.GenerateButtonClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 9);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Количество команд";
            // 
            // teamCountTextBox
            // 
            this.teamCountTextBox.Location = new System.Drawing.Point(137, 2);
            this.teamCountTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.teamCountTextBox.Name = "teamCountTextBox";
            this.teamCountTextBox.Size = new System.Drawing.Size(76, 20);
            this.teamCountTextBox.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Input (name, points)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(331, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Output";
            // 
            // personTextBox
            // 
            this.personTextBox.Location = new System.Drawing.Point(15, 53);
            this.personTextBox.Multiline = true;
            this.personTextBox.Name = "personTextBox";
            this.personTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.personTextBox.Size = new System.Drawing.Size(313, 335);
            this.personTextBox.TabIndex = 13;
            // 
            // teamTextBox
            // 
            this.teamTextBox.Location = new System.Drawing.Point(334, 52);
            this.teamTextBox.Multiline = true;
            this.teamTextBox.Name = "teamTextBox";
            this.teamTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.teamTextBox.Size = new System.Drawing.Size(325, 336);
            this.teamTextBox.TabIndex = 14;
            // 
            // CSD_Randomizer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 400);
            this.Controls.Add(this.teamTextBox);
            this.Controls.Add(this.personTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.teamCountTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.generateButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CSD_Randomizer";
            this.Text = "HITS_Randomizer";
            this.Load += new System.EventHandler(this.CSD_Randomizer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button generateButton;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox teamCountTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox personTextBox;
        private System.Windows.Forms.TextBox teamTextBox;
    }
}

