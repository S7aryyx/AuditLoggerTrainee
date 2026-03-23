namespace AuditLogger.WinForms
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
            rbDatabase = new RadioButton();
            rbFile = new RadioButton();
            rbMemory = new RadioButton();
            btnInit = new Button();
            btnAdd = new Button();
            btnLoad = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // rbDatabase
            // 
            rbDatabase.AutoSize = true;
            rbDatabase.Location = new Point(13, 286);
            rbDatabase.Name = "rbDatabase";
            rbDatabase.Size = new Size(104, 19);
            rbDatabase.TabIndex = 0;
            rbDatabase.TabStop = true;
            rbDatabase.Text = "В Базу Данных";
            rbDatabase.UseVisualStyleBackColor = true;
            // 
            // rbFile
            // 
            rbFile.AutoSize = true;
            rbFile.Location = new Point(12, 261);
            rbFile.Name = "rbFile";
            rbFile.Size = new Size(64, 19);
            rbFile.TabIndex = 1;
            rbFile.TabStop = true;
            rbFile.Text = "В файл";
            rbFile.UseVisualStyleBackColor = true;
            // 
            // rbMemory
            // 
            rbMemory.AutoSize = true;
            rbMemory.Location = new Point(13, 236);
            rbMemory.Name = "rbMemory";
            rbMemory.Size = new Size(74, 19);
            rbMemory.TabIndex = 2;
            rbMemory.TabStop = true;
            rbMemory.Text = "В память";
            rbMemory.UseVisualStyleBackColor = true;
            // 
            // btnInit
            // 
            btnInit.Location = new Point(12, 415);
            btnInit.Name = "btnInit";
            btnInit.Size = new Size(75, 23);
            btnInit.TabIndex = 3;
            btnInit.Text = "Создать";
            btnInit.UseVisualStyleBackColor = true;
            btnInit.Click += btnInit_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(174, 415);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "Добавить";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(93, 415);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(75, 23);
            btnLoad.TabIndex = 5;
            btnLoad.Text = "Загрузить";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(776, 218);
            dataGridView1.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(btnLoad);
            Controls.Add(btnAdd);
            Controls.Add(btnInit);
            Controls.Add(rbMemory);
            Controls.Add(rbFile);
            Controls.Add(rbDatabase);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton rbDatabase;
        private RadioButton rbFile;
        private RadioButton rbMemory;
        private Button btnInit;
        private Button btnAdd;
        private Button btnLoad;
        private DataGridView dataGridView1;
    }
}
