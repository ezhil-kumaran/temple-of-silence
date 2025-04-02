using UnityEngine;

public class Projectilespawner : MonoBehaviour
{
    [SerializeField] private GameObject projectilePrefab;
    [SerializeField] private Transform spawnPoint;
    [SerializeField] private float fireRate = 10f;
    [SerializeField] private int directionset;
    [SerializeField] private float detectionRange = 18f; // Player detection range
    private Transform player;
    private float cooldownTimer;

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("char")?.transform;
    }

    private void Update()
    {
        cooldownTimer += Time.deltaTime;
        if (cooldownTimer >= fireRate && PlayerInRange()) // Fire only if player is close
        {
            SpawnProjectile();
            cooldownTimer = 0f;
        }
    }

    private bool PlayerInRange()
    {
        return player != null && Vector2.Distance(transform.position, player.position) <= detectionRange;
    }

    private void SpawnProjectile()
    {
        GameObject arrow = Instantiate(projectilePrefab, spawnPoint.position, Quaternion.identity);
        Projectile proj = arrow.GetComponent<Projectile>();

        float xDir = 0f, yDir = 0f;
        float rotationAngle = 0f;

        if (directionset == 1) // Right
        {
            xDir = -Mathf.Sign(transform.localScale.x);
            rotationAngle = 0f;
        }
        else if (directionset == -1) // Left
        {
            xDir = -Mathf.Sign(transform.localScale.x);
            rotationAngle = 180f;
        }
        else if (directionset == 2) // Up
        {
            yDir = 1f;
            rotationAngle = 90f;
        }
        else if (directionset == -2) // Down
        {
            yDir = -1f;
            rotationAngle = -90f;
        }

        
        proj.SetDirection(xDir, yDir);

        arrow.transform.rotation = Quaternion.Euler(0f, 0f, rotationAngle);
    }

}


