using UnityEngine;

public class PathMove : MonoBehaviour
{
    public Vector2[] Points;
    public float Duration = 1.0f;
    public LeanTweenType tweenType = LeanTweenType.once;
    public int StartingPoint = -1;
    public bool EditPath = false;
    private void Start()
    {
        if (StartingPoint == -1)
        {
            transform.position = Points[Random.Range(0, Points.Length)];
        }
        else
        {
            transform.position = Points[StartingPoint];
        }
        float duration = Duration / Points.Length;
        Move(1, duration);
    }
    private void Move(int i, float duration)
    {
        if (i == Points.Length)
        {
            i = 0;
        }
        LeanTween.move(gameObject, Points[i], duration)
            .setLoopType(tweenType)
            .setOnComplete(() =>
            {
                i++;
                Move(i, duration);
            });
    }
}
