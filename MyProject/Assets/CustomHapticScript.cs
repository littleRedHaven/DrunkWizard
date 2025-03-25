using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.XR.Interaction.Toolkit.Inputs.Haptics;

public class CustomHapticScript : MonoBehaviour
{

public Transform cube;
public Transform goal;
    private bool picked = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    public void pickedup()
    {
        picked = true;
        StartCoroutine(ContinuousVibration());
    }   

    public void dropped()
    {
        picked = false;
    }   


    IEnumerator ContinuousVibration()
    {
        yield return new WaitForSeconds(0.1f);

        if(Vector3.Distance(cube.position, goal.position)>6f)
        {
            GetComponent<HapticImpulsePlayer>().SendHapticImpulse(0.1f, 1f, 100f);
        }

        else if(Vector3.Distance(cube.position, goal.position)>3f)
        {
            GetComponent<HapticImpulsePlayer>().SendHapticImpulse(0.5f, 1f, 100f);
        }

        else{
            GetComponent<HapticImpulsePlayer>().SendHapticImpulse(1f, 1f, 100f);
        }

        //GetComponent<HapticImpulsePlayer>().SendHapticImpulse(0.1f, 3f, 100f);
        yield return new WaitForSeconds(3f);

        if (picked) {
        
            StartCoroutine(ContinuousVibration());

        }
    }


    public void lowamp()
    {
        GetComponent<HapticImpulsePlayer>().SendHapticImpulse(0.1f, 1f, 100f);
    }

    public void medamp()
    {
        GetComponent<HapticImpulsePlayer>().SendHapticImpulse(0.5f, 1f, 100f);
    }
    public void highamp()
    {
        GetComponent<HapticImpulsePlayer>().SendHapticImpulse(1f, 1f, 100f);
    }



    // Update is called once per frame
    void Update()
    {
        
    }
}
