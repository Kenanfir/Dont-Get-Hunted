using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class Monster : MonoBehaviour
{
    [SerializeField] private Camera cam;
    [SerializeField] private float moveSpeed;
    [SerializeField] private Rigidbody2D rb;

    public GameObject canvas;
    public GameObject lose;
    public GameObject win;
    public int orb;

    Vector3 movement;
    PhotonView view;

    private void Start()
    {
        canvas = GameObject.Find("Canvas");
        win = canvas.transform.Find("Win").gameObject;
        lose = canvas.transform.Find("Lose").gameObject;
        view = GetComponent<PhotonView>();
    }

    void Update()
    {
        if (view.IsMine)
        {
            movement = new Vector3(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"), 0);
            transform.position += movement.normalized * moveSpeed * Time.deltaTime;
        }
        if (view.IsMine && cam.gameObject.activeInHierarchy == false)
        {
            cam.gameObject.SetActive(true);
        }
    }

    void OnCollisionEnter2D(Collision2D hit)
    {
        if (!view.IsMine)
        {
            return;
        }

        if (hit.gameObject.layer == 6) // 6 is for Human
        {
            if (orb < 5)
            {
                Destroy(this.gameObject);
                lose.SetActive(true);
            }
            else if (orb == 5)
            {
                win.SetActive(true);    
            }
        }
        if (hit.gameObject.layer == 8) // 8 is for Orb
        {
            view.RPC("AddOrb", RpcTarget.All, orb);
            Destroy(hit.gameObject);
        }
    }

    [PunRPC]
    public void AddOrb(int mine)
    {
        orb++;
    }
}
