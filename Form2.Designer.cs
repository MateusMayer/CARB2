namespace CARB2
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.checkBoxCdb = new System.Windows.Forms.CheckBox();
            this.checkBoxApi = new System.Windows.Forms.CheckBox();
            this.checkBoxApy = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.LabelFiles = new System.Windows.Forms.Label();
            this.SearchFiles = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.ButtonEncontrar = new System.Windows.Forms.Button();
            this.OpenFileEncontrar = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // checkBoxCdb
            // 
            this.checkBoxCdb.AutoSize = true;
            this.checkBoxCdb.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxCdb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.checkBoxCdb.Checked = true;
            this.checkBoxCdb.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxCdb.Cursor = System.Windows.Forms.Cursors.Cross;
            this.checkBoxCdb.Font = new System.Drawing.Font("OpenSymbol", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxCdb.ForeColor = System.Drawing.Color.White;
            this.checkBoxCdb.Location = new System.Drawing.Point(300, 197);
            this.checkBoxCdb.Name = "checkBoxCdb";
            this.checkBoxCdb.Size = new System.Drawing.Size(70, 24);
            this.checkBoxCdb.TabIndex = 0;
            this.checkBoxCdb.Text = ".CDB";
            this.checkBoxCdb.UseVisualStyleBackColor = false;
            // 
            // checkBoxApi
            // 
            this.checkBoxApi.AutoSize = true;
            this.checkBoxApi.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxApi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.checkBoxApi.Checked = true;
            this.checkBoxApi.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxApi.Cursor = System.Windows.Forms.Cursors.Cross;
            this.checkBoxApi.Font = new System.Drawing.Font("OpenSymbol", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxApi.ForeColor = System.Drawing.Color.White;
            this.checkBoxApi.Location = new System.Drawing.Point(420, 197);
            this.checkBoxApi.Name = "checkBoxApi";
            this.checkBoxApi.Size = new System.Drawing.Size(62, 24);
            this.checkBoxApi.TabIndex = 1;
            this.checkBoxApi.Text = ".API";
            this.checkBoxApi.UseVisualStyleBackColor = false;
            // 
            // checkBoxApy
            // 
            this.checkBoxApy.AutoSize = true;
            this.checkBoxApy.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxApy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.checkBoxApy.Checked = true;
            this.checkBoxApy.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxApy.Cursor = System.Windows.Forms.Cursors.Cross;
            this.checkBoxApy.Font = new System.Drawing.Font("OpenSymbol", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxApy.ForeColor = System.Drawing.Color.White;
            this.checkBoxApy.Location = new System.Drawing.Point(536, 197);
            this.checkBoxApy.Name = "checkBoxApy";
            this.checkBoxApy.Size = new System.Drawing.Size(68, 24);
            this.checkBoxApy.TabIndex = 2;
            this.checkBoxApy.Text = ".APY";
            this.checkBoxApy.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.AccessibleDescription = "Fechar";
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = global::CARB2.Properties.Resources.fechar;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Location = new System.Drawing.Point(844, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(41, 38);
            this.button1.TabIndex = 3;
            this.button1.Tag = "Fechar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // LabelFiles
            // 
            this.LabelFiles.AutoSize = true;
            this.LabelFiles.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.LabelFiles.Location = new System.Drawing.Point(92, 131);
            this.LabelFiles.MaximumSize = new System.Drawing.Size(100, 100);
            this.LabelFiles.MinimumSize = new System.Drawing.Size(711, 30);
            this.LabelFiles.Name = "LabelFiles";
            this.LabelFiles.Size = new System.Drawing.Size(711, 30);
            this.LabelFiles.TabIndex = 4;
            this.LabelFiles.Text = "Selecione o diretório que deseja procurar...";
            this.LabelFiles.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SearchFiles
            // 
            this.SearchFiles.BackColor = System.Drawing.Color.Transparent;
            this.SearchFiles.FlatAppearance.BorderSize = 0;
            this.SearchFiles.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Turquoise;
            this.SearchFiles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchFiles.Image = global::CARB2.Properties.Resources.arquivos;
            this.SearchFiles.Location = new System.Drawing.Point(809, 121);
            this.SearchFiles.Name = "SearchFiles";
            this.SearchFiles.Size = new System.Drawing.Size(49, 49);
            this.SearchFiles.TabIndex = 5;
            this.SearchFiles.UseVisualStyleBackColor = false;
            this.SearchFiles.Click += new System.EventHandler(this.SearchFiles_Click_1);
            // 
            // ButtonEncontrar
            // 
            this.ButtonEncontrar.BackColor = System.Drawing.Color.Transparent;
            this.ButtonEncontrar.BackgroundImage = global::CARB2.Properties.Resources.Encontrar;
            this.ButtonEncontrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ButtonEncontrar.FlatAppearance.BorderSize = 0;
            this.ButtonEncontrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonEncontrar.Location = new System.Drawing.Point(172, 269);
            this.ButtonEncontrar.Name = "ButtonEncontrar";
            this.ButtonEncontrar.Size = new System.Drawing.Size(553, 88);
            this.ButtonEncontrar.TabIndex = 6;
            this.ButtonEncontrar.UseVisualStyleBackColor = false;
            this.ButtonEncontrar.Click += new System.EventHandler(this.ButtonEncontrar_Click_1);
            // 
            // Form2
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScrollMargin = new System.Drawing.Size(100, 100);
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::CARB2.Properties.Resources.CARB2_21;
            this.ClientSize = new System.Drawing.Size(897, 394);
            this.Controls.Add(this.ButtonEncontrar);
            this.Controls.Add(this.SearchFiles);
            this.Controls.Add(this.LabelFiles);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.checkBoxApy);
            this.Controls.Add(this.checkBoxApi);
            this.Controls.Add(this.checkBoxCdb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();
            

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBoxCdb;
        private System.Windows.Forms.CheckBox checkBoxApi;
        private System.Windows.Forms.CheckBox checkBoxApy;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label LabelFiles;
        private System.Windows.Forms.Button SearchFiles;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button ButtonEncontrar;
        private System.Windows.Forms.OpenFileDialog OpenFileEncontrar;
    }
}