using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Threading;

//small class library for parsing the search results on youtube's page for a project he was working on
//"J Gibson" reports that it works a treat which is nice to hear :) 
namespace Jord
{
    public class Class1
    {
        public static string[] YouTubeSearch(string searchTerm)
        {
           
            List<string> links = new List<string>();
            string HTMLString = "";
            string baseUrl = "https://www.youtube.com/results?search_query=";
            using (WebClient client = new WebClient()) // WebClient class inherits IDisposable
            {
                try
                {
                    HTMLString = client.DownloadString("http://" + baseUrl + searchTerm);
                }
                catch (System.Net.WebException)
                {
                    Thread.Sleep(500);
                    HTMLString = client.DownloadString("http://" + baseUrl + searchTerm);
                }
            }
                string tempChar = ("");
                for(int i = 0; i < HTMLString.Length -1; i++){
                    tempChar = Convert.ToString(HTMLString[i]);
                    if(tempChar == "h" && Convert.ToString(HTMLString[i+1]) == "r" && Convert.ToString(HTMLString[i+2]) == "e" && Convert.ToString(HTMLString[i+3]) == "f"){
                      
                        //shift right to past the first "
                        i = i +5;
                        //read all characters from opening " to closing ", exclude "
                        //standard format is href="/watch?v=60CKNwVXA_A"
                        bool done = false; string tempString = "";                        
                        while(done != true){
                            tempString = tempString + HTMLString[i];
                            i++;
                                if(Convert.ToByte(HTMLString[i]) == 47){
                                    done = true;
                                }
                        }
                        links.Add(tempString);                        
                    }
                }
           
            string[] returnArray =  new string[links.Count()];
            int arraycounter = 0;
            foreach(string link in links){
                returnArray[arraycounter] = ("http://youtube.com/" + link);
                arraycounter++;

            }                                                                     
            return returnArray;
        }
    }
}
