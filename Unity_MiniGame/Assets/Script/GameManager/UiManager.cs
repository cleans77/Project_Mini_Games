using UnityEngine;

public class UiManager : MonoBehaviour
{
    public Stamina_Ui_Code Stamina_Ui;

    private void Start()
    {
        Stamina_Ui.MaxEngry(PlayerStats.Gm.Stamina);
    }
    private void Update()
    {
        Stamina_Ui.UpdateEngry(PlayerStats.Gm.Stamina);
    }
}
