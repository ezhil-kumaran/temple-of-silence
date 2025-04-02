using UnityEngine;

public class enemydamage : MonoBehaviour
{
    [SerializeField]private float damage;
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "char")
        {
            collision.GetComponent<health>().damage(damage);
        }
    }
}
