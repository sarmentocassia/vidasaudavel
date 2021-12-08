// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
function Cadastrar() {
    let parametros = {

        Nome: $("#nome").val(),
        Email: $("#email").val(),
        Mensagem: $("#mensagem").val()

    }

    alert(parametros);

    $.post("Home/Cadastrar",parametros)
    .done(alert("Sucesso"))
    .fail(alert("Erro"))
}