using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class uknoScr : MonoBehaviour
{
    private GameObject player;
    private playerScr playerS;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
        playerS = player.GetComponent<playerScr>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown()
    {
        if (!FindObjectOfType<gameManager>().gameHasEnded)
        {
            playerS.roflanState = 0;
        }
    }
}
