<?php
$servername = "localhost";
$database = "lunardb";
$username = "xerio1001";
$password = "lunardb321";

// Create connection

$conn = mysqli_connect($servername, $username, $password, $database);

// Check connection

if ($conn->connect_error) {
die("Connection failed: " . $conn->connect_error);
}

mysqli_close($conn);

?>