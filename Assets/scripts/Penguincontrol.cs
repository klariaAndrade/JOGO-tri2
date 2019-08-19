using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Penguincontrol : MonoBehaviour
{   

       void OnTriggerEnter2D(Collider2D other){
           if (other.gameObject.CompareTag("Coin"))
           {
               SFXManager.instance.ShowCoinParticles(other.gameObject);
               AudioManager.instance.PlaySoundCoinPickup(other.gameObject);
               Destroy(other.gameObject);
               LevelManager.instance.IncrementCoinCount();
           }
           else if (other.gameObject.CompareTag("Gift"))
           {
               StopMusicAndTape();
               Destroy(other.gameObject);
               AudioManager.instance.PlaySoundLevelComplete(gameObject);
               Destroy(gameObject);
               LevelManager.instance.ShowLevelComplete();
           }
           else if(other.gameObject.layer == LayerMask.NameToLayer("forbidden")){
               KillPlayer();
           }
           
       }

       void StopMusicAndTape(){
               Camera.main.GetComponentInChildren<AudioSource>().mute = true;
               LevelManager.instance.SetTapeSpeed(0);
           }
           void KillPlayer() {
               StopMusicAndTape();
               AudioManager.instance.PlaySoundFail(gameObject);
               SFXManager.instance.ShowDieParticles(gameObject);
               Destroy(gameObject);
               LevelManager.instance.ShowGameOverPanel();
           }
}
