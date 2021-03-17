using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class emptyBucket : MonoBehaviour, IDropHandler
{
    bool isTriggeredVanna = false;
    public GameObject vedroSvodoi;
    private inventory invent;

    public void OnDrop(PointerEventData eventData)
    {
        if (isTriggeredVanna)
        {
            Instantiate(vedroSvodoi, transform.parent, false);
            Destroy(this.gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.name == "VannaDecors_Vanna")
        {
            isTriggeredVanna = true;
        }
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.name == "VannaDecors_Vanna")
        {
            isTriggeredVanna = false;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        invent = GameObject.Find("Player").GetComponent<inventory>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
