namespace _11._02._2020
{
    partial class Form1
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
            this.AddUser = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.UpdateLB = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AddUser
            // 
            this.AddUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddUser.Location = new System.Drawing.Point(791, 12);
            this.AddUser.Name = "AddUser";
            this.AddUser.Size = new System.Drawing.Size(150, 38);
            this.AddUser.TabIndex = 0;
            this.AddUser.Text = "Add Uzver";
            this.AddUser.UseVisualStyleBackColor = true;
            this.AddUser.Click += new System.EventHandler(this.AddUser_Click);
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(13, 13);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(772, 452);
            this.listBox1.TabIndex = 1;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // UpdateLB
            // 
            this.UpdateLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UpdateLB.Location = new System.Drawing.Point(13, 479);
            this.UpdateLB.Name = "UpdateLB";
            this.UpdateLB.Size = new System.Drawing.Size(158, 38);
            this.UpdateLB.TabIndex = 2;
            this.UpdateLB.Text = "UPDATE";
            this.UpdateLB.UseVisualStyleBackColor = true;
            this.UpdateLB.Click += new System.EventHandler(this.UpdateLB_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(953, 665);
            this.Controls.Add(this.UpdateLB);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.AddUser);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AddUser;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button UpdateLB;
    }
}

