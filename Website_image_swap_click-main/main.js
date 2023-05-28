const header = document.querySelector('header');
const h1 = document.querySelector('h1');
let image =true;
let title = true;

const changeImagefn = () =>{
    image = !image;
    title =!title;
    header.style.backgroundImage = image ? 'url(baloon.jpg)' : 'url(bee.jpg)'
    h1.textContent = title ?'Baloon' : 'Bee';

};

header.addEventListener('click', changeImagefn);