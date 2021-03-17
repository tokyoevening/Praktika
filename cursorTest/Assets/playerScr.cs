using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerScr : MonoBehaviour
{
    private GameObject player;
    public bool isHasItem = false;
    public int roflanState = 1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!FindObjectOfType<gameManager>().gameHasEnded)
        {
            if (Input.GetKey(KeyCode.Return) && isHasItem || roflanState == 0)
            {
                FindObjectOfType<gameManager>().endGame();
            }
            
        }
    }
}
