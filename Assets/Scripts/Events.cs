using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Events : MonoBehaviour
{
    // Start is called before the first frame update

    public delegate void PopUp(Text text);
    public static PopUp pop;

    public delegate void FadeIn(Text text);
    public static FadeIn fade;


    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
