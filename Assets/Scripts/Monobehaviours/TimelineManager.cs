using UnityEngine;
using UnityEngine.Playables;

public class TimelineManager : MonoBehaviour
{
    [SerializeField] Playable[] playables;
    void Start()
    {
        playables[0].Play();
        var duration = playables[0].GetDuration();
    }


}
