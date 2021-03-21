using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerInventory : MonoBehaviour
{
    private ResourceManager RM;
    public TMPro.TMP_Text silverAmounttext;

    public float PlayerAbbauAmount = 1;

    void Start()
    {
        
    }


    void Update()
    {
        silverAmounttext.SetText(RM.SilverAmountplayer.ToString());
    }
}
