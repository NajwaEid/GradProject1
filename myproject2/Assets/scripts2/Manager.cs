using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
	string currentlevel="currentlevel";
   public GameObject bed , carpet ,closet ,curtain ,bedBlack ,carpetBlack ,closetBlack ,curtainBlack ;
   
   Vector2  bedInitiPos , carpetInitiPos,closetInitiPos, curtainInitiPos ;
   
   public AudioSource source  ;
   public AudioClip  correct ;
   

void Start()
{
	string lev="ﻲﻧﺎﺜﻟﺍ ﻯﻮﺘﺴﻤﻟﺍ";
		PlayerPrefs.SetString(currentlevel,lev);
		   string bigsec="ﻡﻮﻨﻟﺍ ﺔﻓﺮﻏ";
	string bigsection="bigsection";
	PlayerPrefs.SetString(bigsection,bigsec);
	PlayerPrefs.DeleteKey("smallsection");
	bedInitiPos = bed.transform.position ;
	
	carpetInitiPos= carpet.transform.position ;
	
	closetInitiPos= closet.transform.position ;
	
	curtainInitiPos=curtain.transform.position ;
				
}
   
   public void DragBed()
   {
	   
	   
	   bed.transform.position=Input.mousePosition;
	   
   }
   
   
   
   
    public void DragCarpet()
   {
	   
	   carpet.transform.position=Input.mousePosition;
	   
   }
   
   
   
   
   
    public void DragCloset()
   {
	   
	   
	   closet.transform.position=Input.mousePosition;
	   
	   
   }
   
   
   
   
   
   
    public void DragCurtain()
   {
	   
	curtain.transform.position=Input.mousePosition;
	   
	   
   }
   
 

 public void DropBed()
 
 {
	 float Distance =Vector3.Distance(bed.transform.position,bedBlack.transform.position);
	 
	 
	 if(Distance < 50)
	 {
		 bed.transform.position=bedBlack.transform.position;
		 
		 source.clip =correct;
		 source.Play(); 
		 
		 
	 }
	 
	 else 
	 {
		 bed.transform.position = bedInitiPos;
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
 
 
  public void DropCloset()
 
 {
	 
	  float Distance =Vector3.Distance(closet.transform.position,closetBlack.transform.position);
	 
	 
	 if(Distance < 50)
	 {
		 closet.transform.position=closetBlack.transform.position;
		 
		  source.clip =correct;
		 source.Play(); 
		 
		 
		 
	 }
	 
	 else 
	 {
		 closet.transform.position = closetInitiPos;
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
