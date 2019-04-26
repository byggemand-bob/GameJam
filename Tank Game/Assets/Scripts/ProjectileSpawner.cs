using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileSpawner : MonoBehaviour {
    public float bulletVelocity = 20;

    private GameObject bullet;

    // Start is called before the first frame update
    void Start() {
        bullet = GetComponent<GameObject>();
    }

    // Update is called once per frame
    void FixedUpdate() {

    }
}
