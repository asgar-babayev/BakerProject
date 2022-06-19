function openNav() {
    document.getElementById("mySidenav").style.width = "400px";
    document.getElementById("mySidenav").style.paddingLeft = "40px";
    document.querySelector(".cat").classList.add("z-1")
}

function closeNav() {
    document.getElementById("mySidenav").style.width = "0px";
    document.getElementById("mySidenav").style.paddingLeft = "0px";
    document.querySelector(".cat").classList.remove("z-1")
}

$(document).ready(function () {
    if (document.querySelectorAll(".card").length > 3) {
        $("footer").removeClass("pt-35");
    }
    else {
        $("footer").addClass("pt-35");
    }
})

$("#cart").hover(function () {
    $(".cardimg").toggleClass("z-1");
    $(".cat").toggleClass("z-1");
})

let arr = document.querySelectorAll(".addcart");

$(".cardimg").hover(function () {
    let id = $(this).attr("data-id");
    arr.forEach(x => {
        if (x.getAttribute("data-target") == id) {
            x.classList.toggle("h-0");
            x.classList.add("c-pointer");
        }
    })
})


let btnall = document.querySelector(".btnall");
let btns = document.querySelectorAll(".catbtns");
let cards = document.querySelectorAll(".cardimg");


function getAllPorducts() {
    cards.forEach(y => {
        y.classList.remove("d-none");
    })
}

btnall.addEventListener("click", function () {
    getAllPorducts();
})

btns.forEach(x => {
    x.addEventListener("click", function () {
        let dataId = this.getAttribute("data-id");
        cards.forEach(y => {
            if (dataId == y.getAttribute("data-ci-target")) {
                y.classList.remove("d-none");
            }
            else
                y.classList.add("d-none");
        })
    })
})



window.onscroll = function scrollFunction() {
    if (document.body.scrollTop > 20 || document.documentElement.scrollTop > 20) {
        document.querySelector(".hero").classList.remove("bg-transparent");
        document.querySelector(".hero").classList.add("bg-dark");

    } else {
        document.querySelector(".hero").classList.add("bg-transparent");
        document.querySelector(".hero").classList.remove("bg-dark");
    }
}