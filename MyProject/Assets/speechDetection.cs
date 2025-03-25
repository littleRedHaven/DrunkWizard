//using Meta.WitAi;
//using Oculus.Voice;
using System.Collections; 
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class speechDetection : MonoBehaviour
{
    //public AppVoiceExperience wit;
    public GameObject textmesh;
    public Collision cauldCollis;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        cauldCollis = GetComponent<Collision>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)) {

           // wit.Activate();
            Debug.Log("Pressed");
        }
    }

    public void transcription(string[] value)
    {
        Debug.Log(value[0]);
        textmesh.GetComponent<TextMeshPro>().text = value[0];

        if (value[0] == "fireball" || value[0] == "Fireball")
        {
            Debug.Log("bawambabanabam. woohoo!!");
        }
    }


    // this is not finding any collision. How the heck do I find a button input
    public void OnCollisionEnter(Collision cauldCollis)
    {
      //  wit.Activate();
        Debug.Log("Entered");
    }
}
