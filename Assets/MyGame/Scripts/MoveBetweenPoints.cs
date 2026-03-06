using UnityEngine;
using System.Collections.Generic;

public class MoveBetweenPoints : MonoBehaviour
{
    [SerializeField] private Transform pointA;
    [SerializeField] private Transform pointB;
    [SerializeField] private float speed = 2f;
    [SerializeField] private float reachDistance = 0.05f;

    private Transform currentTarget;
    private IMovementDecorator[] decorators;

    private void Start()
    {
        currentTarget = pointB;
        decorators = GetComponents<IMovementDecorator>();
    }

    private void Update()
    {
        Move();

        if (Vector3.Distance(transform.position, currentTarget.position) <= reachDistance)
        {
            foreach (var decorator in decorators)
                decorator.OnReachedTarget();

            currentTarget = currentTarget == pointA ? pointB : pointA;
        }
    }

    private void Move()
    {
        transform.position = Vector3.MoveTowards(
            transform.position,
            currentTarget.position,
            speed * Time.deltaTime
        );
    }
}