using UnityEngine;

public class EnemyProjectileShooter : MonoBehaviour
{
    [SerializeField] Rigidbody2D bulletPrefab;
    [SerializeField] Transform firePoint;
    [SerializeField] Transform targetPoint;
    [SerializeField] float fireInterval = 5f;
    [SerializeField] float projectileTime = 1f;

    private float fireCooldown;

    void Update()
    {
        fireCooldown -= Time.deltaTime;

        if (fireCooldown <= 0f)
        {
            ShootProjectile();
            fireCooldown = fireInterval;
        }
    }

    void ShootProjectile()
    {
        Vector2 velocity = CalculateProjectileVelocity(firePoint.position, targetPoint.position, projectileTime);
        Rigidbody2D bullet = Instantiate(bulletPrefab, firePoint.position, Quaternion.identity);
        bullet.linearVelocity = velocity;

        bullet.gameObject.AddComponent<BulletDestroyer>().SetTarget(targetPoint.position);
    }

    Vector2 CalculateProjectileVelocity(Vector2 origin, Vector2 target, float time)
    {
        Vector2 distance = target - origin;
        float vx = distance.x / time;
        float vy = distance.y / time + 0.5f * Mathf.Abs(Physics2D.gravity.y) * time;
        return new Vector2(vx, vy);
    }
}