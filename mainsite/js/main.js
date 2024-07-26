const descriptionText = document.querySelector("#description_text_segment_1");
const descriptionText2 = document.querySelector("#description_text_segment_2");
const titleText = document.querySelector("#challenge_title");
const dlButton = document.querySelector("#dl_button");

const imperfectPast = document.querySelector("#imperfect_past");
const whereAreWeGoing = document.querySelector("#where_are_we_going");
const powerCube = document.querySelector("#power_cube");
dlButton.style.display = "none";

imperfectPast.addEventListener("click", function() {
    descriptionText.textContent = "We are constantly changing, constantly improving, making missteps. From our roots are where we sprout.";
    descriptionText2.textContent = "(Hint: What does the URL of this site tell you?)";
    titleText.textContent = "Imperfect Past";
    
    dlButton.style.display = "none";
});
whereAreWeGoing.addEventListener("click", function() {
    descriptionText.textContent = "I forgot which one this is mb";
    descriptionText2.textContent = "";
    titleText.textContent = "Where Are We Going?";

    dlButton.style.display = "none";
});
powerCube.addEventListener("click", function() {
    descriptionText.textContent = "Power...?";
    descriptionText2.textContent = "";
    titleText.textContent = "The Power to Make It Right";
    dlButton.style.display = "flex";
});