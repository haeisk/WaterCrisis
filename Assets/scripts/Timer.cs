using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Timer : MonoBehaviour
{
     // Bölüm başlangıç ​​zamanı
    private float startTime;
    private int score = 0;
    
    // Hedef süreler ve puanlar için tablo
    private int[] targetTimes = { 60, 120, 180 }; // saniye cinsinden
    private int[] scores = { 100, 80, 60 };

    // TMP metin kutusu (zamanlayıcı için)
    public TMP_Text timerText;

    // Puan metin kutusu
    public TMP_Text scoreText;

    // Bölüm tamamlanmış mı?
    public bool isComplete = false;

    // Start fonksiyonu
    void Start()
    {
       

        startTime = Time.time; // Bölüm başlangıç ​​zamanını kaydet
    }

    // Update fonksiyonu
    void Update()
    {
        if (!isComplete)
        {
            // Kalan süreyi hesapla
            float remainingTime = targetTimes[0] - (Time.time - startTime);

            // Kalan süreyi formatla ve göster
            timerText.text = string.Format("Kalan Süre: {0:00}", remainingTime);

            // Bölüm tamamlandı mı?
            if (remainingTime <= 0)
            {
                isComplete = true;
                CalculateScore(); // Puanı hesapla
            }
        }
    }

    // Puanı Hesapla fonksiyonu
    void CalculateScore()
    {
        for (int i = 0; i < targetTimes.Length; i++)
  {
    if (targetTimes[i] - (Time.time - startTime) > 0)
    {
      score = scores[i];
      break;
    }
  }

        // Puanı göster ve oyun verisine kaydet
        scoreText.text = string.Format("Puan: {0}", score);
        // ... (Oyun verisine kaydetme kodu)
}

 public void SetIsCompleteTrue() // Public fonksiyon
    {
        isComplete = true;
    }
}