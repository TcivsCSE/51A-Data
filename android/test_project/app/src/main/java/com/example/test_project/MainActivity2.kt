
package com.example.test_project

import androidx.appcompat.app.AppCompatActivity
import android.os.Bundle
import android.widget.Button

class MainActivity2 : AppCompatActivity() {
    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContentView(R.layout.activity_main2)


        //menu
        val btn_menu= findViewById<Button>(R.id.btn_menu)
        btn_menu.setOnClickListener(){

        }
    }
}