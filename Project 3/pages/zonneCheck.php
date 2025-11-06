<!DOCTYPE html>
<?php
session_start();
//    Autheur:         Ties de Bruijn
//    Aanmaakdatum:   <02-23-2024>
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
    <link rel="stylesheet" href="../styles/styles.css">
    <link rel="stylesheet" href="../styles/PageStyles.css">

    <link rel="preconnect" href="https://fonts.googleapis.com">
    <link rel="preconnect" href="https://fonts.gstatic.com" crossorigin>

    <script src="../scripts/HamburgerMenu.js"></script>

</head>
    <body id="ZonneCheck">
        <header>
            <?php
            //include header
            include "../includes/Header.php";
            ?>
        </header>
        <main>
            <article>
                <?php

                //If Form is NOT Submitted then show Form
                if(!isset($_SESSION['Result']) && !isset($_POST['submit']))//TEST
                {

                //goeiemorgen bericht
                date_default_timezone_set('Europe/Amsterdam');
                // Bepaal het tijdstip van de dag
                $tijd = date("H");
                $datumTijd = date("d-m-Y H:i:s");
                // Begroetingsbericht op basis van het tijdstip van de dag
                if ($tijd < "12")
                {
                    $begroeting = "Goedemorgen";
                }
                elseif ($tijd < "18")
                {
                    $begroeting = "Goedemiddag";
                }
                else
                {
                    $begroeting = "Goedenavond";
                }

                // Echo begroeting
                echo "<span class='datumtijd'>$datumTijd</span>";
                echo  "<p>". $begroeting . ", welkom bij onze vragenlijst!</p>";
                echo "<p>De vragenlijst op de website helpt mensen die twijfelen over zonnepanelen. Het zorgt ervoor dat ze realistische verwachtingen hebben, checkt of hun huis geschikt is, vertelt hoeveel het kost en bespaart. Zo kunnen mensen beter beslissen of zonnepanelen iets voor hen zijn.</p>"
                ?>




                <!-- Vragenlijst -->
                <form action="" method="POST">

                    <!-- Vraag 0 ( 0-3 Punten ) -->
                    <h3 for="Vraag0">Naar welke kant zou u zonnepanelen willen hebben?</h3>
                    <input type="radio" name="Vraag0" id="Vraag0a" checked required value="0">
                    <label for="Vraag0a">Noorden</label><br>
                    <input type="radio" name="Vraag0" id="Vraag0b" required value="2">
                    <label for="Vraag0b">Oost</label><br>
                    <input type="radio" name="Vraag0" id="Vraag0c" required value="3">
                    <label for="Vraag0c">Zuid</label><br>
                    <input type="radio" name="Vraag0" id="Vraag0d" required value="1">
                    <label for="Vraag0d">West</label><br>

                    <!-- Vraag1  ( 0-3 Punten ) -->
                    <h3 for="Vraag1">Wat voor type dak heeft u</h3>
                    <input type="radio" name="Vraag1" id="Vraag1a" checked required value="2">
                    <label for="Vraag1a">Plat dak</label><br>
                    <input type="radio" name="Vraag1" id="Vraag1b" required value="3">
                    <label for="Vraagb1">Schuin met dakpannen</label><br>
                    <input type="radio" name="Vraag1" id="Vraag1c" required value="1">
                    <label for="Vraag1c">Schuin met riet</label><br>
                    <input type="radio" name="Vraag1" id="Vraag1d" required value="0">
                    <label for="Vraag1d">Puntdak</label><br>

                    <!-- Vraag2 ( 0-3 Punten ) -->
                    <h3 for="Vraag2">Hoe groot is uw beschikbare dakoppervlakte voor zonnepanelen?</h3>
                    <input type="radio" name="Vraag2" id="Vraag2a" checked required value="0">
                    <label for="Vraag2a">Minder dan 10 m²</label><br>
                    <input type="radio" name="Vraag2" id="Vraag2b" required value="1">
                    <label for="Vraag2b">10-20 m²</label><br>
                    <input type="radio" name="Vraag2" id="Vraag2c" required value="2">
                    <label for="Vraag2c">20-30 m²</label><br>
                    <input type="radio" name="Vraag2" id="Vraag2d" required value="3">
                    <label for="Vraag2d">Meer dan 30 m²</label><br>

                    <!-- Vraag3 ( 0-3 Punten ) -->
                    <h3 for="Vraag3">Wat is uw gemiddelde jaarlijkse energie kosten</h3>
                    <input type="radio" name="Vraag3" id="Vraag3a" checked required value="0">
                    <label for="Vraag3a">Minder dan €500</label><br>
                    <input type="radio" name="Vraag3" id="Vraag3b" required value="1">
                    <label for="Vraag3b">Tussen €500 en €1.000</label><br>
                    <input type="radio" name="Vraag3" id="Vraag3c" required value="2">
                    <label for="Vraag3c">Tussen €1.000 en €1.500</label><br>
                    <input type="radio" name="Vraag3" id="Vraag3d" required value="3">
                    <label for="Vraag3d">Meer dan €1.500</label><br>

                    <!-- Vraag4 ( 0-3 Punten ) -->
                    <h3 for="Vraag4">Hoe veel personen wonen in uw huis</h3>
                    <input type="radio" name="Vraag4" id="Vraag4a" checked required value="0">
                    <label for="Vraag4a">1-2 personen</label><br>
                    <input type="radio" name="Vraag4" id="Vraag4b" required value="1">
                    <label for="Vraag4b">3-4 personen</label><br>
                    <input type="radio" name="Vraag4" id="Vraag4c" required value="2">
                    <label for="Vraag4c">5-6 personen</label><br>
                    <input type="radio" name="Vraag4" id="Vraag4d" required value="3">
                    <label for="Vraag4d">Meer dan 6 personen</label><br>

                    <!-- Vraag5 ( 0-3 Punten ) -->
                    <h3 for="Vraag5">6.	Wat voor omgeving staat uw woning</h3>
                    <input type="radio" name="Vraag5" id="Vraag5a" checked required value="0">
                    <label for="Vraag5a">In een bos</label><br>
                    <input type="radio" name="Vraag5" id="Vraag5b" required value="2">
                    <label for="Vraag5b">In een rijtjes huis</label><br>
                    <input type="radio" name="Vraag5" id="Vraag5c" required value="3">
                    <label for="Vraag5c">Alleen staand huis</label><br>
                    <input type="radio" name="Vraag5" id="Vraag5d" required value="1">
                    <label for="Vraag5d">Bij een vliegveld</label><br>

                    <!-- Vraag6 ( 0-3 Punten ) -->
                    <h3 for="Vraag6">Hoeveel direct zonlicht krijgt uw dak gedurende de dag?</h3>
                    <input type="radio" name="Vraag6" id="Vraag6a" checked required value="3">
                    <label for="Vraag6a">Veel zonlicht, bijna de hele dag door</label><br>
                    <input type="radio" name="Vraag6" id="Vraag6b" required value="2">
                    <label for="Vraag6b">Matig, soms is er schaduw</label><br>
                    <input type="radio" name="Vraag6" id="Vraag6c" required value="0">
                    <label for="Vraag6c">Weinig, er is veel schaduw van gebouwen of bomen </label><br>
                    <input type="radio" name="Vraag6" id="Vraag6d" required value="2">
                    <label for="Vraag6d">Ik weet het niet</label><br>

                    <!-- Vraag7 ( 0-3 Punten ) -->
                    <h3 for="Vraag7">Hoe oud is uw dak</h3>
                    <input type="radio" name="Vraag7" id="Vraag7a" checked required value="3">
                    <label for="Vraag7a">Minder dan 5 jaar oud</label><br>
                    <input type="radio" name="Vraag7" id="Vraag7b" required value="2">
                    <label for="Vraag7b">Tussen 5 en 10 jaar oud</label><br>
                    <input type="radio" name="Vraag7" id="Vraag7c" required value="1">
                    <label for="Vraag7c">Tussen 10 en 15 jaar oud</label><br>
                    <input type="radio" name="Vraag7" id="Vraag7d" required value="0">
                    <label for="Vraag7d">Ouder dan 15 jaar oud</label><br>

                    <!-- Vraag8 ( 0-3 Punten ) -->
                    <h3 for="Vraag8">Hoe verwarmt u uw huis</h3>
                    <input type="radio" name="Vraag8" id="Vraag8a" checked required value="0">
                    <label for="Vraag8a">Gas </label><br>
                    <input type="radio" name="Vraag8" id="Vraag8b" required value="2">
                    <label for="Vraag8b">Elektrisch</label><br>
                    <input type="radio" name="Vraag8" id="Vraag8c" required value="1">
                    <label for="Vraag8c">Kachel</label><br>
                    <input type="radio" name="Vraag8" id="Vraag8d" required value="3">
                    <label for="Vraag8d">Warmte pomp</label><br>

                    <!-- Vraag9 ( 0-3 Punten ) -->
                    <h3 for="Vraag9">Heeft u veel schaduwproblemen op uw dak die moeten worden aangepakt voordat de zonnepanelen worden geïnstalleerd?</h3>
                    <input type="radio" name="Vraag9" id="Vraag9a" checked required value="2">
                    <label for="Vraag9a">Ja, ik wil dat aanpassen</label><br>
                    <input type="radio" name="Vraag9" id="Vraag9b" required value="1">
                    <label for="Vraag9b">Nee, ik wil mijn huidige situatie niet veranderen</label><br>
                    <input type="radio" name="Vraag9" id="Vraag9c" required value="2">
                    <label for="Vraag9c">Misschien, ik ben er niet zeker van. </label><br>
                    <input type="radio" name="Vraag9" id="Vraag9d" required value="3">
                    <label for="Vraag9d">Er zijn geen schaduwproblemen op mijn dak.</label><br>


                    <!-- Vraag10 ( 0-3 Punten ) -->
                    <h3 for="Vraag10">Wat is uw budget voor zonnepanelen</h3>
                    <input type="radio" name="Vraag10" id="Vraag10a" checked required value="0">
                    <label for="Vraag10a">Minder dan €5.000</label><br>
                    <input type="radio" name="Vraag10" id="Vraag10b" required value="1">
                    <label for="Vraag10b">Tussen €5.000 en €10.000</label><br>
                    <input type="radio" name="Vraag10" id="Vraag10c" required value="2">
                    <label for="Vraag10c">Tussen €10.000 en €15.000</label><br>
                    <input type="radio" name="Vraag10" id="Vraag10d" required value="3">
                    <label for="Vraag10d">Meer dan €15.000</label><br>

                    <!-- Vraag11 ( 0-3 Punten ) -->
                    <h3 for="Vraag11">Heeft uw meterkast al een omvormer voor zonnepanelen</h3>
                    <input type="radio" name="Vraag11" id="Vraag11a" checked required value="3">
                    <label for="Vraag11a">Ja zekers!</label><br>
                    <input type="radio" name="Vraag11" id="Vraag11b" required value="2">
                    <label for="Vraag11b">Ja volgens mij wel</label><br>
                    <input type="radio" name="Vraag11" id="Vraag11c" required value="1">
                    <label for="Vraag11c">Nee</label><br>
                    <input type="radio" name="Vraag11" id="Vraag11d" required value="0">
                    <label for="Vraag11d">Weet ik niet</label><br>

                    <!-- Vraag12 ( 0-3 Punten ) -->
                    <h3 for="Vraag12">Wat is uw geschatte jaarlijkse elektriciteitsverbruik (in kWh)?</h3>
                    <input type="radio" name="Vraag12" id="Vraag12a" checked required value="0">
                    <label for="Vraag12a">Minder dan 3000 kWh</label><br>
                    <input type="radio" name="Vraag12" id="Vraag12b" required value="1">
                    <label for="Vraag12b">3000-6000 kWh</label><br>
                    <input type="radio" name="Vraag12" id="Vraag12c" required value="2">
                    <label for="Vraag12c">6000-9000 kWh</label><br>
                    <input type="radio" name="Vraag12" id="Vraag12d" required value="3">
                    <label for="Vraag12d">Meer dan 9000 kWh</label><br>

                    <!-- Vraag13 ( 0-3 Punten ) -->
                    <h3 for="Vraag13">Bent u eigenaar van de woning waarop u de zonnepanelen wilt installeren?</h3>
                    <input type="radio" name="Vraag13" id="Vraag13a" checked required value="3">
                    <label for="Vraag13a">Ja, ik ben eigenaar</label><br>
                    <input type="radio" name="Vraag13" id="Vraag13b" required value="0">
                    <label for="Vraag13b">Nee, ik huur</label><br>
                    <input type="radio" name="Vraag13" id="Vraag13c" required value="2">
                    <label for="Vraag13c">Ik ben mede-eigenaar (bijvoorbeeld met partner)</label><br>
                    <input type="radio" name="Vraag13" id="Vraag13d" required value="2">
                    <label for="Vraag13d">Anders</label><br>

                    <!-- Vraag14 ( 2-3 Punten ) -->
                    <h3 for="Vraag14">Wat is uw hoofddoel bij het overwegen van zonnepanelen?</h3>
                    <input type="radio" name="Vraag14" id="Vraag14a" checked required value="3">
                    <label for="Vraag14a">Geld besparen op energierekeningen</label><br>
                    <input type="radio" name="Vraag14" id="Vraag14b" required value="3">
                    <label for="Vraag14b">Bijdragen aan milieubehoud</label><br>
                    <input type="radio" name="Vraag14" id="Vraag14c" required value="2">
                    <label for="Vraag14c">Onafhankelijkheid van het energienet</label><br>
                    <input type="radio" name="Vraag14" id="Vraag14d" required value="2">
                    <label for="Vraag14d">Andere reden/ Ik weet het niet</label><br>

                    <!-- Submit Button -->
                    <label for="submit"></label>
                    <input type="submit" class="input4 button" id="verzenden" name="submit"  required style="margin-left: 0px; margin-top: 50px">

                </form>
                <?php
                }
                //if form has been send to server Calculate And show Result.
                else
                {
                    //Pagina Titel
                    echo "<h1>Uw resultaat</h1>";

                    //variable met aantal punten (0-45) Punten
                    $Punten = 0;
                    //Max Punten
                    $MaxPunten = 0;
                    //set punten from session
                    if(isset($_SESSION['Result']))
                    {
                        //calculate max punten
                        for ($i = 0; $i < 15; $i++)
                        {
                            //add to maxpoints
                            $MaxPunten += 3;
                        }
                        //load the points form session variable
                        $Punten = $_SESSION['Result'];
                    }
                    else
                    {

                        //alle punten van de vragen optellen
                        for ($i = 0; $i < 15; $i++)
                        {
                            $MaxPunten += 3;
                            //check of de specifieke vraag is beantwoord
                            if(isset($_POST['Vraag' . ($i)]))
                            {
                                //tel de punten op in variable $Punten
                                $Punten += $_POST['Vraag' . ($i)];
                            }
                            //store the amout of points in a session variable
                            $_SESSION['Result'] = $Punten;
                        }
                    }


                    //laat punten zien en het verschil tussen de max punten
                    echo "<p>U heeft " . $Punten . " punten u had er nog " . ($MaxPunten - $Punten) . " nodig voor een perfecte score van ". $MaxPunten."</p>";

                    // give personal message acording to the amount of gained points
                    if($Punten < 15)
                    {
                        echo "<p>Wij denken dat zonnenpanelen niet iets is voor u.</p>".
                             "<p>Dus wij raden het af.</p>".
                             "<p>voor meer info <a href='#contact' style='color: -webkit-link'>Neem Contact op</a></p>";
                    }
                    //Past warschijnlijk wel bij u
                    elseif($Punten < 30)
                    {
                        echo "<p>Wij denken dat zonnenpanelen warschijnlijk wel bij u passen.</p>".
                            "<p>Dus denk er overna. en maak een afspraak</p>".
                            "<p>voor meer info <a href='#contact' style='color: -webkit-link'>Neem Contact op</a></p>";
                    }
                    //Past wel bij u
                    elseif($Punten < 40)
                    {
                        echo "<p>Wij raden u aan om zonnenpanelen aanteschaffen.</p>".
                            "<p>Dus Maak nu een afspraak</p>".
                            "<p>voor meer <a href='#contact' style='color: -webkit-link'>Neem Contact op</a></p>";
                    }
                    //Past goed wel bij u
                    else
                    {
                        echo "<p>Wij raden u strek aan om zonnenpanelen aanteschaffen.</p>".
                            "<p>Dus Maak nu meteen een afspraak</p>".
                            "<p>voor meer <a href='#contact' style='color: -webkit-link'>Neem Contact op</a></p>";
                    }
                    //add horizontal line
                    echo "<hr>";
                    //loop thue all questions and there max values
                    for ($i = 0; $i < 15; $i++) {
                        echo "<p>Na vraag " . ($i+1) . " kun je " . ($i+1) * 3 . " punten behalen";
                        if(isset($_POST['Vraag' . ($i)]))
                        {
                            echo ' u heeft er ' .$_POST['Vraag' . ($i)];
                        }
                        echo "</p>";
                    }
                }
                ?>

            </article>
        </main>
        <footer>
            <?php
            //include footer
            include "../includes/footer.php" ;
            ?>
        </footer>
    </body>
</html>