using UnityEngine;

public class GoldenSpinDecorator : MonoBehaviour, IMovementDecorator
{
    [SerializeField] private float spinSpeedX = 900f;
    [SerializeField] private float spinSpeedY = 1800f;
    [SerializeField] private float spinSpeedZ = 450f;


    public void OnReachedTarget()
    {
        transform.Rotate(
            spinSpeedX * Time.deltaTime,
            spinSpeedY * Time.deltaTime,
            spinSpeedZ * Time.deltaTime,
            Space.Self
        );
    }
}
