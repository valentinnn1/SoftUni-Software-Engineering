const template = x => `visited ${x} times`;
const links = {
  "Google": 2,
  "YouTube": 4,
  "SoftUni": 1,
  "Gmail": 7,
  "Wikipedia": 4,
  "stackoverflow": 6,
}

document.addEventListener("click", (e) => {
  // filter by className, not nodeName
  if (e.target.classList.contains("linkCta")) {
    e.target.parentNode.querySelector(".linkOut").innerHTML = template(links[e.target.textContent.trim()]++)
  }
})