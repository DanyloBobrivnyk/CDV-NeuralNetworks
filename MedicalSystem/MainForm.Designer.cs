namespace MedicalSystem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.insertTestDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TrainTestButton = new System.Windows.Forms.Button();
            this.EpochsTestTextBox = new System.Windows.Forms.TextBox();
            this.TestDataSet_AmountLabel = new System.Windows.Forms.Label();
            this.TestDataSet_Label = new System.Windows.Forms.Label();
            this.ExtendedDataSet_TextBox = new System.Windows.Forms.TextBox();
            this.ExtendedDataSet_Button = new System.Windows.Forms.Button();
            this.ExtendedDataSet_AmountLabel = new System.Windows.Forms.Label();
            this.ExtendedDataSet_Label = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.enterToolStripMenuItem,
            this.insertTestDataToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // enterToolStripMenuItem
            // 
            this.enterToolStripMenuItem.Name = "enterToolStripMenuItem";
            this.enterToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.enterToolStripMenuItem.Text = "Insert Data";
            this.enterToolStripMenuItem.Click += new System.EventHandler(this.enterToolStripMenuItem_Click);
            // 
            // insertTestDataToolStripMenuItem
            // 
            this.insertTestDataToolStripMenuItem.Name = "insertTestDataToolStripMenuItem";
            this.insertTestDataToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.insertTestDataToolStripMenuItem.Text = "Insert Test Data";
            this.insertTestDataToolStripMenuItem.Click += new System.EventHandler(this.insertTestDataToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(101, 20);
            this.aboutToolStripMenuItem.Text = "About Program";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // TrainTestButton
            // 
            this.TrainTestButton.Location = new System.Drawing.Point(118, 375);
            this.TrainTestButton.Name = "TrainTestButton";
            this.TrainTestButton.Size = new System.Drawing.Size(75, 23);
            this.TrainTestButton.TabIndex = 1;
            this.TrainTestButton.Text = "Train";
            this.TrainTestButton.UseVisualStyleBackColor = true;
            this.TrainTestButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // EpochsTestTextBox
            // 
            this.EpochsTestTextBox.Location = new System.Drawing.Point(12, 378);
            this.EpochsTestTextBox.Name = "EpochsTestTextBox";
            this.EpochsTestTextBox.Size = new System.Drawing.Size(100, 20);
            this.EpochsTestTextBox.TabIndex = 2;
            // 
            // TestDataSet_AmountLabel
            // 
            this.TestDataSet_AmountLabel.AutoSize = true;
            this.TestDataSet_AmountLabel.Location = new System.Drawing.Point(12, 362);
            this.TestDataSet_AmountLabel.Name = "TestDataSet_AmountLabel";
            this.TestDataSet_AmountLabel.Size = new System.Drawing.Size(94, 13);
            this.TestDataSet_AmountLabel.TabIndex = 3;
            this.TestDataSet_AmountLabel.Text = "Amount of Epochs";
            // 
            // TestDataSet_Label
            // 
            this.TestDataSet_Label.AutoSize = true;
            this.TestDataSet_Label.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TestDataSet_Label.Location = new System.Drawing.Point(8, 321);
            this.TestDataSet_Label.Name = "TestDataSet_Label";
            this.TestDataSet_Label.Size = new System.Drawing.Size(104, 19);
            this.TestDataSet_Label.TabIndex = 4;
            this.TestDataSet_Label.Text = "Test data set";
            // 
            // ExtendedDataSet_TextBox
            // 
            this.ExtendedDataSet_TextBox.Location = new System.Drawing.Point(517, 375);
            this.ExtendedDataSet_TextBox.Name = "ExtendedDataSet_TextBox";
            this.ExtendedDataSet_TextBox.Size = new System.Drawing.Size(100, 20);
            this.ExtendedDataSet_TextBox.TabIndex = 5;
            // 
            // ExtendedDataSet_Button
            // 
            this.ExtendedDataSet_Button.Location = new System.Drawing.Point(623, 375);
            this.ExtendedDataSet_Button.Name = "ExtendedDataSet_Button";
            this.ExtendedDataSet_Button.Size = new System.Drawing.Size(75, 23);
            this.ExtendedDataSet_Button.TabIndex = 6;
            this.ExtendedDataSet_Button.Text = "Train";
            this.ExtendedDataSet_Button.UseVisualStyleBackColor = true;
            this.ExtendedDataSet_Button.Click += new System.EventHandler(this.ExtendedDataSet_Button_Click);
            // 
            // ExtendedDataSet_AmountLabel
            // 
            this.ExtendedDataSet_AmountLabel.AutoSize = true;
            this.ExtendedDataSet_AmountLabel.Location = new System.Drawing.Point(514, 359);
            this.ExtendedDataSet_AmountLabel.Name = "ExtendedDataSet_AmountLabel";
            this.ExtendedDataSet_AmountLabel.Size = new System.Drawing.Size(94, 13);
            this.ExtendedDataSet_AmountLabel.TabIndex = 7;
            this.ExtendedDataSet_AmountLabel.Text = "Amount of Epochs";
            // 
            // ExtendedDataSet_Label
            // 
            this.ExtendedDataSet_Label.AutoSize = true;
            this.ExtendedDataSet_Label.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExtendedDataSet_Label.Location = new System.Drawing.Point(513, 321);
            this.ExtendedDataSet_Label.Name = "ExtendedDataSet_Label";
            this.ExtendedDataSet_Label.Size = new System.Drawing.Size(155, 22);
            this.ExtendedDataSet_Label.TabIndex = 8;
            this.ExtendedDataSet_Label.Text = "Extended data set";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ExtendedDataSet_Label);
            this.Controls.Add(this.ExtendedDataSet_AmountLabel);
            this.Controls.Add(this.ExtendedDataSet_Button);
            this.Controls.Add(this.ExtendedDataSet_TextBox);
            this.Controls.Add(this.TestDataSet_Label);
            this.Controls.Add(this.TestDataSet_AmountLabel);
            this.Controls.Add(this.EpochsTestTextBox);
            this.Controls.Add(this.TrainTestButton);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Medical system";
            this.Load += new System.EventHandler(this.initializeController);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem insertTestDataToolStripMenuItem;
        private System.Windows.Forms.Button TrainTestButton;
        private System.Windows.Forms.TextBox EpochsTestTextBox;
        private System.Windows.Forms.Label TestDataSet_AmountLabel;
        private System.Windows.Forms.Label TestDataSet_Label;
        private System.Windows.Forms.TextBox ExtendedDataSet_TextBox;
        private System.Windows.Forms.Button ExtendedDataSet_Button;
        private System.Windows.Forms.Label ExtendedDataSet_AmountLabel;
        private System.Windows.Forms.Label ExtendedDataSet_Label;
    }
}

