using System.Collections;
using UnityEngine;
using UnityEngine.Playables;

public class TimelineManager : MonoBehaviour
{
    [SerializeField] GameObject[] objects;
    void Start()
    {
        foreach (var obj in objects)
        {
            obj.SetActive(false);
        }
        StartCoroutine(PlayAll());
    }

    IEnumerator PlayAll()
    {
        for (int i = 0; i < objects.Length; i++)
        {
            objects[i].SetActive(true);
            var play = objects[i].GetComponentInChildren<PlayableDirector>();
            play.Play();
            yield return new WaitForSeconds((float)play.duration);
            objects[i].SetActive(false);
        }
    }


}
