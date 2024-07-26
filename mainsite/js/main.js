const descriptionText = document.querySelector("#description_text");
const titleText = document.querySelector("#challenge_title");

const imperfectPast = document.querySelector("#imperfect_past");

imperfectPast.addEventListener("click", function() {
    descriptionText.textContent = "We are constantly changing, constantly improving. Ad Infinitum";
    titleText.textContent = "Imperfect Past"
});