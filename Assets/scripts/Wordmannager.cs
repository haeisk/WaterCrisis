using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wordmannager : MonoBehaviour
{
  public List<Word> words ;


   private void Start() {
    addWord();
   addWord(); 
   addWord();
   addWord();

    
  }



  public void  addWord(){
    Word word = new Word(WordGenerator.GetRandomWord());
    words.Add(word);
    Debug.Log(word.word);
  }
}
