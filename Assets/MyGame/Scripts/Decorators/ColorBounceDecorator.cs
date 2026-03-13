using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]
public class ColorBounceDecorator : MonoBehaviour, IMovementDecorator
{
    private SpriteRenderer spriteRenderer;

    private void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    public void OnReachedTarget()
    {
        spriteRenderer.color = Random.ColorHSV();
    }
}