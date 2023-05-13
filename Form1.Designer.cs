
namespace WindowsFormsApp2
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
            this.p_zaKontrole = new System.Windows.Forms.Panel();
            this.lbl_brojPoena = new System.Windows.Forms.Label();
            this.lbl_brojPoenaTekst = new System.Windows.Forms.Label();
            this.b_pucaj = new System.Windows.Forms.Button();
            this.b_desno = new System.Windows.Forms.Button();
            this.b_levo = new System.Windows.Forms.Button();
            this.p_zaIgru = new System.Windows.Forms.Panel();
            this.b_meta = new System.Windows.Forms.Button();
            this.b_tenk = new System.Windows.Forms.Button();
            this.lbl_sledeciPogodakTekst = new System.Windows.Forms.Label();
            this.lbl_sledeciPogodak = new System.Windows.Forms.Label();
            this.p_zaKontrole.SuspendLayout();
            this.p_zaIgru.SuspendLayout();
            this.SuspendLayout();
            // 
            // p_zaKontrole
            // 
            this.p_zaKontrole.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.p_zaKontrole.Controls.Add(this.lbl_sledeciPogodak);
            this.p_zaKontrole.Controls.Add(this.lbl_sledeciPogodakTekst);
            this.p_zaKontrole.Controls.Add(this.lbl_brojPoena);
            this.p_zaKontrole.Controls.Add(this.lbl_brojPoenaTekst);
            this.p_zaKontrole.Controls.Add(this.b_pucaj);
            this.p_zaKontrole.Controls.Add(this.b_desno);
            this.p_zaKontrole.Controls.Add(this.b_levo);
            this.p_zaKontrole.Dock = System.Windows.Forms.DockStyle.Right;
            this.p_zaKontrole.Location = new System.Drawing.Point(718, 0);
            this.p_zaKontrole.Name = "p_zaKontrole";
            this.p_zaKontrole.Size = new System.Drawing.Size(202, 548);
            this.p_zaKontrole.TabIndex = 0;
            // 
            // lbl_brojPoena
            // 
            this.lbl_brojPoena.AutoSize = true;
            this.lbl_brojPoena.Location = new System.Drawing.Point(89, 33);
            this.lbl_brojPoena.Name = "lbl_brojPoena";
            this.lbl_brojPoena.Size = new System.Drawing.Size(13, 13);
            this.lbl_brojPoena.TabIndex = 4;
            this.lbl_brojPoena.Text = "0";
            // 
            // lbl_brojPoenaTekst
            // 
            this.lbl_brojPoenaTekst.AutoSize = true;
            this.lbl_brojPoenaTekst.Location = new System.Drawing.Point(9, 33);
            this.lbl_brojPoenaTekst.Name = "lbl_brojPoenaTekst";
            this.lbl_brojPoenaTekst.Size = new System.Drawing.Size(61, 13);
            this.lbl_brojPoenaTekst.TabIndex = 3;
            this.lbl_brojPoenaTekst.Text = "Broj poena:";
            // 
            // b_pucaj
            // 
            this.b_pucaj.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.b_pucaj.Location = new System.Drawing.Point(92, 491);
            this.b_pucaj.Name = "b_pucaj";
            this.b_pucaj.Size = new System.Drawing.Size(27, 20);
            this.b_pucaj.TabIndex = 2;
            this.b_pucaj.Text = "^";
            this.b_pucaj.UseVisualStyleBackColor = true;
            this.b_pucaj.Click += new System.EventHandler(this.b_pucaj_Click);
            // 
            // b_desno
            // 
            this.b_desno.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.b_desno.Location = new System.Drawing.Point(125, 491);
            this.b_desno.Name = "b_desno";
            this.b_desno.Size = new System.Drawing.Size(27, 20);
            this.b_desno.TabIndex = 1;
            this.b_desno.Text = "->";
            this.b_desno.UseVisualStyleBackColor = true;
            this.b_desno.Click += new System.EventHandler(this.b_desno_Click);
            // 
            // b_levo
            // 
            this.b_levo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.b_levo.Location = new System.Drawing.Point(59, 491);
            this.b_levo.Name = "b_levo";
            this.b_levo.Size = new System.Drawing.Size(27, 20);
            this.b_levo.TabIndex = 0;
            this.b_levo.Text = "<-";
            this.b_levo.UseVisualStyleBackColor = true;
            this.b_levo.Click += new System.EventHandler(this.button1_Click);
            // 
            // p_zaIgru
            // 
            this.p_zaIgru.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.p_zaIgru.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.p_zaIgru.Controls.Add(this.b_meta);
            this.p_zaIgru.Controls.Add(this.b_tenk);
            this.p_zaIgru.Location = new System.Drawing.Point(-2, 0);
            this.p_zaIgru.Name = "p_zaIgru";
            this.p_zaIgru.Size = new System.Drawing.Size(723, 548);
            this.p_zaIgru.TabIndex = 1;
            this.p_zaIgru.Resize += new System.EventHandler(this.p_zaIgru_Resize);
            // 
            // b_meta
            // 
            this.b_meta.Location = new System.Drawing.Point(281, 90);
            this.b_meta.Name = "b_meta";
            this.b_meta.Size = new System.Drawing.Size(21, 18);
            this.b_meta.TabIndex = 1;
            this.b_meta.Text = "button1";
            this.b_meta.UseVisualStyleBackColor = true;
            // 
            // b_tenk
            // 
            this.b_tenk.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.b_tenk.Location = new System.Drawing.Point(345, 523);
            this.b_tenk.Name = "b_tenk";
            this.b_tenk.Size = new System.Drawing.Size(32, 25);
            this.b_tenk.TabIndex = 0;
            this.b_tenk.Text = "button1";
            this.b_tenk.UseVisualStyleBackColor = true;
            // 
            // lbl_sledeciPogodakTekst
            // 
            this.lbl_sledeciPogodakTekst.AutoSize = true;
            this.lbl_sledeciPogodakTekst.Location = new System.Drawing.Point(9, 62);
            this.lbl_sledeciPogodakTekst.Name = "lbl_sledeciPogodakTekst";
            this.lbl_sledeciPogodakTekst.Size = new System.Drawing.Size(137, 13);
            this.lbl_sledeciPogodakTekst.TabIndex = 5;
            this.lbl_sledeciPogodakTekst.Text = "Vrednost sledeceg pogotka";
            // 
            // lbl_sledeciPogodak
            // 
            this.lbl_sledeciPogodak.AutoSize = true;
            this.lbl_sledeciPogodak.Location = new System.Drawing.Point(152, 62);
            this.lbl_sledeciPogodak.Name = "lbl_sledeciPogodak";
            this.lbl_sledeciPogodak.Size = new System.Drawing.Size(13, 13);
            this.lbl_sledeciPogodak.TabIndex = 6;
            this.lbl_sledeciPogodak.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 548);
            this.Controls.Add(this.p_zaIgru);
            this.Controls.Add(this.p_zaKontrole);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.p_zaKontrole.ResumeLayout(false);
            this.p_zaKontrole.PerformLayout();
            this.p_zaIgru.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel p_zaKontrole;
        private System.Windows.Forms.Button b_levo;
        private System.Windows.Forms.Button b_pucaj;
        private System.Windows.Forms.Button b_desno;
        private System.Windows.Forms.Panel p_zaIgru;
        private System.Windows.Forms.Button b_tenk;
        private System.Windows.Forms.Button b_meta;
        private System.Windows.Forms.Label lbl_brojPoena;
        private System.Windows.Forms.Label lbl_brojPoenaTekst;
        private System.Windows.Forms.Label lbl_sledeciPogodak;
        private System.Windows.Forms.Label lbl_sledeciPogodakTekst;
    }
}

