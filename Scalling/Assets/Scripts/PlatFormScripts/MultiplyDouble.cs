using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MultiplyDouble : MonoBehaviour
{
    public GameObject Player;
    public int maxPlayers=2;
    public int currentPlayer=1;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player")&&currentPlayer<maxPlayers)
        {
            Instantiate(Player, transform.position, Quaternion.identity);
            currentPlayer++;
        }
    }
}
