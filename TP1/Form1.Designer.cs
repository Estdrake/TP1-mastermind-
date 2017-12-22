
namespace TP1
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.pb1 = new System.Windows.Forms.PictureBox();
            this.pb2 = new System.Windows.Forms.PictureBox();
            this.pb3 = new System.Windows.Forms.PictureBox();
            this.pb4 = new System.Windows.Forms.PictureBox();
            this.pb5 = new System.Windows.Forms.PictureBox();
            this.pbRose = new System.Windows.Forms.PictureBox();
            this.pbVert = new System.Windows.Forms.PictureBox();
            this.pbOrange = new System.Windows.Forms.PictureBox();
            this.pbBleu = new System.Windows.Forms.PictureBox();
            this.btnVérifier = new System.Windows.Forms.Button();
            this.btnAficher = new System.Windows.Forms.Button();
            this.btnRecomencer = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNbessai = new System.Windows.Forms.TextBox();
            this.txtBonne = new System.Windows.Forms.TextBox();
            this.txtMauvai = new System.Windows.Forms.TextBox();
            this.txtSoluce = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbVert)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbOrange)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBleu)).BeginInit();
            this.SuspendLayout();
            // 
            // pb1
            // 
            this.pb1.AllowDrop = true;
            this.pb1.BackColor = System.Drawing.Color.White;
            this.pb1.Location = new System.Drawing.Point(28, 28);
            this.pb1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pb1.Name = "pb1";
            this.pb1.Size = new System.Drawing.Size(75, 81);
            this.pb1.TabIndex = 0;
            this.pb1.TabStop = false;
            this.pb1.DragDrop += new System.Windows.Forms.DragEventHandler(this.ChoixDragDrop);
            this.pb1.DragEnter += new System.Windows.Forms.DragEventHandler(this.ChoixDragEnter);
            // 
            // pb2
            // 
            this.pb2.AllowDrop = true;
            this.pb2.BackColor = System.Drawing.Color.White;
            this.pb2.Location = new System.Drawing.Point(138, 28);
            this.pb2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pb2.Name = "pb2";
            this.pb2.Size = new System.Drawing.Size(75, 81);
            this.pb2.TabIndex = 1;
            this.pb2.TabStop = false;
            this.pb2.DragDrop += new System.Windows.Forms.DragEventHandler(this.ChoixDragDrop);
            this.pb2.DragEnter += new System.Windows.Forms.DragEventHandler(this.ChoixDragEnter);
            // 
            // pb3
            // 
            this.pb3.AllowDrop = true;
            this.pb3.BackColor = System.Drawing.Color.White;
            this.pb3.Location = new System.Drawing.Point(243, 28);
            this.pb3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pb3.Name = "pb3";
            this.pb3.Size = new System.Drawing.Size(75, 81);
            this.pb3.TabIndex = 2;
            this.pb3.TabStop = false;
            this.pb3.DragDrop += new System.Windows.Forms.DragEventHandler(this.ChoixDragDrop);
            this.pb3.DragEnter += new System.Windows.Forms.DragEventHandler(this.ChoixDragEnter);
            // 
            // pb4
            // 
            this.pb4.AllowDrop = true;
            this.pb4.BackColor = System.Drawing.Color.White;
            this.pb4.Location = new System.Drawing.Point(356, 28);
            this.pb4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pb4.Name = "pb4";
            this.pb4.Size = new System.Drawing.Size(75, 81);
            this.pb4.TabIndex = 3;
            this.pb4.TabStop = false;
            this.pb4.DragDrop += new System.Windows.Forms.DragEventHandler(this.ChoixDragDrop);
            this.pb4.DragEnter += new System.Windows.Forms.DragEventHandler(this.ChoixDragEnter);
            // 
            // pb5
            // 
            this.pb5.AllowDrop = true;
            this.pb5.BackColor = System.Drawing.Color.White;
            this.pb5.Location = new System.Drawing.Point(465, 28);
            this.pb5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pb5.Name = "pb5";
            this.pb5.Size = new System.Drawing.Size(75, 81);
            this.pb5.TabIndex = 4;
            this.pb5.TabStop = false;
            this.pb5.DragDrop += new System.Windows.Forms.DragEventHandler(this.ChoixDragDrop);
            this.pb5.DragEnter += new System.Windows.Forms.DragEventHandler(this.ChoixDragEnter);
            // 
            // pbRose
            // 
            this.pbRose.BackColor = System.Drawing.Color.DeepPink;
            this.pbRose.Location = new System.Drawing.Point(465, 152);
            this.pbRose.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pbRose.Name = "pbRose";
            this.pbRose.Size = new System.Drawing.Size(75, 81);
            this.pbRose.TabIndex = 9;
            this.pbRose.TabStop = false;
            this.pbRose.Tag = "DeepPink";
            this.pbRose.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CouleurMouseDown);
            // 
            // pbVert
            // 
            this.pbVert.BackColor = System.Drawing.Color.YellowGreen;
            this.pbVert.Location = new System.Drawing.Point(331, 152);
            this.pbVert.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pbVert.Name = "pbVert";
            this.pbVert.Size = new System.Drawing.Size(75, 81);
            this.pbVert.TabIndex = 8;
            this.pbVert.TabStop = false;
            this.pbVert.Tag = "YellowGreen";
            this.pbVert.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CouleurMouseDown);
            // 
            // pbOrange
            // 
            this.pbOrange.BackColor = System.Drawing.Color.DarkOrange;
            this.pbOrange.Location = new System.Drawing.Point(182, 152);
            this.pbOrange.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pbOrange.Name = "pbOrange";
            this.pbOrange.Size = new System.Drawing.Size(75, 81);
            this.pbOrange.TabIndex = 7;
            this.pbOrange.TabStop = false;
            this.pbOrange.Tag = "DarkOrange";
            this.pbOrange.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CouleurMouseDown);
            // 
            // pbBleu
            // 
            this.pbBleu.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.pbBleu.Location = new System.Drawing.Point(28, 152);
            this.pbBleu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pbBleu.Name = "pbBleu";
            this.pbBleu.Size = new System.Drawing.Size(75, 81);
            this.pbBleu.TabIndex = 5;
            this.pbBleu.TabStop = false;
            this.pbBleu.Tag = "DeepSkyBlue";
            this.pbBleu.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CouleurMouseDown);
            // 
            // btnVérifier
            // 
            this.btnVérifier.Location = new System.Drawing.Point(217, 263);
            this.btnVérifier.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnVérifier.Name = "btnVérifier";
            this.btnVérifier.Size = new System.Drawing.Size(118, 76);
            this.btnVérifier.TabIndex = 10;
            this.btnVérifier.Text = "Vérifier";
            this.btnVérifier.UseVisualStyleBackColor = true;
            this.btnVérifier.Click += new System.EventHandler(this.btnVérifier_Click);
            // 
            // btnAficher
            // 
            this.btnAficher.Location = new System.Drawing.Point(167, 506);
            this.btnAficher.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAficher.Name = "btnAficher";
            this.btnAficher.Size = new System.Drawing.Size(118, 76);
            this.btnAficher.TabIndex = 11;
            this.btnAficher.Text = "Afficher";
            this.btnAficher.UseVisualStyleBackColor = true;
            this.btnAficher.Click += new System.EventHandler(this.btnAficher_Click);
            // 
            // btnRecomencer
            // 
            this.btnRecomencer.Location = new System.Drawing.Point(28, 506);
            this.btnRecomencer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRecomencer.Name = "btnRecomencer";
            this.btnRecomencer.Size = new System.Drawing.Size(118, 76);
            this.btnRecomencer.TabIndex = 12;
            this.btnRecomencer.Text = "Recommencer";
            this.btnRecomencer.UseVisualStyleBackColor = true;
            this.btnRecomencer.Click += new System.EventHandler(this.btnRecomencer_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 366);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Nombre d\'essais:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 406);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Exact et bonne place:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(70, 437);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Exact et mauvaise place";
            // 
            // txtNbessai
            // 
            this.txtNbessai.Location = new System.Drawing.Point(278, 366);
            this.txtNbessai.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNbessai.Name = "txtNbessai";
            this.txtNbessai.Size = new System.Drawing.Size(116, 20);
            this.txtNbessai.TabIndex = 16;
            // 
            // txtBonne
            // 
            this.txtBonne.Location = new System.Drawing.Point(278, 402);
            this.txtBonne.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtBonne.Name = "txtBonne";
            this.txtBonne.Size = new System.Drawing.Size(116, 20);
            this.txtBonne.TabIndex = 17;
            // 
            // txtMauvai
            // 
            this.txtMauvai.Location = new System.Drawing.Point(278, 437);
            this.txtMauvai.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtMauvai.Name = "txtMauvai";
            this.txtMauvai.Size = new System.Drawing.Size(116, 20);
            this.txtMauvai.TabIndex = 18;
            // 
            // txtSoluce
            // 
            this.txtSoluce.Location = new System.Drawing.Point(290, 535);
            this.txtSoluce.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSoluce.Multiline = true;
            this.txtSoluce.Name = "txtSoluce";
            this.txtSoluce.Size = new System.Drawing.Size(295, 48);
            this.txtSoluce.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 608);
            this.Controls.Add(this.txtSoluce);
            this.Controls.Add(this.txtMauvai);
            this.Controls.Add(this.txtBonne);
            this.Controls.Add(this.txtNbessai);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRecomencer);
            this.Controls.Add(this.btnAficher);
            this.Controls.Add(this.btnVérifier);
            this.Controls.Add(this.pbRose);
            this.Controls.Add(this.pbVert);
            this.Controls.Add(this.pbOrange);
            this.Controls.Add(this.pbBleu);
            this.Controls.Add(this.pb5);
            this.Controls.Add(this.pb4);
            this.Controls.Add(this.pb3);
            this.Controls.Add(this.pb2);
            this.Controls.Add(this.pb1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbVert)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbOrange)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBleu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb1;
        private System.Windows.Forms.PictureBox pb2;
        private System.Windows.Forms.PictureBox pb3;
        private System.Windows.Forms.PictureBox pb4;
        private System.Windows.Forms.PictureBox pb5;
        private System.Windows.Forms.PictureBox pbRose;
        private System.Windows.Forms.PictureBox pbVert;
        private System.Windows.Forms.PictureBox pbOrange;
        private System.Windows.Forms.PictureBox pbBleu;
        private System.Windows.Forms.Button btnVérifier;
        private System.Windows.Forms.Button btnAficher;
        private System.Windows.Forms.Button btnRecomencer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNbessai;
        private System.Windows.Forms.TextBox txtBonne;
        private System.Windows.Forms.TextBox txtMauvai;
        private System.Windows.Forms.TextBox txtSoluce;
    }
}

