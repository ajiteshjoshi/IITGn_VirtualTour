using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField] Text FPS;
    [SerializeField] Text currFPS;
    [SerializeField] Slider fps_slider;
    [SerializeField] Toggle vsync_toggle;

    float prev_fps;
    float curr_fps;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        prev_fps = curr_fps;
        curr_fps = 1 / Time.unscaledDeltaTime;

        if (Mathf.Abs(prev_fps - curr_fps)>2f)
        {
            currFPS.text = curr_fps.ToString("0");
        }
        
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        
        float curr_max_fps = 24f + fps_slider.value * 36f;
        FPS.text = curr_max_fps.ToString("0");

        if (vsync_toggle.isOn)
        {
            Application.targetFrameRate = (int)curr_max_fps;
        }
        else
        {
            Application.targetFrameRate = -1;
        }
    }
}
