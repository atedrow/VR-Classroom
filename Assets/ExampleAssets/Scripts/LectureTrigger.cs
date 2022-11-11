using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LectureTrigger : MonoBehaviour
{
    public AudioClip Sound1;
    public AudioClip Sound2;
    public AudioClip Sound3;
    public float Volume;
    AudioSource audio;
    private bool hasPlayed1;
    private bool hasPlayed2;
    private bool hasPlayed3;

    // Start is called before the first frame update
    void Start()
    {
        audio = gameObject.GetComponent<AudioSource>();   
        hasPlayed1 = false;
        hasPlayed2 = false;
        hasPlayed3 = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("space")){
            if(!hasPlayed1){
                audio.PlayOneShot(Sound1, Volume);
                hasPlayed1 = true;
            }else{
                if(!hasPlayed2){
                    if(!audio.isPlaying){
                        audio.PlayOneShot(Sound2, Volume);
                        hasPlayed2 = true;
                    }
                }else{
                    if(!hasPlayed3){
                        if(!audio.isPlaying){
                            audio.PlayOneShot(Sound3, Volume);
                            hasPlayed3 = true;
                        }
                    }
                }
            }
        }
    }
}
