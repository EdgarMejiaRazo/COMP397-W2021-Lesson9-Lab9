using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="SceneData", menuName ="Data/SceneData")]
public class SceneDaraSO : ScriptableObject
{
    [Header("Plater Data")]
    public Vector3 playerPosition;
    public Quaternion playerRotation;
    public int playerHealth;
}
