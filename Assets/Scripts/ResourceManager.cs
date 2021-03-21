using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResourceManager : MonoBehaviour
{
    private OreInventory OInv;
    private PlayerInventory PInv;
    public float SilverAmountplayer;
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
        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if(OInv.PlayerInRange == true)
        {
            if(Physics.Raycast(ray, out hit))
            {
                OInv.currentAmount -= PInv.PlayerAbbauAmount;
            }
        }
    }
}
