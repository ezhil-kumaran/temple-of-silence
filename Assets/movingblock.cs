using UnityEngine;

public class MovingBlock : MonoBehaviour
{
    [SerializeField] private float pointA = -3f; // Leftmost X position
    [SerializeField] private float pointB = 3f;  // Rightmost X position
    [SerializeField] private float speed = 2f;
    private Vector3 target;

    private void Start()
    {
        target = new Vector3(pointB, transform.position.y, transform.position.z);
    }

    private void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, target, speed * Time.deltaTime);

        // Switch direction when reaching a target point
        if (Mathf.Abs(transform.position.x - target.x) < 0.1f)
        {
            target.x = target.x == pointA ? pointB : pointA;
        }
    }
}

