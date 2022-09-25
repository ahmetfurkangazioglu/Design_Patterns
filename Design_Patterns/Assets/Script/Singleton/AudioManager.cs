using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager :MonoSingleton<AudioManager>
{
    public void AllMute()
    {
        Debug.Log("Mute");
    }
    public void AllOpen()
    {
        Debug.Log("Sounds Open");
    }
}
