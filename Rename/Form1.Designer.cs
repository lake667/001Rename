namespace Rename
{
    partial class Form_RenameProgram
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.button_CopyandRename = new System.Windows.Forms.Button();
            this.button_Rename = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.listBox_fileview = new System.Windows.Forms.ListBox();
            this.button_findDictionary = new System.Windows.Forms.Button();
            this.openFileDialog_1 = new System.Windows.Forms.OpenFileDialog();
            this.button_Delete = new System.Windows.Forms.Button();
            this.checkBox_Select = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_CopyandRename
            // 
            this.button_CopyandRename.BackColor = System.Drawing.Color.MediumTurquoise;
            this.button_CopyandRename.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_CopyandRename.Location = new System.Drawing.Point(351, 412);
            this.button_CopyandRename.Margin = new System.Windows.Forms.Padding(4);
            this.button_CopyandRename.Name = "button_CopyandRename";
            this.button_CopyandRename.Size = new System.Drawing.Size(142, 41);
            this.button_CopyandRename.TabIndex = 0;
            this.button_CopyandRename.Text = "取消";
            this.button_CopyandRename.UseVisualStyleBackColor = false;
            this.button_CopyandRename.Click += new System.EventHandler(this.Button_Canceal_Click);
            // 
            // button_Rename
            // 
            this.button_Rename.BackColor = System.Drawing.Color.Turquoise;
            this.button_Rename.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_Rename.Location = new System.Drawing.Point(351, 366);
            this.button_Rename.Margin = new System.Windows.Forms.Padding(4);
            this.button_Rename.Name = "button_Rename";
            this.button_Rename.Size = new System.Drawing.Size(142, 38);
            this.button_Rename.TabIndex = 1;
            this.button_Rename.Text = "确定";
            this.button_Rename.UseVisualStyleBackColor = false;
            this.button_Rename.Click += new System.EventHandler(this.Button_OK_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.checkBox1.Location = new System.Drawing.Point(13, 30);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(231, 24);
            this.checkBox1.TabIndex = 2;
            this.checkBox1.Text = "加日期前缀(当前日期)";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.CheckBox1_CheckedChanged);
            // 
            // listBox_fileview
            // 
            this.listBox_fileview.AllowDrop = true;
            this.listBox_fileview.Font = new System.Drawing.Font("宋体", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.listBox_fileview.FormattingEnabled = true;
            this.listBox_fileview.ItemHeight = 18;
            this.listBox_fileview.Location = new System.Drawing.Point(3, 43);
            this.listBox_fileview.Margin = new System.Windows.Forms.Padding(4);
            this.listBox_fileview.Name = "listBox_fileview";
            this.listBox_fileview.ScrollAlwaysVisible = true;
            this.listBox_fileview.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBox_fileview.Size = new System.Drawing.Size(497, 202);
            this.listBox_fileview.TabIndex = 11;
            this.listBox_fileview.DragDrop += new System.Windows.Forms.DragEventHandler(this.ListBox_fileview_DragDrop);
            this.listBox_fileview.DragEnter += new System.Windows.Forms.DragEventHandler(this.ListBox_fileview_DragEnter);
            // 
            // button_findDictionary
            // 
            this.button_findDictionary.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_findDictionary.Location = new System.Drawing.Point(205, 6);
            this.button_findDictionary.Margin = new System.Windows.Forms.Padding(4);
            this.button_findDictionary.Name = "button_findDictionary";
            this.button_findDictionary.Size = new System.Drawing.Size(138, 29);
            this.button_findDictionary.TabIndex = 1;
            this.button_findDictionary.Text = "添加(浏览)";
            this.button_findDictionary.UseVisualStyleBackColor = true;
            this.button_findDictionary.Click += new System.EventHandler(this.FindDictionary_Click);
            // 
            // button_Delete
            // 
            this.button_Delete.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_Delete.Location = new System.Drawing.Point(351, 6);
            this.button_Delete.Margin = new System.Windows.Forms.Padding(4);
            this.button_Delete.Name = "button_Delete";
            this.button_Delete.Size = new System.Drawing.Size(142, 29);
            this.button_Delete.TabIndex = 1;
            this.button_Delete.Text = "移除所选文件";
            this.button_Delete.UseVisualStyleBackColor = true;
            this.button_Delete.Click += new System.EventHandler(this.Button_Delete_Click);
            // 
            // checkBox_Select
            // 
            this.checkBox_Select.AutoSize = true;
            this.checkBox_Select.Checked = true;
            this.checkBox_Select.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_Select.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.checkBox_Select.Location = new System.Drawing.Point(13, 64);
            this.checkBox_Select.Name = "checkBox_Select";
            this.checkBox_Select.Size = new System.Drawing.Size(181, 24);
            this.checkBox_Select.TabIndex = 13;
            this.checkBox_Select.Text = "选择全部/全不选";
            this.checkBox_Select.UseVisualStyleBackColor = true;
            this.checkBox_Select.CheckedChanged += new System.EventHandler(this.CheckBox_Select);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(5, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "将文件拖入：";
            // 
            // textBox1
            // 
            this.textBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.textBox1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox1.Location = new System.Drawing.Point(117, 25);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(367, 27);
            this.textBox1.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBox_Select);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(9, 359);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(320, 94);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "附加选项";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "原文件名";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox2.Location = new System.Drawing.Point(9, 252);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(491, 96);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "文件名替换";
            // 
            // textBox2
            // 
            this.textBox2.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.textBox2.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox2.Location = new System.Drawing.Point(117, 60);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(367, 27);
            this.textBox2.TabIndex = 3;
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "新文件名";
            // 
            // Form_RenameProgram
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 475);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_Rename);
            this.Controls.Add(this.listBox_fileview);
            this.Controls.Add(this.button_Delete);
            this.Controls.Add(this.button_findDictionary);
            this.Controls.Add(this.button_CopyandRename);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form_RenameProgram";
            this.Text = "Rename20220725版";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_CopyandRename;
        private System.Windows.Forms.Button button_Rename;
        private System.Windows.Forms.ListBox listBox_fileview;
        private System.Windows.Forms.Button button_findDictionary;
        private System.Windows.Forms.OpenFileDialog openFileDialog_1;
        private System.Windows.Forms.Button button_Delete;
        private System.Windows.Forms.CheckBox checkBox_Select;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.CheckBox checkBox1;
    }
}

