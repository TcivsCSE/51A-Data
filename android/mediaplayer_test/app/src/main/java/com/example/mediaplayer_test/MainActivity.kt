package com.example.mediaplayer_test

import android.media.MediaParser
import android.media.MediaPlayer
import androidx.appcompat.app.AppCompatActivity
import android.os.Bundle
import android.widget.Adapter
import android.widget.ArrayAdapter
import android.widget.Spinner

class MainActivity : AppCompatActivity() {

    private  var mediaplayer :MediaPlayer?=null;
    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContentView(R.layout.activity_main)

        val spinner = findViewById<Spinner>(R.id.spinner)

        val song_data = listOf<String>("超跑情人夢","Trololo","rick roll")

        val adapter = ArrayAdapter(this,android.R.layout.simple_spinner_item,song_data)

        spinner.adapter = adapter

    }

    public override fun onPause() {
        super.onPause()
    }
    public
}