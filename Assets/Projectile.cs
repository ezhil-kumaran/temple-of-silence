using UnityEngine;

public class Projectile : MonoBehaviour
{
    [SerializeField] private float speed = 5f;
    [SerializeField] private float lifetime = 4f;
    private float direction;

    

    private void Update()
    {
        transform.position += new Vector3(direction * speed * Time.deltaTime, 0, 0);
        Destroy(gameObject, lifetime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("char"))
        {
            collision.GetComponent<health>().damage(1);
            Destroy(gameObject);
        }
        else if (collision.CompareTag("Ground") || collision.CompareTag("enemy"))
        {
            Destroy(gameObject);
        }
    }
    public void SetDirection(float xDir, float yDir)
    {
        GetComponent<Rigidbody2D>().linearVelocity = new Vector2(xDir * speed, yDir * speed);
    }

}
