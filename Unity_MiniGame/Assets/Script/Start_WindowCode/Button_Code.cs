using UnityEngine;
using UnityEngine.SceneManagement;

public class Button_Code : MonoBehaviour
{
    public void Staret_Button()
    {
        SceneManager.LoadScene("MainWindow");
    }
    public void Setting_Button()
    {

    }
    public void Exit_Button()
    {
        Application.Quit();
    }
}
