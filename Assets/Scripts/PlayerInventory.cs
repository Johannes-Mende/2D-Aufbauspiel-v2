using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInventory : MonoBehaviour
{
    private ResourceManager RM;
    public TMPro.TMP_Text SilverAmounttext;
    void Start()
    {
        
    }


    void Update()
    {
        SilverAmounttext.SetText(RM.SilverAmountplayer.ToString());
    }
}
