namespace h26_carre_exercice_git;

public partial class BourseForm : Form {
    decimal valeurAction = 25;
    int nombreActions = 0;
    decimal montantEnBanque = 2500;

    public BourseForm() {
        InitializeComponent();
    }

    public void AcheterAction() {
        nombreActions++;
    }

    public void VendreAction() {
        if (nombreActions > 0) {
            nombreActions--;
        }
    }
}
