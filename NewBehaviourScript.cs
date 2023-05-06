using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
//If you see a green text, Unity based or Unity specific
    int count = 0;

    // Start is called before the first frame update
    void Start()
    {
        print("Hello World");
    }

    // Update is called once per frame
    void Update()
    {
       count++;
        if (count < 9999) {
            print("Hello again, you have said this " + count + "times.");
        }

        
    }
}
