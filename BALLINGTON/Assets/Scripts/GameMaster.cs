using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMaster : MonoBehaviour
{
    //[SerializeField] AudioClip _crowdAudio;
    
    void Start()
    {
       
    }

    void Awake()
    {
        //singleton pattern
        int numOfGameMasters = FindObjectsOfType<GameMaster>().Length;
        if(numOfGameMasters > 1)
        {
            Destroy(this.gameObject);
        } else
        {
            DontDestroyOnLoad(this.gameObject);
        }
        
    }

    //creating audio but not reloading level
    /*public void Playcrowd()
    {
        //AudioSource.PlayClipAtPoint(_crowdAudio, new Vector3(0, 60.76f, -225.21f), 1f);
    }*/

}
