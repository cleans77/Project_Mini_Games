using TMPro;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public class UIStats : MonoBehaviour
{
    public Slider HpBar;
    public TMP_Text T_HP;
    public TMP_Text T_LV;

    public void SetStart(int curHp ,string curLv)
    {
        HpBar.maxValue = curHp;
        HpBar.value = curHp;

        T_HP.text = curHp.ToString() + " / 99";
        T_LV.text = curLv + " LV";
    }

    public void SetUpdate(int curHp)
    {
        HpBar.value = curHp;
        T_HP.text = curHp.ToString() + " / 99";
    }
}
