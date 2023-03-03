using UnityEngine;

public class RectRndMove : MonoBehaviour
{
    [SerializeField] private float duration;
    [SerializeField] private Vector2 center;
    [SerializeField] private Vector2 size;
    [SerializeField] private LeanTweenType tweanType = LeanTweenType.once;
    void Start()
    {
        Move();

    }

    private void Move()
    {
        var target = RandomPointInBounds();
        LeanTween.move(gameObject, target, duration)
            .setEase(tweanType)
            .setOnComplete(Move);
    }

    private Vector2 RandomPointInBounds()
    {
        return new Vector2(
            Random.Range(center.x - size.x / 2, center.x + size.x / 2),
            Random.Range(center.y - size.y / 2, center.y + size.y / 2)
        );
    }
    private void OnDrawGizmos()
    {
        if (center == null)
        {
            center = new Vector2(transform.position.x, transform.position.y);
            size = new Vector2(.5f, .5f);
        }
        Gizmos.DrawWireCube(center, size);
    }
}