using UnityEngine;

public class TransitionColor : MonoBehaviour
{
    [SerializeField] Color startingColor;
    [SerializeField] Color endingColor;
    [SerializeField] float duration = 1;
    [SerializeField] bool hideOnEnd = false;
    void Start()
    {
        GetComponent<SpriteRenderer>().color = startingColor;
        var t = LeanTween.color(gameObject, endingColor, duration);
        if (hideOnEnd)
            t.setOnComplete(() =>
        {
            gameObject.SetActive(false);
        });
    }


}
