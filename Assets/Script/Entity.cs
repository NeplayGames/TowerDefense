using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TowerDefense
{
    public abstract class Entity : MonoBehaviour
    {
        [field:SerializeField]protected float health {get; set;}
        [field:SerializeField]protected int attackRate {get; set;}
    }

}
