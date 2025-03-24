using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImportantBehaviors : MonoBehaviour
{
    // This is in the "class block" and will
    // be available everywhere in this class
    public int runSpeed;

    // Start is called before the first frame update
    void Start()
    {
        print ("Start runs before an object Updates");
    }

    // Update is called once per frame
    void Update()
    {
        print("This is called once a frame");
    }
}
