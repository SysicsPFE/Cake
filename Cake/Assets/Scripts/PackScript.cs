using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Pack", menuName = "Pack")]
public class PackScript : ScriptableObject
{
    public short Price;
    public Sprite image;
    public byte Locked;
    public byte nbCoin;
    public bool Unlocked;
    public Sprite CharacterImage;
    public string Name;
    public Sprite LockImage;
}
