function listProcessor(params) {
  const execute = (function() {
    let inner = [];

    return {
      add: element => {
        inner.push(element);
      },
      remove: element => {
        inner = inner.filter(x => x !== element);
      },
      print: () => {
        console.log(inner.join(","));
      }
    };
  })();

  params.forEach(tokens => {
    const [command, string] = tokens.split(/\s+/);
    execute[command](string);
  });
}
