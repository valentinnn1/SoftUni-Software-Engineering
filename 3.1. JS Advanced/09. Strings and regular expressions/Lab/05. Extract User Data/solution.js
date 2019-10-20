function solve() {
  const input = JSON.parse(document.getElementById("arr").value);
  const result = document.getElementById("result");

  let namePattern = /[A-Z][a-z]* [A-Z][a-z]*/g;
  let phonePattern = /\+359( |-)[\d]{1}(\1)[\d]{3}(\1)[\d]{3}/g;
  let emailPattern = /[a-z/d]+@[a-z]+.[a-z]{2,3}/g;
  let pattern = /^[A-Z][a-z]* [A-Z][a-z]* \+359( |-)[\d]{1}(\1)[\d]{3}(\1)[\d]{3} [a-z/d]+@[a-z]+.[a-z]{2,3}/g;

  input.forEach(el => {
    if (!pattern.test(el)) {
      p1 = document.createElement("p");
      p1.textContent = `Invalid data`;
      result.appendChild(p1);

      p2 = document.createElement("p");
      p2.textContent = `- - -`;
      result.appendChild(p2);
    } else {
      p1 = document.createElement("p");
      p1.textContent = "Name: " + el.match(namePattern);
      result.appendChild(p1);

      p2 = document.createElement("p");
      p2.textContent = "Phone Number: " + el.match(phonePattern);
      result.appendChild(p2);

      p3 = document.createElement("p");
      p3.textContent = "Email: " + el.match(emailPattern);
      result.appendChild(p3);

      p4 = document.createElement("p");
      p4.textContent = `- - -`;
      result.appendChild(p4);
    }
  });
}
