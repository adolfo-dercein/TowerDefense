using UnityEngine;

namespace Assets._Code.Scripts.Util.Light
{
    public class TorchController : MonoBehaviour
    {
        public float minIntensity = 0.01f;
        public float maxIntensity = 0.02f;
        public float Timer = 0.05f;
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