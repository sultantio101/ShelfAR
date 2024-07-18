using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Networking;
using SimpleJSON; //Library luar
using System;
using Vuforia;

public class APIController : MonoBehaviour
{
    public ObserverBehaviour NamaObserver;
    public TextMeshProUGUI rating;
    public TextMeshProUGUI perating;
    void Start ()
    {
        var namaTarget = NamaObserver.TargetName;
        StartCoroutine(GetRequest("https://www.googleapis.com/books/v1/volumes?q=isbn:"+ namaTarget +"input your Google API Key here"));
        // StartCoroutine(GetRequest("https://www.googleapis.com/books/v1/volumes?q=isbn:"+ namaTarget));
    }

    public void OnTracked()
    {
        Start();
    }

    IEnumerator GetRequest(String url)
    {
        using (UnityWebRequest webRequestRating = UnityWebRequest.Get(url))
        {
            yield return webRequestRating.SendWebRequest();

            switch (webRequestRating.result)
            {
                case UnityWebRequest.Result.ConnectionError:
                case UnityWebRequest.Result.DataProcessingError:
                    Debug.LogError(String.Format("Terjadi Kesalahan {0}", webRequestRating.error));
                    break;
                case UnityWebRequest.Result.Success:
                    Debug.Log(webRequestRating.downloadHandler.text);
                    JSONNode respon = JSON.Parse(webRequestRating.downloadHandler.text);
                    rating.text = respon["items"][0]["volumeInfo"]["averageRating"] + " /5";
                    perating.text = respon["items"][0]["volumeInfo"]["ratingsCount"] + " User";
                    break;
            }
        }
    }
}