
using UnityEngine;
using System.Collections;

public class CameraMove : MonoBehaviour {

    public Transform Player;
    private Vector3 offset;

    void Start()
    {
        offset = Player.transform.position - transform.position;
    }

    void Update()
    {
        transform.position = Player.position - offset;
    }
}























