using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UIElements;

public class CoinSpawner : MonoBehaviour
{
    [SerializeField] float distanceBtwPlayer;
    [SerializeField] float startCooldown;
    [SerializeField] Coin coin;
    [SerializeField] Player player;
    private float cooldown;
    void Start()
    {
        cooldown = startCooldown;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(transform.position.x,transform.position.y,player.transform.position.z + distanceBtwPlayer);
        if (cooldown <= 0) 
        {
            Instantiate(coin, transform.position, Quaternion.identity);
            cooldown = startCooldown;
        }
        else
        {
            cooldown -= Time.deltaTime;
        }
    }
}
