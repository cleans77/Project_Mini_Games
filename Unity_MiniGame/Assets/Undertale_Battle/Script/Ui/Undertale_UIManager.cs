using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Undertale_UIManager : MonoBehaviour
{
    public UIStats UI;
    public Undertale_PlayerStats PlayerStats;
    private void Start()
    {
        UI.SetStart(PlayerStats.Hp, PlayerStats.Lv.ToString());
    }
    private void Update()
    {
        UI.SetUpdate(PlayerStats.Hp);
    }
}
