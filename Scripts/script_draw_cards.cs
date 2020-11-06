using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class script_draw_cards : MonoBehaviour
{
    public GameObject Card_Insert;
    public GameObject Card_Insert2;
    public GameObject Player_Area;
    public GameObject Enemy_Area;
    
        void Start()
    {
        
    }
    public void onClick()
    {
        for (var i = 0; i < 5; i++)
        { 
        GameObject playerCard = Instantiate(Card_Insert, new Vector3(0, 0, 0), Quaternion.identity);
        playerCard.transform.SetParent(Player_Area.transform, false);
    }
    }

}
