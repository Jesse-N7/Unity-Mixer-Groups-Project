using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class SnapShotCollider : MonoBehaviour
{

    public AudioMixerSnapshot day;
    public AudioMixerSnapshot night;

    bool isNight = false;

    public AudioMixerSnapshot ambience;
   // [Range(300,5000)]

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            if (!isNight)
            {
                night.TransitionTo(0.5f);
                isNight = true;
            }
            else if (isNight)
            {
                day.TransitionTo(0.5f);
                isNight = false;
            }
        }

        night.TransitionTo(0.5f);
    }
    private void OnTriggerStay(Collider other)
    {
        
    }
}
