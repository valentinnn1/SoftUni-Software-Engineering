const colorMap = ["#5B88BD", "#A40014", "#8FF897"];
let state = 0;

function growingWord() {
  const word = document.getElementById("growingWord");
  if (word === null) {
    throw new Error("Error");
  }

  let fontSize = window
    .getComputedStyle(word)
    .fontSize
    .replace("px", "");

    if (state >= colorMap.length) {
      state = 0;
    }

  word.style.color = colorMap[state];
  state++;

  word.style.fontSize = (fontSize === "0" ? "2" : fontSize * 2) + "px";
}

// 2nd solution
// function growingWord() {
//   let p = document.querySelectorAll('p')[2];
//   let size = p.style.fontSize.slice(0, -2) * 2;

//   switch (p.style.color) {
//     case 'red':
//       p.style.color = 'blue';
//       break;
//     case 'green':
//       p.style.color = 'red';
//       break;
//     case 'blue':
//       p.style.color = 'green';
//       break;
//     default:
//       p.style.color = 'blue';
//       p.style.fontSize = '2px';
//       break;
//   }

//   if (size) {
//     p.style.fontSize = `${size}px`;
//   }
// }