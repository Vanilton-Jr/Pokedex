function luz() {
    var sidenav = document.getElementById("accordionSidebar");
    sidenav.classList.remove("sidebar-pokemon");
    var topnav = document.getElementById("topnav");
    topnav.classList.add("bg-warning");
    document.querySelector("body").style.backgroundColor = "black";
    document.querySelector("body").style.color = "white";
}


function efetividade() {
    document.querySelector(".efetividade-area-dtls").style.visibility = "visible";
    document.querySelector(".efetividade-title").style.color = "#0086F3";
    document.querySelector(".move-title-dtls").style.color = "gray";
}

function moves() {
    document.querySelector(".efetividade-area-dtls").style.visibility = "hidden";
    document.querySelector(".move-title-dtls").style.color = "#E7005B";
    document.querySelector(".efetividade-title").style.color = "gray";
}

var tipo1 = @Model.Tipo1;
var fundo = document.querySelector("#fundo");

if (tipo1 == "FOGO") {
    fundo.classList.remove("plano-efeito-fantasma");
    fundo.classList.add("plano-efeito-fogo");
}

var valor = document.getElementById("id").Value