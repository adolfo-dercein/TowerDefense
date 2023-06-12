using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class BulletController : MonoBehaviour
{
    public GameObject target;
    public float speed;
    public Vector3 initialPos;
    public Quaternion direction;
    public int damage;
    // Start is called before the first frame update
    void Start()
    {
        gameObject.transform.position = initialPos;
        //gameObject.transform.rotation = direction;
        gameObject.transform.LookAt(target.transform.position);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
        if (transform.position.x > 10 || transform.position.x < -10 || transform.position.z > 10 || transform.position.z < -10)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy"))
        {
            EnemyController enemyController = other.GetComponent<EnemyController>();
            enemyController.health -= damage;
            if (enemyController.health <= 0)
            {
                Destroy(other.gameObject);
            }
            Destroy(gameObject);
        }
    }

}