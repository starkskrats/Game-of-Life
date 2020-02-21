// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your Javascript code.
var c = document.getElementById("gameBoard");
var ctx = c.getContext("2d");
for (var i = 0; i < 20; i++) {
    var x = 30 * i;
    ctx.moveTo(x, 0);
    ctx.lineTo(x, 500);
    ctx.stroke();
}
for (var i = 0; i < 20; i++) {
    var x = 25 * i;
    ctx.moveTo(0, x);
    ctx.lineTo(600, x);
    ctx.stroke();
}