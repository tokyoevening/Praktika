using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class itemScr : MonoBehaviour
{
    private inventory invent;
    private GameObject player;
    private playerScr playerS;
    public GameObject pickUpItem;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
        playerS = player.GetComponent<playerScr>();
        invent = player.GetComponent<inventory>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown()
    {
        playerS.isHasItem = true;

        for (int i = 0; i < invent.slots.Length; i++)
        {
            if (invent.isFull[i] == false)
            {
                invent.isFull[i] = true;
                Instantiate(pickUpItem, invent.slots[i].transform, false);
                
                Destroy(this.gameObject);
                break;
            }
        }
    }
}
