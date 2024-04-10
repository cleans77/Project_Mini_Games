using UnityEngine;
using UnityEngine.UI;

public class Stamina_Ui_Code : MonoBehaviour
{
    public Slider Stamina_Slider;
    public void MaxEngry(float fell)
    {
        Stamina_Slider.maxValue = fell;
        Stamina_Slider.value = fell;
    }
    public void UpdateEngry(float fell)
    {
        Stamina_Slider.value = fell;
    }
}
