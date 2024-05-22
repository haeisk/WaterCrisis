using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class inputfield : MonoBehaviour
{
   // Doğru kelime
    private string correctWord = "bilgisayar";
    private Timer timerPuzzleScript;
    // TMP metin kutusu
    public TMP_InputField inputField;

   

 void Start()
    {
        timerPuzzleScript = GetComponent<Timer>(); // Referansı bul
    }
 // Seviye tamamlama fonksiyonu
    public void CheckWord()
    {
        string userWord = inputField.text.ToLower();

        if (userWord == correctWord)
        {
            // Seviyeyi geçmeyi tetikle
            LevelComplete();
        }
        else
        {
            // Hatalı kelime mesajı göster
            Debug.Log("Hatalı kelime!");
        }
    }

    // Seviye tamamlama fonksiyonu
    public void LevelComplete()
    {
        // Seviye tamamlama mesajı veya animasyonu göster
        Debug.Log("Seviye tamamlandı!");

        // Bir sonraki seviyeye geçişi başlat
        // ...
         timerPuzzleScript.SetIsCompleteTrue();
        // Puan veya diğer oyun verilerini güncelle
        
    }

    // Tuş basışlarını kontrol etmek için Update fonksiyonu
    private void Update()
    {
        // Enter tuşuna basıldığında CheckWord fonksiyonunu çağır
        if (Input.GetKeyDown(KeyCode.Return))
        {
            CheckWord();
        }
    }
}
