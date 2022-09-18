using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bonus : MonoBehaviour
{
    public static Action<int> OnBonusChanged;

    public int amount;

    public Text amountText;

    public List<Modifiers> modifiers;

    private void Start()
    {
        UpdateUI();
    }
    
    public void UpdateUI()
    {
        amountText.text = "Total Bonus = " + amount.ToString();
    }
    public void UpdateBonus()
    {
        amount = 0;
        foreach(Modifiers modifier in modifiers)
        {
            if (modifier.active)
            {
                amount += modifier.amount;
            }
        }
        OnBonusChanged?.Invoke(amount);
        UpdateUI();
    }
}
