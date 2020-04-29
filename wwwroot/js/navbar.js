const toggleButton = document.getElementsByClassName('toggle-menu-button-SC')[0];
const navbarLinks = document.getElementsByClassName('navbar-links-SC')[0];

toggleButton.addEventListener('click', () => {
    navbarLinks.classList.toggle('active');
} )