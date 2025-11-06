<!DOCTYPE html>
<?php
//    Autheur:         Ties de Bruijn, Nikodem Bielaga
//    Aanmaakdatum:   <2-4-2024>
//
//    <Namaak van de Veba-solar site>
?>

<html>
    <head>
        <title>
            Veba Solar
        </title>
        <!--        Declaratie Tekenset-->
        <meta charset="UTF-8">
        <!--        Declaratie Viewport-->
        <meta name="Viewport" content="width=device-width, initial-scale=1.0">
        <!-- so i dont get error -->
        <link rel="shortcut icon" href="#">
        <!--        Link naar het css bestand-->
        <link rel="stylesheet" href="styles/styles.css">
        <link rel="stylesheet" href="styles/PageStyles.css">

        <link rel="preconnect" href="https://fonts.googleapis.com">
        <link rel="preconnect" href="https://fonts.gstatic.com" crossorigin>
<!--    link naar js    -->
        <script src="scripts/HamburgerMenu.js"></script>

    </head>
    <body id="Home">
        <header>
            <?php
                //include header
                include "includes/Header.php";
            ?>
            <article>
                <section>
                    <a href="#"><img src="images/Veba_Logo.svg" alt="Logo" width="16" height="16"></a>
                    <h2>
                        kies voor besparing, <strong>kies voor<br>duurzaam,</strong> kies voor zonne-energie.
                    </h2>
                </section>
            </article>
        </header>
        <footer>
            <?php
            //include footer
            include "includes/footer.php"
            ;?>
        </footer>
    </body>

</html>