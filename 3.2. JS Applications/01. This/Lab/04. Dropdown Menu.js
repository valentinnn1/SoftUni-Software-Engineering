function solve() {
  const ul = document.getElementById("dropdown-ul");
  ul.style.display = "";
  const box = document.getElementById("box");

  const dropdown = document.getElementById("dropdown");
  dropdown.addEventListener("click", show);

  function show(ev) {
    if (ul.style.display === "none" || ul.style.display === "") {
      ul.style.display = "block";
      box.style["background-color"] = "black";
      box.style["color"] = "white";
      ul.addEventListener("click", changeColor);
    } else {
      ul.style.display = "none";
      box.style["background-color"] = "black";
      box.style["color"] = "white";
    }
  }

  function changeColor(ev) {
    if (ev.target.nodeName === "LI") {
      box.style["background-color"] = ev.target.textContent;
      box.style["color"] = "black";
    } else {
      box.style["color"] = "black";
    }
  }
}
