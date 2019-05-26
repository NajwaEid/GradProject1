using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 using UnityEngine.SceneManagement;


public class reload1 : MonoBehaviour
{
	
   public void relod(){
      SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);     
     }
}
