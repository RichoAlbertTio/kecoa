using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KecoaController : MonoBehaviour
{
    // Start is called before the first frame update
    float ms;
    Animator anim;
    void Start()
    {
        ms = Random.Range(1, 5);
        anim = GetComponent<Animator>();
        Invoke("Destroyer", 6);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, transform.up * 100, Time.deltaTime * ms);
    }

    public void dead()
    {
        anim.SetTrigger("dead");
        ms = 0;
        Invoke("Destroyer", 2);
    }


    void Destroyer()
    {
        Destroy(gameObject);
    }
}
