using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Personajes  {

    public string id { get; set; }
    public string name { get; set; }
    public string Rango_id { get; set; }
    public string Class_id{ get; set; }
    public string Deb_id { get; set; }
    public string Arm_id { get; set; }

    public Personajes(string id, string name, string rango_id, string class_id, string deb_id, string arm_id)
    {
        this.id = id;
        this.name = name;
        this.Rango_id = rango_id;
        this.Class_id = class_id;
        this.Deb_id = deb_id;
        this.Arm_id = arm_id;
    }
}
