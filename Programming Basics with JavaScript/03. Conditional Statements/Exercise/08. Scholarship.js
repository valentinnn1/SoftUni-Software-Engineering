function solve(input) {
    let income = Number(input.shift());
    let results = Number(input.shift());
    let minSalary = Number(input.shift());
    let scholarshipSocial = minSalary * 35 / 100;
    let scholarshipExcellent = results * 25;

    if (results >= 5.5) {
        if (scholarshipExcellent >= scholarshipSocial || income > minSalary) {
            console.log(`You get a scholarship for excellent results ${Math.floor(scholarshipExcellent)} BGN`);
        } else {
            console.log(`You get a Social scholarship ${Math.floor(scholarshipSocial)} BGN`);
        }
    } else if (income < minSalary && results > 4.5) {
        console.log(`You get a Social scholarship ${Math.floor(scholarshipSocial)} BGN`);
    } else {
        console.log(`You cannot get a scholarship!`);
    }
}

solve([480.00,4.60,450.00]);