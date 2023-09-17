using System.Collections;
using System.Collections.Generic;
//using Microsoft.Unity.VisualStudio.Editor;
using UnityEngine;


public class PitchVisualizer : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioPitchEstimator estimator;
    public LineRenderer lineSRH;
    public LineRenderer lineFrequency;
    public Transform marker;
    public TextMesh textFrequency;
    public TextMesh textMin;
    public TextMesh textMax;

    public float estimateRate = 30;

    public string noteName;

    private Chara_Controll chara_Controll;
    private Chord_Gage_Controll chord_Gage_Controll;
    

    void Start()
    {
       //chara_Controll = GetComponent<Chara_Controll>();
       chara_Controll = GameObject.Find("monster").GetComponent<Chara_Controll>();
       chord_Gage_Controll = GameObject.Find("Chord_Gage").GetComponent<Chord_Gage_Controll>();
       
       //Debug.Log("最初の読み込みは行えてるよ");

        // 一定間隔で呼び出す（Updateだと速すぎる）
        //デフォは1.0ｆだけどそれだと早いので調整済みでこの数値↓
        InvokeRepeating(nameof(UpdateVisualizer), 0, 1.0f / estimateRate);

    }

    void UpdateVisualizer()
    {
        // 基本周波数を推定
        var frequency = estimator.Estimate(audioSource);

        // SRHスコア
        var srh = estimator.SRH;
        var numPoints = srh.Count;
        var positions = new Vector3[numPoints];
        for (int i = 0; i < numPoints; i++)
        {
            var position = (float)i / numPoints - 0.5f;
            var value = srh[i] * 0.005f;
            positions[i].Set(position, value, 0);
        }
        lineSRH.positionCount = numPoints;
        lineSRH.SetPositions(positions);

        // 基本周波数
        if (float.IsNaN(frequency))
        {
            // 検出されなかったので非表示
            lineFrequency.positionCount = 0;
        }
        else
        {
            var min = estimator.frequencyMin;
            var max = estimator.frequencyMax;
            var position = (frequency - min) / (max - min) - 0.5f;

            lineFrequency.positionCount = 2;
            lineFrequency.SetPosition(0, new Vector3(position, +1, 0));
            lineFrequency.SetPosition(1, new Vector3(position, -1, 0));

            marker.position = new Vector3(position, 0, 0);

            //ここのどれかがキーをさしてると思うんだよね
            //たぶん{0}\のとこだと思う
            //textFrequency.textそのものでした
            textFrequency.text = string.Format("{0}\n{1:0.0} Hz", GetNameFromFrequency(frequency), frequency);

            //Debug.Log( textFrequency.text );
            
            //Debug.Log( "noteName is " + noteName );

            if (noteName == "C")
            {
               //Chara_Controllのメソッド
               chara_Controll.Onclick();
               //chord_Gage_Controll.Onclick_C();
                              
               
            }

            if (noteName == "E")
            {
               //Chara_Controllのメソッド
               chara_Controll.Onclick();
               //chord_Gage_Controll.Onclick_E();
            }

            if (noteName == "G")
            {
               //Chara_Controllのメソッド
               chara_Controll.Onclick();
               //chord_Gage_Controll.Onclick_C();
            }
                      
        }

        // 下限・上限周波数
        textMin.text = string.Format("{0} Hz", estimator.frequencyMin);
        textMax.text = string.Format("{0} Hz", estimator.frequencyMax);

    }

    // 周波数 → 音名
    string GetNameFromFrequency(float frequency)
    {
        //440Hzからの差を対数で計算して12をかけて音程番号(MIDI番号)を求める
        var noteNumber = Mathf.RoundToInt(12 * Mathf.Log(frequency / 440) / Mathf.Log(2) + 69);

        //noteNumberのあまりが0ならC、1ならC＃  以下略
        string[] names = {
            "C", "C#", "D", "D#", "E", "F", "F#", "G", "G#", "A", "A#", "B"
        };



        noteName = names [noteNumber % 12];

        
        //キーが○だったらというコード
        //if ( noteName == "A")
        //{
           // Debug.Log( " this is A " );
       // }

        //Debug.Log( noteName );


        //return names[noteNumber % 12];
        return noteName;
    }


}
