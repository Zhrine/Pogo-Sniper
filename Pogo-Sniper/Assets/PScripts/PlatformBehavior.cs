using UnityEngine;

namespace PScripts
{
    public class PlatformBehavior : MonoBehaviour
    {
        public float jumpForce = 10f;
        private void OnCollisionEnter(Collision collision)
        {
            Rigidbody rb = collision.collider.GetComponent<Rigidbody>();
            if (rb != null)
            {
                Vector3 velocity = rb.velocity;
                velocity.y = jumpForce;
                rb.velocity = velocity;
            }
        }
    
    }
}
