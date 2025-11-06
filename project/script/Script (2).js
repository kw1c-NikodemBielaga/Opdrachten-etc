

// Zoek het HTML-element met de class 'bx-menu' en wijs het toe aan de variabele menuIcon
const menuIcon = document.querySelector('.bx-menu');
    
// Zoek het HTML-element met de class 'navlist' en wijs het toe aan de variabele navList
const navList = document.querySelector('.navlist');

// Voeg een click-eventlistener toe aan het menu-icoon
menuIcon.addEventListener('click', function () 
{
    // Controleer of de stijl van het navigatielijstelement is ingesteld op 'block'
if (navList.style.display === 'block') 
{
    // Als het zo is, verander het naar 'none' om het te verbergen
navList.style.display = 'none';
} 
else 
{
// Als het niet zo is, verander het naar 'block' om het zichtbaar te maken
    navList.style.display = 'block';
}
});