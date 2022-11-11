using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorTrigger : MonoBehaviour
{
    public AudioClip Sound1;
    public AudioClip Sound2;
    public float Volume;
    AudioSource audio;
    // public variable for setting starting time of clip
    public int start_time;

    private int timer;
    private bool hasPlayed1;
    private bool hasPlayed2;
    // Start is called before the first frame update
    void Start()
    {
        audio = gameObject.GetComponent<AudioSource>();   
        timer = 0;
        hasPlayed1 = false;
        hasPlayed2 = false;
    }

    // Update is called once per frame
    void Update()
    {
        timer++;
        if(hasPlayed1){
            if(!hasPlayed2){
                if(!audio.isPlaying){
                    audio.PlayOneShot(Sound2, Volume);
                    hasPlayed2 = true;
                }
            }
        }
       if (timer == start_time){
            audio.PlayOneShot(Sound1, Volume);
            hasPlayed1 = true;
        }
    }
}
