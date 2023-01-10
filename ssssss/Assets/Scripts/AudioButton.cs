using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioButton : MonoBehaviour
{
   private AudioSource GameStartButton;

   private void Start()
   {
    GameStartButton = GetComponent<AudioSource>();
   }

   public void PlayAudioButton()
   {
    GameStartButton.Play();
   }

   public void DontPlayAudioButton()
   {
     GameStartButton.Stop();
   }
}
