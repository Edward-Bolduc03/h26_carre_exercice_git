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

    public void MettreAJourAffichageValeurAction() {
        affichageValeurActionLabel.Text = valeurAction.ToString();
    }

    public void MettreAJourAffichageApresActionUtilisateur() {
        affichageNombreActionsLabel.Text = nombreActions.ToString();
        affichageMontantBanqueLabel.Text = montantEnBanque.ToString();
    }

    public void AcheterAction() {
        nombreActions++;
        montantEnBanque -= valeurAction;
        MettreAJourAffichageApresActionUtilisateur();
    }

    public void VendreAction() {
        decimal valeurPortefeuille = nombreActions * valeurAction;
        int nouveauNombre = Math.Max(0, nombreActions - 1);

        nombreActions = nouveauNombre;

        decimal nouvelleValeurPortefeuille = nombreActions * valeurAction;

        if (nouvelleValeurPortefeuille < valeurPortefeuille) {
            montantEnBanque += valeurAction;
        }

        MettreAJourAffichageApresActionUtilisateur();
    }

    private void acheterButton_Click(object sender, EventArgs e) {
        AcheterAction();
    }

    private void vendreButton_Click(object sender, EventArgs e) {
        VendreAction();
    }
}
