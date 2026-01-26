namespace h26_carre_exercice_git
{
    partial class BourseForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            montantBanqueLabel = new Label();
            affichageMontantBanqueLabel = new Label();
            nombreActionsLabel = new Label();
            affichageNombreActionsLabel = new Label();
            valeurActionLabel = new Label();
            affichageValeurActionLabel = new Label();
            acheterButton = new Button();
            vendreButton = new Button();
            SuspendLayout();
            // 
            // montantBanqueLabel
            // 
            montantBanqueLabel.AutoSize = true;
            montantBanqueLabel.Location = new Point(12, 9);
            montantBanqueLabel.Name = "montantBanqueLabel";
            montantBanqueLabel.Size = new Size(178, 25);
            montantBanqueLabel.TabIndex = 0;
            montantBanqueLabel.Text = "Montant en banque :";
            // 
            // affichageMontantBanqueLabel
            // 
            affichageMontantBanqueLabel.AutoSize = true;
            affichageMontantBanqueLabel.Location = new Point(189, 9);
            affichageMontantBanqueLabel.Name = "affichageMontantBanqueLabel";
            affichageMontantBanqueLabel.Size = new Size(62, 25);
            affichageMontantBanqueLabel.TabIndex = 1;
            affichageMontantBanqueLabel.Text = "5000$";
            // 
            // nombreActionsLabel
            // 
            nombreActionsLabel.AutoSize = true;
            nombreActionsLabel.Location = new Point(12, 34);
            nombreActionsLabel.Name = "nombreActionsLabel";
            nombreActionsLabel.Size = new Size(163, 25);
            nombreActionsLabel.TabIndex = 2;
            nombreActionsLabel.Text = "Nombre d'actions :";
            // 
            // affichageNombreActionsLabel
            // 
            affichageNombreActionsLabel.AutoSize = true;
            affichageNombreActionsLabel.Location = new Point(189, 34);
            affichageNombreActionsLabel.Name = "affichageNombreActionsLabel";
            affichageNombreActionsLabel.Size = new Size(22, 25);
            affichageNombreActionsLabel.TabIndex = 3;
            affichageNombreActionsLabel.Text = "0";
            // 
            // valeurActionLabel
            // 
            valeurActionLabel.AutoSize = true;
            valeurActionLabel.Location = new Point(12, 59);
            valeurActionLabel.Name = "valeurActionLabel";
            valeurActionLabel.Size = new Size(171, 25);
            valeurActionLabel.TabIndex = 4;
            valeurActionLabel.Text = "Valeur d'une action :";
            // 
            // affichageValeurActionLabel
            // 
            affichageValeurActionLabel.AutoSize = true;
            affichageValeurActionLabel.Location = new Point(189, 59);
            affichageValeurActionLabel.Name = "affichageValeurActionLabel";
            affichageValeurActionLabel.Size = new Size(42, 25);
            affichageValeurActionLabel.TabIndex = 5;
            affichageValeurActionLabel.Text = "10$";
            // 
            // acheterButton
            // 
            acheterButton.Location = new Point(12, 87);
            acheterButton.Name = "acheterButton";
            acheterButton.Size = new Size(163, 34);
            acheterButton.TabIndex = 6;
            acheterButton.Text = "Acheter";
            acheterButton.UseVisualStyleBackColor = true;
            acheterButton.Click += acheterButton_Click;
            // 
            // vendreButton
            // 
            vendreButton.Location = new Point(181, 87);
            vendreButton.Name = "vendreButton";
            vendreButton.Size = new Size(163, 34);
            vendreButton.TabIndex = 7;
            vendreButton.Text = "Vendre";
            vendreButton.UseVisualStyleBackColor = true;
            vendreButton.Click += vendreButton_Click;
            // 
            // BourseForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(356, 132);
            Controls.Add(vendreButton);
            Controls.Add(acheterButton);
            Controls.Add(affichageValeurActionLabel);
            Controls.Add(valeurActionLabel);
            Controls.Add(affichageNombreActionsLabel);
            Controls.Add(nombreActionsLabel);
            Controls.Add(affichageMontantBanqueLabel);
            Controls.Add(montantBanqueLabel);
            Name = "BourseForm";
            Text = "Bourse";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label montantBanqueLabel;
        private Label affichageMontantBanqueLabel;
        private Label nombreActionsLabel;
        private Label affichageNombreActionsLabel;
        private Label valeurActionLabel;
        private Label affichageValeurActionLabel;
        private Button acheterButton;
        private Button vendreButton;
    }
}
