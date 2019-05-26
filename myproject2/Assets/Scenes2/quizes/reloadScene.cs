using System.Collections;
using System.Collections.Generic;
using UnityEngine;

  using UnityEngine.SceneManagement;

public class reloadScene : MonoBehaviour
{
   
 //  public void ReloadLevel()//{
	   	   
 // SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
 //}//
 
 
  
	  public void quizRepeat()   {
		
		   SceneManager.LoadScene("quizRepeat");

     }
	 
	 
	  public void quiz()   {
		
		   SceneManager.LoadScene("quiz");

     }
 
 
}
