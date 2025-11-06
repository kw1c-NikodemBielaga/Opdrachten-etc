/*
	Nikodem Bielaga
	06-02-2024
	praktijkopdracht
*/
// Selecteer alle knoppen om de opties weer te geven
const showButtons = document.querySelectorAll('.show, .show1, .show2, .show3, .show4');
// Selecteer alle div-elementen die de opties bevatten
const optionsDivs = document.querySelectorAll('.options, .options1, .options2, .options3, .options4');

// Voeg een eventlistener toe aan elk weergevenknop element
showButtons.forEach((button, index) =>
{
    button.addEventListener('mouseover', function()
    {
        // Verberg alle optiedivs behalve degene die overeenkomt met de huidige knop
        optionsDivs.forEach((div, divIndex) =>
        {
            if (divIndex !== index)
            {
                div.style.display = 'none';
            }
        });
        // Toon de optiediv die overeenkomt met de huidige knop
        optionsDivs[index].style.display = 'block';
    });

    // Verberg de optiedivs wanneer de muiscursor de knop verlaat
    button.addEventListener('mouseout', function()
    {
        optionsDivs[index].style.display = 'none';
    });
});

// Definieer de index van de huidige afbeelding en de array van afbeeldingsbronnen
var currentImageIndex = 0;
var images =
    [
        "images/trainstation073-header-077.jpg",
        "images/trainstation073-header-06.jpg",
        "images/trainstation073-header-05.jpg"
];

// Functie om naar de vorige afbeelding te gaan
function prevImage()
{
    currentImageIndex = (currentImageIndex - 1 + images.length) % images.length;
    updateBackground();
}

// Functie om naar de volgende afbeelding te gaan
function nextImage()
{
    currentImageIndex = (currentImageIndex + 1) % images.length;
    updateBackground();
}

// Functie om de achtergrondafbeelding bij te werken
function updateBackground()
{
    document.body.style.backgroundImage = "url(" + images[currentImageIndex] + ")";
}

// Selecteer alle dia's
let slide = document.querySelectorAll('.slide');
let current = 0;

// Verberg alle dia's
function cls() {
    for (let i = 0; i < slide.length; i++)
    {
        slide[i].style.display = 'none';
    }
}

// Ga naar de volgende dia
function next()
{
    cls();
    if (current === slide.length - 1) current = -1;
    current++;
    slide[current].style.display = 'block';
}

// Ga naar de vorige dia
function prev()
{
    cls();
    if (current === 0) current = slide.length;
    current--;
    slide[current].style.display = 'block';
}

// Start de diavoorstelling
function start()
{
    cls();
    slide[current].style.display = 'block';
}
start();

