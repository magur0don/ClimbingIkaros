using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TimeViewer : MonoBehaviour
{
    public Timer Timer;
    public TextMeshProUGUI TimerText;

    // Update is called once per frame
    void Update()
    {
        TimerText.text = Timer.GetGameTimeText;
    }
}
