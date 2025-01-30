using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SistemaRespawn : MonoBehaviour
{

    public Transform posRespawn;
    public Transform posPlayer;


    public void Muerte()
    {
        posPlayer.position = posRespawn.position;
    }
}
