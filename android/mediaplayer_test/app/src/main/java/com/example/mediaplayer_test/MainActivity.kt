package com.example.mediaplayer_test

import android.content.Context
import android.media.MediaParser
import android.media.MediaPlayer
import android.nfc.Tag
import androidx.appcompat.app.AppCompatActivity
import android.os.Bundle
import android.util.Log
import android.view.View
import android.widget.*
import androidx.core.view.get

class MainActivity : AppCompatActivity() {
    public lateinit var spinner: Spinner
    public lateinit var textview :TextView
    val song_data = listOf<String>("AHHHHHH","Trololo","rick roll")
    val songId_data = listOf<Int>(R.raw.ahhhhh,R.raw.trololo,R.raw.rickroll)
    val context:Context=this
    private  var mediaplayer :MediaPlayer?=null;
    var selected_song :Int =1;
    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContentView(R.layout.activity_main)

        spinner = findViewById<Spinner>(R.id.spinner)
        textview = findViewById(R.id.tv)


        val adapter = ArrayAdapter(this,android.R.layout.simple_spinner_item,song_data)

        spinner.adapter = adapter

        spinner.onItemSelectedListener = object : AdapterView.OnItemSelectedListener {
            override fun onItemSelected(
                parent: AdapterView<*>?,
                view: View?,
                position: Int,
                id: Long
            ) {
                if (position != selected_song) {
                    mediaplayer?.stop()
                }
                mediaplayer =MediaPlayer.create(context,songId_data[song_data.indexOf(spinner.selectedItem)])
                selected_song=position
                mediaplayer?.start()
                textview.text = "正在播放: "+song_data[selected_song]
            }
            override fun onNothingSelected(parent: AdapterView<*>?) {

            }
        }
        mediaplayer = MediaPlayer.create(context,songId_data[selected_song])
        mediaplayer?.start()
        textview.text = "正在播放: "+song_data[selected_song]
    }
    override fun onStart() {
        super.onStart()

    }
    override fun onRestart() {
        super.onRestart()
        mediaplayer?.start()
    }

    override fun onPause() {
        super.onPause()
        mediaplayer?.pause()
    }
    override fun onDestroy() {
        super.onDestroy()
        mediaplayer?.stop()
    }

    override fun onStop() {
        super.onStop()
        mediaplayer?.pause()
    }
}

