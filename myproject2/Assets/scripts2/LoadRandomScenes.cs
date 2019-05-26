 using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

using Mono.Data.Sqlite;
using System.Data;
using System;
using UnityEngine.UI;
public class LoadRandomScenes : MonoBehaviour
{
	public List<int> firstlist = new List<int>();
	public List<int> usednumbers = new List<int>();
	public int count=0;
	public string conn;
    public IDbConnection dbconn;
	public static LoadRandomScenes Instance;
	
   public void LoadRandomScene(){	   
	   Debug.Log("i pressed on veg menu");
	   int currentSceneIndex=SceneManager.GetActiveScene().buildIndex;
	 string smallsec="ﺭﺎﻀﺨﻟﺍ";
	string smallsection="smallsection";
	string scenenum="scenenumber";
	    var numbers = new List<int>() {0,0,0,0,0,0,0,0,0,0,0,0,0,0,14,15,16,17,18,19,20,21};
 	   int index = UnityEngine.Random.Range(14,21);   
	   SceneManager.LoadScene(numbers[index]);	      	   
 	    numbers.Remove(index);		
		PlayerPrefs.SetString(smallsection,smallsec);
		string a=PlayerPrefs.GetString("bigsection");
		Debug.Log("inside small section "+a);
		Debug.Log("scene numer "+currentSceneIndex);
		PlayerPrefs.SetInt(scenenum,currentSceneIndex);
	  
}


public void exitfromgame(){
	 string instname=PlayerPrefs.GetString("instemail");
	 string stuname=PlayerPrefs.GetString("studentname");
	 string lastsec=PlayerPrefs.GetString("bigsection");
	 string lastsec2=PlayerPrefs.GetString("smallsection");
	 string curlev=PlayerPrefs.GetString("currentlevel");
	Debug.Log(stuname);
	int sceneno=PlayerPrefs.GetInt("scenenumber");
	conn= "URI=file:" +Application.dataPath+"/Plugins/grad.s3db";
        dbconn=(IDbConnection) new SqliteConnection(conn);
        dbconn.Open();
		IDbCommand dbcmd=dbconn.CreateCommand();
		IDbCommand dbcmd2=dbconn.CreateCommand();
		IDbCommand dbcmd3=dbconn.CreateCommand();
		string sec=lastsec+"-"+lastsec2;
		//string sec="bate5";
		int getid=5;
//string sqlQuery3="INSERT INTO "+instname+" (lastscene, lastsection) VALUES "+"('"+sceneno+"',"+"'"+sec+"')"+" WHERE name = '" + stuname + "'";
//string sqlQuery3="UPDATE "+instname+" SET lastscene ="+sceneno+", lastsection ="+sec+" WHERE id = '" + getid + "'";
string sqlQuery3 = "UPDATE "+instname+ " SET lastscene = "+sceneno+" WHERE name = '" + stuname + "'";
string sqlQuery4 = "UPDATE "+instname+ " SET lastsection = "+"'"+sec+"'"+" WHERE name = '" + stuname + "'";
string sqlQuery5 = "UPDATE "+instname+ " SET currentlevel = "+"'"+curlev+"'"+" WHERE name = '" + stuname + "'";

	    dbcmd.CommandText=sqlQuery3;
		  dbcmd.ExecuteNonQuery();
		  
	    dbcmd2.CommandText=sqlQuery4;
		  dbcmd2.ExecuteNonQuery();
		  
	    dbcmd3.CommandText=sqlQuery5;
		  dbcmd3.ExecuteNonQuery();
	
	AsyncOperation asyncLoad = SceneManager.LoadSceneAsync(128);
	
}


public void LoadFruitRandomly(){
	
	   int currentSceneIndex=SceneManager.GetActiveScene().buildIndex;
	 string smallsec="ﺔﻬﻛﺎﻔﻟﺍ";
	string smallsection="smallsection";
	string scenenum="scenenumber";		
		PlayerPrefs.SetString(smallsection,smallsec);
		PlayerPrefs.SetInt(scenenum,currentSceneIndex);
		
		
		conn= "URI=file:" +Application.dataPath+"/Plugins/grad.s3db";
        dbconn=(IDbConnection) new SqliteConnection(conn);
        dbconn.Open();
		IDbCommand dbcmd=dbconn.CreateCommand();
		IDbCommand dbcmd2=dbconn.CreateCommand();
		IDbCommand dbcmd3=dbconn.CreateCommand();
		IDbCommand dbcmd4=dbconn.CreateCommand();
		string sqlQuery="SELECT count(*) FROM fruit" ;
		string sqlQuery2="SELECT * FROM fruit ";
		string sqlQuery4="DELETE FROM usedscenes";
		dbcmd.CommandText=sqlQuery;
		dbcmd2.CommandText=sqlQuery2;
		dbcmd4.CommandText=sqlQuery4;
		dbcmd4.ExecuteNonQuery();
		count = Convert.ToInt32(dbcmd.ExecuteScalar());
		IDataReader reader=dbcmd2.ExecuteReader();
		while(reader.Read())
		{
			int idd = reader.GetInt32(0);
			firstlist.Add(idd);
		}
		
           DontDestroyOnLoad(this.gameObject);
            Instance = this;
			firstlist.Sort();
		
			int min0=firstlist[0];
			int max0=firstlist[firstlist.Count -1];
		
			max0=max0+1;
		int num=UnityEngine.Random.Range(min0,max0);
		usednumbers.Add(num);
		
		  string sqlQuery3="INSERT INTO usedscenes (id) VALUES "+"("+num+")";
		  Debug.Log(sqlQuery3);
		  dbcmd3.CommandText=sqlQuery3;
		  dbcmd3.ExecuteNonQuery();
		//  startTime=Time.time;
			AsyncOperation asyncLoad = SceneManager.LoadSceneAsync(num);
		
		
		
	   
}




public void LoadMilkRandomly(){
	   
	     int currentSceneIndex=SceneManager.GetActiveScene().buildIndex;
	 string smallsec="ﻥﺎﺒﻟﻻﺍ";
	string smallsection="smallsection";
	string scenenum="scenenumber";
	   PlayerPrefs.SetString(smallsection,smallsec);
		PlayerPrefs.SetInt(scenenum,currentSceneIndex);
		 	   int index2 = UnityEngine.Random.Range(54,58);
	   SceneManager.LoadScene( index2);
	 
}

 public void LoadMeatRandomly(){
	    
	   int currentSceneIndex=SceneManager.GetActiveScene().buildIndex;
	 string smallsec="ﻡﻮﺤﻠﻟﺍ";
	string smallsection="smallsection";
	string scenenum="scenenumber";
	   
 	   int index3 = UnityEngine.Random.Range(42,46);
	   
	   SceneManager.LoadScene( index3);
	   
	   PlayerPrefs.SetString(smallsection,smallsec);
		PlayerPrefs.SetInt(scenenum,currentSceneIndex);
	 
}




public void LoadColdDrinksRandomly(){
	   
	    int currentSceneIndex=SceneManager.GetActiveScene().buildIndex;
	 string smallsec="ﺓﺩﺭﺎﺑ ﺕﺎﺑﻭﺮﺸﻣ";
	string smallsection="smallsection";
	string scenenum="scenenumber";
	   PlayerPrefs.SetString(smallsection,smallsec);
		PlayerPrefs.SetInt(scenenum,currentSceneIndex);
		
 	   int index4 = UnityEngine.Random.Range(28,33);
	   
	   SceneManager.LoadScene( index4);
	 
}

public void LoadHotDrinksRandomly(){
	 int currentSceneIndex=SceneManager.GetActiveScene().buildIndex;
	 string smallsec="ﺔﻨﺧﺎﺳ ﺕﺎﺑﻭﺮﺸﻣ";
	string smallsection="smallsection";
	string scenenum="scenenumber";
	   PlayerPrefs.SetString(smallsection,smallsec);
		PlayerPrefs.SetInt(scenenum,currentSceneIndex);
	   
 	   int index5 = UnityEngine.Random.Range(35,40);
	   
	   SceneManager.LoadScene( index5);
	 
}


public void LoadBeansRandomly(){
	
	 int currentSceneIndex=SceneManager.GetActiveScene().buildIndex;
	 string smallsec="ﺕﺎﻴﻟﻮﻘﺑ";
	string smallsection="smallsection";
	string scenenum="scenenumber";
	   PlayerPrefs.SetString(smallsection,smallsec);
		PlayerPrefs.SetInt(scenenum,currentSceneIndex);
	   
 	   int index6 = UnityEngine.Random.Range(23,27);
	   
	   SceneManager.LoadScene( index6);
	 
}






public void LoadHotSweetRandomly(){
	
	 int currentSceneIndex=SceneManager.GetActiveScene().buildIndex;
	 string smallsec="ﺕﺎﻳﻮﻠﺣ";
	string smallsection="smallsection";
	string scenenum="scenenumber";
	   PlayerPrefs.SetString(smallsection,smallsec);
		PlayerPrefs.SetInt(scenenum,currentSceneIndex);
	   
 	   int index7 = UnityEngine.Random.Range(48,52);
	   
	   SceneManager.LoadScene( index7);
	 
}

///////////////////////////////////////////////////////////
public void LoadBedRoomRandomly(){
	   
 	   int index8 = UnityEngine.Random.Range(77,82);
	   
	   SceneManager.LoadScene( index8);
	 
}


public void LoadBathroomRandomly(){
	   
 	   int index9 = UnityEngine.Random.Range(67,75);
	   
	   SceneManager.LoadScene( index9);
	 
}


public void LoadGuestRoomRandomly(){
	   
 	   int index10 = UnityEngine.Random.Range(91,94);
	   
	   SceneManager.LoadScene( index10);
	 
}


public void LoadGardenRandomly(){
	   
 	   int index11 = UnityEngine.Random.Range(84,86);
	   
	   SceneManager.LoadScene( index11);
	 
}

public void LoadLivingRoomRandomly(){
	   
 	   int index12 = UnityEngine.Random.Range(111,115);
	   
	   SceneManager.LoadScene( index12);
	 
}

public void LoadKitchenRandomly(){
	   
 	   int index13 = UnityEngine.Random.Range(96,109);
	   
	   SceneManager.LoadScene( index13);
	 
}


public void LoadBodyUniteRandomly(){
	   
 	   int index14 = UnityEngine.Random.Range(116,127);
	   
	   SceneManager.LoadScene( index14);
	 
}

}