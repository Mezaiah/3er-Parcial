using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;


public class SpawnPlayers : MonoBehaviour
{
    public GameObject PlayerPref;
    // Start is called before the first frame update
    void Start()
    {
        PhotonNetwork.Instantiate(PlayerPref.name, new Vector3(0.0f, 1.0f, 0.0f), Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
