   using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

using Mono.Data.Sqlite;
using System.Data;
using System;
using UnityEngine.UI;

public class studentMMenu : MonoBehaviour

{

 public string conn;
 
 public Text txt;

 public string menu ;

 public IDbConnection dbconn;
 
 	public GameObject Panel;

	
		public string idins;
		
		
		 void Start()
    {
		idins=PlayerPrefs.GetString("instemail");
		
		Debug.Log(idins);
		
        
    }
	
	
	
	public void showStudents()
	
	{
		
			conn= "URI=file:" +Application.dataPath+"/Plugins/grad.s3db";
        dbconn=(IDbConnection) new SqliteConnection(conn);
        dbconn.Open();
        IDbCommand dbcmd=dbconn.CreateCommand();
		
		
		  string sqlQuery ="SELECT * FROM " +idins;
		  Debug.Log(sqlQuery);
		 
		 dbcmd.CommandText=sqlQuery;

		 dbcmd.ExecuteNonQuery();
		 
		 
		 IDataReader reader =dbcmd.ExecuteReader(); 
		 menu =""+Environment.NewLine ;
		
		
		while(reader.Read())
		{
			
		
		 
		  Panel.SetActive(true); 

			
			int id =reader.GetInt32(0);
			string pass =reader.GetString(1);
			
			
			
				string ids  = id.ToString();
   		      		 
		 
 			
			menu =  menu + "             " + id + "                                                   " + pass +Environment.NewLine +Environment.NewLine ;
			
			Debug.Log(menu);
			
			
			
			
		}
		
		 txt.text =menu ;	

		
		
		
	}
	
	
	public void close_panel()
	
	{
				  Panel.SetActive(false); 

		
	}
	
	
	

}
