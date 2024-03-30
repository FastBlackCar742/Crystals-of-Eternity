using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Menu : MonoBehaviour
{
    [Header("References")] 
    [SerializeField] private TextMeshProUGUI currencyUI;
    [SerializeField] private TextMeshProUGUI waveUI;
    [SerializeField] private Animator anim;

    private bool isMenuOpen = true;

    public void ToggleMenu()
    {
        isMenuOpen = !isMenuOpen;
        anim.SetBool("MenuOpen", isMenuOpen);
    }
   // public void 
    private void OnGUI()
    {
        currencyUI.text = LevelManager.main.currency.ToString();
        waveUI.text = "Wave: " + FindObjectOfType<EnemySpawner>().currentWave.ToString();

    }
}
