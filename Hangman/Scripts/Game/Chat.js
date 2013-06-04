var $chatWindow = $("#chatWindow");

function postComplete(chat) {
    $chatWindow.append("<p>" + chat.message + "</p>").hide().fadeIn(2000);
};