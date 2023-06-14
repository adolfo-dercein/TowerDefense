using Assets._Code.Scripts.Util;
using UnityEngine;

public class CannonController : MonoBehaviour
{
    private GameObject closestEnemy;
    public GameObject bulletPrefab;
    public GameObject bullet;
    public float rotationSpeed = 5f;
    public float bulletSpeed = 5f;
    public float range = 3f;
    private float shootingTimer = 1f;
    public float shootingInterval = 1f;

    private void Start() { }

    private void Update()
    {
        float closestDistance = Mathf.Infinity;

        GameObject[] enemies = GameObject.FindGameObjectsWithTag(Tags.Enemy);

        foreach (GameObject enemy in enemies)
        {
            float distance = Vector3.Distance(transform.position, enemy.transform.position);

            if (distance < closestDistance)
            {
                closestDistance = distance;
                closestEnemy = enemy;
            }
        }

        shootingTimer += Time.deltaTime;

        if (closestEnemy != null)
        {
            Vector3 direction = closestEnemy.transform.position - gameObject.transform.position;
            direction.y = 0f;

            Quaternion desiredRotation = Quaternion.LookRotation(direction);

            gameObject.transform.rotation = Quaternion.Slerp(gameObject.transform.rotation, desiredRotation, rotationSpeed * Time.deltaTime);

            if (closestDistance < range && bullet == null && shootingTimer >= shootingInterval )
            {
                shootingTimer = 0;

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
