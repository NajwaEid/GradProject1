 using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

using Mono.Data.Sqlite;
using System.Data;
using System;
using UnityEngine.UI;
public class Exitfromlevel2 : MonoBehaviour
{
	public string conn;
    public IDbConnection dbconn;
   public void exitfromgame(){
	 string instname=PlayerPrefs.GetString("instemail");
	 string stuname=PlayerPrefs.GetString("studentname");
	 string lastsec=PlayerPrefs.GetString("bigsection");
	 //string lastsec2=PlayerPrefs.GetString("smallsection");
	 string curlev=PlayerPrefs.GetString("currentlevel");
	
	int sceneno=PlayerPrefs.GetInt("scenenumber");
	conn= "URI=file:" +Application.dataPath+"/Plugins/grad.s3db";
        dbconn=(IDbConnection) new SqliteConnection(conn);
        dbconn.Open();
		IDbCommand dbcmd=dbconn.CreateCommand();
		IDbCommand dbcmd2=dbconn.CreateCommand();
		IDbCommand dbcmd3=dbconn.CreateCommand();
		//string sec=lastsec+"-"+lastsec2;
	
		//int getid=5;
//string sqlQuery3="INSERT INTO "+instname+" (lastscene, lastsection) VALUES "+"('"+sceneno+"',"+"'"+sec+"')"+" WHERE name = '" + stuname + "'";
//string sqlQuery3="UPDATE "+instname+" SET lastscene ="+sceneno+", lastsection ="+sec+" WHERE id = '" + getid + "'";
string sqlQuery3 = "UPDATE "+instname+ " SET lastscene = "+sceneno+" WHERE name = '" + stuname + "'";
string sqlQuery4 = "UPDATE "+instname+ " SET lastsection = "+"'"+lastsec+"'"+" WHERE name = '" + stuname + "'";
string sqlQuery5 = "UPDATE "+instname+ " SET currentlevel = "+"'"+curlev+"'"+" WHERE name = '" + stuname + "'";

	    dbcmd.CommandText=sqlQuery3;
		  dbcmd.ExecuteNonQuery();
		  
	    dbcmd2.CommandText=sqlQuery4;
		  dbcmd2.ExecuteNonQuery();
		  
	    dbcmd3.CommandText=sqlQuery5;
		  dbcmd3.ExecuteNonQuery();
	
	AsyncOperation asyncLoad = SceneManager.LoadSceneAsync(128);
	
}
}
