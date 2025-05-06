package com.triptraka.test.ui.screens

import androidx.compose.foundation.layout.Column
import androidx.compose.foundation.layout.fillMaxWidth
import androidx.compose.foundation.layout.padding
import androidx.compose.foundation.lazy.LazyColumn
import androidx.compose.material3.Divider
import androidx.compose.material3.MaterialTheme
import androidx.compose.material3.OutlinedTextField
import androidx.compose.material3.Text
import androidx.compose.runtime.Composable
import androidx.compose.runtime.getValue
import androidx.compose.runtime.LaunchedEffect
import androidx.compose.ui.Modifier
import androidx.compose.ui.unit.dp
import androidx.lifecycle.viewmodel.compose.viewModel
import androidx.compose.ui.platform.LocalContext
import androidx.compose.foundation.lazy.items
import com.triptraka.test.extensions.dateFormatted
import com.triptraka.test.viewmodels.CruiseViewModel

@Composable
fun CruiseListScreen() {
    val viewModel: CruiseViewModel = viewModel()
    val context = LocalContext.current

    LaunchedEffect(Unit) {
        viewModel.loadCruisesFromJson(context)
    }

    val searchQuery by viewModel.searchQuery
    val cruises = viewModel.filteredCruises

    Column {
        OutlinedTextField(
            value = searchQuery,
            onValueChange = viewModel::onSearchQueryChange,
            label = { Text("Search") },
            modifier = Modifier
                .fillMaxWidth()
                .padding(16.dp)
        )

        LazyColumn {
            items(cruises) { cruise ->
                Column(Modifier.padding(16.dp)) {
                    Text(text = cruise.tripName.orEmpty(), style = MaterialTheme.typography.titleMedium)
                    Text(text = cruise.embarkationPort.orEmpty())
                    Text(text = cruise.startDate.dateFormatted())
                    Divider()
                }
            }
        }
    }
}