using UnityEngine;

public class CannonController : MonoBehaviour
{
    private GameObject closestEnemy;
    public GameObject bulletPrefab;
    public GameObject bullet;
    public float rotationSpeed = 5f;

    private void Start()
    {
    }

    private void Update()
    {
        float closestDistance = Mathf.Infinity;

        GameObject[] enemies = GameObject.FindGameObjectsWithTag("Enemy");

        foreach (GameObject enemy in enemies)
        {
            float distance = Vector3.Distance(transform.position, enemy.transform.position);

            if (distance < closestDistance)
            {
                closestDistance = distance;
                closestEnemy = enemy;
            }
        }

        if (closestEnemy != null)
        {
            Vector3 direction = closestEnemy.transform.position - gameObject.transform.position;
            direction.y = 0f;

            Quaternion desiredRotation = Quaternion.LookRotation(direction);

            float rotationSpeed = 5f; // Adjust the speed of rotation as needed
            gameObject.transform.rotation = Quaternion.Slerp(gameObject.transform.rotation, desiredRotation, rotationSpeed * Time.deltaTime);

            if (closestDistance < 5 && bullet == null )
            {
               
                bullet = Instantiate(bulletPrefab);
                BulletController bulletController = bullet.GetComponent<BulletController>();
                if (bulletController != null)
                {
                    bulletController.initialPos = transform.position;
                    bulletController.speed = 5f;
                    bulletController.direction = desiredRotation;
                    bulletController.target = closestEnemy;
                    bulletController.damage = 1;
                }
            }
        }
    }
}
