namespace EmlakciKayitSistemiGUI
{
    partial class EmlakciForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.Label lblSoyad;
        private System.Windows.Forms.Label lblTelefon;
        private System.Windows.Forms.Label lblAdres;
        private System.Windows.Forms.Label lblSatisFiyati;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.TextBox txtAdres;
        private System.Windows.Forms.TextBox txtSatisFiyati;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.ListView listViewKayitlar;
        private System.Windows.Forms.ColumnHeader columnHeaderAd;
        private System.Windows.Forms.ColumnHeader columnHeaderSoyad;
        private System.Windows.Forms.ColumnHeader columnHeaderTelefon;
        private System.Windows.Forms.ColumnHeader columnHeaderAdres;
        private System.Windows.Forms.ColumnHeader columnHeaderSatisFiyati;
        private System.Windows.Forms.TextBox txtAra;
        private System.Windows.Forms.Button btnAra;

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblAd = new System.Windows.Forms.Label();
            this.lblSoyad = new System.Windows.Forms.Label();
            this.lblTelefon = new System.Windows.Forms.Label();
            this.lblAdres = new System.Windows.Forms.Label();
            this.lblSatisFiyati = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.txtSatisFiyati = new System.Windows.Forms.TextBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.listViewKayitlar = new System.Windows.Forms.ListView();
            this.columnHeaderAd = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderSoyad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderTelefon = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderAdres = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderSatisFiyati = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtAra = new System.Windows.Forms.TextBox();
            this.btnAra = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.Location = new System.Drawing.Point(50, 50);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(23, 13);
            this.lblAd.TabIndex = 0;
            this.lblAd.Text = "Ad:";
            // 
            // lblSoyad
            // 
            this.lblSoyad.AutoSize = true;
            this.lblSoyad.Location = new System.Drawing.Point(50, 80);
            this.lblSoyad.Name = "lblSoyad";
            this.lblSoyad.Size = new System.Drawing.Size(44, 13);
            this.lblSoyad.TabIndex = 1;
            this.lblSoyad.Text = "Soyad:";
            // 
            // lblTelefon
            // 
            this.lblTelefon.AutoSize = true;
            this.lblTelefon.Location = new System.Drawing.Point(50, 110);
            this.lblTelefon.Name = "lblTelefon";
            this.lblTelefon.Size = new System.Drawing.Size(49, 13);
            this.lblTelefon.TabIndex = 2;
            this.lblTelefon.Text = "Telefon:";
            // 
            // lblAdres
            // 
            this.lblAdres.AutoSize = true;
            this.lblAdres.Location = new System.Drawing.Point(50, 140);
            this.lblAdres.Name = "lblAdres";
            this.lblAdres.Size = new System.Drawing.Size(38, 13);
            this.lblAdres.TabIndex = 3;
            this.lblAdres.Text = "Adres:";
            // 
            // lblSatisFiyati
            // 
            this.lblSatisFiyati.AutoSize = true;
            this.lblSatisFiyati.Location = new System.Drawing.Point(50, 170);
            this.lblSatisFiyati.Name = "lblSatisFiyati";
            this.lblSatisFiyati.Size = new System.Drawing.Size(64, 13);
            this.lblSatisFiyati.TabIndex = 4;
            this.lblSatisFiyati.Text = "Satış Fiyatı:";
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(120, 50);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(150, 20);
            this.txtAd.TabIndex = 5;
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(120, 80);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(150, 20);
            this.txtSoyad.TabIndex = 6;
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(120, 110);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(150, 20);
            this.txtTelefon.TabIndex = 7;
            // 
            // txtAdres
            // 
            this.txtAdres.Location = new System.Drawing.Point(120, 140);
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(150, 20);
            this.txtAdres.TabIndex = 8;
            // 
            // txtSatisFiyati
            // 
            this.txtSatisFiyati.Location = new System.Drawing.Point(120, 170);
            this.txtSatisFiyati.Name = "txtSatisFiyati";
            this.txtSatisFiyati.Size = new System.Drawing.Size(150, 20);
            this.txtSatisFiyati.TabIndex = 9;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(120, 200);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(75, 23);
            this.btnKaydet.TabIndex = 10;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // listViewKayitlar
            // 
            this.listViewKayitlar.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderAd,
            this.columnHeaderSoyad,
            this.columnHeaderTelefon,
            this.columnHeaderAdres,
            this.columnHeaderSatisFiyati});
            this.listViewKayitlar.FullRowSelect = true;
            this.listViewKayitlar.GridLines = true;
            this.listViewKayitlar.HideSelection = false;
            this.listViewKayitlar.Location = new System.Drawing.Point(300, 50);
            this.listViewKayitlar.Name = "listViewKayitlar";
            this.listViewKayitlar.Size = new System.Drawing.Size(400, 200);
            this.listViewKayitlar.TabIndex = 11;
            this.listViewKayitlar.UseCompatibleStateImageBehavior = false;
            this.listViewKayitlar.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderAd
            // 
            this.columnHeaderAd.Text = "Ad";
            this.columnHeaderAd.Width = 80;
            // 
            // columnHeaderSoyad
            // 
            this.columnHeaderSoyad.Text = "Soyad";
            this.columnHeaderSoyad.Width = 80;
            // 
            // columnHeaderTelefon
            // 
            this.columnHeaderTelefon.Text = "Telefon";
            this.columnHeaderTelefon.Width = 80;
            // 
            // columnHeaderAdres
            // 
            this.columnHeaderAdres.Text = "Adres";
            this.columnHeaderAdres.Width = 100;
            // 
            // columnHeaderSatisFiyati
            // 
            this.columnHeaderSatisFiyati.Text = "Satış Fiyatı";
            this.columnHeaderSatisFiyati.Width = 80;
            // 
            // txtAra
            // 
            this.txtAra.Location = new System.Drawing.Point(300, 20);
            this.txtAra.Name = "txtAra";
            this.txtAra.Size = new System.Drawing.Size(200, 20);
            this.txtAra.TabIndex = 12;
            // 
            // btnAra
            // 
            this.btnAra.Location = new System.Drawing.Point(520, 20);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(75, 23);
            this.btnAra.TabIndex = 13;
            this.btnAra.Text = "Ara";
            this.btnAra.UseVisualStyleBackColor = true;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // EmlakciForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 300);
            this.Controls.Add(this.btnAra);
            this.Controls.Add(this.txtAra);
            this.Controls.Add(this.listViewKayitlar);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.txtSatisFiyati);
            this.Controls.Add(this.txtAdres);
            this.Controls.Add(this.txtTelefon);
            this.Controls.Add(this.txtSoyad);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.lblSatisFiyati);
            this.Controls.Add(this.lblAdres);
            this.Controls.Add(this.lblTelefon);
            this.Controls.Add(this.lblSoyad);
            this.Controls.Add(this.lblAd);
            this.Name = "EmlakciForm";
            this.Text = "Emlakçı Kayıt Sistemi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
