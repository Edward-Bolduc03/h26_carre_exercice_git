namespace h26_carre_exercice_git;

public partial class BourseForm : Form {
    decimal valeurAction = 25;
    int nombreActions = 0;
    decimal montantEnBanque = 2500;

    public BourseForm() {
        InitializeComponent();
        MettreAJourAffichageApresActionUtilisateur();
        MettreAJourAffichageValeurAction();
    }

    public string DecimalVersArgent(decimal montant) {
        return Math.Round(montant, 2).ToString() + "$";
    }

    public void MettreAJourAffichageValeurAction() {
        affichageValeurActionLabel.Text = DecimalVersArgent(valeurAction);
    }

    public void MettreAJourAffichageApresActionUtilisateur() {
        affichageNombreActionsLabel.Text = nombreActions.ToString();
        affichageMontantBanqueLabel.Text = DecimalVersArgent(montantEnBanque);
    }

    public void AcheterAction() {
        nombreActions++;
        montantEnBanque -= valeurAction;
        MettreAJourAffichageApresActionUtilisateur();
    }

    public void VendreAction() {
        nombreActions--;
        montantEnBanque += valeurAction;

        MettreAJourAffichageApresActionUtilisateur();
    }

    private void acheterButton_Click(object sender, EventArgs e) {
        AcheterAction();
    }

    private void vendreButton_Click(object sender, EventArgs e) {
        VendreAction();
    }
}
