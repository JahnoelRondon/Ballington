using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMaster : MonoBehaviour
{
    //[SerializeField] AudioClip _crowdAudio;
    private PlayerMover _player;

    void Start()
    {
        _player = GameObject.Find("Player").GetComponent<PlayerMover>();
    }

    void Awake()
    {
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

    void Update()
    {
        
    }
}
