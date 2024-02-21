using UnityEngine;
using UnityEngine.U2D;

public class shapeController : MonoBehaviour
{
    public SpriteShapeController spriteShapeController;
    void Start()
    {
        Vector2[] newPoints = new Vector2[]
        {
            new Vector2(0, 0),
            new Vector2(1, 1),
            new Vector2(2, 0),
            new Vector2(3, 1),
            new Vector2(4, 0)
        };
        print(spriteShapeController.spline.GetPointCount());

        spriteShapeController.BakeCollider();
        spriteShapeController.BakeMesh();
    }
}
