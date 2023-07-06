using UnityEngine;

namespace Assets._Code.Scripts.Util.Light
{
    public class LightController : MonoBehaviour
    {
        public float minIntensity = 0.02f;
        public float maxIntensity = 0.03f;
        public float Timer = 0.1f;
        private new UnityEngine.Light light = null;

        private void Start()
        {
            light = this.GetComponentInChildren<UnityEngine.Light>();
            InvokeRepeating("Flicker", Timer, Timer);
        }
        private void Flicker()
        {
            float R = UnityEngine.Random.Range(minIntensity, maxIntensity);
            light.intensity = R;
        }
    }
}