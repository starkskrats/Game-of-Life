"use strict";
var red = 0;
var green = 0;
var blue = 0;

var canvas = document.getElementById("gameBoard");
var ctx = canvas.getContext("2d");

var connection = new signalR.HubConnectionBuilder().withUrl("/game").build();

connection.on("ReceiveBoard", (board) => {
    ctx.clearRect(0, 0, canvas.width, canvas.height);
    for (var i = 0; i < 19; i++) {
        var x = 32 * i;
        ctx.moveTo(x, 0);
        ctx.lineTo(x, 608);
        ctx.stroke();
    }
    for (var i = 0; i < 19; i++) {
        var x = 32 * i;
        ctx.moveTo(0, x);
        ctx.lineTo(608, x);
        ctx.stroke();
    }
    for (var i = 22; i < 419; i++) {
        var placement = i % 21;
        if ((placement == 0) || (placement == 20) || !board[i].isAlive)
            continue;
        ctx.fillStyle = 'rgb(' + board[i].red + ', ' + board[i].green + ', ' + board[i].blue + ')';
        var row = Math.trunc(i / 21) - 1;
        var col = Math.trunc(i % 21) - 1;
        ctx.fillRect(col * 32, row * 32, 32, 32);
    }
});

connection.start().then(function () {
    connection.invoke("SendClick", 0, -1, -1, -1).catch(err => console.error(err.toString()));
}).catch(function (err) {
    return console.error(err.toString());
});

document.getElementById("gameBoard").addEventListener("click", function (event) {
    if (red == 0 && green == 0 && blue == 0) {
        alert('Please select a color first!');
        return false;
    }
    var canvasBounds = canvas.getBoundingClientRect();
    var col = Math.trunc((event.clientX - canvasBounds.left) / 32);
    var row = Math.trunc((event.clientY - canvasBounds.top) / 32) + 1;
    var index = ((row * 21) + 1) + col;
    connection.invoke("SendClick", index, red, green, blue).catch(err => console.error(err.toString()));
    event.preventDefault();
});

$("#red").click(function(){
    $("#choose").hide();
    $("#current").text("Current color: RED");
    $("#current").show();
    red = 255;
    green = 0;
    blue = 0;
});

$("#orange").click(function(){
    $("#choose").hide();
    $("#current").text("Current color: ORANGE");
    $("#current").show();
    red = 255;
    green = 165;
    blue = 0;
});

$("#yellow").click(function(){
    $("#choose").hide();
    $("#current").text("Current color: YELLOW");
    $("#current").show();
    red = 255;
    green = 255;
    blue = 0;
});

$("#green").click(function(){
    $("#choose").hide();
    $("#current").text("Current color: GREEN");
    $("#current").show();
    red = 0;
    green = 255;
    blue = 0;
});

$("#blue").click(function(){
    $("#choose").hide();
    $("#current").text("Current color: BLUE");
    $("#current").show();
    red = 0;
    green = 0;
    blue = 255;
});

$("#purple").click(function(){
    $("#choose").hide();
    $("#current").text("Current color: PURPLE");
    $("#current").show();
    red = 128;
    green = 0;
    blue = 128;
});

$("#next").click(function(){
    connection.invoke("Next").catch(err => console.error(err.toString()));
});