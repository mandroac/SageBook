"use strict";

var connection = new signalR.HubConnectionBuilder().withUrl("/chatHub").build();

$(function () {
    connection.start().then(() => {
        console.log("Connected to /chatHub");
    }).catch((err) => {
        console.log(err)
    })
})

connection.on("ReceiveChatMessage", function (message) {
    console.log(message.sendDate)
    const date = new Date(message.sendDate)
    $('#discussion_' + message.bookId).append('<tr>'
        + '<td style="text-align:center">' + message.sender.email + '</td>'
        + '<td>' + message.content + '</td>'
        + '<td style= "text-align:center">' + date.toLocaleDateString('uk-ua', { day: '2-digit', month: 'short', hour: '2-digit', minute: '2-digit', second: '2-digit' }) + '</td>'
        + '</tr>')
})

