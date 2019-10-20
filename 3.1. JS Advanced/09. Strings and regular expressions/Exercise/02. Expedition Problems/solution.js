function solve() {
  const str = document.getElementById("string");

  const text = document.getElementById("text");

  const matchedMessage = text.value
    .match(new RegExp(`${str.value}.*${str.value}`, "g"))[0]
    .replace(str.value, "")
    .replace(str.value, "");

  const locationRegex = /(north|east).*?(\d{2})[^,]*?,[^,]*?(\d{6})/gim;

  let northMatch;
  let eastMatch;

  let matched = locationRegex.exec(text.value);

  while (matched !== null) {
    if (matched[1].toLowerCase() === "north") {
      northMatch = matched;
    } else {
      eastMatch = matched;
    }
    matched = locationRegex.exec(text.value);
  }

  const result = document.getElementById("result");

  const p1 = document.createElement("p");
  const p2 = document.createElement("p");
  const p3 = document.createElement("p");

  p1.innerHTML = `${northMatch[2]}.${northMatch[3]} N`;
  p2.innerHTML = `${eastMatch[2]}.${eastMatch[3]} E`;
  p3.innerHTML = `Message: ${matchedMessage}`;

  result.appendChild(p1);
  result.appendChild(p2);
  result.appendChild(p3);
}
