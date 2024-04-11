using PlS;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Undertale_UIManager : MonoBehaviour
{
    public UIStats UI;
    private void Start()
    {
        UI.SetStart(Undertale_PlayerStats.Hp, Undertale_PlayerStats.Lv.ToString());
    }
    private void Update()
    {
        UI.SetUpdate(Undertale_PlayerStats.Hp);
    }
}
