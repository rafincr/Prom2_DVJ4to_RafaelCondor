using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Personaje_manager : MonoBehaviour {

    public GameObject id;
    public GameObject name;
    public GameObject Deb_id;
    public GameObject Class_id;
    public GameObject Arm_id;
    public GameObject Fort_id;

    public Personaje_manager(string id, string name, string deb_id, string class_id, string arm_id, string fort_id)
    {
        this.id.GetComponent<Text>().text = id;
        this.name.GetComponent<Text>().text = name;
        this.Deb_id.GetComponent<Text>().text = deb_id;
        this.Class_id.GetComponent<Text>().text = class_id;
        this.Arm_id.GetComponent<Text>().text = arm_id;
        this.Fort_id.GetComponent<Text>().text = fort_id;
    }
}
