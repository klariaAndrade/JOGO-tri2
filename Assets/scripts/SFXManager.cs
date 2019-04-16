using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;

public class SFXManager : MonoBehaviour
{
    public static SFXManager instance = null;
    public GameObject CoinParticles;
    public GameObject DieParticles;
    void Awake()
    {
        if (instance ==  null)
        {
            instance = this;
        }
    }
    public void ShowCoinParticles (GameObject obj){
        GameObject particles = Instantiate(CoinParticles, obj.transform.position, Quaternion.identity);
        GameObject tape = GameObject.Find("Tape");
        particles.transform.SetParent(tape.transform);
    }
     public void ShowDieParticles (GameObject obj){
        GameObject particles = Instantiate(DieParticles, obj.transform.position, Quaternion.identity);
        GameObject tape = GameObject.Find("Tape");
        particles.transform.SetParent(tape.transform);
    }
}