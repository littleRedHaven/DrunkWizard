using UnityEngine;

public class Passthrough_manager : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public OVRPassthroughLayer layer1;
    public OVRPassthroughLayer layer2;
    private bool clicked = false;
    void Start()
    {
        
    }

    public void switchlayers()
    {

        if (clicked)
        {
            clicked = true;
            layer1.enabled = false;
            layer2.enabled = true;
        }




    }



    // Update is called once per frame
    void Update()
    {
        
    }
    
    
}
