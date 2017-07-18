namespace WindowsFormsApplication1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.from_butt = new System.Windows.Forms.Button();
            this.from_path_box = new System.Windows.Forms.TextBox();
            this.to_butt = new System.Windows.Forms.Button();
            this.to_path_box = new System.Windows.Forms.TextBox();
            this.to_list = new System.Windows.Forms.ListBox();
            this.copy_butt = new System.Windows.Forms.RadioButton();
            this.move_butt = new System.Windows.Forms.RadioButton();
            this.scann_butt = new System.Windows.Forms.Button();
            this.start_butt = new System.Windows.Forms.Button();
            this.progressbar = new System.Windows.Forms.ProgressBar();
            this.select_to = new System.Windows.Forms.Button();
            this.all_to = new System.Windows.Forms.Button();
            this.select_from = new System.Windows.Forms.Button();
            this.all_from = new System.Windows.Forms.Button();
            this.from_list = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(798, 556);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "v1.1 by mixa3607";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Location = new System.Drawing.Point(876, -2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(26, 23);
            this.button1.TabIndex = 16;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // from_butt
            // 
            this.from_butt.Location = new System.Drawing.Point(11, 4);
            this.from_butt.Name = "from_butt";
            this.from_butt.Size = new System.Drawing.Size(82, 29);
            this.from_butt.TabIndex = 0;
            this.from_butt.Text = "*.osz folder";
            this.from_butt.UseVisualStyleBackColor = true;
            this.from_butt.Click += new System.EventHandler(this.from_butt_Click);
            // 
            // from_path_box
            // 
            this.from_path_box.Enabled = false;
            this.from_path_box.Location = new System.Drawing.Point(99, 9);
            this.from_path_box.Name = "from_path_box";
            this.from_path_box.ReadOnly = true;
            this.from_path_box.ShortcutsEnabled = false;
            this.from_path_box.Size = new System.Drawing.Size(309, 20);
            this.from_path_box.TabIndex = 1;
            this.from_path_box.WordWrap = false;
            this.from_path_box.TextChanged += new System.EventHandler(this.from_path_box_TextChanged);
            // 
            // to_butt
            // 
            this.to_butt.Location = new System.Drawing.Point(476, 4);
            this.to_butt.Name = "to_butt";
            this.to_butt.Size = new System.Drawing.Size(82, 29);
            this.to_butt.TabIndex = 2;
            this.to_butt.Text = "Songs folder";
            this.to_butt.UseVisualStyleBackColor = true;
            this.to_butt.Click += new System.EventHandler(this.to_butt_Click);
            // 
            // to_path_box
            // 
            this.to_path_box.Cursor = System.Windows.Forms.Cursors.Default;
            this.to_path_box.Enabled = false;
            this.to_path_box.Location = new System.Drawing.Point(564, 9);
            this.to_path_box.Name = "to_path_box";
            this.to_path_box.ReadOnly = true;
            this.to_path_box.ShortcutsEnabled = false;
            this.to_path_box.Size = new System.Drawing.Size(299, 20);
            this.to_path_box.TabIndex = 3;
            this.to_path_box.WordWrap = false;
            // 
            // to_list
            // 
            this.to_list.FormattingEnabled = true;
            this.to_list.Location = new System.Drawing.Point(476, 40);
            this.to_list.Name = "to_list";
            this.to_list.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.to_list.Size = new System.Drawing.Size(412, 472);
            this.to_list.TabIndex = 5;
            // 
            // copy_butt
            // 
            this.copy_butt.AutoSize = true;
            this.copy_butt.BackColor = System.Drawing.Color.Transparent;
            this.copy_butt.Checked = true;
            this.copy_butt.Cursor = System.Windows.Forms.Cursors.Default;
            this.copy_butt.ForeColor = System.Drawing.Color.Fuchsia;
            this.copy_butt.Location = new System.Drawing.Point(13, 523);
            this.copy_butt.Name = "copy_butt";
            this.copy_butt.Size = new System.Drawing.Size(48, 17);
            this.copy_butt.TabIndex = 6;
            this.copy_butt.TabStop = true;
            this.copy_butt.Text = "copy";
            this.copy_butt.UseVisualStyleBackColor = false;
            // 
            // move_butt
            // 
            this.move_butt.AutoSize = true;
            this.move_butt.BackColor = System.Drawing.Color.Transparent;
            this.move_butt.ForeColor = System.Drawing.Color.Fuchsia;
            this.move_butt.Location = new System.Drawing.Point(13, 548);
            this.move_butt.Name = "move_butt";
            this.move_butt.Size = new System.Drawing.Size(51, 17);
            this.move_butt.TabIndex = 7;
            this.move_butt.Text = "move";
            this.move_butt.UseVisualStyleBackColor = false;
            // 
            // scann_butt
            // 
            this.scann_butt.BackColor = System.Drawing.Color.Transparent;
            this.scann_butt.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.scann_butt.ForeColor = System.Drawing.Color.Lime;
            this.scann_butt.Location = new System.Drawing.Point(82, 518);
            this.scann_butt.Name = "scann_butt";
            this.scann_butt.Size = new System.Drawing.Size(160, 47);
            this.scann_butt.TabIndex = 8;
            this.scann_butt.Text = "scann";
            this.scann_butt.UseVisualStyleBackColor = false;
            this.scann_butt.Click += new System.EventHandler(this.scann_butt_Click);
            // 
            // start_butt
            // 
            this.start_butt.BackColor = System.Drawing.Color.Transparent;
            this.start_butt.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.start_butt.ForeColor = System.Drawing.Color.Red;
            this.start_butt.Location = new System.Drawing.Point(255, 518);
            this.start_butt.Name = "start_butt";
            this.start_butt.Size = new System.Drawing.Size(160, 47);
            this.start_butt.TabIndex = 9;
            this.start_butt.Text = "start";
            this.start_butt.UseVisualStyleBackColor = false;
            this.start_butt.Click += new System.EventHandler(this.start_butt_Click);
            // 
            // progressbar
            // 
            this.progressbar.BackColor = System.Drawing.Color.DeepPink;
            this.progressbar.Location = new System.Drawing.Point(427, 518);
            this.progressbar.Name = "progressbar";
            this.progressbar.Size = new System.Drawing.Size(461, 35);
            this.progressbar.Step = 1;
            this.progressbar.TabIndex = 10;
            // 
            // select_to
            // 
            this.select_to.BackColor = System.Drawing.Color.Transparent;
            this.select_to.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("select_to.BackgroundImage")));
            this.select_to.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.select_to.Location = new System.Drawing.Point(427, 129);
            this.select_to.Name = "select_to";
            this.select_to.Size = new System.Drawing.Size(43, 41);
            this.select_to.TabIndex = 11;
            this.select_to.UseVisualStyleBackColor = false;
            this.select_to.Click += new System.EventHandler(this.select_to_Click);
            // 
            // all_to
            // 
            this.all_to.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("all_to.BackgroundImage")));
            this.all_to.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.all_to.Location = new System.Drawing.Point(427, 179);
            this.all_to.Name = "all_to";
            this.all_to.Size = new System.Drawing.Size(43, 41);
            this.all_to.TabIndex = 12;
            this.all_to.UseVisualStyleBackColor = true;
            this.all_to.Click += new System.EventHandler(this.all_to_Click);
            // 
            // select_from
            // 
            this.select_from.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("select_from.BackgroundImage")));
            this.select_from.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.select_from.Location = new System.Drawing.Point(427, 304);
            this.select_from.Name = "select_from";
            this.select_from.Size = new System.Drawing.Size(43, 41);
            this.select_from.TabIndex = 13;
            this.select_from.UseVisualStyleBackColor = true;
            this.select_from.Click += new System.EventHandler(this.select_from_Click);
            // 
            // all_from
            // 
            this.all_from.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("all_from.BackgroundImage")));
            this.all_from.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.all_from.Location = new System.Drawing.Point(427, 351);
            this.all_from.Name = "all_from";
            this.all_from.Size = new System.Drawing.Size(43, 41);
            this.all_from.TabIndex = 14;
            this.all_from.UseVisualStyleBackColor = true;
            this.all_from.Click += new System.EventHandler(this.all_from_Click);
            // 
            // from_list
            // 
            this.from_list.FormattingEnabled = true;
            this.from_list.Location = new System.Drawing.Point(11, 39);
            this.from_list.Name = "from_list";
            this.from_list.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.from_list.Size = new System.Drawing.Size(410, 472);
            this.from_list.TabIndex = 4;
            this.from_list.SelectedIndexChanged += new System.EventHandler(this.from_list_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(900, 575);
            this.Controls.Add(this.from_list);
            this.Controls.Add(this.all_from);
            this.Controls.Add(this.select_from);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.all_to);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.select_to);
            this.Controls.Add(this.from_butt);
            this.Controls.Add(this.progressbar);
            this.Controls.Add(this.from_path_box);
            this.Controls.Add(this.start_butt);
            this.Controls.Add(this.to_butt);
            this.Controls.Add(this.scann_butt);
            this.Controls.Add(this.to_path_box);
            this.Controls.Add(this.move_butt);
            this.Controls.Add(this.to_list);
            this.Controls.Add(this.copy_butt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "osu! copy *.osz helper";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button from_butt;
        private System.Windows.Forms.TextBox from_path_box;
        private System.Windows.Forms.Button to_butt;
        private System.Windows.Forms.TextBox to_path_box;
        private System.Windows.Forms.ListBox to_list;
        private System.Windows.Forms.RadioButton copy_butt;
        private System.Windows.Forms.RadioButton move_butt;
        private System.Windows.Forms.Button scann_butt;
        private System.Windows.Forms.Button start_butt;
        private System.Windows.Forms.ProgressBar progressbar;
        private System.Windows.Forms.Button select_to;
        private System.Windows.Forms.Button all_to;
        private System.Windows.Forms.Button select_from;
        private System.Windows.Forms.Button all_from;
        private System.Windows.Forms.ListBox from_list;
    }
}

