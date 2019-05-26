 
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
using UnityEngine.UI;


public class vegQuiz : MonoBehaviour
{ 
 public GameObject Panel1;
 public GameObject Panelc;
 public GameObject Panel;
 public Text txt;

 
 	  public List<int> firstlist = new List<int>();

		    public GameObject Panel2;
		    public GameObject Panel3;
		    public GameObject Panel4;
		    public GameObject Panel5;
		    public GameObject Panel6;
			public GameObject Panel7;
			public GameObject Panel8;
			public GameObject Panel9;
	
	 public string conn;
     public IDbConnection dbconn;
 
     public DateTime time_now;
	 public DateTime time_now2;
	 public TimeSpan diff ;
	 public string timef ;
	  public int count =0; 
	public int count1 =0; 
      int corr =1 ;
	 int ncorr =0; 

	 int cc=0;  
	 
	    public String tableName; 
				    public string str2 ="qz" ;
					public string str ;

    
	  void Start()
    {
		 time_now= System.DateTime.Now;
         Debug.Log(time_now);
     
	    str=PlayerPrefs.GetString("studentname");
				
				Debug.Log(str);

}

  public void open1_pannel1()
	
	{		
		if(Panel1!=null)
		Panel1.SetActive(true);
		count1++;
	
    }
	

  public void open1_pannel2()
	
	{		
		if(Panel2!=null)
		Panel2.SetActive(true); 
	
			count1++;

    }
	
	 public void open1_pannel3()
	
	{		
		if(Panel3!=null)
		Panel3.SetActive(true); 
	
	 		count++;

			if (count==2) 
				
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
					
		IDbCommand dbcmd5=dbconn.CreateCommand();
		IDbCommand dbcmd6=dbconn.CreateCommand();
		
		string tableName = String.Concat(str, str2);  

		   
		  Debug.Log(tableName);


if(count1==0)
   
   { 
      string sqlQuery4 = @" insert into " + tableName + "(vegetableQT,vegetableQR,vegetablefailed) values ('" + timef + "','" + corr + "','" + count1 + "')"; 
  		  Debug.Log(sqlQuery4);
		  dbcmd4.CommandText=sqlQuery4;
		  dbcmd4.ExecuteNonQuery();
		  
		  Panel.SetActive(true); 
	   }  
      
   else 
   {
   string sqlQuery6 = @" insert into " + tableName + "(vegetableQT,vegetableQR,vegetablefailed) values ('" + timef + "','" + ncorr + "','" + count1 + "')"; 
  		  Debug.Log(sqlQuery6);
		  dbcmd4.CommandText=sqlQuery6;
		  dbcmd4.ExecuteNonQuery();
		  
		  		 
				string countt1  = count1.ToString();
   		      
		        txt.text=countt1;
		  		Panelc.SetActive(true); 
				  
    }
	}
    
    }

  public void open1_pannel4()
	
	{		
		if(Panel4!=null)
		Panel4.SetActive(true); 
	     
       		count1++;
	    }

	
	
  public void open1_pannel5()
	
	{		
		if(Panel5!=null)
		Panel5.SetActive(true);  
		count++;
		
		if (count==2) 
				
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
					
		IDbCommand dbcmd5=dbconn.CreateCommand();
		IDbCommand dbcmd6=dbconn.CreateCommand();
		
		string tableName = String.Concat(str, str2);  

		   
		  Debug.Log(tableName);

		
		
		

if(count1==0)
   
   { 
 
   
      string sqlQuery4 = @" insert into " + tableName + "(vegetableQT,vegetableQR,vegetablefailed) values ('" + timef + "','" + corr + "','" + count1 + "')"; 
  		  Debug.Log(sqlQuery4);
		  dbcmd4.CommandText=sqlQuery4;
		  dbcmd4.ExecuteNonQuery();
		  
		  Panel.SetActive(true); 
	   }  
      
   else 
   {
	      string sqlQuery6 = @" insert into " + tableName + "(vegetableQT,vegetableQR,vegetablefailed) values ('" + timef + "','" + ncorr + "','" + count1 + "')"; 
  		  Debug.Log(sqlQuery6);
		  dbcmd4.CommandText=sqlQuery6;
		  dbcmd4.ExecuteNonQuery();
		  Panelc.SetActive(true); 
   
   }
	}
    
		
		
		
		
		
		
		
    }

  public void open1_pannel6()
	
	{		
		if(Panel6!=null)
		Panel6.SetActive(true);
	
			count1++;  
    }

	
	
  public void open1_pannel7()
	
	{		
		if(Panel7!=null)
			
		Panel7.SetActive(true); 
		
				count1++;    
    }
	
	 public void open1_pannel8()
	
	{		
		if(Panel8!=null)
			
		Panel8.SetActive(true); 
		
		count1++;    
    }
	
	 public void open1_pannel9()
	
	{		
		if(Panel9!=null)
			
		Panel9.SetActive(true); 
		
		count1++;
	     

    }
	
	
	
}
