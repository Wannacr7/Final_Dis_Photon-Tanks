using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;



public class SkinManager: MonoBehaviour
{
    [SerializeField] MeshRenderer m_mat_Player;

    PhotonView pv;

    private void Awake()
    {
        pv = GetComponent<PhotonView>();
    }
    void Start()
    {

        string temp = (string)pv.Owner.CustomProperties["Color"];
        if (temp == "Red") m_mat_Player.material.color = Color.red;
        else if (temp == "Blue") m_mat_Player.material.color = Color.blue;
        else m_mat_Player.material.color = Color.green;

    }
}
