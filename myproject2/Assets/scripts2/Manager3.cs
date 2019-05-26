using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager3 : MonoBehaviour
{
	string currentlevel="currentlevel";
    public GameObject tv , couch ,carpet ,curtain ,tvBlack ,carpetBlack ,couchBlack ,curtainBlack ;
   
   Vector2  tvInitiPos , carpetInitiPos,couchInitiPos, curtainInitiPos ;
   
   public AudioSource source  ;
   public AudioClip  correct ;
   
   
   void Start()
{
	string lev="ﻲﻧﺎﺜﻟﺍ ﻯﻮﺘﺴﻤﻟﺍ";
		PlayerPrefs.SetString(currentlevel,lev);
		   string bigsec="ﺱﻮﻠﺠﻟﺍ ﺔﻓﺮﻏ";
	string bigsection="bigsection";
	PlayerPrefs.SetString(bigsection,bigsec);
	PlayerPrefs.DeleteKey("smallsection");
	 int currentSceneIndex=138;
	 string scenenum="scenenumber";
		PlayerPrefs.SetInt(scenenum,currentSceneIndex);
	
	
	
     tvInitiPos = tv.transform.position ;
	
	carpetInitiPos= carpet.transform.position ;
	
	couchInitiPos= couch.transform.position ;
	
	curtainInitiPos=curtain.transform.position ;
				
}


	
	 public void DragTv()
   {
	   
	   
	   tv.transform.position=Input.mousePosition;
	   
   }
   
    public void DragCarpet()
   {
	   
	   
	   carpet.transform.position=Input.mousePosition;
	   
   }
   
   public void DragCouch()
   {
	   
	   
	   couch.transform.position=Input.mousePosition;
	   
   }
   
   
   public void DragCurtin()
   {
	   
	   
	   curtain.transform.position=Input.mousePosition;
	   
   }
    
   
   
   
   //////////////////////////////
   
   
   public void Droptv()
 
 {
	 float Distance =Vector3.Distance(tv.transform.position,tvBlack.transform.position);
	 
	 
	 if(Distance < 50)
	 {
		 tv.transform.position=tvBlack.transform.position;
		 
		 source.clip =correct;
		 source.Play(); 
		 
		 
	 }
	 
	 else 
	 {
		 tv.transform.position = tvInitiPos;
	 }
	 
	 
	 
 }
 
 
 
  public void DropCurtain()
 
 {
	 
	  float Distance =Vector3.Distance(curtain.transform.position,curtainBlack.transform.position);
	 
	 
	 if(Distance < 50)
	 {
		 curtain.transform.position=curtainBlack.transform.position;
		 
		  source.clip =correct;
		 source.Play(); 
		 
		 
		 
	 }
	 
	 else 
	 {
		 curtain.transform.position = curtainInitiPos;
	 }
	 
	 
	 
	 
 }
 
 
  public void Dropcouch()
 
 {
	 
	  float Distance =Vector3.Distance(couch.transform.position,couchBlack.transform.position);
	 
	 
	 if(Distance < 50)
	 {
		 couch.transform.position=couchBlack.transform.position;
		 
		  source.clip =correct;
		 source.Play(); 
		 
		 
		 
	 }
	 
	 else 
	 {
		 couch.transform.position = couchInitiPos;
	 }
	 
 }
 
 
 
  public void DropCarpet()
 
 {
	
 float Distance =Vector3.Distance(carpet.transform.position,carpetBlack.transform.position);
	 
	 
	 if(Distance < 50)
	 {
		 carpet.transform.position=carpetBlack.transform.position;
		 
		  source.clip =correct;
		 source.Play(); 
		 
		 
		 
	 }
	 
	 else 
	 {
		 carpet.transform.position = carpetInitiPos;
	 }	
	 
	 
 }

   
   
   
   
   
   
   
   


}
