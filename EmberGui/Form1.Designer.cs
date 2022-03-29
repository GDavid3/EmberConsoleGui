
namespace EmberGui
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Feltolt = new System.Windows.Forms.Button();
            this.Hozzáad = new System.Windows.Forms.Button();
            this.Nev = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Kor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Cim = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Fizetes = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(304, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // Feltolt
            // 
            this.Feltolt.Location = new System.Drawing.Point(13, 170);
            this.Feltolt.Name = "Feltolt";
            this.Feltolt.Size = new System.Drawing.Size(75, 23);
            this.Feltolt.TabIndex = 1;
            this.Feltolt.Text = "Feltolt";
            this.Feltolt.UseVisualStyleBackColor = true;
            this.Feltolt.Click += new System.EventHandler(this.Feltolt_Click);
            // 
            // Hozzáad
            // 
            this.Hozzáad.Location = new System.Drawing.Point(323, 12);
            this.Hozzáad.Name = "Hozzáad";
            this.Hozzáad.Size = new System.Drawing.Size(75, 23);
            this.Hozzáad.TabIndex = 2;
            this.Hozzáad.Text = "Hozzáad";
            this.Hozzáad.UseVisualStyleBackColor = true;
            this.Hozzáad.Click += new System.EventHandler(this.Hozzáad_Click);
            // 
            // Nev
            // 
            this.Nev.Location = new System.Drawing.Point(402, 60);
            this.Nev.Name = "Nev";
            this.Nev.Size = new System.Drawing.Size(93, 20);
            this.Nev.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(399, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Név:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(498, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Kor:";
            // 
            // Kor
            // 
            this.Kor.Location = new System.Drawing.Point(501, 60);
            this.Kor.Name = "Kor";
            this.Kor.Size = new System.Drawing.Size(93, 20);
            this.Kor.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(597, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Cím:";
            // 
            // Cim
            // 
            this.Cim.Location = new System.Drawing.Point(600, 60);
            this.Cim.Name = "Cim";
            this.Cim.Size = new System.Drawing.Size(93, 20);
            this.Cim.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(696, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Fizetes";
            // 
            // Fizetes
            // 
            this.Fizetes.Location = new System.Drawing.Point(699, 60);
            this.Fizetes.Name = "Fizetes";
            this.Fizetes.Size = new System.Drawing.Size(93, 20);
            this.Fizetes.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Fizetes);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Cim);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Kor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Nev);
            this.Controls.Add(this.Hozzáad);
            this.Controls.Add(this.Feltolt);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Feltolt;
        private System.Windows.Forms.Button Hozzáad;
        private System.Windows.Forms.TextBox Nev;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Kor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Cim;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Fizetes;
    }
}

