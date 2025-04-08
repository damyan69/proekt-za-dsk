namespace proektzadsk
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
            textboxTask = new TextBox();
            checkBox1 = new CheckBox();
            buttonAddTask = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // textboxTask
            // 
            textboxTask.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textboxTask.Location = new Point(12, 72);
            textboxTask.Name = "textboxTask";
            textboxTask.Size = new Size(414, 23);
            textboxTask.TabIndex = 0;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Segoe Script", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            checkBox1.ForeColor = SystemColors.Control;
            checkBox1.Location = new Point(12, 175);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(128, 32);
            checkBox1.TabIndex = 3;
            checkBox1.Text = "checkBox1";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // buttonAddTask
            // 
            buttonAddTask.Location = new Point(161, 101);
            buttonAddTask.Name = "buttonAddTask";
            buttonAddTask.Size = new Size(114, 28);
            buttonAddTask.TabIndex = 4;
            buttonAddTask.Text = "Add";
            buttonAddTask.UseVisualStyleBackColor = true;
            buttonAddTask.Click += buttonAddTask_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(515, 276);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 64, 0);
            ClientSize = new Size(438, 603);
            Controls.Add(label1);
            Controls.Add(buttonAddTask);
            Controls.Add(checkBox1);
            Controls.Add(textboxTask);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textboxTask;
        private CheckBox checkBox1;
        private Button buttonAddTask;
        private Label label1;
    }
}
