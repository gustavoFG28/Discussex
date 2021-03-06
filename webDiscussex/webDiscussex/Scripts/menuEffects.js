var menuClose;
$(document).ready(() => {
    menuClose = true;
    fecharMenuClick();
    gerenciarMenu();
    alterarLogo();
})

function gerenciarMenu() {
    $(".menu-icon").click(() => {
        $(".menu-icon").toggleClass("change");
        alterarMenu(menuClose);
        menuClose = !menuClose;
    })
}

function fecharMenuClick() {
    $("#corpo").click(() => {
        if (!menuClose)
            $(".menu-icon").click();
    });
}

function alterarMenu(situacao) {
    if (!situacao)
    {
        $("#menu nav").slideUp();
    }
    else
    {
        $("#menu nav").slideDown();
    } 
}

function alterarLogo() {
    $("#menu").mouseover(() => {
        $("#logo").attr("src", "/img/LogoDark.png");
    });
    $("#menu").mouseout(() => {
        $("#logo").attr("src", "/img/Logo.png");
    });
}