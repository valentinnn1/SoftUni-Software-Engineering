class Company {
  constructor() {
    this.departments = [];
  }

  addEmployee(username, salary, position, department) {
    if (
      !this.validate(username) ||
      !this.validate(salary) ||
      !this.validate(position) ||
      !this.validate(department)
    ) {
      throw new Error("Invalid input!");
    }
    if (salary < 0) {
      throw new Error("Invalid input!");
    }

    let existingDepartment = this.departments.find(x => x.name === department);
    if (!existingDepartment) {
      existingDepartment = this.departments.push({
        name: department,
        employees: [],
        averageSalary: function() {
          return (
            this.employees.reduce((a, c) => a + c.salary, 0) /
            this.employees.length
          );
        }
      });
    }
    this.departments
      .find(x => x.name === department)
      .employees.push({ username, salary, position });
    return `New employee is hired. Name: ${username}. Position: ${position}`;
  }

  validate(str) {
    if (str === "" || typeof str === "undefined" || str === null) {
      return false;
    }
    return true;
  }

  bestDepartment() {
    const [best] = [...this.departments].sort((a, b) => {
      return b.averageSalary() - a.averageSalary();
    });

    let output = `Best Department is: ${best.name}\n`;
    output += `Average salary: ${best.averageSalary().toFixed(2)}\n`;
    output += [...best.employees]
      .sort(
        (a, b) => b.salary - a.salary || a.username.localeCompare(b.username)
      )
      .map(x => `${x.username} ${x.salary} ${x.position}`)
      .join("\n")
      .trim();
    return output;
  }
}
let c = new Company();
c.addEmployee("Stanimir", 2000, "engineer", "Construction");
c.addEmployee("Pesho", 1500, "electrical engineer", "Construction");
c.addEmployee("Slavi", 500, "dyer", "Construction");
c.addEmployee("Stan", 2000, "architect", "Construction");
c.addEmployee("Stanimir", 1200, "digital marketing manager", "Marketing");
c.addEmployee("Pesho", 1000, "graphical designer", "Marketing");
c.addEmployee("Gosho", 1350, "HR", "Human resources");
console.log(c.bestDepartment());
