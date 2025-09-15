using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Lighting : MonoBehaviour
{   //Reference the spotlight marker
    public Transform lightmarker;

    //Create a variable  for pointing to the light
    Transform spotlightATransform;

    // Start is called before the first frame update
    void Start()
    {
        //Make a game object
        GameObject SpotlightA = new GameObject("SpotlightA");

        //Connect the light to look at the mark
        spotlightATransform = SpotlightA.transform;

        //Add light component to the game object
        Light spotlightA = SpotlightA.AddComponent<Light>();

        //Change the light from a point to a spotlight
        spotlightA.type = LightType.Spot;

        //Create a light position vaiable
        Vector3 spotlightAPosition;

        //Choose a position
        spotlightAPosition = new Vector3(3, 15, 0);

        //Change indirect multiplier
        spotlightA.intensity= 10;

        //Change the position
        spotlightA.transform.position = spotlightAPosition;

        spotlightA.intensity = 150;

        spotlightA.range = 40;
    }
    // Update is called once per frame
    void Update()
    {
        spotlightATransform.LookAt(lightmarker);
    }
}
