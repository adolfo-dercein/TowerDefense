using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public Rigidbody body;

    private float minSpeed = Parameters.EnemyParameters.MinSpeed;
    private float maxSpeed = Parameters.EnemyParameters.MaxSpeed;
    private float health = Parameters.EnemyParameters.InitialHealth;
    public GameObject firstWaypoint;
    public Vector3 direction;

    private float speed;

    void Start()
    {
        speed = Random.Range(minSpeed, maxSpeed);
        direction = (firstWaypoint.transform.position - transform.position).normalized;
    }

    void Update()
    {
        MoveForward();
        DestroyWhenOutside();
    }

    void MoveForward()
    {
        transform.Translate(direction * speed * Time.deltaTime);
    }

    void DestroyWhenOutside()
    {
        if(gameObject.transform.position.z > 7)
        {
            Destroy(gameObject);
        }
    }
}
