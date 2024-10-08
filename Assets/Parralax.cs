using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parralax : MonoBehaviour
{
    GameObject player;
    Renderer rend;

    float playerStartpos;
    public float speed = 0.5f;
    void Start()
    {
        player = GameObject.Find("Player");
        rend = GetComponent<Renderer>();
        playerStartpos = player.transform.position.x;
    }

    // Update is called once per frame
    void Update()
    {
        float offset = (player.transform.position.x - playerStartpos) * speed;
        rend.material.SetTextureOffset("_MainTex", new Vector2(offset, 0f));
    }
}
