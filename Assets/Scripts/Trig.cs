using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Trig : MonoBehaviour
{
    [SerializeField] Text text;
    private void OnTriggerEnter(Collider other)
    {
        Events.pop(text);
    }

    private void OnTriggerExit(Collider other)
    {
        Events.fade(text);
    }
}
