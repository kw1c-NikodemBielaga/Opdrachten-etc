<!DOCTYPE html>
<?php
/**
 * User: N.Bielaga
 * Date: 6.06.2024
 * File: Praktijkopdracht4
 */
session_start();
?>

<html lang="nl">
<head>
    <title>
        Sportacademie
    </title>
    <meta charset="utf-8">
    <meta name=viewport content="width=device-width, initial-scale=1">
    <link rel="stylesheet" href="../https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.5.2/css/all.min.css" integrity="sha512-SnH5WK+bZxgPHs44uWIX+LLJAJ9/2PkPKZ5QiAj6Ta86w+fsb2TkcmfRyVX3pBnMFcV7oQPJkl9QevSCWr3W6A==" crossorigin="anonymous" referrerpolicy="no-referrer" />
    <link rel="stylesheet" type="text/css" href="../stylesheet/style.css">
</head>
<body>
<header>
    <?php
    include "../Includes/header.php";
    ?>
</header>
<main>
    <a href="../Includes/activiteiten_toevoegen.php">Voeg nieuwe Activiteit toe</a><br><br>
    <form>
        <fieldset>
            <legend>Zoek activiteit</legend>
            <input type="text" name="searchName" value="<?php if(isset($_GET["searchName"])){ echo $_GET["searchName"]; } ?>">
            <select name="searchLocation">
                <option value="">All</option>
                <?php
                include "../Includes/functionsdb.php";
                //Database connectie opzetten.
                startConnection("SportAcademie");

                //Query die alle unieke locaties ophaalt.
                $queryLocation = "SELECT DISTINCT [Location] FROM Activity;";

                //Query uitvoeren
                $resultLocation = executeQuery($queryLocation);

                //Van alle locaties een optie maken in de select.
                while ($row = $resultLocation->fetch(PDO::FETCH_ASSOC)) {
                    //If die controleert welke locatie is aangeklikt en die de waarde selecten meegeven
                    if(isset($_GET["searchLocation"]) && $_GET["searchLocation"] == $row["Location"]) {
                        $option = "selected";
                    } else {
                        $option = "";
                    }

                    echo "<option $option>" . $row["Location"] . "</option>";
                }

                ?>
            </select>

            <input type="submit" value="Zoeken.." name="submit">
        </fieldset>
    </form>


    <div class="activity-table">
        <?php
        // Uitlezen van alle activiteiten uit de database
        $query = "SELECT * FROM Activity";

        // Query aanpassen wanneer er op iets gezocht wordt
        if(isset($_GET["submit"])) {
            $searchName = $_GET['searchName'];
            $searchLocation = $_GET['searchLocation'];

            $query = "SELECT * FROM Activity WHERE [Name] LIKE '%$searchName%'";
            if(!empty($searchLocation)) {
                $query .= " AND [Location] LIKE '%$searchLocation%'";
            }
        }

        // Query uitvoeren
        $result = executeQuery($query);

        // Resultaten laten zien op de pagina
        echo "<table>";
        echo "<thead>";
        echo "<tr><th>Naam</th><th>Start</th><th>Einde</th><th>Locatie</th></tr>";
        echo "</thead>";
        echo "<tbody>";
        while ($row = $result->fetch(PDO::FETCH_ASSOC))
        {
            echo "<tr>";
            echo "<td>" . $row["Name"] . "</td>";
            echo "<td>" . $row["Start"] . "</td>";
            echo "<td>" . $row["End"] . "</td>";
            echo "<td>" . $row["Location"] . "</td>";
            $activityName = $row["Name"];
            echo "<td>" . "<a href='activiteiten_bewerken.php?activityName=$activityName'>Bewerken</a>" . "</td>";
            echo "<td>" . "<a href='activiteiten_verwijderen.php?activityName=$activityName'>Verwijderen</a>" . "</td>";
            echo "</tr>";
        }
        echo "</tbody>";
        echo "</table>";


        ?>
    </div>
</main>
<footer>
    <?php
    include "../Includes/footer.php";
    ?>
</footer>
</body>
</html>