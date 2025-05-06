using UnityEngine;

public class MovingPlatform2D : MonoBehaviour
{
    public float moveDistance = 3f;  
    public float moveSpeed = 2f;     

    private Vector2 startPos;
    private int direction = 1;

    void Start()
    {
        startPos = transform.position;
    }

    void Update()
    {
        transform.Translate(Vector2.right * direction * moveSpeed * Time.deltaTime);

    
        if (Mathf.Abs(transform.position.x - startPos.x) >= moveDistance)
        {
            direction *= -1;
        }
    }
}