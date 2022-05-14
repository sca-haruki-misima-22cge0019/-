using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trap : MonoBehaviour
{
    [SerializeField]
    protected float waitTime;

    protected bool stop = false;

    [SerializeField]
    float rotateX;
    [SerializeField]
    float rotateY;
    [SerializeField]
    float rotateZ;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(rotateX, rotateY, rotateZ) * Time.deltaTime, Space.World);
    }


    protected IEnumerator Wait()
    {
        stop = true;

        yield return new WaitForSeconds(waitTime);

        stop = false;
    }
}