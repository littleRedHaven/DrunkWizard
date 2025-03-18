using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelOpener : MonoBehaviour
{
    public int newlev; 

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       //newlev = GameObject.Find("leveli");
       //newlev = GetComponent(Variables).leveli;
       
     }

    // Update is called once per frame
    void Update()
    {
        
     }

    private void OnCollisionEnter(Collision collision)
    {
        SceneManager.LoadScene(newlev);
        
    }

    void OpenLobby()
    {
        SceneManager.LoadScene(0);
    }

    void OpenLevelOne()
    {
        SceneManager.LoadScene(1);
    }

    void OpenLevelTwo()
    {
        SceneManager.LoadScene(2);
    }

    void OpenLevelThree()
    {
        SceneManager.LoadScene(3);
    }

    void OpenLevelFour()
    {
        SceneManager.LoadScene(4);
    }
}
