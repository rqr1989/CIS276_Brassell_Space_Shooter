using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCam : MonoBehaviour
{
    [SerializeField] private GameObject player;
    private Vector3 cameraOffset;

    private void Awake()
    {
        player = FindObjectOfType<Player>().gameObject;
    }
    //Start method
    private void Start()
    {
        cameraOffset = transform.position - player.transform.position;

    }

    private void Update()
    {
        transform.position = cameraOffset + player.transform.position;
    }
}
