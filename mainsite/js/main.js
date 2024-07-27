const descriptionText = document.querySelector("#description_text_segment_1");
const descriptionText2 = document.querySelector("#description_text_segment_2");
const titleText = document.querySelector("#challenge_title");

const dlButton = document.querySelector("#dl_button");
const dlTxt = document.querySelector("#dl_txt_id");

const imperfectPast = document.querySelector("#imperfect_past");
const paranoid = document.querySelector("#where_are_we_going");
const powerCube = document.querySelector("#power_cube");
const loseItAll = document.querySelector("#what_can_we_lose");
const theoremsAndDreams = document.querySelector("#theorems_and_dreams");
const connections = document.querySelector("#connections");
const imLost = document.querySelector("#im_lost");
const theyKnewMyName = document.querySelector("#they_knew_my_name");
const behindTheCurtain = document.querySelector("#behind_the_curtain");

dlButton.style.display = "none";

imperfectPast.addEventListener("click", function() {
    descriptionText.textContent = "We are constantly changing, constantly improving, making missteps. From our roots are where we sprout.";
    descriptionText2.textContent = "(Hint: What does the URL of this site tell you?)";
    titleText.textContent = "Imperfect Past";
    
    dlButton.style.display = "none";
    clearText();
});
paranoid.addEventListener("click", function() { // This is the cipher one
    descriptionText.textContent = "They could find out the secret, they have everything they'd need.";
    descriptionText2.textContent = "I'm not ready for them to know.";
    titleText.textContent = "Paranoid";

    dlButton.style.display = "none";
    answer = paranoidKey;
    clearText();
});
powerCube.addEventListener("click", function() {
    descriptionText.textContent = "Power...?";
    descriptionText2.textContent = "";
    titleText.textContent = "The Power to Make It Right";
    //dlButton.style.display = "flex";
    dlButton.style.display = "none";
    clearText();
});
loseItAll.addEventListener("click", function() {
    descriptionText.textContent = "Here I am, still holding on to every word that I say.";
    descriptionText2.textContent = "This may be what finally breaks me";
    titleText.textContent = "BREAK ME";
    dlButton.style.display = "flex";
    dlButton.href = "./Memories.zip";
    document.getElementById("dl_button_img").src="./images/ZipIcon.png";
    dlTxt.textContent = "Memories.zip";
    answer = breakMeKey;
    clearText();
});
theoremsAndDreams.addEventListener("click", function() {
    descriptionText.textContent = "What if we went down a different path?";
    descriptionText2.textContent = "Chose a different life?";
    titleText.textContent = "Theorems and Dreams";
    dlButton.style.display = "flex";
    dlButton.href = "./AnotherLife.pdf";
    document.getElementById("dl_button_img").src="./images/PDFicon.png";
    dlTxt.textContent = "AnotherLife.pdf";
    answer = theoremsAndDreamsKey;
    clearText();
});
connections.addEventListener("click", function() {
    descriptionText.textContent = "It's through our connections we know who we are";
    descriptionText2.textContent = "Find our connection and know what we've lost";
    titleText.textContent = "Connections";
    dlButton.style.display = "none";
    answer = connectionsKey;
    clearText();
});
imLost.addEventListener("click", function() {
    descriptionText.textContent = "I'm searching for someone... somewhere...";
    descriptionText2.textContent = "(What is the name of the restaurant in the image?)";
    titleText.textContent = "I'm Lost";
    dlButton.style.display = "none";
    clearText();
});
theyKnewMyName.addEventListener("click", function() {
    descriptionText.textContent = "Sometimes you don't need to be the best, you only need to be the first";
    descriptionText2.textContent = "{Geometry Dash Level ID When Released}";
    titleText.textContent = "And They Knew My Name";
    dlButton.style.display = "none";
    answer = gdKey;
    clearText();
});
behindTheCurtain.addEventListener("click", function() {
    descriptionText.textContent = "Ever wonder how the things we're looking at work?";
    descriptionText2.textContent = "What's going on behind the scenes?";
    titleText.textContent = "Behind the Curtain";
    dlButton.style.display = "none";
    answer = behindTheCurtainKey;
    clearText();
});