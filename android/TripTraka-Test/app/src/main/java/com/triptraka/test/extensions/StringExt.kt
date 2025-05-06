package com.triptraka.test.extensions

import java.time.LocalDateTime
import java.time.format.DateTimeFormatter

fun String?.dateFormatted(): String {
    return try {
        val inputFormatter = DateTimeFormatter.ISO_DATE_TIME
        val outputFormatter = DateTimeFormatter.ofPattern("MMMM d, yyyy")
        LocalDateTime.parse(this, inputFormatter).format(outputFormatter)
    } catch (e: Exception) {
        this.orEmpty()
    }
}