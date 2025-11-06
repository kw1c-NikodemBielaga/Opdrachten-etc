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
        <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.5.2/css/all.min.css" integrity="sha512-SnH5WK+bZxgPHs44uWIX+LLJAJ9/2PkPKZ5QiAj6Ta86w+fsb2TkcmfRyVX3pBnMFcV7oQPJkl9QevSCWr3W6A==" crossorigin="anonymous" referrerpolicy="no-referrer" />
        <link rel="stylesheet" type="text/css" href="stylesheet/style.css">
    </head>
    <body>
        <header>
            <?php
            include "Includes/header.php";
            ?>
        </header>
        <main>
            <?php
            include "Includes/main.php";
            ?>
        </main>
    <footer>
        <?php
        include "Includes/footer.php"
        ?>
    </footer>
    </body>
</html>
