using Assets._Code.Scripts.Util;
using UnityEngine;

public class CannonController : MonoBehaviour
{
    private GameObject closestEnemy;
    public GameObject bulletPrefab;
    public GameObject bullet;

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

        if (closestEnemy != null)
        {
            Vector3 direction = closestEnemy.transform.position - gameObject.transform.position;
            direction.y = 0f;

            Quaternion desiredRotation = Quaternion.LookRotation(direction);

            float rotationSpeed = Parameters.CannonParameters.RotationSpeed; // Adjust the speed of rotation as needed
            gameObject.transform.rotation = Quaternion.Slerp(gameObject.transform.rotation, desiredRotation, rotationSpeed * Time.deltaTime);

            if (closestDistance < 5 && bullet == null )
            {
                bullet = Instantiate(bulletPrefab);
                BulletController bulletController = bullet.GetComponent<BulletController>();
                if (bulletController != null)
                {
                    bulletController.initialPos = transform.position;
                    bulletController.direction = desiredRotation;
                    bulletController.target = closestEnemy;
                }
            }
        }
    }
}
