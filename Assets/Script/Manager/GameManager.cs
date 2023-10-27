using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class GameManager : MonoBehaviour
{
    public GameObject human;
    public GameObject monster;
    public GameObject[] orb;

    private void Start()
    {

    }
    public void ChooseHuman()
    {
        PhotonNetwork.Instantiate(human.name, human.transform.position, Quaternion.identity);
    }
    public void ChooseMonster()
    {
        PhotonNetwork.Instantiate(monster.name, monster.transform.position, Quaternion.identity);

        int i;
        i = 0;

        while (orb.Length > i)
        {
            Instantiate(orb[i], orb[i].transform.position, Quaternion.identity);
            i++;
        }
    }
}
