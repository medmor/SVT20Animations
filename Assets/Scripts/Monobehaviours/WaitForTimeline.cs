using System.Collections;
using UnityEngine;

public class WaitForTimeline : MonoBehaviour
{
    [SerializeField] private GameObject timeline;
    [SerializeField] private float seconds = 5;

    void Start()
    {
        StartCoroutine(Waite());
    }

    IEnumerator Waite()
    {
        yield return new WaitForSeconds(seconds);
        timeline.SetActive(true);
    }
}
