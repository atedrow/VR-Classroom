using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlarmTrigger : MonoBehaviour
{
    public AudioClip Sound;
    public float Volume;
    AudioSource audio;
    private int timer;

    public int start_time;
    // Start is called before the first frame update
    void Start()
    {
        audio = gameObject.GetComponent<AudioSource>();   
        timer = 0;
    }

    // Update is called once per frame
    void Update()
    {
       timer++;
       if (timer == start_time){
            audio.PlayOneShot(Sound, Volume);
       } 
        
    }
}
