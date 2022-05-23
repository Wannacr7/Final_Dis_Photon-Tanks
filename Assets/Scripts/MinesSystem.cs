using Photon.Pun;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MinesSystem : MonoBehaviourPun
{
    [SerializeField] GameObject prefab;
    float time;
    float cooldown = 3;
    [SerializeField] Transform spawn_pos;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void Update()
    {
        time += Time.deltaTime;
        if (photonView.IsMine && Input.GetKeyUp(KeyCode.Return) && time>=cooldown)
        {
            time = 0;
            Debug.Log("Enter");
            photonView.RPC("SetMine", RpcTarget.AllBuffered);
        } 
    }

    [PunRPC]
    void SetMine()
    {
        Debug.Log("Colocando una mina");
        GameObject temp = Instantiate(prefab, spawn_pos);
        temp.transform.parent = null;
        
        
    }

}
