using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CoinManager : MonoBehaviour
{
    [SerializeField] int coins;
    [SerializeField] TextMeshProUGUI coinsbar;

    private void Start()
    {
        coinsbar.text = "0";
    }

    public void AddCoin()
    {
        coins++;
        coinsbar.text = coins.ToString();

    }
}
