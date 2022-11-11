using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animationTrigger : MonoBehaviour
{
    private Animation idle;

    // Start is called before the first frame update
    void Start()
    {
       idle = gameObject.GetComponent<Animation>();
       idle.Play("Sitting Rubbing Arm");
    }

    // Update is called once per frame
    void Update()
    {
        int rand = Random.Range(0,1);
        int test = 1;
        if (test == 1){
            idle.Play("Sitting And Pointing");
        } else {
            idle.CrossFadeQueued("Sitting Rubbing Arm");
        }
    }
}
