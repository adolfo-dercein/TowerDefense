

public class EnemyParameters
{
    public float MinSpeed => 0.2f;
    public float MaxSpeed => 1.0f;
    public float InitialHealth => 3.0f;
    public float SpawnFrecuency => 4.0f;
    public float LimitToDestroy => 7f;

    /// <summary>
    /// How much time (in seconds) it will wait before start spawning 
    /// </summary>
    public float SpawnFrecuencyOffset => 2f;
}
