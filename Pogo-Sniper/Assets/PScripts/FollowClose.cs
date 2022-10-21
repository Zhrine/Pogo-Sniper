using UnityEngine;
using UnityEngine.AI;

public class FollowClose : MonoBehaviour
{
    public NavMeshAgent Player;
    public Transform Target;

    // Update is called once per frame
    void Update()
    { 
       Player.SetDestination(Target.position);
   
    }
}

//(new Vector3(player.transform.position.x, this.transform.position.y, this.transform.position.z));