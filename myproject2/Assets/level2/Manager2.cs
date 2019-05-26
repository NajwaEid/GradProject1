using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager2 : MonoBehaviour
{
	string currentlevel="currentlevel";
      public GameObject shampo, toliet ,bathtub ,sink ,shower ,shampoBlack ,tolietBlack ,bathtubBlack ,sinkBlack,showerBlack ;
   
   Vector2  ShampoInitiPos , tolietInitiPos,bathtubInitiPos, sinkInitiPos ,showerInitiPos  ;
   
   public AudioSource source  ;
   public AudioClip  correct ;
   
   
   void Start()
{
	string lev="ﻲﻧﺎﺜﻟﺍ ﻯﻮﺘﺴﻤﻟﺍ";
		PlayerPrefs.SetString(currentlevel,lev);
		   string bigsec="ﻡﺎﻤﺤﻟﺍ";
	string bigsection="bigsection";
	PlayerPrefs.SetString(bigsection,bigsec);
	PlayerPrefs.DeleteKey("smallsection");
	
	 int currentSceneIndex=139;
	 string scenenum="scenenumber";
		PlayerPrefs.SetInt(scenenum,currentSceneIndex);
	
	ShampoInitiPos = shampo.transform.position ;
	
	tolietInitiPos= toliet.transform.position ;
	
	bathtubInitiPos= bathtub.transform.position ;
	
	sinkInitiPos= sink.transform.position ;
	
	showerInitiPos = shower.transform.position ;
	
	
}	
	 public void Dragshampo()
   {
	   
	   
	   shampo.transform.position=Input.mousePosition;
	   
   }
   
    public void Dragtoliet()
   {
	   
	   
	   toliet.transform.position=Input.mousePosition;
	   
   }
   
   
    public void Dragbathtub()
   {
	   
	   
	   bathtub.transform.position=Input.mousePosition;
	   
   }
   
    public void Dragsink()
   {
	   
	   
	   sink.transform.position=Input.mousePosition;
	   
   }
   
    public void Dragshower()
   {
	   
	   
	   shower.transform.position=Input.mousePosition;
	   
   }
   
   
   
    public void Dropshampo()
 
 {
	 float Distance =Vector3.Distance(shampo.transform.position,shampoBlack.transform.position);
	 
	 
	 if(Distance < 50)
	 {
		 shampo.transform.position=shampoBlack.transform.position;
		 
		 source.clip =correct;
		 source.Play(); 
		 
		 
	 }
	 
	 else 
	 {
		 shampo.transform.position = ShampoInitiPos;
	 }
	 
	 
	 
	 
	 
 }
 
 
 
  public void Droptoliet()
 
 {
	 float Distance =Vector3.Distance(toliet.transform.position,tolietBlack.transform.position);
	 
	 
	 if(Distance < 50)
	 {
		 toliet.transform.position=tolietBlack.transform.position;
		 
		 source.clip =correct;
		 source.Play(); 
		 
		 
	 }
	 
	 else 
	 {
		 toliet.transform.position = tolietInitiPos;
	 }
	 
	 
	 
 }
 
 
 
 
 
 
  public void Dropbathtub()
 
 {
	 float Distance =Vector3.Distance(bathtub.transform.position,bathtubBlack.transform.position);
	 
	 
	 if(Distance < 50)
	 {
		 bathtub.transform.position=bathtubBlack.transform.position;
		 
		 source.clip =correct;
		 source.Play(); 
		 
		 
	 }
	 
	 else 
	 {
		 bathtub.transform.position = bathtubInitiPos;
	 }
	 
	 
	 
 }
 
 
 
 
  public void Dropsink()
 
 {
	 float Distance =Vector3.Distance(sink.transform.position,sinkBlack.transform.position);
	 
	 
	 if(Distance < 50)
	 {
		 sink.transform.position=sinkBlack.transform.position;
		 
		 source.clip =correct;
		 source.Play(); 
		 
		 
	 }
	 
	 else 
	 {
		 sink.transform.position = sinkInitiPos;
	 }
	 
	 
	 
 }
 
 
 
 
  public void Dropshower()
 
 {
	 float Distance =Vector3.Distance(shower.transform.position,showerBlack.transform.position);
	 
	 
	 if(Distance < 50)
	 {
		 shower.transform.position=showerBlack.transform.position;
		 
		 source.clip =correct;
		 source.Play(); 
		 
		 
	 }
	 
	 else 
	 {
		 shower.transform.position = showerInitiPos;
	 }
	 
	 
	 
 

				
}
   
   
   
}
