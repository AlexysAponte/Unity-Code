using UnityEngine;
using System.Collections;

public class Respawn : MonoBehaviour
{
    public Transform spawnPoint;
    public float minHeightForDeath;
    public GameObject player;

    void Start()
    {

    }
    // Update is called once per frame
    void OnTriggerEnter(Collider other)
    {
        other.transform.position = spawnPoint.position;
    }
}
