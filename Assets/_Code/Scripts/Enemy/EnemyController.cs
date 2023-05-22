using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public Rigidbody body;

    private float minSpeed = Parameters.EnemyParameters.MinSpeed;
    private float maxSpeed = Parameters.EnemyParameters.MaxSpeed;
    private float health = Parameters.EnemyParameters.InitialHealth;

    private float speed;

    void Start()
    {
        speed = Random.Range(minSpeed, maxSpeed);
    }

    void Update()
    {
        MoveForward();
        DestroyWhenOutside();
    }

    void MoveForward()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }

    void DestroyWhenOutside()
    {
        if(gameObject.transform.position.z > 7)
        {
            Destroy(gameObject);
        }
    }
}
