using UnityEngine;

public class ZRotation : MonoBehaviour
{
    [SerializeField] private bool RandomDirection = false;
    [SerializeField] private float Angle = 360f;
    [SerializeField] private float Duration = 1f;
    [SerializeField] private LeanTweenType LoopType = LeanTweenType.once;


    void Start()
    {
        var dir = 1;
        if (RandomDirection)
        {
            dir = Random.value < .5 ? 1 : -1;
        }
        LeanTween.rotateZ(gameObject, transform.rotation.z + dir * Angle, Duration)
            .setLoopType(LoopType);

    }

}
