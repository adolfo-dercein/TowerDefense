using System;
using System.Collections;
using UnityEngine;

namespace Assets._Code.Scripts.Towers
{
    public class Rotator
    {
        private Transform parentTransform;
        float rotationSpeed;

        public Rotator(Transform parentTransform, float rotationSpeed)
        {
            this.parentTransform = parentTransform;
            this.rotationSpeed = rotationSpeed;
        }

        public void AimAt(Vector3 target)
        {
            Vector3 direction = target - parentTransform.position;
            direction.y = 0f;

            var targetRotation = Quaternion.LookRotation(direction);
            parentTransform.rotation = Quaternion.Slerp(parentTransform.rotation, targetRotation, rotationSpeed * Time.fixedDeltaTime);
        }
    }
}