// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
document.getElementById("burger").addEventListener("click", function () {
    document.getElementById("burgerContainer").classList.toggle("burger-is-active");
    document.getElementById("burger").classList.toggle("is-active");
    document.getElementById("sidebar").classList.toggle("sidebar-is-active");
});

$('#coop-table').TableBodyScroll({
    height: 50
});

$('#employer-table').TableBodyScroll({
    height: 50
});