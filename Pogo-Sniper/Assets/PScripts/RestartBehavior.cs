using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
     
public class RestartBehavior : MonoBehaviour 
{
     //Code referenced from a very helpful user on answersunity.com named Jscotty, thanks jscotty!
    public void RestartGame() 
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name); 
    }
     
}