package com.triptraka.test

import android.os.Bundle
import androidx.activity.ComponentActivity
import androidx.activity.compose.setContent
import com.triptraka.test.ui.screens.CruiseListScreen
import com.triptraka.test.ui.theme.TripTrakaTheme

class MainActivity : ComponentActivity() {

    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContent {
            TripTrakaTheme {
                CruiseListScreen()
            }
        }
    }
}