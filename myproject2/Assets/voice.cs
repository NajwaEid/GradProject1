using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class voice : MonoBehaviour
{
	
		 public AudioSource source  ;

 public void stop()
 {
      if(source.isPlaying)
      {
         source.Stop();
      }
      
 }
 
 public void play()
 {
      if(!source.isPlaying)
      {
         source.Play();
      }
      
 }
 
 
 
 
}
