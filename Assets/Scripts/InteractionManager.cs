using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InteractionManager : MonoBehaviour
{

    [SerializeField] Text balcony;
    [SerializeField] GameObject door;

    void Start()
    {
        Events.pop += Show;
        Events.fade += Hide;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                //Select stage    
                if (hit.collider.gameObject.tag == "Clickable")
                {
                    Open();
                }
            }
        }
    }

    void Show(Text text)
    {
        text.gameObject.SetActive(true);
    }

    void Hide(Text text)
    {
        text.gameObject.SetActive(false);
    }

    void Open()
    {
        door.SetActive(false);
    }
}
