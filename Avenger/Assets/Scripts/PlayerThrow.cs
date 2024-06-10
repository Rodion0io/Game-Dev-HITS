using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerThrow : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] GameObject CurWeapon;
    [SerializeField] Transform FirePoint;
    [SerializeField] float throwSpeed = 255;
    [SerializeField] GameObject BasicPlayer;
    void Start()
    {
        FirePoint = transform.GetChild(0).transform;
    }

    void Update()
    {
        if(Input.GetMouseButtonDown(1))
        {
            GameObject weapon = Instantiate(CurWeapon, FirePoint.position, FirePoint.rotation);
            weapon.GetComponent<Rigidbody2D>().AddForce(FirePoint.up* throwSpeed, ForceMode2D.Impulse);
            Instantiate(BasicPlayer, transform.position, transform.rotation);
            Destroy(gameObject);
        }
    }
}
