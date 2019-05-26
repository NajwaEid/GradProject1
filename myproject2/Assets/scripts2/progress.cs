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
 

public class progress : MonoBehaviour
{
     string res=""+Environment.NewLine;
	//public Button log ;
	string stuname;
	string sp;
	public Text f;
	public string conn;
    public IDbConnection dbconn;
      public  string sname="studentname";
		public GameObject Panel;
public GameObject Panel2;
public GameObject Panel22;
public GameObject Panel33;

	
 
	
	void Start()
    {
		
        
    
	
	}
	
	public void press()
	{
		
		  Panel.SetActive(true); 

	    
		stuname=PlayerPrefs.GetString("studentname");
		sp=stuname+"progress";
		
		
		conn= "URI=file:" +Application.dataPath+"/Plugins/grad.s3db";
        dbconn=(IDbConnection) new SqliteConnection(conn);
        dbconn.Open();
		IDbCommand dbcmd=dbconn.CreateCommand();
	
		
		string sqlQuery2="SELECT * FROM "+ sp;
		
	
		dbcmd.CommandText=sqlQuery2;
		IDataReader reader=dbcmd.ExecuteReader();
		
		 res =""; 
		
		while(reader.Read())
		{

			string datee=reader.GetString(0);
			string learntime=reader.GetString(1);
			string curenrlev=reader.GetString(2);

            res=  res + curenrlev +"                          " + learntime +"                  " + datee + Environment.NewLine ;

			
		

		}

		f.text=res;
		
		
	}
	
	public void  close_panel()
	{
				  Panel.SetActive(false); 


	}
	
	public void  op_panel()
	{
				  Panel2.SetActive(true); 


	}
	
	public void  op_panel2()
	{
				  Panel22.SetActive(true); 
				  Panel33.SetActive(false);


	}

}
