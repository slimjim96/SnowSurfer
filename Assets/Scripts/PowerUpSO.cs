using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "PowerUpSO", menuName = "Scriptable Objects/PowerUpSO")]
public class PowerUpSO : ScriptableObject
{
   [SerializeField] string powerupType;
    [SerializeField] float valueChange;
    [SerializeField] float time;
}
