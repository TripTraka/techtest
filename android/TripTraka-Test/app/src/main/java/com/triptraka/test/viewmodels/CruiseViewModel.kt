package com.triptraka.test.viewmodels

import android.content.Context
import androidx.compose.runtime.State
import androidx.compose.runtime.mutableStateListOf
import androidx.compose.runtime.mutableStateOf
import androidx.lifecycle.ViewModel
import com.triptraka.test.R
import com.triptraka.test.data.Cruise
import com.triptraka.test.extensions.dateFormatted
import org.json.JSONObject

class CruiseViewModel : ViewModel() {

    private val _cruises = mutableStateListOf<Cruise>()
    private val _searchQuery = mutableStateOf("")

    val searchQuery: State<String> = _searchQuery
    val filteredCruises: List<Cruise>
        get() = _cruises.filter {
            val query = searchQuery.value.lowercase()
                    it.tripName.orEmpty().lowercase().contains(query) ||
                    it.embarkationPort.orEmpty().lowercase().contains(query) ||
                    it.startDate.dateFormatted().lowercase().contains(query)
        }

    fun loadCruiseData(data: List<Cruise>) {
        _cruises.clear()
        _cruises.addAll(data)
    }

    fun loadCruisesFromJson(context: Context) {
        val inputStream = context.resources.openRawResource(R.raw.eu2025)
        val jsonString = inputStream.bufferedReader().use { it.readText() }
        val root = JSONObject(jsonString)
        val cruisesArray = root.getJSONObject("Data").getJSONArray("Cruises")

        val cruiseList = (0 until cruisesArray.length()).map { i ->
            val obj = cruisesArray.getJSONObject(i)
            Cruise(
                tripName = obj.getString("TripName"),
                embarkationPort = obj.getString("EmbarkationPort"),
                startDate = obj.getString("StartDate")
            )
        }
        loadCruiseData(cruiseList)
    }

    fun onSearchQueryChange(query: String) {
        _searchQuery.value = query
    }
}