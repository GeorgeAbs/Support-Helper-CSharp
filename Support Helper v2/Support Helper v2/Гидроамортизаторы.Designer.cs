
namespace Support_Helper_v2
{
    partial class Гидроамортизаторы
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Гидроамортизаторы));
            this.label1 = new System.Windows.Forms.Label();
            this.pos0 = new System.Windows.Forms.TextBox();
            this.neg0 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.neg180 = new System.Windows.Forms.TextBox();
            this.pos180 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.typeOfHydroTB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(13, 384);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Если гидроамортизатор повернут по расчету:";
            // 
            // pos0
            // 
            this.pos0.Location = new System.Drawing.Point(125, 400);
            this.pos0.Name = "pos0";
            this.pos0.Size = new System.Drawing.Size(100, 22);
            this.pos0.TabIndex = 1;
            this.pos0.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // neg0
            // 
            this.neg0.Location = new System.Drawing.Point(125, 427);
            this.neg0.Name = "neg0";
            this.neg0.Size = new System.Drawing.Size(100, 22);
            this.neg0.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(13, 452);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(360, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Если гидроамортизатор повернут на 180 относительно расчета:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 408);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Положительное";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 430);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Отрицательное";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 498);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Отрицательное";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 476);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Положительное";
            // 
            // neg180
            // 
            this.neg180.Location = new System.Drawing.Point(125, 495);
            this.neg180.Name = "neg180";
            this.neg180.Size = new System.Drawing.Size(100, 22);
            this.neg180.TabIndex = 9;
            // 
            // pos180
            // 
            this.pos180.Location = new System.Drawing.Point(125, 468);
            this.pos180.Name = "pos180";
            this.pos180.Size = new System.Drawing.Size(100, 22);
            this.pos180.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(310, 40);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Тип";
            // 
            // typeOfHydroTB
            // 
            this.typeOfHydroTB.Location = new System.Drawing.Point(273, 56);
            this.typeOfHydroTB.Name = "typeOfHydroTB";
            this.typeOfHydroTB.Size = new System.Drawing.Size(100, 22);
            this.typeOfHydroTB.TabIndex = 13;
            // 
            // Гидроамортизаторы
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 526);
            this.Controls.Add(this.typeOfHydroTB);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.neg180);
            this.Controls.Add(this.pos180);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.neg0);
            this.Controls.Add(this.pos0);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Гидроамортизаторы";
            this.Text = "Гидроамортизаторы";
            this.Load += new System.EventHandler(this.Гидроамортизаторы_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox pos0;
        private System.Windows.Forms.TextBox neg0;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox neg180;
        private System.Windows.Forms.TextBox pos180;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox typeOfHydroTB;
    }
}