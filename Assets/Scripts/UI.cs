using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UI : MonoBehaviour
{
    public PlayContinuousSound gee;
    public PlayContinuousSound windBlow;
    public void ResetScene()
    {
        string sceneName = SceneManager.GetActiveScene().name;
        SceneManager.LoadScene(sceneName);
    }
    public void ResetWeld()
    {
        GameObject[] objectsWithTag = GameObject.FindGameObjectsWithTag("Trail");
        foreach (GameObject obj in objectsWithTag)
        {
            Destroy(obj);
        }
    }
     public void PlayGee()
    {
        gee.TogglePlay();
    }

    public void PlayWindBlow()
    {
        windBlow.TogglePlay();
    }
}
