using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class loadVoice : MonoBehaviour


{
	
	 public AudioSource source  ;
   public AudioClip  correct ;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Awake()
    {
		
		 source.clip =correct;
		 source.Play(); 
		 
		 
    }
}
