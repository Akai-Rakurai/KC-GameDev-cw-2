using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Daytwo : MonoBehaviour
{
    string heroname = ("Hiro");
    float heroheight = 2.2f;
    int heroage = 22;
    string heropower = ("super strength");
    string villainname = ("Umbra");
    float villainheight = 1.7f;
    int villainage = 32;
    string villainpower = ("the ability to control darkness and shadow");


    void Start()
    {
        int AgeDiffrence = (villainage - heroage);
        print("In a world conquered by darkness a prophecy foretold the name of a great hero, his name was " + heroname + ". After years of searching the hero was found in the labrinth of trials.");
        print("The hero was " + heroheight + " meters tall and he was " + heroage + " years old, He had a power and it was " + heropower + ".");
        print(heroname + "'s mission is to defeat the villanous lord " + villainname + " and his many armies, " + villainname + " is " + villainheight + " meters tall and he is " + villainage + " years old, He has " + villainpower + ".");
        print("Although there is an age diffrence of " + AgeDiffrence + " years between " + heroname + " and " + villainname + " the final victor will be " + heroname + ".");
    }
}
