using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

  using UnityEngine.SceneManagement;

public class reload : MonoBehaviour
{
	
	
	  public void ReloadLevel(){
	   	   
  SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
 }
 
 
    
    
}
