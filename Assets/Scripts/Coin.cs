using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    [SerializeField] float rotationSpeed;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0,rotationSpeed * Time.deltaTime, 0); ;
    }

    private void OnTriggerEnter(Collider other)
    {   
        FindObjectOfType<CoinManager>().AddCoin();
        Destroy(gameObject);
    }
}
