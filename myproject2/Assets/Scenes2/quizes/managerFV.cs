
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
public class managerFV : MonoBehaviour
{
  
   public int count1 =0; 
     public String tableName; 
	 public string str2 ="qz" ;
	 public string str ;

   public int count2 =0; 
   public GameObject ap,gr,jz,ora,bot,btnj,tom,cucm,melon,strw,apri,rman,apb,tomb,grb,jzb,orab,botb,btnjb,cucmb,melonb,strwb,aprib,rmanb ;
   Vector2  apInitiPos ;
   Vector2  grInitiPos ;
   Vector2  jzInitiPos ;
   Vector2  oraInitiPos ;
   Vector2  botInitiPos ;
   Vector2  btnjInitiPos ;
   Vector2  tomInitiPos ;
   Vector2  cucmInitiPos ;
   Vector2  melonInitiPos ;
   Vector2  strwInitiPos ;
   Vector2  apriInitiPos ;
   Vector2  rmanInitiPos ;
  
   public AudioSource source  ;
   public AudioClip  correct ;
    public AudioClip  incorrect ;
	 public Text txt;

	
	public GameObject Panel;
		public GameObject Panelc;

	
	public int fruitCount =0 ;
	public int  VegCount =0 ;
	
	public int incorrect_count =0; 
	
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
        
	apInitiPos  = ap.transform.position ;
	
	grInitiPos= gr.transform.position ;
	
	jzInitiPos= jz.transform.position ;
	
	oraInitiPos = ora.transform.position ;
	
	botInitiPos = bot.transform.position ;
	btnjInitiPos = btnj.transform.position ;
	
	tomInitiPos  = tom.transform.position ;
	cucmInitiPos  = cucm.transform.position ;
	
	melonInitiPos = melon.transform.position ;
	strwInitiPos   = strw.transform.position ;
	
	apriInitiPos = apri.transform.position ;
	rmanInitiPos   = rman.transform.position ;
	
	
		 time_now= System.DateTime.Now;
         Debug.Log(time_now);
		 		 
		  str=PlayerPrefs.GetString("studentname");
		  Debug.Log(str);
		 	
	
	}
  
  
  
  public void Dragap ()
   {
	   
	   
	  ap.transform.position=Input.mousePosition;
	   
   }
   
   public void Draggr ()
   {
	   
	   
	  gr.transform.position=Input.mousePosition;
	   
   }
   
   public void Dragjz ()
   {
	   
	   
	  jz.transform.position=Input.mousePosition;
	   
   }
   
   
   public void Dragora ()
   {
	   
	   
	  ora.transform.position=Input.mousePosition;
	   
   }
   
   public void Dragbot()
   {
	   
	   
	  bot.transform.position=Input.mousePosition;
	   
   }
   
   public void Dragbtnj ()
   {
	   
	   
	  btnj.transform.position=Input.mousePosition;
	   
   }
   
   public void Dragtom ()
   {
	   
	   
	  tom.transform.position=Input.mousePosition;
	   
   }
   
   public void Dragcucm ()
   {
	   
	   
	  cucm.transform.position=Input.mousePosition;
	   
   }
   
   public void Dragmelon ()
   {
	   
	   
	  melon.transform.position=Input.mousePosition;
	   
   }
   public void Dragstrw ()
   {
	   
	   
	  strw.transform.position=Input.mousePosition;
	   
   }
   public void Dragapri ()
   {
	   
	   
	  apri.transform.position=Input.mousePosition;
	   
   }
   public void Dragrman ()
   {
	   
	   
	  rman.transform.position=Input.mousePosition;
	   
   }
   
  
  
  
  public void Dropap()
 
 {
	 float Distance =Vector3.Distance(ap.transform.position,apb.transform.position);
	 
	 	 if(Distance < 200)
	 {
		ap.transform.position=apb.transform.position;
		 
		 source.clip =correct;
		 source.Play(); 
		 fruitCount++; 
		 if(fruitCount==7) 
			 done(); 
		 
		 
		 	 }
	 
	 else 
	 {
		 ap.transform.position = apInitiPos;
		 
		  source.clip =incorrect;
		 source.Play(); 
		 
		 incorrect_count++;
		 
		 
		 
	 }
	  }
	  
	  
	  
	  
  
   public void Dropgr()
 
 {
	 float Distance =Vector3.Distance(gr.transform.position,grb.transform.position);
	 
	 	 if(Distance < 200)
	 {
		gr.transform.position=grb.transform.position;
		 
		 source.clip =correct;
		 source.Play(); 
		 fruitCount++; 
		 if(fruitCount==7) 
			 done(); 
		 
		 
		  
		 
		 	 }
	 
	 else 
	 {
		 gr.transform.position = grInitiPos;
		 
		  source.clip =incorrect;
		 source.Play(); 
		 
		 incorrect_count++;

		 
	 }
	  }
  
  
   public void Dropora()
 
 {
	 float Distance =Vector3.Distance(ora.transform.position,orab.transform.position);
	 
	 	 if(Distance < 200)
	 {
		ora.transform.position=orab.transform.position;
		 
		 source.clip =correct;
		 source.Play(); 
		 fruitCount++; 
		 if(fruitCount==7) 
			 done(); 
		 
		 
		 	 }
	 
	 else 
	 {
		 ora.transform.position = oraInitiPos;
		 
		  source.clip =incorrect;
		 source.Play(); 
		  incorrect_count++;

		 
	 }
	  }
  
  
   public void Dropmelon()
 
 {
	 float Distance =Vector3.Distance(melon.transform.position,melonb.transform.position);
	 
	 	 if(Distance < 200)
	 {
		melon.transform.position=melonb.transform.position;
		 
		 source.clip =correct;
		 source.Play(); 
		 fruitCount++; 
		 if(fruitCount==7) 
			 done(); 
		 
		 
		 	 }
	 
	 else 
	 {
		 melon.transform.position = melonInitiPos;
		 
		  source.clip =incorrect;
		 source.Play(); 
		 
		 incorrect_count++;

		 
	 }
	  }
  
  
   public void Dropstrw()
 
 {
	 float Distance =Vector3.Distance(strw.transform.position,strwb.transform.position);
	 
	 	 if(Distance < 200)
	 {
		strw.transform.position=strwb.transform.position;
		 
		 source.clip =correct;
		 source.Play(); 
		 
		 fruitCount++; 
		 if(fruitCount==7) 
			 done(); 
		 
		 
		 	 }
	 
	 else 
	 {
		 strw.transform.position = strwInitiPos;
		 
		  source.clip =incorrect;
		 source.Play(); 
		 
		 incorrect_count++;

		 
	 }
	  }
  
  
  
  
   public void Dropapri()
 
 {
	 float Distance =Vector3.Distance(apri.transform.position,aprib.transform.position);
	 
	 	 if(Distance < 200)
	 {
		apri.transform.position=aprib.transform.position;
		 
		 source.clip =correct;
		 source.Play(); 
		 fruitCount++; 
		 if(fruitCount==7) 
			 done(); 
		 
		 
		 	 }
	 
	 else 
	 {
		 apri.transform.position = apriInitiPos;
		 
		  source.clip =incorrect;
		 source.Play(); 
		 
		 incorrect_count++;

		 
	 }
	  }
  
  
  
  
   public void Droprman()
 
 {
	 float Distance =Vector3.Distance(rman.transform.position,rmanb.transform.position);
	 
	 	 if(Distance < 200)
	 {
		rman.transform.position=rmanb.transform.position;
		 
		 source.clip =correct;
		 source.Play(); 
		 
		 fruitCount++; 
		 if(fruitCount==7) 
			 done(); 
		 
		 
		 
		 	 }
	 
	 else 
	 {
		 rman.transform.position = rmanInitiPos;
		 
		  source.clip =incorrect;
		 source.Play(); 
		 
		 	incorrect_count++;

		 
	 }
	  }
  
  
  
  
   public void Dropjz()
 
 {
	 float Distance =Vector3.Distance(jz.transform.position,jzb.transform.position);
	 
	 	 if(Distance < 200)
	 {
		 
		jz.transform.position=jzb.transform.position;
   		source.clip =correct;
		 source.Play(); 
		 
		 
		  VegCount++; 
		 if(VegCount==5) 
			 done();
		 
		 	 }
	 
	 else 
	 {
		 jz.transform.position = jzInitiPos;
		 
		  source.clip =incorrect;
		 source.Play(); 
		 incorrect_count++;

		 
	 }
	  }
  
  
     public void Dropbot()
 
 {
	 float Distance =Vector3.Distance(bot.transform.position,botb.transform.position);
	 
	 	 if(Distance < 200)
	 {
		bot.transform.position=botb.transform.position;
		 
		 source.clip =correct;
		 source.Play(); 
		 
		 
		  VegCount++; 
		 if(VegCount==5) 
			 done();
		 
		 
		 
		 	 }
	 
	 else 
	 {
		 bot.transform.position = botInitiPos;
		 
		  source.clip =incorrect;
		 source.Play(); 
		 
		 incorrect_count++;

		 
	 }
	  }
  
  
  
     public void Dropbtnj()
 
 {
	 float Distance =Vector3.Distance(btnj.transform.position,btnjb.transform.position);
	 
	 	 if(Distance < 200)
	 {
	     btnj.transform.position=btnjb.transform.position;
		 
		 source.clip =correct;
		 source.Play(); 
		 
		  VegCount++; 
		 if(VegCount==5) 
			 done();
		  
		 
		 	 }
	 
	 else 
	 {
		 btnj.transform.position = btnjInitiPos;
		 
		  source.clip =incorrect;
		 source.Play(); 
		 
		 	incorrect_count++;

		 
	 }
	  }
  
     public void Droptom()
 
 {
	 float Distance =Vector3.Distance(tom.transform.position,tomb.transform.position);
	 
	 	 if(Distance < 200)
	 {
		tom.transform.position=tomb.transform.position;
		 
		 source.clip =correct;
		 source.Play(); 
		 
		  VegCount++; 
		 if(VegCount==5) 
			 done();
		 
		 
		 	 }
	 
	 else 
	 {
		 tom.transform.position = tomInitiPos;
		 
		  source.clip =incorrect;
		 source.Play(); 
		 
		 incorrect_count++;

		 
	 }
	  }
  
  
  
  
  
  
     public void Dropcucm()
 
 {
	 float Distance =Vector3.Distance(cucm.transform.position,cucmb.transform.position);
	 
	 	 if(Distance < 200)
	 {
		cucm.transform.position=cucmb.transform.position;
		 
		 source.clip =correct;
		 source.Play(); 
		  VegCount++; 
		 if(VegCount==5) 
			 done();
	 
		 
		 	 }
	 
	 else 
	 {
		 cucm.transform.position = cucmInitiPos;
		 
		  source.clip =incorrect;
		 source.Play(); 
		 
		 incorrect_count++;

		 
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

 

	   if(VegCount==5 && fruitCount==7 & incorrect_count==0) {
    	Debug.Log("finalllly");
		
		string sqlQuery4 = @" insert into " + tableName + "(FVQT,FVQR,FVFailed) values ('" + timef + "','" + corr + "','" + count1 + "')"; 
  		 Debug.Log(sqlQuery4);
		 dbcmd4.CommandText=sqlQuery4;
		 dbcmd4.ExecuteNonQuery();
		 Panel.SetActive(true); 

	}
	
	
	 else {
		 
		 if(VegCount==5 && fruitCount==7 & incorrect_count!=0)
	{
	   Debug.Log(incorrect_count);
	   
	   	  string sqlQuery6 = @" insert into " + tableName + "(FVQT,FVQR,FVFailed)values ('" + timef + "','" + ncorr + "','" + incorrect_count + "')"; 
  		  Debug.Log(sqlQuery6);
		  dbcmd4.CommandText=sqlQuery6;
		  dbcmd4.ExecuteNonQuery();
    		
		  string countt1  = incorrect_count.ToString();
   		      
		    txt.text=countt1;
		  	Panelc.SetActive(true);   
	}
	 }
	  
	  
	  
	  
	  
	  
  }
  
  
public void relod(){
      SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);     
     }
  
  
  
  
  
  
}
