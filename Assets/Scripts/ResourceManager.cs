using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResourceManager : MonoBehaviour
{
  
    //public float SilverAmountplayer;
    void Start()
    {
        
    }

    void Update()
    {
      if(Input.GetMouseButtonDown(0))
      {
        Abbau();
      }
    }

    private void Abbau()
    {
        if(OreInventory.PlayerInRange == true)
        {
            Debug.Log("Abbau");
            OreInventory.currentAmount         -=  PlayerInventory.PlayerAbbauAmount;
            PlayerInventory.OrePlayerInventory +=  PlayerInventory.PlayerAbbauAmount;
        }
        
    }

}
