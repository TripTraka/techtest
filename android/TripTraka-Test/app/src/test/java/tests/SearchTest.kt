package tests

import com.triptraka.test.data.Cruise
import com.triptraka.test.viewmodels.CruiseViewModel
import org.junit.Test

class SearchTest {

    @Test
    fun testSearch() {
        val viewModel1 = CruiseViewModel()
        viewModel1.loadCruiseData(listOf(
            Cruise(
                tripName = "Trip",
                embarkationPort = "Port",
                startDate = "2025-04-24T14:00:00",
            )
        ))
        viewModel1.onSearchQueryChange("Tr")

        val viewModel2 = CruiseViewModel()
        viewModel2.loadCruiseData(listOf(
            Cruise(
                tripName = "Trip",
                embarkationPort = "Port",
                startDate = "2025-04-24T14:00:00",
            )
        ))
        viewModel2.onSearchQueryChange("Tr")
        assert(viewModel1.filteredCruises == viewModel2.filteredCruises)
    }
}