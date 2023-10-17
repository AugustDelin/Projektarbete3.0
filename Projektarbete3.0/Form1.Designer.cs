namespace PoddRss
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
            this.btnLaggTill = new System.Windows.Forms.Button();
            this.btnTaBort = new System.Windows.Forms.Button();
            this.btnAndra = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBoxNamn = new System.Windows.Forms.TextBox();
            this.cbFrekvens = new System.Windows.Forms.ComboBox();
            this.poddView = new System.Windows.Forms.ListView();
            this.Namn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Avsnitt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.URL = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Kategori = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxUrl = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbKategori = new System.Windows.Forms.ComboBox();
            this.avsnittListBox = new System.Windows.Forms.ListBox();
            this.avsnittTextBox = new System.Windows.Forms.TextBox();
            this.kategoriListBox = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnLaggTillKategori = new System.Windows.Forms.Button();
            this.btnAndraKategori = new System.Windows.Forms.Button();
            this.btnTaBortKategori = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLaggTill
            // 
            this.btnLaggTill.Location = new System.Drawing.Point(383, 204);
            this.btnLaggTill.Name = "btnLaggTill";
            this.btnLaggTill.Size = new System.Drawing.Size(101, 29);
            this.btnLaggTill.TabIndex = 0;
            this.btnLaggTill.Text = "Lägg Till";
            this.btnLaggTill.UseVisualStyleBackColor = true;
            this.btnLaggTill.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnTaBort
            // 
            this.btnTaBort.Location = new System.Drawing.Point(603, 204);
            this.btnTaBort.Name = "btnTaBort";
            this.btnTaBort.Size = new System.Drawing.Size(102, 29);
            this.btnTaBort.TabIndex = 1;
            this.btnTaBort.Text = "Ta Bort";
            this.btnTaBort.UseVisualStyleBackColor = true;
            this.btnTaBort.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnAndra
            // 
            this.btnAndra.Location = new System.Drawing.Point(490, 204);
            this.btnAndra.Name = "btnAndra";
            this.btnAndra.Size = new System.Drawing.Size(107, 29);
            this.btnAndra.TabIndex = 2;
            this.btnAndra.Text = "Ändra";
            this.btnAndra.UseVisualStyleBackColor = true;
            this.btnAndra.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Namn";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtBoxNamn
            // 
            this.txtBoxNamn.Location = new System.Drawing.Point(68, 65);
            this.txtBoxNamn.Name = "txtBoxNamn";
            this.txtBoxNamn.Size = new System.Drawing.Size(288, 26);
            this.txtBoxNamn.TabIndex = 4;
            // 
            // cbFrekvens
            // 
            this.cbFrekvens.FormattingEnabled = true;
            this.cbFrekvens.Location = new System.Drawing.Point(68, 136);
            this.cbFrekvens.Name = "cbFrekvens";
            this.cbFrekvens.Size = new System.Drawing.Size(121, 28);
            this.cbFrekvens.TabIndex = 5;
            // 
            // poddView
            // 
            this.poddView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Namn,
            this.Avsnitt,
            this.URL,
            this.Kategori});
            this.poddView.GridLines = true;
            this.poddView.HideSelection = false;
            this.poddView.Location = new System.Drawing.Point(68, 241);
            this.poddView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.poddView.Name = "poddView";
            this.poddView.Size = new System.Drawing.Size(660, 204);
            this.poddView.TabIndex = 34;
            this.poddView.TileSize = new System.Drawing.Size(300, 100);
            this.poddView.UseCompatibleStateImageBehavior = false;
            this.poddView.View = System.Windows.Forms.View.Details;
            this.poddView.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // Namn
            // 
            this.Namn.Text = "Namn";
            this.Namn.Width = 159;
            // 
            // Avsnitt
            // 
            this.Avsnitt.Text = "Avsnitt";
            this.Avsnitt.Width = 76;
            // 
            // URL
            // 
            this.URL.Text = "URL";
            this.URL.Width = 135;
            // 
            // Kategori
            // 
            this.Kategori.Text = "Kategori";
            this.Kategori.Width = 286;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 20);
            this.label2.TabIndex = 35;
            this.label2.Text = "URL";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtBoxUrl
            // 
            this.txtBoxUrl.Location = new System.Drawing.Point(68, 207);
            this.txtBoxUrl.Name = "txtBoxUrl";
            this.txtBoxUrl.Size = new System.Drawing.Size(288, 26);
            this.txtBoxUrl.TabIndex = 36;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(231, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 20);
            this.label3.TabIndex = 37;
            this.label3.Text = "Kategori";
            // 
            // cbKategori
            // 
            this.cbKategori.FormattingEnabled = true;
            this.cbKategori.Location = new System.Drawing.Point(235, 136);
            this.cbKategori.Name = "cbKategori";
            this.cbKategori.Size = new System.Drawing.Size(121, 28);
            this.cbKategori.TabIndex = 38;
            // 
            // avsnittListBox
            // 
            this.avsnittListBox.FormattingEnabled = true;
            this.avsnittListBox.ItemHeight = 20;
            this.avsnittListBox.Location = new System.Drawing.Point(69, 453);
            this.avsnittListBox.Name = "avsnittListBox";
            this.avsnittListBox.Size = new System.Drawing.Size(659, 284);
            this.avsnittListBox.TabIndex = 39;
            // 
            // avsnittTextBox
            // 
            this.avsnittTextBox.Location = new System.Drawing.Point(755, 453);
            this.avsnittTextBox.Multiline = true;
            this.avsnittTextBox.Name = "avsnittTextBox";
            this.avsnittTextBox.Size = new System.Drawing.Size(468, 284);
            this.avsnittTextBox.TabIndex = 40;
            // 
            // kategoriListBox
            // 
            this.kategoriListBox.FormattingEnabled = true;
            this.kategoriListBox.ItemHeight = 20;
            this.kategoriListBox.Location = new System.Drawing.Point(755, 241);
            this.kategoriListBox.Name = "kategoriListBox";
            this.kategoriListBox.Size = new System.Drawing.Size(468, 184);
            this.kategoriListBox.TabIndex = 41;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(65, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 20);
            this.label4.TabIndex = 43;
            this.label4.Text = "Frekvens";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(755, 122);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(155, 26);
            this.textBox1.TabIndex = 44;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(751, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 20);
            this.label5.TabIndex = 45;
            this.label5.Text = "Kategorier";
            // 
            // btnLaggTillKategori
            // 
            this.btnLaggTillKategori.Location = new System.Drawing.Point(755, 182);
            this.btnLaggTillKategori.Name = "btnLaggTillKategori";
            this.btnLaggTillKategori.Size = new System.Drawing.Size(101, 29);
            this.btnLaggTillKategori.TabIndex = 46;
            this.btnLaggTillKategori.Text = "Lägg Till";
            this.btnLaggTillKategori.UseVisualStyleBackColor = true;
            // 
            // btnAndraKategori
            // 
            this.btnAndraKategori.Location = new System.Drawing.Point(873, 182);
            this.btnAndraKategori.Name = "btnAndraKategori";
            this.btnAndraKategori.Size = new System.Drawing.Size(101, 29);
            this.btnAndraKategori.TabIndex = 47;
            this.btnAndraKategori.Text = "Ändra";
            this.btnAndraKategori.UseVisualStyleBackColor = true;
            // 
            // btnTaBortKategori
            // 
            this.btnTaBortKategori.Location = new System.Drawing.Point(1000, 182);
            this.btnTaBortKategori.Name = "btnTaBortKategori";
            this.btnTaBortKategori.Size = new System.Drawing.Size(102, 29);
            this.btnTaBortKategori.TabIndex = 48;
            this.btnTaBortKategori.Text = "Ta Bort";
            this.btnTaBortKategori.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1364, 806);
            this.Controls.Add(this.btnTaBortKategori);
            this.Controls.Add(this.btnAndraKategori);
            this.Controls.Add(this.btnLaggTillKategori);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.kategoriListBox);
            this.Controls.Add(this.avsnittTextBox);
            this.Controls.Add(this.avsnittListBox);
            this.Controls.Add(this.cbKategori);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBoxUrl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.poddView);
            this.Controls.Add(this.cbFrekvens);
            this.Controls.Add(this.txtBoxNamn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAndra);
            this.Controls.Add(this.btnTaBort);
            this.Controls.Add(this.btnLaggTill);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLaggTill;
        private System.Windows.Forms.Button btnTaBort;
        private System.Windows.Forms.Button btnAndra;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBoxNamn;
        private System.Windows.Forms.ComboBox cbFrekvens;
        private System.Windows.Forms.ListView poddView;
        private System.Windows.Forms.ColumnHeader Namn;
        private System.Windows.Forms.ColumnHeader Avsnitt;
        private System.Windows.Forms.ColumnHeader URL;
        private System.Windows.Forms.ColumnHeader Kategori;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBoxUrl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbKategori;
        private System.Windows.Forms.ListBox avsnittListBox;
        private System.Windows.Forms.TextBox avsnittTextBox;
        private System.Windows.Forms.ListBox kategoriListBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnLaggTillKategori;
        private System.Windows.Forms.Button btnAndraKategori;
        private System.Windows.Forms.Button btnTaBortKategori;
    }
}

