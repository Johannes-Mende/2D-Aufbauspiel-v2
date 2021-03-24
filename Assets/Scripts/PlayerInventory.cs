using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerInventory : MonoBehaviour
{

    public TMPro.TMP_Text silverAmounttext;

    public static float PlayerAbbauAmount = 1;
    public static float OrePlayerInventory;    //RM.SilverAmountplayer muss hier definiert werden??

    void Start()
    {
        
    }


    void Update()
    {
        silverAmounttext.SetText(OrePlayerInventory.ToString());
    }
}
