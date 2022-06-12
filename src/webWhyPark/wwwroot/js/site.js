// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

document.getElementById('gerenciar').style.display = "block"
document.getElementById('cadVeiculo').style.display = "none"
document.getElementById('historico').style.display = "none"
document.getElementById('favorito').style.display = "none"
document.getElementById('msg').style.display = "none"
document.getElementById('help').style.display = "none"




const gerFunction = () => {
    document.getElementById('gerenciar').style.display = "block"
    document.getElementById('cadVeiculo').style.display = "none"
    document.getElementById('historico').style.display = "none"
    document.getElementById('favorito').style.display = "none"
    document.getElementById('msg').style.display = "none"
    document.getElementById('help').style.display = "none"
}



const cadVeiculos = () => {

    document.getElementById('gerenciar').style.display = "none"
    document.getElementById('cadVeiculo').style.display = "block"
    document.getElementById('historico').style.display = "none"
    document.getElementById('favorito').style.display = "none"
    document.getElementById('msg').style.display = "none"
    document.getElementById('help').style.display = "none"
}


const  historico = () => {
    document.getElementById('gerenciar').style.display = "none"
    document.getElementById('cadVeiculo').style.display = "none"
    document.getElementById('historico').style.display = "block"
    document.getElementById('favorito').style.display = "none"
    document.getElementById('msg').style.display = "none"
    document.getElementById('help').style.display = "none"
}


const  favoritos = () => {
    document.getElementById('gerenciar').style.display = "none"
    document.getElementById('cadVeiculo').style.display = "none"
    document.getElementById('historico').style.display = "none"
    document.getElementById('favorito').style.display = "block"
    document.getElementById('msg').style.display = "none"
    document.getElementById('help').style.display = "none"
}


const  mesagem = () => {
    document.getElementById('gerenciar').style.display = "none"
    document.getElementById('cadVeiculo').style.display = "none"
    document.getElementById('historico').style.display = "none"
    document.getElementById('favorito').style.display = "none"
    document.getElementById('msg').style.display = "block"
    document.getElementById('help').style.display = "none"
}

const  info = () => {
    document.getElementById('gerenciar').style.display = "none"
    document.getElementById('cadVeiculo').style.display = "none"
    document.getElementById('historico').style.display = "none"
    document.getElementById('favorito').style.display = "none"
    document.getElementById('msg').style.display = "none"
    document.getElementById('help').style.display = "block"
}



// estacionamento 
let toggle = document.querySelector(".toggle");
let navigation = document.querySelector(".navigation");
let main = document.querySelector(".main");

toggle.onclick = function () {
  navigation.classList.toggle("active");
  main.classList.toggle("active");
};

let list = document.querySelectorAll(".navigation li");
function activeLink() {
  list.forEach((item) => item.classList.remove("hovered"));

  this.classList.add("hovered");
}
list.forEach((item) => item.addEventListener("mouseover", activeLink));
