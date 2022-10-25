using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioButton : MonoBehaviour
{
   private AudioSource audioSrc;

   private void Start()
   {
    audioSrc = GetComponent<AudioSource>();
   }

   public void PlayAudioButton()
   {
    audioSrc.Play();
   }

   public void DontPlayAudioButton()
   {
    audioSrc.Stop();
   }
}
