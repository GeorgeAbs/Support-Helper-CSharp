
namespace Support_Helper_v2
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.excel = new System.Windows.Forms.Button();
            this.sup = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.structure = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // excel
            // 
            this.excel.Location = new System.Drawing.Point(97, 15);
            this.excel.Name = "excel";
            this.excel.Size = new System.Drawing.Size(140, 36);
            this.excel.TabIndex = 0;
            this.excel.Text = "Выбрать Excel-настройки";
            this.excel.UseVisualStyleBackColor = true;
            this.excel.Click += new System.EventHandler(this.excel_Click);
            // 
            // sup
            // 
            this.sup.Enabled = false;
            this.sup.Location = new System.Drawing.Point(97, 124);
            this.sup.Name = "sup";
            this.sup.Size = new System.Drawing.Size(140, 36);
            this.sup.TabIndex = 1;
            this.sup.Text = "Выбрать расчетный файл (*.sup)";
            this.sup.UseVisualStyleBackColor = true;
            this.sup.Click += new System.EventHandler(this.sup_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Support_Helper_v2.Properties.Resources.varik3;
            this.pictureBox1.Location = new System.Drawing.Point(160, 166);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(172, 38);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // structure
            // 
            this.structure.Enabled = false;
            this.structure.Location = new System.Drawing.Point(97, 69);
            this.structure.Name = "structure";
            this.structure.Size = new System.Drawing.Size(140, 35);
            this.structure.TabIndex = 3;
            this.structure.Text = "Требуемая структура *.sup";
            this.structure.UseVisualStyleBackColor = true;
            this.structure.Click += new System.EventHandler(this.structure_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 206);
            this.Controls.Add(this.structure);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.sup);
            this.Controls.Add(this.excel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Support Helper";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button excel;
        private System.Windows.Forms.Button sup;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button structure;
    }
}

