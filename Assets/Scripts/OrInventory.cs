﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrInventory : MonoBehaviour
{
    #region Ore
    public new string name;
    public float maxAmount;
    public float currentAmount;
    public TMPro.TMP_Text maxAmounttext;
    public TMPro.TMP_Text currentAmounttext;
    #endregion



    void Start()
    {
        
    }

    void Update()
    {
        maxAmounttext.SetText(maxAmount.ToString());            //Konvertieren von den Float werten in Text für Text Mesh Pro
        currentAmounttext.SetText(currentAmount.ToString());
    }

    public void Abbau()
    {

    }

}
