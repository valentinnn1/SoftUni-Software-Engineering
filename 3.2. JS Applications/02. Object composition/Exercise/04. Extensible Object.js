function solve() {
  let myObj = {
    extend: function(template) {
      const obj = Object.entries(template);
      for (const [key, value] of obj) {
        if (typeof value === "function") {
          Object.getPrototypeOf(this)[key] = value;
        } else {
          this[key] = value;
        }
      }
    }
  };
  return myObj;
}
solve();
