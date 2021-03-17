using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doorScr : MonoBehaviour
{
    [SerializeField] private Transform followTarget;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown()
    {
        if (!FindObjectOfType<gameManager>().gameHasEnded)
        {
            GameObject cam = GameObject.Find("Main_Camera");
            moveCamera moveCam = cam.GetComponent<moveCamera>();

            if (followTarget.gameObject.name == "Koridor")
            {
                if (this.gameObject.name == "komnataToKoridor" || this.gameObject.name == "vannaToKoridor")
                {
                    cam.transform.position = new Vector3(followTarget.position.x + 7f, followTarget.position.y, -10);
                }
                else
                {
                    cam.transform.position = new Vector3(followTarget.position.x - 7f, followTarget.position.y, -10);
                }
                moveCam.isKoridor = true;
                moveCam.isPadik = false;
            }
            else if (followTarget.gameObject.name == "Padik")
            {
                cam.transform.position = new Vector3(followTarget.position.x + 2.2f, followTarget.position.y, -10);
                moveCam.isKoridor = false;
                moveCam.isPadik = true;
            }
            else
            {
                cam.transform.position = new Vector3(followTarget.position.x, followTarget.position.y, -10);
                moveCam.isKoridor = false;
                moveCam.isPadik = false;
            }
        }
        
    }
}
