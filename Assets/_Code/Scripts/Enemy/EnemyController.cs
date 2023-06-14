using Assets._Code.Scripts.Enemy;
using Assets._Code.Scripts.Enemy.States;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    EnemyBaseState currentState;

    public EnemyAliveState AliveState = new EnemyAliveState();
    public EnemyDeathState DeathState = new EnemyDeathState();
    public EnemyWinState WinState = new EnemyWinState();

    public Rigidbody body;

    void Start()
    {
        currentState = AliveState;
        currentState.EnterState(this);
    }

    void Update()
    {
        currentState.UpdateState(this);
    }

    public void SwitchState(EnemyBaseState state)
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
