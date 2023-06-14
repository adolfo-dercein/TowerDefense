
using Assets._Code.Scripts.Util.Parameters;

public static class Parameters
{
    static Parameters()
    {
        EnemyParameters = new EnemyParameters();
        CannonParameters = new CannonParameters();
        BulletParameters = new BulletParameters();
    }

    public static EnemyParameters EnemyParameters;
    public static CannonParameters CannonParameters;
    public static BulletParameters BulletParameters;
}
