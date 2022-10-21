using UnityEngine;

namespace PScripts
//this script was used from https://answers.unity.com/questions/1087449/how-to-create-a-generic-script-for-bouncing-behavi.html
// it was very helpful getting my base mechanics done in this way, thank you Cheo
{
    public class BouncingEffect : MonoBehaviour {
 
        public float radius = 0.0F;
        public float power = 10.0F;
        public float upwardsModifier = 0.0F;
 
        Vector3 epicentro;
 
        void Start() {
 
            Vector3 explosionPos = transform.position;
            epicentro = explosionPos;
 
        }
 
        void OnCollisionEnter(Collision collision) {
            if (collision.gameObject.tag == "Player")
            {
                GameObject Player = GameObject.FindWithTag("Player");
                Rigidbody player = Player.GetComponent<Rigidbody>();
                player.AddExplosionForce (power, epicentro, radius, upwardsModifier);
            Debug.Log("Player has collided with Bouncer");
            }
        }
    }
}