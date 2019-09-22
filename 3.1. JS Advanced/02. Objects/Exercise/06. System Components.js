function systemComponents(input) {
    let systems = new Map();
    for (const line of input) {
        let tokens = line.split(' | ');
        let system = tokens[0];
        let component = tokens[1];
        let subcomponent = tokens[2];

        if (systems.has(system) == false) {
            systems.set(system, new Map());
        }
        if (systems.get(system).has(component) == false) {
            systems.get(system).set(component, []);
        }
        systems.get(system).get(component).push(subcomponent);
    }

    let systemsSorted = new Map(
        Array.from(systems)
            .sort((a, b) => {
                return a[0] > b[0]; // a[0], b[0] is the key of the map
            })
            .sort((a, b) => {
                return b[1].size - a[1].size; // a[1], b[1] is the value of the map
            })
    );

    for (const system of systemsSorted) {
        console.log(system[0]);

        let componentsSorted = new Map(
            Array.from(system[1])
                .sort((a, b) => {
                    return b[1].length - a[1].length;
                })
        );

        for (const component of componentsSorted) {
            console.log(`|||${component[0]}`);

            for (const subComponend of component[1]) {
                console.log(`||||||${subComponend}`);
            }
        }
    }
}

systemComponents(['SULS | Main Site | Home Page',
    'SULS | Main Site | Login Page',
    'SULS | Main Site | Register Page',
    'SULS | Judge Site | Login Page',
    'SULS | Judge Site | Submittion Page',
    'Lambda | CoreA | A23',
    'SULS | Digital Site | Login Page',
    'Lambda | CoreB | B24',
    'Lambda | CoreA | A24',
    'Lambda | CoreA | A25',
    'Lambda | CoreC | C4',
    'Indice | Session | Default Storage',
    'Indice | Session | Default Security']
);