<?php
/**
 * User: N.Bielaga
 * Date: 6.06.2024
 * File: Praktijkopdracht4
 */
?>
<?php
session_start();
if (!isset($_SESSION['username'])) {
    header("Location: inlogpage.php");
    exit(); // Zorg ervoor dat er geen code meer wordt uitgevoerd na de redirect
}
?>
    <form method="post">
        <fieldset>
            <legend>Activiteit toevoegen</legend>
            <p>
                <label for="name">Name</label>
                <input type="text" name="name" id="name">
            </p>
            <p>
                <label for="start">Starttijd</label>
                <input type="text" name="start" id="start">
            </p>
            <p>
                <label for="end">Eindtijd</label>
                <input type="text" name="end" id="end">
            </p>
            <p>
                <label for="location">Locatie</label>
                <input type="text" name="location" id="location">
            </p>

            <input type="submit" name="toevoegen" value="Voeg activiteit toe">
        </fieldset>
    </form>
<?php

if(isset($_POST["toevoegen"]))
{
    //echo "TEST";

    //Ingevulde gegevens van het formulier ophalen en in een variabele opslaan.
    $Name = $_POST["name"];
    $Start = $_POST["start"];
    $End = $_POST["end"];
    $Location = $_POST["location"];

    //Acties naar de DB

    //Inladen van alle database functies
    include "../Includes/functionsdb.php";

    //verbinding maken met de database
    startConnection("SportAcademie");

    $query = "INSERT INTO Activity VALUES ('$Name', '$Start', '$End', '$Location');";
    //echo $query;

    $rowsAffected = executeInsertQuery($query);

    if($rowsAffected > 0)
    {
        echo "Activiteit succesvol toegevoegd.";
    }
    else
    {
        echo "Er is iets misgegaan.";
    }


}

