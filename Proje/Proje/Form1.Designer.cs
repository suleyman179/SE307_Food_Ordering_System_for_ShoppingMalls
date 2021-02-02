namespace Proje
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.kfcButton = new System.Windows.Forms.Button();
            this.btnBurger = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.homepage1 = new Proje.homepage();
            this.subway1 = new Proje.Subway();
            this.mcDonalds1 = new Proje.McDonalds();
            this.dominos1 = new Proje.Dominos();
            this.burgerkingUC1 = new Proje.burgerkingUC();
            this.kfc1 = new Proje.KFC();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Green;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(6, 613);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.kfcButton);
            this.panel2.Controls.Add(this.btnBurger);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(6, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(197, 613);
            this.panel2.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Olive;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(-6, 423);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(206, 57);
            this.button1.TabIndex = 7;
            this.button1.Text = "Subway";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button4
            // 
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Olive;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(-6, 360);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(206, 57);
            this.button4.TabIndex = 6;
            this.button4.Text = "Domino\'s";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Olive;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(-6, 297);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(206, 57);
            this.button3.TabIndex = 5;
            this.button3.Text = "McDonald\'s";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // kfcButton
            // 
            this.kfcButton.FlatAppearance.BorderSize = 0;
            this.kfcButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Olive;
            this.kfcButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.kfcButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kfcButton.ForeColor = System.Drawing.Color.White;
            this.kfcButton.Image = ((System.Drawing.Image)(resources.GetObject("kfcButton.Image")));
            this.kfcButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.kfcButton.Location = new System.Drawing.Point(-6, 234);
            this.kfcButton.Name = "kfcButton";
            this.kfcButton.Size = new System.Drawing.Size(206, 57);
            this.kfcButton.TabIndex = 4;
            this.kfcButton.Text = "KFC";
            this.kfcButton.UseVisualStyleBackColor = true;
            this.kfcButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnBurger
            // 
            this.btnBurger.FlatAppearance.BorderSize = 0;
            this.btnBurger.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Olive;
            this.btnBurger.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBurger.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBurger.ForeColor = System.Drawing.Color.White;
            this.btnBurger.Image = ((System.Drawing.Image)(resources.GetObject("btnBurger.Image")));
            this.btnBurger.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBurger.Location = new System.Drawing.Point(-6, 171);
            this.btnBurger.Name = "btnBurger";
            this.btnBurger.Size = new System.Drawing.Size(206, 57);
            this.btnBurger.TabIndex = 3;
            this.btnBurger.Text = "BurgerKing";
            this.btnBurger.UseVisualStyleBackColor = true;
            this.btnBurger.Click += new System.EventHandler(this.btnBurger_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(19, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Food Ordering System";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(33, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(121, 66);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Green;
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(203, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(675, 49);
            this.panel3.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.Location = new System.Drawing.Point(3, 55);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(669, 558);
            this.panel4.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(272, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Restaurants";
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Olive;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(-3, 108);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(206, 57);
            this.button2.TabIndex = 8;
            this.button2.Text = "HomePage";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // homepage1
            // 
            this.homepage1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.homepage1.Location = new System.Drawing.Point(209, 56);
            this.homepage1.Margin = new System.Windows.Forms.Padding(4);
            this.homepage1.Name = "homepage1";
            this.homepage1.Size = new System.Drawing.Size(669, 558);
            this.homepage1.TabIndex = 9;
            // 
            // subway1
            // 
            this.subway1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.subway1.Location = new System.Drawing.Point(209, 56);
            this.subway1.Margin = new System.Windows.Forms.Padding(4);
            this.subway1.Name = "subway1";
            this.subway1.Size = new System.Drawing.Size(669, 558);
            this.subway1.TabIndex = 7;
            // 
            // mcDonalds1
            // 
            this.mcDonalds1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mcDonalds1.Location = new System.Drawing.Point(209, 56);
            this.mcDonalds1.Margin = new System.Windows.Forms.Padding(4);
            this.mcDonalds1.Name = "mcDonalds1";
            this.mcDonalds1.Size = new System.Drawing.Size(669, 558);
            this.mcDonalds1.TabIndex = 6;
            // 
            // dominos1
            // 
            this.dominos1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dominos1.Location = new System.Drawing.Point(209, 56);
            this.dominos1.Margin = new System.Windows.Forms.Padding(4);
            this.dominos1.Name = "dominos1";
            this.dominos1.Size = new System.Drawing.Size(669, 558);
            this.dominos1.TabIndex = 5;
            // 
            // burgerkingUC1
            // 
            this.burgerkingUC1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.burgerkingUC1.Location = new System.Drawing.Point(209, 56);
            this.burgerkingUC1.Margin = new System.Windows.Forms.Padding(4);
            this.burgerkingUC1.Name = "burgerkingUC1";
            this.burgerkingUC1.Size = new System.Drawing.Size(669, 558);
            this.burgerkingUC1.TabIndex = 4;
            // 
            // kfc1
            // 
            this.kfc1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kfc1.Location = new System.Drawing.Point(209, 56);
            this.kfc1.Margin = new System.Windows.Forms.Padding(4);
            this.kfc1.Name = "kfc1";
            this.kfc1.Size = new System.Drawing.Size(669, 558);
            this.kfc1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 613);
            this.Controls.Add(this.homepage1);
            this.Controls.Add(this.subway1);
            this.Controls.Add(this.mcDonalds1);
            this.Controls.Add(this.dominos1);
            this.Controls.Add(this.burgerkingUC1);
            this.Controls.Add(this.kfc1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.Text = "Food Ordering System";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button kfcButton;
        private System.Windows.Forms.Button btnBurger;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label2;
        private KFC kfc1;
        private burgerkingUC burgerkingUC1;
        private Dominos dominos1;
        private McDonalds mcDonalds1;
        private System.Windows.Forms.Button button1;
        private Subway subway1;
        private System.Windows.Forms.Button button2;
        private homepage homepage1;
    }
}

