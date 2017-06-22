namespace Laboratoire4
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtMasseKg = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtVitesse = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEnergie = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.btnDelegate = new System.Windows.Forms.Button();
            this.btnMethodeAnonyme = new System.Windows.Forms.Button();
            this.btnLamda = new System.Windows.Forms.Button();
            this.btnFunc = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtSalaire = new System.Windows.Forms.TextBox();
            this.txtDepartement = new System.Windows.Forms.TextBox();
            this.txtNo = new System.Windows.Forms.TextBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.btnVersListeOriginal = new System.Windows.Forms.Button();
            this.btnInfoLINQNomPrenom = new System.Windows.Forms.Button();
            this.btnbtnInfoLambda = new System.Windows.Forms.Button();
            this.btnInfoLINQ = new System.Windows.Forms.Button();
            this.btnNombreEmploye = new System.Windows.Forms.Button();
            this.btnMoyenneSalaire = new System.Windows.Forms.Button();
            this.listBoxPersonne = new System.Windows.Forms.ListBox();
            this.listBoxResults = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Masse:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtMasseKg
            // 
            this.txtMasseKg.Location = new System.Drawing.Point(112, 63);
            this.txtMasseKg.Name = "txtMasseKg";
            this.txtMasseKg.Size = new System.Drawing.Size(100, 20);
            this.txtMasseKg.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(218, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "kg";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(0, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Vitesse de la lumiere:";
            // 
            // txtVitesse
            // 
            this.txtVitesse.Location = new System.Drawing.Point(112, 102);
            this.txtVitesse.Name = "txtVitesse";
            this.txtVitesse.Size = new System.Drawing.Size(100, 20);
            this.txtVitesse.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(218, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "m/s";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(60, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Énergie:";
            // 
            // txtEnergie
            // 
            this.txtEnergie.Enabled = false;
            this.txtEnergie.Location = new System.Drawing.Point(112, 146);
            this.txtEnergie.Name = "txtEnergie";
            this.txtEnergie.Size = new System.Drawing.Size(100, 20);
            this.txtEnergie.TabIndex = 2;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(218, 153);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(34, 13);
            this.label.TabIndex = 8;
            this.label.Text = "joules";
            // 
            // btnDelegate
            // 
            this.btnDelegate.Location = new System.Drawing.Point(63, 204);
            this.btnDelegate.Name = "btnDelegate";
            this.btnDelegate.Size = new System.Drawing.Size(75, 23);
            this.btnDelegate.TabIndex = 3;
            this.btnDelegate.Text = "Delegate";
            this.btnDelegate.UseVisualStyleBackColor = true;
            this.btnDelegate.Click += new System.EventHandler(this.btnDelegate_Click);
            // 
            // btnMethodeAnonyme
            // 
            this.btnMethodeAnonyme.Location = new System.Drawing.Point(12, 233);
            this.btnMethodeAnonyme.Name = "btnMethodeAnonyme";
            this.btnMethodeAnonyme.Size = new System.Drawing.Size(126, 23);
            this.btnMethodeAnonyme.TabIndex = 4;
            this.btnMethodeAnonyme.Text = "Méthode Anonymes";
            this.btnMethodeAnonyme.UseVisualStyleBackColor = true;
            this.btnMethodeAnonyme.Click += new System.EventHandler(this.btnMethodeAnonyme_Click);
            // 
            // btnLamda
            // 
            this.btnLamda.Location = new System.Drawing.Point(63, 262);
            this.btnLamda.Name = "btnLamda";
            this.btnLamda.Size = new System.Drawing.Size(75, 23);
            this.btnLamda.TabIndex = 5;
            this.btnLamda.Text = "Lambda";
            this.btnLamda.UseVisualStyleBackColor = true;
            this.btnLamda.Click += new System.EventHandler(this.btnLamda_Click);
            // 
            // btnFunc
            // 
            this.btnFunc.Location = new System.Drawing.Point(63, 291);
            this.btnFunc.Name = "btnFunc";
            this.btnFunc.Size = new System.Drawing.Size(75, 23);
            this.btnFunc.TabIndex = 6;
            this.btnFunc.Text = "Func";
            this.btnFunc.UseVisualStyleBackColor = true;
            this.btnFunc.Click += new System.EventHandler(this.button4_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(442, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Prenom:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(442, 95);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Nom:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(442, 118);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(21, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "No";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(442, 141);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Departement";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(442, 165);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 13);
            this.label10.TabIndex = 16;
            this.label10.Text = "Salaire";
            // 
            // txtSalaire
            // 
            this.txtSalaire.Location = new System.Drawing.Point(525, 158);
            this.txtSalaire.Name = "txtSalaire";
            this.txtSalaire.Size = new System.Drawing.Size(100, 20);
            this.txtSalaire.TabIndex = 11;
            // 
            // txtDepartement
            // 
            this.txtDepartement.Location = new System.Drawing.Point(525, 134);
            this.txtDepartement.Name = "txtDepartement";
            this.txtDepartement.Size = new System.Drawing.Size(100, 20);
            this.txtDepartement.TabIndex = 10;
            // 
            // txtNo
            // 
            this.txtNo.Location = new System.Drawing.Point(525, 111);
            this.txtNo.Name = "txtNo";
            this.txtNo.Size = new System.Drawing.Size(100, 20);
            this.txtNo.TabIndex = 9;
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(525, 88);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(100, 20);
            this.txtNom.TabIndex = 8;
            // 
            // txtPrenom
            // 
            this.txtPrenom.Location = new System.Drawing.Point(525, 67);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(100, 20);
            this.txtPrenom.TabIndex = 7;
            // 
            // btnVersListeOriginal
            // 
            this.btnVersListeOriginal.Location = new System.Drawing.Point(631, 106);
            this.btnVersListeOriginal.Name = "btnVersListeOriginal";
            this.btnVersListeOriginal.Size = new System.Drawing.Size(53, 33);
            this.btnVersListeOriginal.TabIndex = 17;
            this.btnVersListeOriginal.Text = ">";
            this.btnVersListeOriginal.UseVisualStyleBackColor = true;
            this.btnVersListeOriginal.Click += new System.EventHandler(this.btnVersListeOriginal_Click);
            // 
            // btnInfoLINQNomPrenom
            // 
            this.btnInfoLINQNomPrenom.Location = new System.Drawing.Point(376, 274);
            this.btnInfoLINQNomPrenom.Name = "btnInfoLINQNomPrenom";
            this.btnInfoLINQNomPrenom.Size = new System.Drawing.Size(249, 40);
            this.btnInfoLINQNomPrenom.TabIndex = 14;
            this.btnInfoLINQNomPrenom.Text = "File Departement Informatique (LINQ) seulment Nom et Prenom)";
            this.btnInfoLINQNomPrenom.UseVisualStyleBackColor = true;
            this.btnInfoLINQNomPrenom.Click += new System.EventHandler(this.btnInfoLINQNomPrenom_Click);
            // 
            // btnbtnInfoLambda
            // 
            this.btnbtnInfoLambda.Location = new System.Drawing.Point(376, 245);
            this.btnbtnInfoLambda.Name = "btnbtnInfoLambda";
            this.btnbtnInfoLambda.Size = new System.Drawing.Size(249, 23);
            this.btnbtnInfoLambda.TabIndex = 13;
            this.btnbtnInfoLambda.Text = "Filtre département informatique (Lambda)";
            this.btnbtnInfoLambda.UseVisualStyleBackColor = true;
            this.btnbtnInfoLambda.Click += new System.EventHandler(this.btnbtnInfoLambda_Click);
            // 
            // btnInfoLINQ
            // 
            this.btnInfoLINQ.Location = new System.Drawing.Point(376, 216);
            this.btnInfoLINQ.Name = "btnInfoLINQ";
            this.btnInfoLINQ.Size = new System.Drawing.Size(249, 23);
            this.btnInfoLINQ.TabIndex = 12;
            this.btnInfoLINQ.Text = "Filtre département informatique (LINQ)";
            this.btnInfoLINQ.UseVisualStyleBackColor = true;
            this.btnInfoLINQ.Click += new System.EventHandler(this.btnInfoLINQ_Click);
            // 
            // btnNombreEmploye
            // 
            this.btnNombreEmploye.Location = new System.Drawing.Point(376, 351);
            this.btnNombreEmploye.Name = "btnNombreEmploye";
            this.btnNombreEmploye.Size = new System.Drawing.Size(249, 40);
            this.btnNombreEmploye.TabIndex = 15;
            this.btnNombreEmploye.Text = "Nb Emplyé en informatique (LINQ+Lambda)";
            this.btnNombreEmploye.UseVisualStyleBackColor = true;
            this.btnNombreEmploye.Click += new System.EventHandler(this.btnNombreEmploye_Click);
            // 
            // btnMoyenneSalaire
            // 
            this.btnMoyenneSalaire.Location = new System.Drawing.Point(376, 397);
            this.btnMoyenneSalaire.Name = "btnMoyenneSalaire";
            this.btnMoyenneSalaire.Size = new System.Drawing.Size(249, 40);
            this.btnMoyenneSalaire.TabIndex = 16;
            this.btnMoyenneSalaire.Text = "Moyenne Salaire EMployé en informatique salaire >30000";
            this.btnMoyenneSalaire.UseVisualStyleBackColor = true;
            this.btnMoyenneSalaire.Click += new System.EventHandler(this.btnMoyenneSalaire_Click);
            // 
            // listBoxPersonne
            // 
            this.listBoxPersonne.FormattingEnabled = true;
            this.listBoxPersonne.Location = new System.Drawing.Point(700, 71);
            this.listBoxPersonne.Name = "listBoxPersonne";
            this.listBoxPersonne.Size = new System.Drawing.Size(200, 121);
            this.listBoxPersonne.TabIndex = 18;
            // 
            // listBoxResults
            // 
            this.listBoxResults.FormattingEnabled = true;
            this.listBoxResults.Location = new System.Drawing.Point(641, 216);
            this.listBoxResults.Name = "listBoxResults";
            this.listBoxResults.Size = new System.Drawing.Size(292, 147);
            this.listBoxResults.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 534);
            this.Controls.Add(this.listBoxResults);
            this.Controls.Add(this.listBoxPersonne);
            this.Controls.Add(this.btnInfoLINQ);
            this.Controls.Add(this.btnbtnInfoLambda);
            this.Controls.Add(this.btnMoyenneSalaire);
            this.Controls.Add(this.btnNombreEmploye);
            this.Controls.Add(this.btnInfoLINQNomPrenom);
            this.Controls.Add(this.btnVersListeOriginal);
            this.Controls.Add(this.txtPrenom);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.txtNo);
            this.Controls.Add(this.txtDepartement);
            this.Controls.Add(this.txtSalaire);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnFunc);
            this.Controls.Add(this.btnLamda);
            this.Controls.Add(this.btnMethodeAnonyme);
            this.Controls.Add(this.btnDelegate);
            this.Controls.Add(this.label);
            this.Controls.Add(this.txtEnergie);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtVitesse);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMasseKg);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMasseKg;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtVitesse;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtEnergie;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Button btnDelegate;
        private System.Windows.Forms.Button btnMethodeAnonyme;
        private System.Windows.Forms.Button btnLamda;
        private System.Windows.Forms.Button btnFunc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtSalaire;
        private System.Windows.Forms.TextBox txtDepartement;
        private System.Windows.Forms.TextBox txtNo;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.Button btnVersListeOriginal;
        private System.Windows.Forms.Button btnInfoLINQNomPrenom;
        private System.Windows.Forms.Button btnbtnInfoLambda;
        private System.Windows.Forms.Button btnInfoLINQ;
        private System.Windows.Forms.Button btnNombreEmploye;
        private System.Windows.Forms.Button btnMoyenneSalaire;
        private System.Windows.Forms.ListBox listBoxPersonne;
        private System.Windows.Forms.ListBox listBoxResults;
    }
}

