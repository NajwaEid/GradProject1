
 using System.Collections;
using System.Collections.Generic;
using UnityEngine;


using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using  UnityEngine.EventSystems;
using UnityEngine.UI;

 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

 using UnityEngine.SceneManagement;

using Mono.Data.Sqlite;
using System.Data;
 using System;

public class manager111 : MonoBehaviour
{
    public GameObject m1, m2 ,m3 ,m4 ,m1b,m2b , m3b, m4b ;
   
   Vector2   m1Pos ,m2Pos  ,m3Pos ,m4Pos ;
   
   public AudioSource source  ;
   public AudioClip  correct ;
   
   public int Truecount=0; 
   
   	 public Text txt;

   
   public int wrongCount =0; 
   
   public String tableName; 
				    public string str2 ="qz" ;
					public string str ;

   
   
   public GameObject Panel;
		public GameObject Panelc;

	 public string conn;
     public IDbConnection dbconn;
 
     public DateTime time_now;
	 public DateTime time_now2;
	 public TimeSpan diff ;
	 public string timef ;
 
 
      int corr =1 ;
	 int ncorr =0; 
   
   
   void Start()
{
	
 m1Pos =m1.transform.position ;
 m2Pos =m2.transform.position ;
 m3Pos =m3.transform.position ;
 m4Pos =m4.transform.position ;
 
  time_now= System.DateTime.Now;
         Debug.Log(time_now);
		 
		  str=PlayerPrefs.GetString("studentname");
				
				Debug.Log(str);

 }
 

   
   public void Dragm1()
   {
	   
		   m1.transform.position=Input.mousePosition;
		   
	   
   }
   
   
   
   
    public void Dragm2()
   {
	   
	 m2.transform.position=Input.mousePosition;
	   
   }
   
   
   
   
   
    public void Dragm3()
   {
	   
	   
	   m3.transform.position=Input.mousePosition;
	   
	   
   }
   
   
   
   
   
   
    public void Dragm4()
   {
	   
	m4.transform.position=Input.mousePosition;
	   
	   
   }
   
 
 
 
public void Dropm1()
 
 {
	 float Distance =Vector3.Distance(m1.transform.position,m1b.transform.position);
	 
	 
	 if(Distance < 50)
	 {
		 m1.transform.position=m1b.transform.position;

		 source.clip =correct;
		 source.Play(); 
		 
		 Truecount++; 
		 
		  if(Truecount==4) 
			 done(); 
		 
		 
		 
		 
	 }
	 
	 else 
	 {
		 m1.transform.position = m1Pos;
		 
		 wrongCount++;
		 
	 }
	 
	 
	 
 }
 
 
 
 public void Dropm2()
 
 {
	 float Distance =Vector3.Distance(m2.transform.position,m2b.transform.position);
	 
	 
	 if(Distance < 50)
	 {
		 m2.transform.position=m2b.transform.position;

		 source.clip =correct;
		 source.Play(); 
		 
		 Truecount++; 
		 
		  if(Truecount==4) 
			 done(); 
		 
		 
	 }
	 
	 else 
	 {
		 m2.transform.position = m2Pos;
		 		 wrongCount++;

	 }
	 
	 
	 
 }
 
 
 
 
 public void Dropm3()
 
 {
	 float Distance =Vector3.Distance(m3.transform.position,m3b.transform.position);
	 
	 
	 if(Distance < 50)
	 {
		 m3.transform.position=m3b.transform.position;

		 source.clip =correct;
		 source.Play();  
		
           Truecount++; 
		 
		  if(Truecount==4) 
			 done(); 
		
	 }
	 
	 else 
	 {
		 m3.transform.position = m3Pos;
		 		 wrongCount++;

	 }
	 
	 
	 
 }
 
 
 
 
 public void Dropm4()
 
 {
	 float Distance =Vector3.Distance(m4.transform.position,m4b.transform.position);
	 
	 
	 if(Distance < 50)
	 {
		 m4.transform.position=m4b.transform.position;

		 source.clip =correct;
		 source.Play(); 
		 
          Truecount++; 
		 
		  if(Truecount==4) 
			 done(); 		 
		 
	 }
	 
	 else 
	 {
		 m1.transform.position = m4Pos;
		 		 wrongCount++;

	 }
	 
	 
	 
 }
 
 


public void done()

  
  {
	  time_now2= System.DateTime.Now;
         Debug.Log(time_now2);
		 
		  diff = time_now2 - time_now ;
            Debug.Log(diff);
			
			
			timef =diff.ToString(@"hh\:mm");
             Debug.Log(timef);
   
             
            timef =diff.ToString(@"hh\:mm");
            Debug.Log(timef);
			
			
		conn= "URI=file:" +Application.dataPath+"/Plugins/grad.s3db";
        dbconn=(IDbConnection) new SqliteConnection(conn);
        dbconn.Open();
        IDbCommand dbcmd4=dbconn.CreateCommand();
		
		  string tableName = String.Concat(str, str2);  

		   
		  Debug.Log(tableName);

		

 
		
	   
	  if(Truecount==4 && wrongCount==0) {
    	Debug.Log("finalllly");
		
		string sqlQuery4 = @" insert into " + tableName + "(sweetQT,sweetQR,sweetFailed) values ('" + timef + "','" + corr + "','" + wrongCount + "')"; 
  		 Debug.Log(sqlQuery4);
		 dbcmd4.CommandText=sqlQuery4;
		 dbcmd4.ExecuteNonQuery();
		 Panel.SetActive(true); 


	}
	
	
	 else {
		 
		  
	   Debug.Log(wrongCount);
	   
	   string sqlQuery6 = @" insert into " + tableName + "(sweetQT,sweetQR,sweetFailed)values ('" + timef + "','" + ncorr + "','" + wrongCount + "')"; 
  		  Debug.Log(sqlQuery6);
		  dbcmd4.CommandText=sqlQuery6;
		  dbcmd4.ExecuteNonQuery();
    		
		  string countt1  = wrongCount.ToString();
   		      
		    txt.text=countt1;
		  	Panelc.SetActive(true);   
	
	 }
	  
	  
	  
	  
	  
	  
  }
  
    
public void relod(){
      SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);     
     }
  





 
   
}
