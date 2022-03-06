using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class spawner : MonoBehaviour
{
    public int openingdirection;
//1=bottom door
//2=top door
//3=left door
//4=right door
    // Start is called before the first frame update
    private roomtemplate template;
    private int rand;
    private bool spawned = false;
    void Start()
    {
      template = GameObject.FindGameObjectWithTag("rooms").GetComponent<roomtemplate>(); 
      Invoke("Spawn",0.1f);
    }


    // Update is called once per frame
    void Spawn()
    {
        if(spawned==false){
            if(openingdirection== 1){
            rand=Random.Range(0,template.bottom_rooms.Length);
            Instantiate(template.bottom_rooms[rand],transform.position,template.bottom_rooms[rand].transform.rotation);
            }
        else if(openingdirection==2){
            rand=Random.Range(0,template.top_rooms.Length);
            Instantiate(template.top_rooms[rand],transform.position,template.top_rooms[rand].transform.rotation);

        }
        else if(openingdirection==3){
            rand=Random.Range(0,template.left_rooms.Length);
            Instantiate(template.left_rooms[rand],transform.position,template.left_rooms[rand].transform.rotation);

        }
        else if(openingdirection==4){
            rand=Random.Range(0,template.right_rooms.Length);
            Instantiate(template.right_rooms[rand],transform.position,template.right_rooms[rand].transform.rotation);
       }

            

    }
    spawned = true;
}
}
