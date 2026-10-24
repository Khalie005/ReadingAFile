namespace FrmLab1
{
    partial class FrmStudentRecord
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
            label1 = new Label();
            lvViewRecord = new ListView();
            openFileDialog1 = new OpenFileDialog();
            btnUpload = new Button();
            btnFind = new Button();
            btnRegister = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Nirmala UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(122, 25);
            label1.TabIndex = 5;
            label1.Text = "View Record";
            // 
            // lvViewRecord
            // 
            lvViewRecord.FullRowSelect = true;
            lvViewRecord.Location = new Point(12, 37);
            lvViewRecord.Name = "lvViewRecord";
            lvViewRecord.Size = new Size(360, 180);
            lvViewRecord.TabIndex = 6;
            lvViewRecord.UseCompatibleStateImageBehavior = false;
            lvViewRecord.View = View.SmallIcon;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnUpload
            // 
            btnUpload.BackColor = Color.SlateGray;
            btnUpload.Font = new Font("Nirmala UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnUpload.ForeColor = SystemColors.ControlLightLight;
            btnUpload.Location = new Point(378, 105);
            btnUpload.Name = "btnUpload";
            btnUpload.Size = new Size(110, 34);
            btnUpload.TabIndex = 24;
            btnUpload.Text = "Upload";
            btnUpload.UseVisualStyleBackColor = false;
            btnUpload.Click += btnUpload_Click;
            // 
            // btnFind
            // 
            btnFind.BackColor = Color.SlateGray;
            btnFind.Font = new Font("Nirmala UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnFind.ForeColor = SystemColors.ControlLightLight;
            btnFind.Location = new Point(378, 71);
            btnFind.Name = "btnFind";
            btnFind.Size = new Size(110, 34);
            btnFind.TabIndex = 25;
            btnFind.Text = "Find";
            btnFind.UseVisualStyleBackColor = false;
            btnFind.Click += btnFind_Click;
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.SlateGray;
            btnRegister.Font = new Font("Nirmala UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRegister.ForeColor = SystemColors.ControlLightLight;
            btnRegister.Location = new Point(378, 36);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(110, 34);
            btnRegister.TabIndex = 26;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // FrmStudentRecord
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(506, 239);
            Controls.Add(btnRegister);
            Controls.Add(btnFind);
            Controls.Add(btnUpload);
            Controls.Add(lvViewRecord);
            Controls.Add(label1);
            Name = "FrmStudentRecord";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmStudentRecord";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListView lvViewRecord;
        private OpenFileDialog openFileDialog1;
        private Button btnUpload;
        private Button btnFind;
        private Button btnRegister;
    }
}