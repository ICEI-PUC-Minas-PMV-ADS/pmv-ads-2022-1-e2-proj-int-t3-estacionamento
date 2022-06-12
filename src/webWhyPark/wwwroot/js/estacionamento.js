document.getElementById('gerenciarEst').style.display = "block"
document.getElementById('cadVagas').style.display = "none"
document.getElementById('clientes').style.display = "none"
document.getElementById('entradaSaida').style.display = "none"
document.getElementById('listaEntradaSaida').style.display = "none"
document.getElementById('PrecoHora').style.display = "none"
document.getElementById('caixa').style.display = "none"
document.getElementById('msgEsta').style.display = "none"
document.getElementById('helpEst').style.display = "none"




const gerenciarConta = () =>{

    document.getElementById('gerenciarEst').style.display = "block"
    document.getElementById('cadVagas').style.display = "none"
    document.getElementById('clientes').style.display = "none"
    document.getElementById('entradaSaida').style.display = "none"
    document.getElementById('listaEntradaSaida').style.display = "none"
    document.getElementById('PrecoHora').style.display = "none"
    document.getElementById('caixa').style.display = "none"
    document.getElementById('msgEsta').style.display = "none"
    document.getElementById('helpEst').style.display = "none"
}


const cadVaga = ()=>{
    document.getElementById('gerenciarEst').style.display = "none"
    document.getElementById('cadVagas').style.display = "block"
    document.getElementById('clientes').style.display = "none"
    document.getElementById('entradaSaida').style.display = "none"
    document.getElementById('listaEntradaSaida').style.display = "none"
    document.getElementById('PrecoHora').style.display = "none"
    document.getElementById('caixa').style.display = "none"
    document.getElementById('msgEsta').style.display = "none"
    document.getElementById('helpEst').style.display = "none"
}

const clientesList = () => {
    document.getElementById('gerenciarEst').style.display = "none"
    document.getElementById('cadVagas').style.display = "none"
    document.getElementById('clientes').style.display = "block"
    document.getElementById('entradaSaida').style.display = "none"
    document.getElementById('listaEntradaSaida').style.display = "none"
    document.getElementById('PrecoHora').style.display = "none"
    document.getElementById('caixa').style.display = "none"
    document.getElementById('msgEsta').style.display = "none"
    document.getElementById('helpEst').style.display = "none"
}

const entradaSaidaFunc = ()=>{
    document.getElementById('gerenciarEst').style.display = "none"
    document.getElementById('cadVagas').style.display = "none"
    document.getElementById('clientes').style.display = "none"
    document.getElementById('entradaSaida').style.display = "block"
    document.getElementById('listaEntradaSaida').style.display = "none"
    document.getElementById('PrecoHora').style.display = "none"
    document.getElementById('caixa').style.display = "none"
    document.getElementById('msgEsta').style.display = "none"
    document.getElementById('helpEst').style.display = "none"
}


const listaEntradaSaidaFunc = ()=>{
    document.getElementById('gerenciarEst').style.display = "none"
    document.getElementById('cadVagas').style.display = "none"
    document.getElementById('clientes').style.display = "none"
    document.getElementById('entradaSaida').style.display = "none"
    document.getElementById('listaEntradaSaida').style.display = "block"
    document.getElementById('PrecoHora').style.display = "none"
    document.getElementById('caixa').style.display = "none"
    document.getElementById('msgEsta').style.display = "none"
    document.getElementById('helpEst').style.display = "none"
}

const PrecoHoraFunc = ()=>{
    document.getElementById('gerenciarEst').style.display = "none"
    document.getElementById('cadVagas').style.display = "none"
    document.getElementById('clientes').style.display = "none"
    document.getElementById('entradaSaida').style.display = "none"
    document.getElementById('listaEntradaSaida').style.display = "none"
    document.getElementById('PrecoHora').style.display = "block"
    document.getElementById('caixa').style.display = "none"
    document.getElementById('msgEsta').style.display = "none"
    document.getElementById('helpEst').style.display = "none"
}


const caixaFunc = ()=>{
    document.getElementById('gerenciarEst').style.display = "none"
    document.getElementById('cadVagas').style.display = "none"
    document.getElementById('clientes').style.display = "none"
    document.getElementById('entradaSaida').style.display = "none"
    document.getElementById('listaEntradaSaida').style.display = "none"
    document.getElementById('PrecoHora').style.display = "none"
    document.getElementById('caixa').style.display = "block"
    document.getElementById('msgEsta').style.display = "none"
    document.getElementById('helpEst').style.display = "none"
}


const mensagem = ()=>{
    document.getElementById('gerenciarEst').style.display = "none"
    document.getElementById('cadVagas').style.display = "none"
    document.getElementById('clientes').style.display = "none"
    document.getElementById('entradaSaida').style.display = "none"
    document.getElementById('listaEntradaSaida').style.display = "none"
    document.getElementById('PrecoHora').style.display = "none"
    document.getElementById('caixa').style.display = "none"
    document.getElementById('msgEsta').style.display = "block"
    document.getElementById('helpEst').style.display = "none"
}



const infofunc = ()=>{
    document.getElementById('gerenciarEst').style.display = "none"
    document.getElementById('cadVagas').style.display = "none"
    document.getElementById('clientes').style.display = "none"
    document.getElementById('entradaSaida').style.display = "none"
    document.getElementById('listaEntradaSaida').style.display = "none"
    document.getElementById('PrecoHora').style.display = "none"
    document.getElementById('caixa').style.display = "none"
    document.getElementById('msgEsta').style.display = "none"
    document.getElementById('helpEst').style.display = "block"

}




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
