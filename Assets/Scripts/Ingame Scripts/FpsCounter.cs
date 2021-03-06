using TMPro;
using UnityEngine;

public class FpsCounter : MonoBehaviour
{
    private int avgFrameRate;
    public TMP_Text fpsCounter;
    void Start()
    {
        fpsCounter.text = "0 fps";
    }

    void Update()
    {
        float current = (int)(1f / Time.unscaledDeltaTime);
        avgFrameRate = (int)current;
        fpsCounter.text = avgFrameRate + " FPS";
    }
}
