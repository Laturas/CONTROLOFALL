const descriptionText = document.querySelector("#description_text_segment_1");
const descriptionText2 = document.querySelector("#description_text_segment_2");
const titleText = document.querySelector("#challenge_title");

const dlButton = document.querySelector("#dl_button");
const dlTxt = document.querySelector("#dl_txt_id");

dlButton.style.display = "none";

function getSolutionStatuses() {
    var xhr = new XMLHttpRequest();
    //console.log("getting http://localhost:8080/");
    xhr.onprogress = function() {
        console.log(JSON.parse(xhr.response).imperfectPastStatus);
        console.log(xhr.response);
    };
    
    xhr.open("GET", "http://localhost:8080/", true);
    //xhr.setRequestHeader("Access-Control-Allow-Origin", "*");
    xhr.send();
}

function sendSolutionToBackend(solution) {
    var xhr = new XMLHttpRequest();
    //console.log("posting");
    xhr.onprogress = function() {
        return;
    };
    let link = "http://localhost:8080/" + solution + "/";
    //console.log("Posting to: " + link);
    
    xhr.open("POST", link, true);
    //xhr.setRequestHeader("Access-Control-Allow-Origin", "*");
    xhr.send();
}