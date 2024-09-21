using UnityEngine;
using UnityEngine.Video;

public class TutorialSelector : MonoBehaviour
{
    public VideoClip[] clips;
    public VideoPlayer player;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void StartTutorial(int index)
    {
        player.clip = clips[index];
        player.Play();
    }
}
