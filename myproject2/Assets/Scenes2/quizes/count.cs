 
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

public class count : MonoBehaviour
{
	
	 public GameObject Panelc;
 public GameObject Panel;
 public Text txt;
        public int countTo =0; 
	    public int count1 =0;
	    public int count2 =0;
	    public int count3 =0;
		public int count4 =0;
		public int count5 =0;
		public int count6 =0;	
		//public GameObject Panel1;
		 public String tableName; 
		public string str2 ="qz" ;
		public string str ;
		
			public int count7 =0;
				public int count8 =0;
				
					public int count9 =0;
					
						public int count10 =0;
						
							public int count11 =0;
								public int count12 =0;
								
								public int zero_count =0 ;
								
								
								
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
		 time_now= System.DateTime.Now;
         Debug.Log(time_now);
		 
		  str=PlayerPrefs.GetString("studentname");
				
				Debug.Log(str);
		 
		 

    }
							
	
    public void add1()
	
	{
		count1=0;
		zero_count ++ ;
		
		
		countTo =count1+count2+count3+count4+count5+count6+count7+count8+count9+count10+count11+count12 ;
		if(countTo==6) 
			done(); 
		
		
	}
	
	public void add2()
	
	{
		count2=1 ;
		
				countTo =count1+count2+count3+count4+count5+count6+count7+count8+count9+count10+count11+count12 ;

		
			if(countTo==6) 
			done(); 
		
		
	}
	
	public void add3()
	
	{
		count3 =1 ;
				countTo =count1+count2+count3+count4+count5+count6+count7+count8+count9+count10+count11+count12 ;

		
			if(countTo==6) 
			done(); 
		
		
	}
	
	
	public void add4()
	
	{
		count4 =0;
				zero_count ++ ;

				countTo =count1+count2+count3+count4+count5+count6+count7+count8+count9+count10+count11+count12 ;

			if(countTo==6) 
			done(); 
		
		
	}
	
	
	public void add5()
	
	{
		count5 =1 ;
				countTo =count1+count2+count3+count4+count5+count6+count7+count8+count9+count10+count11+count12 ;

			if(countTo==6) 
			done(); 
		
		
	}
	
	
	public void add6()
	
	{
		count6 =0 ;
						zero_count ++ ;


				countTo =count1+count2+count3+count4+count5+count6+count7+count8+count9+count10+count11+count12 ;

			if(countTo==6) 
			done(); 
		
		
	}
	
	public void add7()
	
	{
		count7 =0 ;
						zero_count ++ ;


				countTo =count1+count2+count3+count4+count5+count6+count7+count8+count9+count10+count11+count12 ;

			if(countTo==6) 
			done(); 
		
		
	}
	
	
	
	public void add8()
	
	{
		count8 =1 ;
				countTo =count1+count2+count3+count4+count5+count6+count7+count8+count9+count10+count11+count12 ;

			if(countTo==6) 
			done(); 
		
		
	}
	
	
	public void add9()
	
	{
		count9 =1 ;
				countTo =count1+count2+count3+count4+count5+count6+count7+count8+count9+count10+count11+count12 ;

			if(countTo==6) 
			done(); 
		
		
	}
	
	
	public void add10()
	
	{
		count10 =0 ;
						zero_count ++ ;


				countTo =count1+count2+count3+count4+count5+count6+count7+count8+count9+count10+count11+count12 ;

			if(countTo==6) 
			done(); 
		
		
	}
	
	
	public void ad11()
	
	{
		count11 =0 ;
						zero_count ++ ;

				countTo =count1+count2+count3+count4+count5+count6+count7+count8+count9+count10+count11+count12 ;

			if(countTo==6) 
			done(); 
		
		
	}
	
	
	public void add12()
	
	{
		
		count12 =1 ;
				countTo =count1+count2+count3+count4+count5+count6+count7+count8+count9+count10+count11+count12 ;

			if(countTo==6) 
			done(); 
		
		
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
					
	 
	if(countTo==6 && zero_count==0) {
    	Debug.Log("finalllly");
		
 
 
		string sqlQuery4 = @" insert into " + tableName + "(bodyQT,bodyQR,bodyFailed)values ('" + timef + "','" + corr + "','" + count1 + "')"; 
  		 Debug.Log(sqlQuery4);
		 dbcmd4.CommandText=sqlQuery4;
		 dbcmd4.ExecuteNonQuery();
		 Panel.SetActive(true); 

	
	
	
	
	
	
	
	
	}
	
	
	else
	{
	   Debug.Log(zero_count);
	   
 
 
	   string sqlQuery6 = @" insert into " + tableName + "(bodyQT,bodyQR,bodyFailed)values ('" + timef + "','" + ncorr + "','" + zero_count + "')"; 
  		  Debug.Log(sqlQuery6);
		  dbcmd4.CommandText=sqlQuery6;
		  dbcmd4.ExecuteNonQuery();
		  
		  		
		  string countt1  = zero_count.ToString();
   		      
		    txt.text=countt1;
		  	Panelc.SetActive(true); 
				  
	   
	   
	   
	   
	   
	   

	}

	
	
}
	
	
	
      	public void relod(){
      SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);     
     }
 
		
		 
	 
     	 
	 
      
    
 
}