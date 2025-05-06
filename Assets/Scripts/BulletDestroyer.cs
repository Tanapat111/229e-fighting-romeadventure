using UnityEngine;

public class BulletDestroyer : MonoBehaviour
{
    private Vector2 target;
    private float threshold = 1f;

    public void SetTarget(Vector2 targetPosition)
    {
        target = targetPosition;
    }

    void Update()
    {
        if (Vector2.Distance(transform.position, target) <= threshold)
        {
            Destroy(gameObject);
        }
    }
} 
