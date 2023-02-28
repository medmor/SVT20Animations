using UnityEngine;

public class YMove : MonoBehaviour
{
    [SerializeField] private bool RandomDirection = false;
    [SerializeField] private float Distance = 10f;
    [SerializeField] private float RandomizeDistanceOffset = 0;
    [SerializeField] private float Duration = 1f;
    [SerializeField] private LeanTweenType LoopType = LeanTweenType.once;


    void Start()
    {
        var dir = 1;
        if (RandomDirection)
        {
            dir = Random.value < .5 ? 1 : -1;
        }
        if (RandomizeDistanceOffset > 0)
        {
            Distance = Random.Range(Distance - RandomizeDistanceOffset, Distance + RandomizeDistanceOffset);
        }
        print(Distance);
        LeanTween.moveLocalY(gameObject, transform.localPosition.y + dir * Distance, Duration)
            .setLoopType(LoopType);

    }

}
