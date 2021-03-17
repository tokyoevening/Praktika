using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveCamera : MonoBehaviour
{
    public bool isKoridor = false;
    public bool isPadik = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!FindObjectOfType<gameManager>().gameHasEnded)
        {
            if (isKoridor) {
                if (Input.GetKey(KeyCode.RightArrow) && this.gameObject.transform.position.x < 7.8)
                {
                    transform.Translate(new Vector3(10 * Time.deltaTime, 0, 0));
                }
                if (Input.GetKey(KeyCode.LeftArrow) && this.gameObject.transform.position.x > -6)
                {
                    transform.Translate(new Vector3(-10 * Time.deltaTime, 0, 0));
                }
            }
            else if (isPadik)
            {
                if (Input.GetKey(KeyCode.RightArrow) && this.gameObject.transform.position.x < -19.6)
                {
                    transform.Translate(new Vector3(10 * Time.deltaTime, 0, 0));
                }
                if (Input.GetKey(KeyCode.LeftArrow) && this.gameObject.transform.position.x > -24.1)
                {
                    transform.Translate(new Vector3(-10 * Time.deltaTime, 0, 0));
                }
            }
        }
    }
}
