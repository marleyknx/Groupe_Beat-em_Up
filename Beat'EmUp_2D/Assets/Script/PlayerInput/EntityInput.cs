using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(menuName = "Scriptable Objects / EntityInput")]
public class EntityInput : ScriptableObject
{
    public bool IsPressed;
    public Vector2 direction;
}
