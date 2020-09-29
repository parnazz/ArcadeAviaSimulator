using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    [SerializeField] private Transform player;
    private Vector3 playerInitialRotation;

    // Start is called before the first frame update
    void Start()
    {
        playerInitialRotation = player.localEulerAngles;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = player.transform.position;
        transform.localRotation = Quaternion.Euler(
            (player.localEulerAngles - playerInitialRotation).z,
            (player.localEulerAngles - playerInitialRotation).y,
            -(player.localEulerAngles - playerInitialRotation).x);
    }
}
