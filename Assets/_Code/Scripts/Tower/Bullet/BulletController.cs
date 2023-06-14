using UnityEngine;
using Assets._Code.Scripts.Tower.Bullet;
using Assets._Code.Scripts.Tower.Bullet.States;

public class BulletController : MonoBehaviour
{
    BulletBaseState currentState;

    public BulletFireState FireState = new BulletFireState();
    public BulletDestroyedState DestroyedState = new BulletDestroyedState();

    public GameObject target;
    public Vector3 initialPos;
    public Quaternion direction;
    public AudioSource shootSFX;

    void Start()
    {
        currentState = FireState;
        currentState.EnterState(this);
    }

    void Update()
    {
        currentState.UpdateState(this);
    }

    public void SwitchState(BulletBaseState state)
    {
        currentState = state;
        state.EnterState(this);
    }

    public void DestroyGameObject()
    {
        Destroy(gameObject);
    }

    private void OnTriggerEnter(Collider other)
    {
        currentState.OnTriggerEnter(this, other);
    }
}
