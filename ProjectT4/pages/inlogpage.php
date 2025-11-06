<!DOCTYPE html>
<?php
/**
 * User: N.Bielaga
 * Date: 6.06.2024
 * File: Praktijkopdracht4
 */
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
    <?php
    session_start();
    include "../Includes/functionsdb.php"; // Adjust the path as necessary
    startConnection("SportAcademie");

    if (isset($_POST['username'], $_POST['password'])) {
        // Controleer of 'username' en 'password' zijn ingestuurd via het POST-verzoek

        $username = $_POST['username'];
        $password = $_POST['password'];

        // Gebruik prepared statements om SQL-injecties te voorkomen
        $query = "SELECT * FROM [User] WHERE UserName = ? AND [Password] = ?";
        $stmt = $pdo->prepare($query); // Bereid de SQL-query voor
        $stmt->execute([$username, $password]); // Voer de query uit met de ingevulde parameters
        $user = $stmt->fetch(); // Haal het resultaat van de query op als een associatieve array

        if ($user) {
            // Als er een gebruiker is gevonden met de ingevoerde gegevens

            $_SESSION['username'] = $username; // Sla de gebruikersnaam op in de sessie
            header("Location: inlogpage.php"); // Stuur de gebruiker door naar de inlogpagina
            exit(); // Zorg ervoor dat er geen verdere output wordt verzonden na de doorverwijzing
        } else {
            // Als er geen gebruiker is gevonden met de ingevoerde gegevens

            echo "Invalid username or password"; // Geef een foutmelding weer dat de inloggegevens ongeldig zijn
        }
    }
    ?>

    <header>
            <?php
            include "../Includes/header.php";
            ?>
        </header>
        <main>
            <div class="image-container">
                <div>
                    <h1>Inloggen</h1>
                    <form method="post" action="inlogpage.php">
                        <input type="text" id="username" name="username" placeholder="Username" required><br>
                        <input type="password" id="password" name="password" placeholder="Password" required><br>
                        <button class="botom" type="submit">Login</button>
                    </form>
                </div>
            </div>
        </main>
        <footer>
            <?php
            include "../Includes/footer.php"
            ?>
        </footer>
    </body>
</html>

