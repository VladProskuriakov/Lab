namespace FormApp
{
    partial class PointForm
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
            this.BtnCreate = new System.Windows.Forms.Button();
            this.BtnSort = new System.Windows.Forms.Button();
            this.BtnSerialize = new System.Windows.Forms.Button();
            this.BtnDeserialize = new System.Windows.Forms.Button();
            this.listBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // BtnCreate
            // 
            this.BtnCreate.Location = new System.Drawing.Point(12, 374);
            this.BtnCreate.Name = "BtnCreate";
            this.BtnCreate.Size = new System.Drawing.Size(177, 54);
            this.BtnCreate.TabIndex = 0;
            this.BtnCreate.Text = "Create";
            this.BtnCreate.UseVisualStyleBackColor = true;
            this.BtnCreate.Click += new System.EventHandler(this.BtnCreate_Click);
            // 
            // BtnSort
            // 
            this.BtnSort.Location = new System.Drawing.Point(215, 374);
            this.BtnSort.Name = "BtnSort";
            this.BtnSort.Size = new System.Drawing.Size(176, 54);
            this.BtnSort.TabIndex = 1;
            this.BtnSort.Text = "Sort";
            this.BtnSort.UseVisualStyleBackColor = true;
            this.BtnSort.Click += new System.EventHandler(this.BtnSort_Click);
            // 
            // BtnSerialize
            // 
            this.BtnSerialize.Location = new System.Drawing.Point(416, 374);
            this.BtnSerialize.Name = "BtnSerialize";
            this.BtnSerialize.Size = new System.Drawing.Size(165, 54);
            this.BtnSerialize.TabIndex = 2;
            this.BtnSerialize.Text = "Serialize";
            this.BtnSerialize.UseVisualStyleBackColor = true;
            this.BtnSerialize.Click += new System.EventHandler(this.BtnSerialize_Click);
            // 
            // BtnDeserialize
            // 
            this.BtnDeserialize.Location = new System.Drawing.Point(607, 374);
            this.BtnDeserialize.Name = "BtnDeserialize";
            this.BtnDeserialize.Size = new System.Drawing.Size(162, 54);
            this.BtnDeserialize.TabIndex = 3;
            this.BtnDeserialize.Text = "Deserialize";
            this.BtnDeserialize.UseVisualStyleBackColor = true;
            this.BtnDeserialize.Click += new System.EventHandler(this.BtnDeserialize_Click);
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.Location = new System.Drawing.Point(0, 2);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(769, 342);
            this.listBox.TabIndex = 4;
            // 
            // PointForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.BtnDeserialize);
            this.Controls.Add(this.BtnSerialize);
            this.Controls.Add(this.BtnSort);
            this.Controls.Add(this.BtnCreate);
            this.Name = "PointForm";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnCreate;
        private System.Windows.Forms.Button BtnSort;
        private System.Windows.Forms.Button BtnSerialize;
        private System.Windows.Forms.Button BtnDeserialize;
        private System.Windows.Forms.ListBox listBox;
    }
}

